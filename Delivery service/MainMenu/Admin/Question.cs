using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Delivery_service
{
    public partial class Question : Form
    {
        SqlConnection connection;
        SqlDataReader reader = null;
        SqlCommand cmd;
        string connectionString = @"Server=tcp:deliveryservice.database.windows.net,1433;Initial Catalog=Delivery service;Persist Security Info=False;User ID=Nikiru;Password=Rnp26122001;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        string DeliveryID;
        public Question()
        {
            InitializeComponent();
        }
        public Question(string id, string quest)
        {
            InitializeComponent();
            label1.Text = quest;
            DeliveryID = id;
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

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                string query = $"UPDATE [Delivery service questions] SET [Answer]=N'{QuestionTextBox.Text}' where [id]={DeliveryID}";
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

        private void Question_Load(object sender, EventArgs e)
        {

        }
    }
}
