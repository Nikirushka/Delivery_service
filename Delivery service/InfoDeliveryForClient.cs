using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Delivery_service
{
    public partial class InfoDeliveryForClient : Form
    {
        SqlConnection connection;
        SqlDataReader reader = null;
        SqlCommand cmd;
        string connectionString = @"Server=tcp:deliveryservice.database.windows.net,1433;Initial Catalog=Delivery service;Persist Security Info=False;User ID=Nikiru;Password=Rnp26122001;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        string DeliveryID;
        public InfoDeliveryForClient()
        {
            InitializeComponent();
        }
        public InfoDeliveryForClient(string DeliveryID_, string obj_, string adr1_, string adr2_, string time1_, string time2_, string date1, string date2, string comm_)
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
                string query = $"UPDATE [Delivery service order] SET [Object description] =N'{ObjTextBox.Text}', [Reception point] =N'{RecTextBox.Text}', [Destination point] =N'{DesTextBox.Text}', [Commentary] =N'{CommentaryTextBox.Text}',[Reception date]=N'{DeliveryDateTimePicker.Value.ToString("yyyy-MM-dd")}', [Destination date]=N'{gunaDateTimePicker1.Value.ToString("yyyy-MM-dd")}', [Reception time]=N'{maskedTextBox1.Text}', [Destination time]=N'{maskedTextBox2.Text}'  where [id]={DeliveryID}";
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
