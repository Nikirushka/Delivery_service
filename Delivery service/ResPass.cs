using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delivery_service
{
    public partial class ResPass : Form
    {
        SqlConnection connection;
        SqlDataReader reader = null;
        SqlCommand cmd;

        string name, surname, phone, email, log, pass, patr;

        private void EmailTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            EmailTextBox.Text = "";
        }

        private void EmailTextBox_MouseClick(object sender, EventArgs e)
        {
            EmailTextBox.Text = "";
        }

        string connectionString = @"Server=tcp:deliveryservice.database.windows.net,1433;Initial Catalog=Delivery service;Persist Security Info=False;User ID=Nikiru;Password=Rnp26122001;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        public ResPass()
        {
            InitializeComponent();
        }

        private void Close_button_MouseEnter(object sender, EventArgs e)
        {
            Close_button.Image = Properties.Resources.Close_button_enter;
        }

        private void Close_button_MouseLeave(object sender, EventArgs e)
        {
            Close_button.Image = Properties.Resources.Close_button_leave;
        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void LoginB_Click(object sender, EventArgs e)
        {
            //gPq4gjXcvXCh82jvV9n098xCbRc0w444PqYZH223ZDt0w4LxbGfawsU1bzpPxo8n7HcAN7q1c8rK2iu7aP986nTvLphvLhc1pyoX
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                int id = 0;
                string query = $"exec GetIDbyEmail N'{EmailTextBox.Text}'";
                cmd = new SqlCommand(query, connection);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        id = Convert.ToInt32(reader[0]);
                    }
                    reader.Close();
                    query = $"select * from [Delivery service user] where id={id}";
                    cmd = new SqlCommand(query, connection);
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        name = reader[2].ToString();
                        surname = reader[1].ToString();
                        patr = reader[3].ToString();
                        phone = reader[5].ToString();
                        email = reader[6].ToString();
                        log = reader[8].ToString();
                        pass = reader[9].ToString();
                    }
                    MailAddress fromMailAddress = new MailAddress("help.delivery.service@gmail.com", "Support Delivery Service");
                    MailAddress toAddress = new MailAddress($"{EmailTextBox.Text}");
                    MailMessage mailMessage = new MailMessage(fromMailAddress, toAddress);
                    mailMessage.IsBodyHtml = true;
                    mailMessage.Subject = "Восстановление пароля - Delivery Service";
                    mailMessage.Body = @"<!DOCTYPE html PUBLIC ""-//W3C//DTD XHTML 1.0 Transitional//EN"" ""http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd"">
<html xmlns=""http://www.w3.org/1999/xhtml"" xmlns:o=""urn:schemas-microsoft-com:office:office"" style=""width:100%;font-family:helvetica, 'helvetica neue', arial, verdana, sans-serif;-webkit-text-size-adjust:100%;-ms-text-size-adjust:100%;padding:0;Margin:0"">
<head>
<meta charset=""UTF-8"">
<meta content=""width=device-width, initial-scale=1"" name=""viewport"">
<meta name=""x-apple-disable-message-reformatting"">
<meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
<meta content=""telephone=no"" name=""format-detection"">
<title>Новое письмо</title>
<!--[if (mso 16)]>
<style type=""text/css"">
a {text-decoration: none;}
</style>
<![endif]-->
<!--[if gte mso 9]><style>sup { font-size: 100% !important; }</style><![endif]-->
<!--[if gte mso 9]>
<xml>
<o:OfficeDocumentSettings>
<o:AllowPNG></o:AllowPNG>
<o:PixelsPerInch>96</o:PixelsPerInch>
</o:OfficeDocumentSettings>
</xml>
<![endif]-->
<style type=""text/css"">
#outlook a {
padding:0;
}
.ExternalClass {
width:100%;
}
.ExternalClass,
.ExternalClass p,
.ExternalClass span,
.ExternalClass font,
.ExternalClass td,
.ExternalClass div {
line-height:100%;
}
.es-button {
mso-style-priority:100!important;
text-decoration:none!important;
}
a[x-apple-data-detectors] {
color:inherit!important;
text-decoration:none!important;
font-size:inherit!important;
font-family:inherit!important;
font-weight:inherit!important;
line-height:inherit!important;
}
.es-desk-hidden {
display:none;
float:left;
overflow:hidden;
width:0;
max-height:0;
line-height:0;
mso-hide:all;
}
.es-button-border:hover a.es-button, .es-button-border:hover button.es-button {
background:#ffffff!important;
border-color:#ffffff!important;
}
.es-button-border:hover {
background:#ffffff!important;
border-style:solid solid solid solid!important;
border-color:#3d5ca3 #3d5ca3 #3d5ca3 #3d5ca3!important;
}
[data-ogsb] .es-button {
border-width:0!important;
padding:15px 20px 15px 20px!important;
}
@media only screen and (max-width:600px) {p, ul li, ol li, a { line-height:150%!important } h1 { font-size:20px!important; text-align:center; line-height:120%!important } h2 { font-size:16px!important; text-align:left; line-height:120%!important } h3 { font-size:20px!important; text-align:center; line-height:120%!important } .es-header-body h1 a, .es-content-body h1 a, .es-footer-body h1 a { font-size:20px!important } h2 a { text-align:left } .es-header-body h2 a, .es-content-body h2 a, .es-footer-body h2 a { font-size:16px!important } .es-header-body h3 a, .es-content-body h3 a, .es-footer-body h3 a { font-size:20px!important } .es-menu td a { font-size:14px!important } .es-header-body p, .es-header-body ul li, .es-header-body ol li, .es-header-body a { font-size:10px!important } .es-content-body p, .es-content-body ul li, .es-content-body ol li, .es-content-body a { font-size:16px!important } .es-footer-body p, .es-footer-body ul li, .es-footer-body ol li, .es-footer-body a { font-size:12px!important } .es-infoblock p, .es-infoblock ul li, .es-infoblock ol li, .es-infoblock a { font-size:12px!important } *[class=""gmail-fix""] { display:none!important } .es-m-txt-c, .es-m-txt-c h1, .es-m-txt-c h2, .es-m-txt-c h3 { text-align:center!important } .es-m-txt-r, .es-m-txt-r h1, .es-m-txt-r h2, .es-m-txt-r h3 { text-align:right!important } .es-m-txt-l, .es-m-txt-l h1, .es-m-txt-l h2, .es-m-txt-l h3 { text-align:left!important } .es-m-txt-r img, .es-m-txt-c img, .es-m-txt-l img { display:inline!important } .es-button-border { display:block!important } a.es-button, button.es-button { font-size:14px!important; display:block!important; border-left-width:0px!important; border-right-width:0px!important } .es-btn-fw { border-width:10px 0px!important; text-align:center!important } .es-adaptive table, .es-btn-fw, .es-btn-fw-brdr, .es-left, .es-right { width:100%!important } .es-content table, .es-header table, .es-footer table, .es-content, .es-footer, .es-header { width:100%!important; max-width:600px!important } .es-adapt-td { display:block!important; width:100%!important } .adapt-img { width:100%!important; height:auto!important } .es-m-p0 { padding:0px!important } .es-m-p0r { padding-right:0px!important } .es-m-p0l { padding-left:0px!important } .es-m-p0t { padding-top:0px!important } .es-m-p0b { padding-bottom:0!important } .es-m-p20b { padding-bottom:20px!important } .es-mobile-hidden, .es-hidden { display:none!important } tr.es-desk-hidden, td.es-desk-hidden, table.es-desk-hidden { width:auto!important; overflow:visible!important; float:none!important; max-height:inherit!important; line-height:inherit!important } tr.es-desk-hidden { display:table-row!important } table.es-desk-hidden { display:table!important } td.es-desk-menu-hidden { display:table-cell!important } .es-menu td { width:1%!important } table.es-table-not-adapt, .esd-block-html table { width:auto!important } table.es-social { display:inline-block!important } table.es-social td { display:inline-block!important } }
</style>
</head>
<body style=""width:100%;font-family:helvetica, 'helvetica neue', arial, verdana, sans-serif;-webkit-text-size-adjust:100%;-ms-text-size-adjust:100%;padding:0;Margin:0"">
<div class=""es-wrapper-color"" style=""background-color:#FAFAFA"">
<!--[if gte mso 9]>
<v:background xmlns:v=""urn:schemas-microsoft-com:vml"" fill=""t"">
<v:fill type=""tile"" color=""#fafafa""></v:fill>
</v:background>
<![endif]-->
<table class=""es-wrapper"" width=""100%"" cellspacing=""0"" cellpadding=""0"" style=""mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px;padding:0;Margin:0;width:100%;height:100%;background-repeat:repeat;background-position:center top"">
<tr style=""border-collapse:collapse"">
<td valign=""top"" style=""padding:0;Margin:0"">
<table cellpadding=""0"" cellspacing=""0"" class=""es-content"" align=""center"" style=""mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px;table-layout:fixed !important;width:100%"">
<tr style=""border-collapse:collapse"">
<td class=""es-adaptive"" align=""center"" style=""padding:0;Margin:0"">
<table class=""es-content-body"" style=""mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px;background-color:transparent;width:600px"" cellspacing=""0"" cellpadding=""0"" bgcolor=""#ffffff"" align=""center"">
<tr style=""border-collapse:collapse"">
<td align=""left"" style=""padding:10px;Margin:0"">
<table width=""100%"" cellspacing=""0"" cellpadding=""0"" style=""mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px"">
<tr style=""border-collapse:collapse"">
<td valign=""top"" align=""center"" style=""padding:0;Margin:0;width:580px"">
<table width=""100%"" cellspacing=""0"" cellpadding=""0"" role=""presentation"" style=""mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px"">
<tr style=""border-collapse:collapse"">
<td align=""center"" class=""es-infoblock"" style=""padding:0;Margin:0;line-height:14px;font-size:12px;color:#CCCCCC""><p style=""Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-family:helvetica, 'helvetica neue', arial, verdana, sans-serif;line-height:14px;color:#CCCCCC;font-size:12px"">Put your preheader text here. <a href=""https://viewstripo.email"" class=""view"" target=""_blank"" style=""-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;text-decoration:none;color:#CCCCCC;font-size:12px"">View in browser</a></p></td>
</tr>
</table></td>
</tr>
</table></td>
</tr>
</table></td>
</tr>
</table>
<table cellpadding=""0"" cellspacing=""0"" class=""es-header"" align=""center"" style=""mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px;table-layout:fixed !important;width:100%;background-color:transparent;background-repeat:repeat;background-position:center top"">
<tr style=""border-collapse:collapse"">
<td class=""es-adaptive"" align=""center"" style=""padding:0;Margin:0"">
<table class=""es-header-body"" style=""mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px;background-color:#3D5CA3;width:600px"" cellspacing=""0"" cellpadding=""0"" bgcolor=""#3d5ca3"" align=""center"">
<tr style=""border-collapse:collapse"">
<td style=""Margin:0;padding-top:20px;padding-bottom:20px;padding-left:20px;padding-right:20px;background-color:#3D5CA3"" bgcolor=""#3d5ca3"" align=""left"">
<!--[if mso]><table style=""width:560px"" cellpadding=""0""
cellspacing=""0""><tr><td style=""width:270px"" valign=""top""><![endif]-->
<table class=""es-left"" cellspacing=""0"" cellpadding=""0"" align=""left"" style=""mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px;float:left"">
<tr style=""border-collapse:collapse"">
<td class=""es-m-p20b"" align=""left"" style=""padding:0;Margin:0;width:270px"">
<table width=""100%"" cellspacing=""0"" cellpadding=""0"" role=""presentation"" style=""mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px"">
<tr style=""border-collapse:collapse"">
<td class=""es-m-p0l es-m-txt-c"" align=""left"" style=""padding:0;Margin:0;font-size:0px""><a href=""https://viewstripo.email"" target=""_blank"" style=""-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;text-decoration:none;color:#1376C8;font-size:14px""><img src=""https://lidknf.stripocdn.email/content/guids/CABINET_83d431fb1d570bb36f4d6f2c2dfcf0d8/images/16971620329784148.png"" alt style=""display:block;border:0;outline:none;text-decoration:none;-ms-interpolation-mode:bicubic"" width=""183""></a></td>
</tr>
</table></td>
</tr>
</table>
<!--[if mso]></td><td style=""width:20px""></td><td style=""width:270px"" valign=""top""><![endif]-->
<table class=""es-right"" cellspacing=""0"" cellpadding=""0"" align=""right"" style=""mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px;float:right"">
<tr style=""border-collapse:collapse"">
<td align=""left"" style=""padding:0;Margin:0;width:270px"">
<table width=""100%"" cellspacing=""0"" cellpadding=""0"" role=""presentation"" style=""mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px"">
<tr style=""border-collapse:collapse"">
<td align=""center"" style=""padding:0;Margin:0;padding-top:40px""><p style=""Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-family:helvetica, 'helvetica neue', arial, verdana, sans-serif;line-height:50px;color:#FFCCFF;font-size:33px"">Delivery Service&nbsp;</p><p style=""Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-family:helvetica, 'helvetica neue', arial, verdana, sans-serif;line-height:50px;color:#FFCCFF;font-size:33px;text-align:center"">Restore Password</p></td>
</tr>
</table></td>
</tr>
</table>
<!--[if mso]></td></tr></table><![endif]--></td>
</tr>
</table></td>
</tr>
</table>
<table class=""es-content"" cellspacing=""0"" cellpadding=""0"" align=""center"" style=""mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px;table-layout:fixed !important;width:100%"">
<tr style=""border-collapse:collapse"">
<td style=""padding:0;Margin:0;background-color:#FAFAFA"" bgcolor=""#fafafa"" align=""center"">
<table class=""es-content-body"" style=""mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px;background-color:#FFFFFF;width:600px"" cellspacing=""0"" cellpadding=""0"" bgcolor=""#ffffff"" align=""center"">
<tr style=""border-collapse:collapse"">
<td style=""padding:0;Margin:0;padding-left:20px;padding-right:20px;padding-top:40px;background-color:transparent"" bgcolor=""transparent"" align=""left"">
<table width=""100%"" cellspacing=""0"" cellpadding=""0"" style=""mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px"">
<tr style=""border-collapse:collapse"">
<td valign=""top"" align=""center"" style=""padding:0;Margin:0;width:560px"">
<table style=""mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px;background-position:left top"" width=""100%"" cellspacing=""0"" cellpadding=""0"" role=""presentation"">
<tr style=""border-collapse:collapse"">
<td align=""center"" style=""padding:0;Margin:0;padding-top:5px;padding-bottom:5px;font-size:0""><img src=""https://lidknf.stripocdn.email/content/guids/CABINET_dd354a98a803b60e2f0411e893c82f56/images/23891556799905703.png"" alt style=""display:block;border:0;outline:none;text-decoration:none;-ms-interpolation-mode:bicubic"" width=""175""></td>
</tr>
<tr style=""border-collapse:collapse"">
<td align=""center"" style=""padding:0;Margin:0;padding-top:15px;padding-bottom:15px""><h1 style=""Margin:0;line-height:24px;mso-line-height-rule:exactly;font-family:arial, 'helvetica neue', helvetica, sans-serif;font-size:20px;font-style:normal;font-weight:normal;color:#333333""><strong style=""background-color:transparent"">ЗАБЫЛИ СВОЙ ПАРОЛЬ?</strong></h1></td>
</tr>
<tr style=""border-collapse:collapse"">
<td align=""center"" style=""padding:0;Margin:0;padding-left:40px;padding-right:40px""><p style=""Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-family:helvetica, 'helvetica neue', arial, verdana, sans-serif;line-height:24px;color:#666666;font-size:16px"">ПРИВЕТ,"+$"{name}"+$" {surname}"+@"</p></td>
</tr>
<tr style=""border-collapse:collapse"">
<td align=""center"" style=""padding:0;Margin:0;padding-right:35px;padding-left:40px""><p style=""Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-family:helvetica, 'helvetica neue', arial, verdana, sans-serif;line-height:24px;color:#666666;font-size:16px"">ЭТО ТВОИ ДАННЫЕ!</p></td>
</tr>
<tr style=""border-collapse:collapse"">
<td align=""center"" style=""padding:0;Margin:0;padding-top:25px;padding-left:40px;padding-right:40px""><p style=""Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-family:helvetica, 'helvetica neue', arial, verdana, sans-serif;line-height:24px;color:#666666;font-size:16px"">"+$"Логин : {log}, Пароль : {pass}"+@"</p></td>
</tr>
</table></td>
</tr>
</table></td>
</tr>
</table></td>
</tr>
</table>
<table class=""es-footer"" cellspacing=""0"" cellpadding=""0"" align=""center"" style=""mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px;table-layout:fixed !important;width:100%;background-color:transparent;background-repeat:repeat;background-position:center top"">
<tr style=""border-collapse:collapse"">
<td style=""padding:0;Margin:0;background-color:#FAFAFA"" bgcolor=""#fafafa"" align=""center"">
<table class=""es-footer-body"" style=""mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px;background-color:transparent;width:600px"" cellspacing=""0"" cellpadding=""0"" bgcolor=""transparent"" align=""center"">
<tr style=""border-collapse:collapse"">
<td style=""Margin:0;padding-top:20px;padding-bottom:20px;padding-left:20px;padding-right:20px;background-color:#3D5CA3"" bgcolor=""#3d5ca3"" align=""left"">
<!--[if mso]><table style=""width:560px"" cellpadding=""0""
cellspacing=""0""><tr><td style=""width:270px"" valign=""top""><![endif]-->
<table class=""es-left"" cellspacing=""0"" cellpadding=""0"" align=""left"" style=""mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px;float:left"">
<tr style=""border-collapse:collapse"">
<td class=""es-m-p20b"" align=""left"" style=""padding:0;Margin:0;width:270px"">
<table width=""100%"" cellspacing=""0"" cellpadding=""0"" role=""presentation"" style=""mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px"">
<tr style=""border-collapse:collapse"">
<td class=""es-m-p0l es-m-txt-c"" align=""left"" style=""padding:0;Margin:0;font-size:0px""><a href=""https://viewstripo.email"" target=""_blank"" style=""-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;text-decoration:none;color:#333333;font-size:14px""><img src=""https://lidknf.stripocdn.email/content/guids/CABINET_83d431fb1d570bb36f4d6f2c2dfcf0d8/images/16971620329784148.png"" alt style=""display:block;border:0;outline:none;text-decoration:none;-ms-interpolation-mode:bicubic"" width=""183""></a></td>
</tr>
</table></td>
</tr>
</table>
<!--[if mso]></td><td style=""width:20px""></td><td style=""width:270px"" valign=""top""><![endif]-->
<table class=""es-right"" cellspacing=""0"" cellpadding=""0"" align=""right"" style=""mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px;float:right"">
<tr style=""border-collapse:collapse"">
<td align=""left"" style=""padding:0;Margin:0;width:270px"">
<table width=""100%"" cellspacing=""0"" cellpadding=""0"" role=""presentation"" style=""mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px"">
<tr style=""border-collapse:collapse"">
<td align=""center"" style=""padding:0;Margin:0;padding-top:40px""><p style=""Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-family:helvetica, 'helvetica neue', arial, verdana, sans-serif;line-height:50px;color:#FFCCFF;font-size:33px"">Delivery Service&nbsp;</p><p style=""Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-family:helvetica, 'helvetica neue', arial, verdana, sans-serif;line-height:50px;color:#FFCCFF;font-size:33px;text-align:center"">Restore Password</p></td>
</tr>
</table></td>
</tr>
</table>
<!--[if mso]></td></tr></table><![endif]--></td>
</tr>
</table></td>
</tr>
</table></td>
</tr>
</table>
</div>
</body>
</html>";
                    SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                    smtpClient.Credentials = new NetworkCredential("help.delivery.service@gmail.com", "gPq4gjXcvXCh82jvV9n098xCbRc0w444PqYZH223ZDt0w4LxbGfawsU1bzpPxo8n7HcAN7q1c8rK2iu7aP986nTvLphvLhc1pyoX");
                    smtpClient.EnableSsl = true;
                    smtpClient.Send(mailMessage);
                    MessageBox.Show("Ваши данные успешно отправлены на вашу почту!", "Восстановление пароля - Delivery Service");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Пользователя с таким электронным адресом не существует!", "Ошибка!");
                }
                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
