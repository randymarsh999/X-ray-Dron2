using RshCSharpWrapper;
using RshCSharpWrapper.RshDevice;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace StartStop
{
    public partial class frmMain : Form
    {

        RSH_API st;
        Device device = new Device();
        private PiezoParameters PP = new PiezoParameters();
        private RshInitDMA p = new RshInitDMA();
        private frmMOptions frmMOpt = new frmMOptions();
        private frmDataBase frmDBConnection = new frmDataBase();
        private frmLA2 frmLA2usb = new frmLA2();


        private bool frmLA2USB_show =false;
        private bool frmMOpt_show = false;


        public frmMain()
        {
            InitializeComponent();
            frmMOpt.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lStatus.Text == "Status: Stop")
            {
                
                lStatus.Text = "Status: Measuring";
                chMeas.Series.Clear();
                chMeas.Series.Add("I");
                chMeas.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                chMeas.Series[0].Color = Color.Red;
                InitializationOfParametersForMeas();
                InitLA2USB();
                switch (frmMOpt.cmbSavingType.Text.ToUpper())
                    {
                    case "TEXT":
                        {
                            InitSaveDataToFile(frmMOpt.txtComposition.Text);
                            break;
                        }
                    case "SQL FILE":
                        {
                            InitSaveDataToFile();
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }

                measTimer.Enabled = true;
            }
            else
            {
                measTimer.Enabled = false;
                lStatus.Text = "Status: Stop";
            }
        }


        public static int SayGoodBye(RSH_API statusCode)
        {
            string errorMessage;
            Device.RshGetErrorDescription(statusCode, out errorMessage, RSH_LANGUAGE.RUSSIAN);
            Console.WriteLine("\n" + errorMessage);
            Console.WriteLine("\n" + statusCode.ToString() + " ( 0x{0:x} ) ", (uint)statusCode);
            Console.WriteLine("\n\nPress any key to end up the program.");
            return (int)statusCode;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            PP.Intensity_V = Math.Abs(GetDataFromLA2USB(p, PP.activeChanNumber, PP.serNum));
            if (frmMOpt.cmbIntensivityArbInterval.Text == "1000")
            {
                PP.Intensity_arb = (PP.Intensity_V / 0.054248663) * 4.098;
            }
            if (frmMOpt.cmbIntensivityArbInterval.Text == "400")
            {
                PP.Intensity_arb = (PP.Intensity_V / 0.052) * 1.6;
            }
            //int. arb=(V/(V in 1 mm))*(int. arb in 1 mm)
            if (frmMOpt.cmbIntensivityArbInterval.Text == "200")
            {
                PP.Intensity_arb = (PP.Intensity_V / 0.05375) * 1.25;
            }
            PP.mTime += PP.TimerMeas*PP.CoefTimer;
            measRes();
            chMeas.Series[0].Points.AddXY(PP.mTime, PP.Intensity_arb);
            switch (frmMOpt.cmbSavingType.Text)
            {
                case "TEXT":
                    {
                        int[] col = new int[] { 11, 12, 13 };
                        SaveDataTEXT(col);
                        break;
                    }
                case "SQL_FILE":
                    {
                        SaveData();
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            
                
        }
        /// <summary>
        /// Save data to file if SQL_FILE
        /// </summary>
        void SaveData()
        {
            DBConn dBConn = new DBConn();
            string sql = dBConn.DBExportDataString(this.dGridTempMeas, PP.DBTableName, 0);
            FileJob FJ = new FileJob();
            FJ.WriteF(sql, PP.FileNameSaveTempMeasDB);
        }
        /// <summary>
        /// TEXT
        /// </summary>
        void SaveDataTEXT(int[]p)
        {
            DBConn dBConn = new DBConn();
            string sql = dBConn.DBExportDataString(this.dGridTempMeas, PP.DBTableName, p);
            FileJob FJ = new FileJob();
            FJ.WriteF(sql, PP.FileNameSaveTempMeasDB);
        }


        private void InitLA2USB()
        {
            //Stopwatch myStopwatch = new Stopwatch();
            //myStopwatch.Start();
            //Код выполнения операции.
            //Создание экземляра класса для работы с устройствами
            //загрузка и подключение к библиотеке абстракции устройства






            st = device.EstablishDriverConnection(PP.BOARD_NAME);
            if (st != RSH_API.SUCCESS)
            {
                MessageBox.Show(st.ToString());
                return;
            }

            Console.WriteLine("\n--> Start-Stop data acquisition mode <--\n\n");

            //=================== ИНФОРМАЦИЯ О ЗАГРУЖЕННОЙ БИБЛИОТЕКЕ ====================== 
            string libVersion, libname, libCoreVersion, libCoreName;

            st = device.Get(RSH_GET.LIBRARY_VERSION_STR, out libVersion);
            if (st != RSH_API.SUCCESS) SayGoodBye(st).ToString();

            st = device.Get(RSH_GET.CORELIB_VERSION_STR, out libCoreVersion);
            st = device.Get(RSH_GET.CORELIB_FILENAME, out libCoreName);
            st = device.Get(RSH_GET.LIBRARY_FILENAME, out libname);
            //===================== ПРОВЕРКА СОВМЕСТИМОСТИ =================================  
            uint caps = (uint)RSH_CAPS.SOFT_GATHERING_IS_AVAILABLE;
            // Проверим, поддерживает ли плата функцию сбора данных в режиме "Старт-Стоп".
            st = device.Get(RSH_GET.DEVICE_IS_CAPABLE, ref caps);

            if (st != RSH_API.SUCCESS)
            {
                MessageBox.Show(st.ToString());
                return;
            }
            //========================== ИНИЦИАЛИЗАЦИЯ =====================================        
            //Подключаемся к устройству. Нумерация начинается с 1.
            st = device.Connect(1);
            if (st != RSH_API.SUCCESS)
            {
                MessageBox.Show(st.ToString());
                return;
            }
            //Структура для инициализации параметров работы устройства.  

            //Запуск сбора данных программный. 
            p.startType = (uint)RshInitDMA.StartTypeBit.Program;

            //----------------------------------------------
            #region FragmentForSettingMeasParameters
            //частота дискретизации
            if (frmLA2usb.txtSAMPLE_FREQ.Text != "")
            {
                PP.SAMPLE_FREQ = Convert.ToInt32(frmLA2usb.txtSAMPLE_FREQ.Text);
                //Частота дискретизации.

            }
            p.frequency = PP.SAMPLE_FREQ;

            //Размер внутреннего блока данных, по готовности которого произойдёт прерывание.
            if (frmLA2usb.txtBufSize.Text != "")
            {
                PP.BSIZE = Convert.ToUInt32(frmLA2usb.txtBufSize.Text);
            }
            p.bufferSize = PP.BSIZE;
            #endregion

            //выбор канала для съема
            //Сделаем 0-ой канал активным.
            p.channels[0].control = (uint)RshChannel.ControlBit.Used;
            //Зададим коэффициент усиления для 0-го канала.
            p.channels[0].gain = 1;
            //Инициализация устройства (передача выбранных параметров сбора данных)
            //После инициализации неправильные значения в структуре будут откорректированы.
            st = device.Init(p);
            if (st != RSH_API.SUCCESS)
            {
                MessageBox.Show(st.ToString());
                return;
            }
            //=================== ИНФОРМАЦИЯ О ПРЕДСТОЯЩЕМ СБОРЕ ДАННЫХ ====================== 

            uint activeChanNumberM = PP.activeChanNumber;
            uint serNumM = PP.serNum;
            device.Get(RSH_GET.DEVICE_ACTIVE_CHANNELS_NUMBER, ref activeChanNumberM);
            device.Get(RSH_GET.DEVICE_NAME_VERBOSE, out libname);
            device.Get(RSH_GET.DEVICE_SERIAL_NUMBER, ref serNumM);


            PP.timegathering = p.bufferSize / p.frequency;
            //Console.WriteLine(
            //    "\nThe name of the connected device: {0} " +
            //    "\nSerial number of the connected device: {1:d} " +
            //    "\nData to be collected: {2:d} samples " +
            //    "\nADC frequency: {3:f} Hz " +
            //    "\nThe number of active channels: {4:d} " +
            //    "\nThe estimated time of gathering completion: {5:f} seconds",
            //    libname, serNumM, p.bufferSize, p.frequency, activeChanNumberM, (p.bufferSize / p.frequency));
            this.Update();
            this.Refresh();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sDlg.ShowDialog();
            sDlg.FileName = frmMOpt.txtComposition.Text;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sDlg_FileOk(object sender, CancelEventArgs e)
        {
            PP.FileNameSaveTempMeasDB = sDlg.FileName;
        }
        /// <summary>
        /// Save data if Value = SQL
        /// </summary>
        void InitSaveDataToFile()
        {
            PP.DBTableName = frmMOpt.txtComposition.Text;
            PP.DBSQLConnctionString = frmDBConnection.ConnectionStringToDB;
            DBConn dBConn = new DBConn();
            PP.DB_SQL_CMD = dBConn.DBCreateTableSQLCommand(this.dGridTempMeas, PP.DBTableName);
            FileJob FJ = new FileJob();
            FJ.WriteF(PP.DB_SQL_CMD, PP.FileNameSaveTempMeasDB);
        }
        /// <summary>
        /// Save data if value =TEXT
        /// </summary>
        /// <param name="data"></param>
        void InitSaveDataToFile(string data)
        {
            FileJob FJ = new FileJob();
            FJ.WriteF(data, PP.FileNameSaveTempMeasDB);
        }

        private double GetDataFromLA2USB(RshInitDMA p, uint activeChanNumber, uint serNum)
        {
            double outVal = 0;
            // Время ожидания(в миллисекундах) до наступления прерывания. Прерывание произойдет при полном заполнении буфера. 
            int j = 0;
            do // Алгоритм сбора данных в режиме Старт-Стоп.
            {
                st = device.Start(); // Запускаем плату на сбор буфера.
                if (st != RSH_API.SUCCESS)
                {
                    return 0;
                }

                uint wt = PP.waitTime;
                if ((st = device.Get(RSH_GET.WAIT_BUFFER_READY_EVENT, ref wt)) == RSH_API.SUCCESS)  // Ожидаем готовность буфера.
                {
                    Console.WriteLine("\nInterrupt has taken place!\nWhich means that onboard buffer had filled completely.");

                    device.Stop();

                    //Буфер с данными в мзр.
                    short[] userBuffer = new short[p.bufferSize];
                    //Буфер с данными в вольтах.
                    double[] userBufferD = new double[p.bufferSize];

                    //Получаем буфер с данными.
                    st = device.GetData(userBuffer);
                    if (st != RSH_API.SUCCESS)
                    {
                        MessageBox.Show(st.ToString());
                    }

                    //Получаем буфер с данными. В этом буфере будут те же самые данные, но преобразованные в вольты.
                    st = device.GetData(userBufferD);

                    if (st != RSH_API.SUCCESS)
                    {
                        MessageBox.Show(st.ToString());
                        return 0;
                    }
                    for (int i = 0; i < userBufferD.Count(); i++)
                    {
                        outVal += userBufferD[i];
                    }

                    outVal /= userBufferD.Count();
                    this.Update();
                    this.Refresh();
                    return outVal;
                }
                else
                {
                    SayGoodBye(st);
                }
                ++j;
            } while (j < 0);
            return outVal;
        }

        private void lA2USBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLA2USB_show = true;
            frmLA2usb.Show();
        }

        /// <summary>
        /// Initialization Of Parameters For Meas
        /// </summary>
        private void InitializationOfParametersForMeas()
        {
            //init datagrid
            if (frmLA2USB_show == false)
            {
                frmLA2usb.Show();
                frmLA2usb.Hide();
                frmLA2USB_show = true;
            }
            if (frmMOpt_show == false)
            {
                frmMOpt.Show();
                frmMOpt.Hide();
                frmMOpt_show=true;
            }



                

            FileJob FJ = new FileJob();
            FJ.ClearDataGridView(dGridTempMeas);
            DataGridJob DGJ = new DataGridJob();
            DGJ.AddColumn(dGridTempMeas, "id", "INT");
            DGJ.AddColumn(dGridTempMeas, "id_section", "text");
            DGJ.AddColumn(dGridTempMeas, "Tsint_K", "double precision");
            DGJ.AddColumn(dGridTempMeas, "id_sample", "INT");
            DGJ.AddColumn(dGridTempMeas, "T_K", "double precision");
            DGJ.AddColumn(dGridTempMeas, "Ubias_V", "double precision");
            DGJ.AddColumn(dGridTempMeas, "Hbias_T", "double precision");
            DGJ.AddColumn(dGridTempMeas, "Direction", "text");
            DGJ.AddColumn(dGridTempMeas, "Polarity", "text");
            DGJ.AddColumn(dGridTempMeas, "Time", "time");
            DGJ.AddColumn(dGridTempMeas, "Date", "date");
            DGJ.AddColumn(dGridTempMeas, "Timer", "double precision");
            DGJ.AddColumn(dGridTempMeas, "intensity_arb", "double precision");
            DGJ.AddColumn(dGridTempMeas, "intensity_v", "double precision");
            dGridTempMeas.Rows.Add();
            //set init parameters
            PP.CelSel = 0;
            PP.mTime = 0;
            PP.ids = 0;
            PP.DBTableName = frmMOpt.txtComposition.Text;

            if (frmLA2usb.txtTimer.Text != "")
            {
                PP.TimerMeas = Convert.ToInt32(frmLA2usb.txtTimer.Text);

            }

            if (PP.FileNameSaveTempMeasDB == "")
            {
                PP.FileNameSaveTempMeasDB = "E:\\temp\\temp10.txt";
            }
            this.measTimer.Interval = PP.TimerMeas;

        }
        /// <summary>
        /// Set data to DataGrid
        /// </summary>
        void measRes()
        {
            string dateformat = "hh:mm:ss.fff";
            DateTime dateT = new DateTime();
            dateT = DateTime.Now;
            dateT.AddMilliseconds(1);
            dGridTempMeas["id", 0].Value = PP.ids;
            dGridTempMeas["id_section", 0].Value = frmMOpt.txtComposition.Text;
            dGridTempMeas["id_sample", 0].Value = frmMOpt.txtSampleNumber.Text;
            dGridTempMeas["Tsint_K", 0].Value = frmMOpt.txtTempSint.Text;
            dGridTempMeas["T_K", 0].Value = txtTemp.Text;
            dGridTempMeas["Ubias_V", 0].Value = PP.BiasUCurrent;
            dGridTempMeas["Hbias_T", 0].Value = PP.HBias;
            dGridTempMeas["Date", 0].Value = DateTime.Now.ToShortDateString();
            dGridTempMeas["Time", 0].Value = dateT.ToString(dateformat);
            dGridTempMeas["Timer", 0].Value = PP.mTime;
            dGridTempMeas["intensity_arb", 0].Value = PP.Intensity_arb;
            dGridTempMeas["intensity_v", 0].Value = PP.Intensity_V;
            ++PP.ids;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void measurmentOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMOpt_show = true;
            frmMOpt.Show();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void TxtTimer_TextChanged(object sender, EventArgs e)
        {

        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AbouToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAboutBox frmAboutBox = new frmAboutBox();
            frmAboutBox.Show();
        }
    }
}
