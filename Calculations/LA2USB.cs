using RshCSharpWrapper.RshDevice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RshCSharpWrapper;
using RshCSharpWrapper.RshDevice;



class LA2USB
    {
    //private object myStopwatch;
    //RSH_API st;

    //private double GetDataFromLA2USB(RshInitDMA p, uint activeChanNumber, uint serNum)
    //{

        //myStopwatch.Start();
        //double outVal = 0;
        //// Время ожидания(в миллисекундах) до наступления прерывания. Прерывание произойдет при полном заполнении буфера. 
        //int j = 0;
        //do // Алгоритм сбора данных в режиме Старт-Стоп.
        //{
        //    st = device.Start(); // Запускаем плату на сбор буфера.
        //    if (st != RSH_API.SUCCESS)
        //    {
        //        return 0;
        //    }

        //    uint wt = PP.waitTime;
        //    if ((st = device.Get(RSH_GET.WAIT_BUFFER_READY_EVENT, ref wt)) == RSH_API.SUCCESS)  // Ожидаем готовность буфера.
        //    {
        //        Console.WriteLine("\nInterrupt has taken place!\nWhich means that onboard buffer had filled completely.");

        //        device.Stop();

        //        //Буфер с данными в мзр.
        //        short[] userBuffer = new short[p.bufferSize];
        //        //Буфер с данными в вольтах.
        //        double[] userBufferD = new double[p.bufferSize];

        //        //Получаем буфер с данными.
        //        st = device.GetData(userBuffer);
        //        if (st != RSH_API.SUCCESS)
        //        {
        //            MessageBox.Show(st.ToString());
        //        }

        //        //Получаем буфер с данными. В этом буфере будут те же самые данные, но преобразованные в вольты.
        //        st = device.GetData(userBufferD);

        //        if (st != RSH_API.SUCCESS)
        //        {
        //            MessageBox.Show(st.ToString());
        //            return 0;
        //        }
        //        for (int i = 0; i < userBufferD.Count(); i++)
        //        {
        //            outVal += userBufferD[i];
        //        }

        //        outVal /= userBufferD.Count();
        //        this.Update();
        //        this.Refresh();
        //        myStopwatch.Stop();
        //        PP.mTime = PP.mTime + (Convert.ToDouble(myStopwatch.ElapsedMilliseconds.ToString()) * PP.CoefTimer);
        //        return outVal;
        //    }
        //    else
        //    {
        //        SayGoodBye(st);
        //    }
        //    ++j;

        //} while (j < 0);
        //return outVal;
    //}



}

