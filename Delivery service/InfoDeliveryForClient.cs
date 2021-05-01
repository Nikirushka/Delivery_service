using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delivery_service
{
    public partial class InfoDeliveryForClient : Form
    {
        SqlConnection connection;
        SqlDataReader reader = null;
        SqlCommand cmd;
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='|DataDirectory|Delivery_service.mdf';Integrated Security=True;Connect Timeout=30";
        string DeliveryID;
        public InfoDeliveryForClient()
        {
            InitializeComponent();
        }
        public InfoDeliveryForClient(string DeliveryID_, string obj_, string adr1_, string adr2_, string time_, string comm_)
        {
            InitializeComponent();
            ObjTextBox.Text = obj_;
            CommentaryTextBox.Text = comm_;
            RecTextBox.Text = adr1_;
            DesTextBox.Text = adr2_;
            DeliveryDateTimePicker.Value =Convert.ToDateTime(time_);
            DeliveryID = DeliveryID_;
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

        private void CommentaryTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void ObjTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void DesTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                string query = $"UPDATE [Delivery service order] SET [Object description] =N'{ObjTextBox.Text}', [Reception point] =N'{RecTextBox.Text}', [Destination point] =N'{DesTextBox.Text}', [Commentary] =N'{CommentaryTextBox.Text}',[Deadline date]=N'{DeliveryDateTimePicker.Value.ToString("yyyy-MM-dd")}'  where [id]={DeliveryID}";
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

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                string query = $"UPDATE [Delivery service order] SET [Status id]=2  where [id]={DeliveryID}";
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
    }
}
