using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

/// <summary>
/// 
/// </summary>
public partial class frmDataBase : Form

{
    private Label label6;
    private TextBox txtRequsetDB;
    private Button btnSentDBRequest;
    private Button btnSetPass;
    private Button btnConnectDB;
    private Label label5;
    private TextBox ePort;
    private Button btnSetPort;
    private Label label4;
    private Label label3;
    private Label label2;
    private Label label1;
    private TextBox eDB;
    private TextBox ePass;
    private TextBox eLogin;
    private TextBox eServer;
    private Button btnSetDB;
    private Button btnSetLogin;
    private Button btnSetSever;
    DataBasePostgres Dbpostgres = new DataBasePostgres();
/// <summary>
/// 
/// </summary>
        public string Server { set; get; }
        /// <summary>
        /// 
        /// </summary>
        public string Port { set; get; }
        /// <summary>
        /// 
        /// </summary>
        public string UserId { set; get; }
        /// <summary>
        /// 
        /// </summary>
        public string Password { set; get; }
        /// <summary>
        /// 
        /// </summary>
        public string DB { set; get; }
        /// <summary>
        /// 
        /// </summary>
        public bool DataBaseConnected { get; set; }
        /// <summary>
        /// Gets or sets the connection string to database.
        /// </summary>
        /// <value>
        /// The connection string to database.
        /// </value>
        public string ConnectionStringToDB { set; get; }
		/// <summary>
		/// Конструктор класса формы DataBase
		/// </summary>
		public frmDataBase()
		{
			InitializeComponent();
            //инициализация параметров для входа в базу данных
            Dbpostgres.SetSever("Server=" + eServer.Text + ";");
            Server += "Server=" + eServer.Text + ";";
			DB += "Database=" + eDB.Text + ";";
			UserId += "User Id=" + eLogin.Text + ";";
			Port += "Port = " + ePort.Text + ";";
			Password += "Password=" + ePass.Text + ";";
            ConnectionStringToDB = Server + Port + UserId + Password + DB;
            DataBaseConnected = false;
        }
		/// <summary>
		/// Устанавливает сервер базы данных для соединения
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>				
		private void btnSetSever_Click(object sender, EventArgs e)
		{
            ConnString();
        }
        /// <summary>
        /// 
        /// </summary>
        public void ConnString()
        {
           //ConnString();
            ConnectionStringToDB = Server + Port + UserId + Password + DB;
            
        }
		/// <summary>
		/// Устанавливает базу данных для соединения
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		public void btnSetDB_Click(object sender, EventArgs e)
		{
            ConnString();
        }
		/// <summary>
		/// Устанавливает Логин для соединения
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnSetLogin_Click(object sender, EventArgs e)
		{
            ConnString();
        }
		/// <summary>
		/// Устанавливает порт сервера базы данных для соединения
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnSetPort_Click(object sender, EventArgs e)
		{
            ConnString();
        }
		/// <summary>
		/// Устанавливает пароль базы данных для соединения
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnSetPass_Click(object sender, EventArgs e)
		{
            ConnString();
        }
		/// <summary>
		/// Устанавливает пробное соединение
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnConnectDB_Click(object sender, EventArgs e)
		{

    }

    private void eServer_TextChanged(object sender, EventArgs e)
        {
            ConnString();
        }

        private void eDB_TextChanged(object sender, EventArgs e)
        {
            ConnString();
        }

        private void eLogin_TextChanged(object sender, EventArgs e)
        {
            ConnString();
        }

        private void ePass_TextChanged(object sender, EventArgs e)
        {
            ConnString();
        }

        private void ePort_TextChanged(object sender, EventArgs e)
        {
            ConnString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void frmDataBase_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

    }

    private void InitializeComponent()
        {
            this.label6 = new System.Windows.Forms.Label();
            this.txtRequsetDB = new System.Windows.Forms.TextBox();
            this.btnSentDBRequest = new System.Windows.Forms.Button();
            this.btnSetPass = new System.Windows.Forms.Button();
            this.btnConnectDB = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ePort = new System.Windows.Forms.TextBox();
            this.btnSetPort = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.eDB = new System.Windows.Forms.TextBox();
            this.ePass = new System.Windows.Forms.TextBox();
            this.eLogin = new System.Windows.Forms.TextBox();
            this.eServer = new System.Windows.Forms.TextBox();
            this.btnSetDB = new System.Windows.Forms.Button();
            this.btnSetLogin = new System.Windows.Forms.Button();
            this.btnSetSever = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Request";
            // 
            // txtRequsetDB
            // 
            this.txtRequsetDB.Location = new System.Drawing.Point(26, 271);
            this.txtRequsetDB.Name = "txtRequsetDB";
            this.txtRequsetDB.Size = new System.Drawing.Size(100, 20);
            this.txtRequsetDB.TabIndex = 38;
            // 
            // btnSentDBRequest
            // 
            this.btnSentDBRequest.Location = new System.Drawing.Point(132, 271);
            this.btnSentDBRequest.Name = "btnSentDBRequest";
            this.btnSentDBRequest.Size = new System.Drawing.Size(103, 20);
            this.btnSentDBRequest.TabIndex = 37;
            this.btnSentDBRequest.Text = "Send Request";
            this.btnSentDBRequest.UseVisualStyleBackColor = true;
            // 
            // btnSetPass
            // 
            this.btnSetPass.Location = new System.Drawing.Point(132, 152);
            this.btnSetPass.Name = "btnSetPass";
            this.btnSetPass.Size = new System.Drawing.Size(75, 20);
            this.btnSetPass.TabIndex = 36;
            this.btnSetPass.Text = "Password";
            this.btnSetPass.UseVisualStyleBackColor = true;
            // 
            // btnConnectDB
            // 
            this.btnConnectDB.Location = new System.Drawing.Point(83, 220);
            this.btnConnectDB.Name = "btnConnectDB";
            this.btnConnectDB.Size = new System.Drawing.Size(87, 29);
            this.btnConnectDB.TabIndex = 35;
            this.btnConnectDB.Text = "Connect";
            this.btnConnectDB.UseVisualStyleBackColor = true;
            this.btnConnectDB.Click += new System.EventHandler(this.BtnConnectDB_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Port";
            // 
            // ePort
            // 
            this.ePort.Location = new System.Drawing.Point(26, 194);
            this.ePort.Name = "ePort";
            this.ePort.Size = new System.Drawing.Size(100, 20);
            this.ePort.TabIndex = 33;
            this.ePort.Text = "5432";
            // 
            // btnSetPort
            // 
            this.btnSetPort.Location = new System.Drawing.Point(132, 194);
            this.btnSetPort.Name = "btnSetPort";
            this.btnSetPort.Size = new System.Drawing.Size(75, 20);
            this.btnSetPort.TabIndex = 32;
            this.btnSetPort.Text = "Set port";
            this.btnSetPort.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Data base";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Server";
            // 
            // eDB
            // 
            this.eDB.Location = new System.Drawing.Point(26, 72);
            this.eDB.Name = "eDB";
            this.eDB.Size = new System.Drawing.Size(100, 20);
            this.eDB.TabIndex = 27;
            this.eDB.Text = "nii_db";
            // 
            // ePass
            // 
            this.ePass.Location = new System.Drawing.Point(26, 153);
            this.ePass.Name = "ePass";
            this.ePass.PasswordChar = '*';
            this.ePass.Size = new System.Drawing.Size(100, 20);
            this.ePass.TabIndex = 26;
            this.ePass.Text = "nii011235813";
            // 
            // eLogin
            // 
            this.eLogin.Location = new System.Drawing.Point(26, 114);
            this.eLogin.Name = "eLogin";
            this.eLogin.Size = new System.Drawing.Size(100, 20);
            this.eLogin.TabIndex = 25;
            this.eLogin.Text = "postgres";
            // 
            // eServer
            // 
            this.eServer.Location = new System.Drawing.Point(26, 33);
            this.eServer.Name = "eServer";
            this.eServer.Size = new System.Drawing.Size(100, 20);
            this.eServer.TabIndex = 24;
            this.eServer.Text = "10.11.0.36";
            // 
            // btnSetDB
            // 
            this.btnSetDB.Location = new System.Drawing.Point(132, 75);
            this.btnSetDB.Name = "btnSetDB";
            this.btnSetDB.Size = new System.Drawing.Size(75, 20);
            this.btnSetDB.TabIndex = 23;
            this.btnSetDB.Text = "Set DB";
            this.btnSetDB.UseVisualStyleBackColor = true;
            // 
            // btnSetLogin
            // 
            this.btnSetLogin.Location = new System.Drawing.Point(132, 114);
            this.btnSetLogin.Name = "btnSetLogin";
            this.btnSetLogin.Size = new System.Drawing.Size(75, 20);
            this.btnSetLogin.TabIndex = 22;
            this.btnSetLogin.Text = "Set login";
            this.btnSetLogin.UseVisualStyleBackColor = true;
            // 
            // btnSetSever
            // 
            this.btnSetSever.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSetSever.Location = new System.Drawing.Point(132, 33);
            this.btnSetSever.Name = "btnSetSever";
            this.btnSetSever.Size = new System.Drawing.Size(75, 20);
            this.btnSetSever.TabIndex = 21;
            this.btnSetSever.Text = "Set server";
            this.btnSetSever.UseVisualStyleBackColor = true;
            // 
            // frmDataBase
            // 
            this.ClientSize = new System.Drawing.Size(264, 318);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtRequsetDB);
            this.Controls.Add(this.btnSentDBRequest);
            this.Controls.Add(this.btnSetPass);
            this.Controls.Add(this.btnConnectDB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ePort);
            this.Controls.Add(this.btnSetPort);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eDB);
            this.Controls.Add(this.ePass);
            this.Controls.Add(this.eLogin);
            this.Controls.Add(this.eServer);
            this.Controls.Add(this.btnSetDB);
            this.Controls.Add(this.btnSetLogin);
            this.Controls.Add(this.btnSetSever);
            this.Name = "frmDataBase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    private void BtnConnectDB_Click_1(object sender, EventArgs e)
    {

    }
}

/// <summary>
/// DataBase Class
/// </summary>
class DataBasePostgres
    {
        private string server;
        private string Port;
        private string UserId;
        private string pass;
        private string db;


        public DataBasePostgres()
        {
           
            //инициализация параметров для входа в базу данных
            //server += "Server=" + eServer.Text + ";";
            //db += "Database=" + eDB.Text + ";";
            //UserId += "User Id=" + eLogin.Text + ";";
            //Port += "Port = " + ePort.Text + ";";
            //pass += "Password=" + ePass.Text + ";";
        }
        /// <summary>
        /// Устанавливает сервер базы данных для соединения
        /// </summary>
        /// <param name="serverId">The server identifier.</param>
        public void SetSever(string serverId)
        {
            server += "Server=" +server + ";";
        }
        /// <summary>
        /// Устанавливает базу данных для соединения
        /// </summary>
        /// <param name="DBId">The database identifier.</param>
        public void SetDB(string DBId)
        {
            db += "Database=" + DBId + ";";
        }
        /// <summary>
        /// Устанавливает Логин для соединения
        /// </summary>
        public void SetLogin(string elogin)
        {
            UserId += "User Id=" + elogin + ";";
        }
        /// <summary>
        /// Устанавливает порт сервера базы данных для соединения
        /// </summary>
        public void SetPort(string portId)
        {
            Port += "Port = " + portId + ";";
        }
        /// <summary>
        /// Устанавливает пароль базы данных для соединения
        /// </summary>
        /// <param name="passwordDB">The password database.</param>
        public void SetPass(string passwordDB)
        {
            pass += "Password=" + passwordDB + ";";
        }
        /// <summary>
        /// Устанавливает пробное соединение
        /// </summary>
        public void ConnectDB()
        {
            try
            {
                string connect = server + Port + UserId + pass + db;
                NpgsqlConnection pgcon = new NpgsqlConnection(connect);
                pgcon.Open();
                //string sql = "create table ss(id int);";
                //NpgsqlCommand CSend = new NpgsqlCommand(sql, pgcon);
                //CSend.ExecuteNonQuery();
                pgcon.Close();
            }
            catch (Exception msg)
            {
                // something went wrong, and you wanna know why
                MessageBox.Show(msg.ToString());
                throw;
            }
        }


        //NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString);
        //npgSqlConnection.Open();
        //Console.WriteLine("Соединение с БД открыто");
        //NpgsqlCommand npgSqlCommand = new NpgsqlCommand("SELECT * FROM example", npgSqlConnection);
        //NpgsqlDataReader npgSqlDataReader = npgSqlCommand.ExecuteReader();
        //if (npgSqlDataReader.HasRows)
        //{
        //    Console.WriteLine("Таблица: example");
        //    Console.WriteLine("id value");
        //    foreach (DbDataRecord dbDataRecord in npgSqlDataReader)
        //        Console.WriteLine(dbDataRecord["id"] + "   " + dbDataRecord["value"]);
        //}
        //else
        //    Console.WriteLine("Запрос не вернул строк");

    //}
}
