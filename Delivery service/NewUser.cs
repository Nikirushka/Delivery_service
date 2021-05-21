using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Delivery_service
{
    public partial class NewUser : Form
    {
        SqlConnection connection;
        SqlDataReader reader = null;
        SqlCommand cmd;
        string FileNameImage;
        string connectionString = @"Server=tcp:deliveryservice.database.windows.net,1433;Initial Catalog=Delivery service;Persist Security Info=False;User ID=Nikiru;Password=Rnp26122001;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        public NewUser()
        {
            InitializeComponent();
            UserComboBox.SelectedIndex = 0;
        }

        private void NewUser_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
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
                // проверка на уникальность логина
                string query = $"SELECT * FROM [Delivery service user] WHERE Login = N'{textBox1.Text}'";
                cmd = new SqlCommand(query, connection);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    MessageBox.Show("Такой логин уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    reader.Close();
                    return;
                }
                reader.Close();
                // добавление нового пользователя
                query = $"INSERT INTO [Delivery service user] " +
                    $"VALUES ( N'{textBox4.Text}', N'{textBox3.Text}', N'{textBox5.Text}',N'{dateTimePicker1.Value.ToString("yyyy-MM-dd")}', N'{maskedTextBox6.Text}', N'{textBox8.Text}', @p,N'{textBox1.Text}', N'{textBox2.Text}',GETDATE())";
                cmd = new SqlCommand(query, connection);
                if (memoryStream.ToArray().ToString() == "System.Byte[]")
                {
                    OpenFileDialog openFileDialog1 = new OpenFileDialog();
                    string pathToFile = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Profile_on.png");
                    openFileDialog1.FileName = pathToFile;
                    ProfilePic.Image = new Bitmap(openFileDialog1.FileName);
                    ProfilePic.Image.Save(memoryStream, ProfilePic.Image.RawFormat);
                }
                cmd.Parameters.AddWithValue("@p", memoryStream.ToArray());
                cmd.ExecuteNonQuery();
                query = $"select id from [delivery service user] where login= N'{textBox1.Text}'";
                cmd = new SqlCommand(query, connection);
                reader = cmd.ExecuteReader();
                int check = 0;
                while (reader.Read())
                {
                    check = reader.GetInt32(0);
                }
                reader.Close();
                if (UserComboBox.SelectedIndex == 0)
                {
                    query = $"INSERT INTO [Delivery service client] " +
                    $"([User id],[Orders]) " +
                    $"VALUES ( {check},0)";

                }
                else
                {
                    query = $"INSERT INTO [Delivery service owner] " +
                    $"([User id]) " +
                    $"VALUES ({check})";
                }
                cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
                MailAddress fromMailAddress = new MailAddress("help.delivery.service@gmail.com", "Support Delivery Service");
                MailAddress toAddress = new MailAddress($"{textBox8.Text}");
                MailMessage mailMessage = new MailMessage(fromMailAddress, toAddress);
                mailMessage.IsBodyHtml = true;
                mailMessage.Subject = "Регистрация нового пользователя - Delivery Service";
                mailMessage.Body = @"<!DOCTYPE html PUBLIC ""-//W3C//DTD XHTML 1.0 Transitional//EN"" ""http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd""><html xmlns=""http://www.w3.org/1999/xhtml"" xmlns:o=""urn:schemas-microsoft-com:office:office"" style=""width:100%;font-family:arial, 'helvetica neue', helvetica, sans-serif;-webkit-text-size-adjust:100%;-ms-text-size-adjust:100%;padding:0;Margin:0""><head><meta charset=""UTF-8""><meta content=""width=device-width, initial-scale=1"" name=""viewport""><meta name=""x-apple-disable-message-reformatting""><meta http-equiv=""X-UA-Compatible"" content=""IE=edge""><meta content=""telephone=no"" name=""format-detection""><title>Новое письмо</title><!--[if (mso 16)]><style type=""text/css"">a {text-decoration: none;}</style><![endif]--><!--[if gte mso 9]><style>sup { font-size: 100% !important; }</style><![endif]--><!--[if gte mso 9]><xml><o:OfficeDocumentSettings><o:AllowPNG></o:AllowPNG><o:PixelsPerInch>96</o:PixelsPerInch></o:OfficeDocumentSettings></xml><![endif]--><style type=""text/css"">.rollover div {font-size:0;}.rollover:hover .rollover-first {max-height:0px!important;display:none!important;}.rollover:hover .rollover-second {max-height:none!important;display:block!important;}#outlook a {padding:0;}.ExternalClass {width:100%;}.ExternalClass,.ExternalClass p,.ExternalClass span,.ExternalClass font,.ExternalClass td,.ExternalClass div {line-height:100%;}.es-button {mso-style-priority:100!important;text-decoration:none!important;}a[x-apple-data-detectors] {color:inherit!important;text-decoration:none!important;font-size:inherit!important;font-family:inherit!important;font-weight:inherit!important;line-height:inherit!important;}.es-desk-hidden {display:none;float:left;overflow:hidden;width:0;max-height:0;line-height:0;mso-hide:all;}@media only screen and (max-width:600px) {p, ul li, ol li, a { line-height:150%!important } h1 { font-size:30px!important; text-align:center; line-height:120%!important } h2 { font-size:26px!important; text-align:center; line-height:120%!important } h3 { font-size:20px!important; text-align:center; line-height:120%!important } .es-header-body h1 a, .es-content-body h1 a, .es-footer-body h1 a { font-size:30px!important } .es-header-body h2 a, .es-content-body h2 a, .es-footer-body h2 a { font-size:26px!important } .es-header-body h3 a, .es-content-body h3 a, .es-footer-body h3 a { font-size:20px!important } .es-menu td a { font-size:15px!important } .es-header-body p, .es-header-body ul li, .es-header-body ol li, .es-header-body a { font-size:16px!important } .es-content-body p, .es-content-body ul li, .es-content-body ol li, .es-content-body a { font-size:16px!important } .es-footer-body p, .es-footer-body ul li, .es-footer-body ol li, .es-footer-body a { font-size:13px!important } .es-infoblock p, .es-infoblock ul li, .es-infoblock ol li, .es-infoblock a { font-size:12px!important } *[class=""gmail-fix""] { display:none!important } .es-m-txt-c, .es-m-txt-c h1, .es-m-txt-c h2, .es-m-txt-c h3 { text-align:center!important } .es-m-txt-r, .es-m-txt-r h1, .es-m-txt-r h2, .es-m-txt-r h3 { text-align:right!important } .es-m-txt-l, .es-m-txt-l h1, .es-m-txt-l h2, .es-m-txt-l h3 { text-align:left!important } .es-m-txt-r img, .es-m-txt-c img, .es-m-txt-l img { display:inline!important } .es-button-border { display:block!important } a.es-button, button.es-button { font-size:20px!important; display:block!important; border-left-width:0px!important; border-right-width:0px!important } .es-btn-fw { border-width:10px 0px!important; text-align:center!important } .es-adaptive table, .es-btn-fw, .es-btn-fw-brdr, .es-left, .es-right { width:100%!important } .es-content table, .es-header table, .es-footer table, .es-content, .es-footer, .es-header { width:100%!important; max-width:600px!important } .es-adapt-td { display:block!important; width:100%!important } .adapt-img { width:100%!important; height:auto!important } .es-m-p0 { padding:0px!important } .es-m-p0r { padding-right:0px!important } .es-m-p0l { padding-left:0px!important } .es-m-p0t { padding-top:0px!important } .es-m-p0b { padding-bottom:0!important } .es-m-p20b { padding-bottom:20px!important } .es-mobile-hidden, .es-hidden { display:none!important } tr.es-desk-hidden, td.es-desk-hidden, table.es-desk-hidden { width:auto!important; overflow:visible!important; float:none!important; max-height:inherit!important; line-height:inherit!important } tr.es-desk-hidden { display:table-row!important } table.es-desk-hidden { display:table!important } td.es-desk-menu-hidden { display:table-cell!important } .es-menu td { width:1%!important } table.es-table-not-adapt, .esd-block-html table { width:auto!important } table.es-social { display:inline-block!important } table.es-social td { display:inline-block!important } }</style></head><body style=""width:100%;font-family:arial, 'helvetica neue', helvetica, sans-serif;-webkit-text-size-adjust:100%;-ms-text-size-adjust:100%;padding:0;Margin:0""><div class=""es-wrapper-color"" style=""background-color:#FFFFFF""><!--[if gte mso 9]><v:background xmlns:v=""urn:schemas-microsoft-com:vml"" fill=""t""><v:fill type=""tile"" color=""#ffffff""></v:fill></v:background><![endif]--><table class=""es-wrapper"" width=""100%"" cellspacing=""0"" cellpadding=""0"" style=""mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px;padding:0;Margin:0;width:100%;height:100%;background-repeat:repeat;background-position:center top""><tr style=""border-collapse:collapse""><td valign=""top"" style=""padding:0;Margin:0""><table cellpadding=""0"" cellspacing=""0"" class=""es-content"" align=""center"" style=""mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px;table-layout:fixed !important;width:100%""><tr style=""border-collapse:collapse""><td class=""es-adaptive"" align=""center"" style=""padding:0;Margin:0""><table class=""es-content-body"" cellspacing=""0"" cellpadding=""0"" align=""center"" style=""mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px;background-color:#FFFFFF;width:600px""><tr style=""border-collapse:collapse""><td align=""left"" style=""padding:0;Margin:0;padding-top:15px""><table width=""100%"" cellspacing=""0"" cellpadding=""0"" style=""mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px""><tr style=""border-collapse:collapse""><td class=""es-m-p0r"" valign=""top"" align=""center"" style=""padding:0;Margin:0;width:600px""><table width=""100%"" cellspacing=""0"" cellpadding=""0"" role=""presentation"" style=""mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px""><tr style=""border-collapse:collapse""><td class=""es-m-p0l es-m-txt-c"" align=""center"" style=""padding:0;Margin:0;font-size:0px""><a href="""" target=""_blank"" class=""rollover"" style=""-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;text-decoration:underline;color:#836027;font-size:14px""><img src=""https://rfdjhd.stripocdn.email/content/guids/CABINET_1de9d14de806427b8cc677d205def9da/images/43371618829029633.png"" alt=""Jewelry logo"" title=""Jewelry logo"" width=""137"" style=""display:block;border:0;outline:none;text-decoration:none;-ms-interpolation-mode:bicubic;font-size:12px"" class=""rollover-first""><div style=""font-size:0;mso-hide:all""><img alt=""Jewelry logo"" title=""Jewelry logo"" width=""137"" class=""rollover-second"" style=""display:none;border:0;outline:none;text-decoration:none;-ms-interpolation-mode:bicubic;max-height:0px"" src=""https://rfdjhd.stripocdn.email/content/guids/CABINET_1de9d14de806427b8cc677d205def9da/images/32971618829800984.png""></div></a></td></tr></table></td></tr></table></td></tr></table></td></tr></table><table class=""es-content"" cellspacing=""0"" cellpadding=""0"" align=""center"" style=""mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px;table-layout:fixed !important;width:100%""><tr style=""border-collapse:collapse""><td align=""center"" style=""padding:0;Margin:0""><table class=""es-content-body"" style=""mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px;background-color:transparent;border-top:1px solid #836027;border-right:1px solid #836027;border-left:1px solid #836027;width:600px"" cellspacing=""0"" cellpadding=""0"" bgcolor=""#ffffff"" align=""center""><tr style=""border-collapse:collapse""><td style=""padding:0;Margin:0;background-color:#FFFFFF"" bgcolor=""#ffffff"" align=""left""><table width=""100%"" cellspacing=""0"" cellpadding=""0"" style=""mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px""><tr style=""border-collapse:collapse""><td valign=""top"" align=""center"" style=""padding:0;Margin:0;width:598px""><table width=""100%"" cellspacing=""0"" cellpadding=""0"" role=""presentation"" style=""mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px""><tr style=""border-collapse:collapse""><td align=""center"" style=""padding:0;Margin:0;padding-top:5px;padding-left:10px;padding-right:10px;font-size:0""><img class=""adapt-img"" src=""https://rfdjhd.stripocdn.email/content/guids/CABINET_ea97118f59193813e3046bb79941ffee/images/89951526643846833.png"" alt style=""display:block;border:0;outline:none;text-decoration:none;-ms-interpolation-mode:bicubic"" width=""578""></td></tr><tr style=""border-collapse:collapse""><td style=""padding:0;Margin:0;position:relative"" align=""center""><img class=""adapt-img"" src=""https://rfdjhd.stripocdn.email/content/guids/bannerImgGuid/images/82961618829446588.png"" alt title width=""100%"" style=""display:block;border:0;outline:none;text-decoration:none;-ms-interpolation-mode:bicubic""></td></tr><tr style=""border-collapse:collapse""><td align=""center"" style=""padding:0;Margin:0;padding-top:5px;padding-left:10px;padding-right:10px;font-size:0""><img class=""adapt-img"" src=""https://rfdjhd.stripocdn.email/content/guids/CABINET_ea97118f59193813e3046bb79941ffee/images/89951526643846833.png"" alt style=""display:block;border:0;outline:none;text-decoration:none;-ms-interpolation-mode:bicubic"" width=""578""></td></tr></table></td></tr></table></td></tr></table></td></tr></table><table cellpadding=""0"" cellspacing=""0"" class=""es-content"" align=""center"" style=""mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px;table-layout:fixed !important;width:100%""><tr style=""border-collapse:collapse""><td align=""center"" style=""padding:0;Margin:0""><table bgcolor=""#ffffff"" class=""es-content-body"" align=""center"" cellpadding=""0"" cellspacing=""0"" style=""mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px;background-color:#FFFFFF;width:600px""><tr style=""border-collapse:collapse""><td align=""left"" style=""padding:0;Margin:0;padding-top:20px;padding-left:20px;padding-right:20px;background-position:center top""><table cellpadding=""0"" cellspacing=""0"" width=""100%"" style=""mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px""><tr style=""border-collapse:collapse""><td align=""center"" valign=""top"" style=""padding:0;Margin:0;width:560px""><table cellpadding=""0"" cellspacing=""0"" width=""100%"" role=""presentation"" style=""mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px""><tr style=""border-collapse:collapse""><td align=""left"" class=""es-m-txt-c"" style=""padding:0;Margin:0;padding-bottom:10px""><h1 style=""Margin:0;line-height:36px;mso-line-height-rule:exactly;font-family:tahoma, verdana, segoe, sans-serif;font-size:30px;font-style:normal;font-weight:normal;color:#836027;text-align:center"">Привет, " + textBox3.Text + @"!</h1></td></tr><tr style=""border-collapse:collapse""><td align=""center"" class=""es-m-txt-c"" style=""padding:0;Margin:0;padding-bottom:20px""><p style=""Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-family:arial, 'helvetica neue', helvetica, sans-serif;line-height:27px;color:#999999;font-size:18px"">Спасибо за регистрацию!</p><p style=""Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-family:arial, 'helvetica neue', helvetica, sans-serif;line-height:27px;color:#999999;font-size:18px"">Ваши данные :<br>→Логин : " + textBox1.Text + @"<br>→Пароль : " + textBox2.Text + @"</p></td></tr></table></td></tr></table></td></tr></table></td></tr></table><table cellpadding=""0"" cellspacing=""0"" class=""es-content"" align=""center"" style=""mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px;table-layout:fixed !important;width:100%""><tr style=""border-collapse:collapse""><td align=""center"" style=""padding:0;Margin:0""><table bgcolor=""#ffffff"" class=""es-content-body"" align=""center"" cellpadding=""0"" cellspacing=""0"" style=""mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px;background-color:#FFFFFF;width:600px""><tr style=""border-collapse:collapse""><td align=""left"" style=""padding:0;Margin:0;padding-left:20px;padding-right:20px""><table cellspacing=""0"" cellpadding=""0"" width=""100%"" style=""mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px""><tr style=""border-collapse:collapse""><td valign=""top"" align=""center"" style=""padding:0;Margin:0;width:560px""><table cellspacing=""0"" cellpadding=""0"" width=""100%"" role=""presentation"" style=""mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px""><tr style=""border-collapse:collapse""><td bgcolor=""#ecebf1"" align=""center"" style=""padding:0;Margin:0;padding-top:15px;padding-bottom:15px""><h1 style=""Margin:0;line-height:36px;mso-line-height-rule:exactly;font-family:tahoma, verdana, segoe, sans-serif;font-size:30px;font-style:normal;font-weight:normal;color:#6666CC"">help.delivery.service@gmail.com</h1></td></tr></table></td></tr></table></td></tr></table></td></tr></table></td></tr></table></div></body></html>";
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                smtpClient.Credentials = new NetworkCredential("help.delivery.service@gmail.com", "gPq4gjXcvXCh82jvV9n098xCbRc0w444PqYZH223ZDt0w4LxbGfawsU1bzpPxo8n7HcAN7q1c8rK2iu7aP986nTvLphvLhc1pyoX");
                smtpClient.EnableSsl = true;
                smtpClient.Send(mailMessage);
                MessageBox.Show("На вашу почту отправлено письмо с данными!", "Спасибо за регистрацию! - Delivery Service");
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
        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ProfilePic.Image = new Bitmap(openFileDialog1.FileName);

                    ProfilePic.Image.Save(memoryStream, ProfilePic.Image.RawFormat);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
    }
}
