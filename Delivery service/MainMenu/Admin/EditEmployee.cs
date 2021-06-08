using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Delivery_service
{
    public partial class EditEmployee : Form
    {
        SqlConnection connection;
        SqlDataReader reader = null;
        SqlCommand cmd;
        string FileNameImage;
        string connectionString = @"Server=tcp:deliveryservice.database.windows.net,1433;Initial Catalog=Delivery service;Persist Security Info=False;User ID=Nikiru;Password=Rnp26122001;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        public EditEmployee()
        {
            InitializeComponent();
        }
        int UserID;
        public EditEmployee(int usid, string surn, string name, string patr, DateTime date, string phone, string email, string login, string pass)
        {
            InitializeComponent();
            UserID = usid;
            textBox4.Text = surn;
            textBox3.Text = name;
            textBox5.Text = patr;
            dateTimePicker1.Value = date;
            maskedTextBox6.Text = phone;
            textBox8.Text = email;
            textBox1.Text = login;
            textBox2.Text = pass;
        }

        private void NewUser_Load(object sender, EventArgs e)
        {
        }

        private void BackB_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        Point lastpoint;

        private void NewUser_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void NewUser_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void RegB_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                string query = $"update [Delivery service User] set Surname=N'{textBox4.Text}', Name=N'{textBox3.Text}', Patronymic=N'{textBox5.Text}',[Phone number]=N'{maskedTextBox6.Text}', [Birth date]=N'{dateTimePicker1.Value.ToString("yyyy-MM-dd")}', Email=N'{textBox8.Text}',Login=N'{textBox1.Text}',Password=N'{textBox2.Text}' where [id]={UserID}";
                cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void RegB_MouseEnter(object sender, EventArgs e)
        {
            RegB.ForeColor = Color.FromArgb(217, 35, 73);
        }

        private void BackB_MouseEnter(object sender, EventArgs e)
        {
            BackB.ForeColor = Color.FromArgb(217, 35, 73);
        }

        private void RegB_MouseLeave(object sender, EventArgs e)
        {
            RegB.ForeColor = Color.FromArgb(227, 213, 212);
        }

        private void BackB_MouseLeave(object sender, EventArgs e)
        {
            BackB.ForeColor = Color.FromArgb(227, 213, 212);
        }
        MemoryStream memoryStream = new MemoryStream();

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
