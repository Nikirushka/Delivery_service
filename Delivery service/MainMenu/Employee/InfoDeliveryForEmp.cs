﻿using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Delivery_service
{
    public partial class InfoDeliveryForEmp : Form
    {
        SqlConnection connection;
        SqlDataReader reader = null;
        SqlCommand cmd;
        string connectionString = @"Server=tcp:deliveryservice.database.windows.net,1433;Initial Catalog=Delivery service;Persist Security Info=False;User ID=Nikiru;Password=Rnp26122001;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        string DeliveryID;
        string empID;
        public InfoDeliveryForEmp()
        {
            InitializeComponent();
        }
        public InfoDeliveryForEmp(string emp_,string DeliveryID_,string sur_, string obj_, string adr1_, string adr2_, string time1_, string time2_, string date1, string date2, string comm_)
        {
            InitializeComponent();
            ObjTextBox.Text = obj_;
            CommentaryTextBox.Text = comm_;
            RecTextBox.Text = adr1_;
            DesTextBox.Text = adr2_;
            DeliveryDateTimePicker.Value = Convert.ToDateTime(date1);
            gunaDateTimePicker1.Value = Convert.ToDateTime(date2);
            maskedTextBox1.Text = time1_;
            maskedTextBox2.Text = time2_;
            DeliveryID = DeliveryID_;
            gunaTextBox2.Text = sur_;
            empID = emp_;
        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Close_button_MouseEnter(object sender, EventArgs e)
        {
            Close_button.Image = Properties.Resources.Close_button_enter;
        }

        private void Close_button_MouseLeave(object sender, EventArgs e)
        {
            Close_button.Image = Properties.Resources.Close_button_leave2;
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open(); 
                string query = $"INSERT INTO [Delivery service time order] VALUES ({DeliveryID},{empID},{gunaTextBox1.Text})"; 
                cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                query = $"update [Delivery service order] set [Delivery service order].[status id]=4, [Delivery service order].[employee id]={empID} where [delivery service order].[id]={DeliveryID}";
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

        private void InfoDeliveryForEmp_Load(object sender, EventArgs e)
        {

        }

        private void gunaTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == 32 || e.KeyChar == 8) return;
            else
                e.Handled = true;
        }
    }
}
