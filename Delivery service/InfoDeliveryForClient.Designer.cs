namespace Delivery_service
{
    partial class InfoDeliveryForClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoDeliveryForClient));
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.Close_button = new System.Windows.Forms.PictureBox();
            this.label20 = new System.Windows.Forms.Label();
            this.gunaButton3 = new Guna.UI.WinForms.GunaButton();
            this.label12 = new System.Windows.Forms.Label();
            this.CommentaryTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.DesTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.RecTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.ObjTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.DeliveryDateTimePicker = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.Close_button)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 15;
            this.gunaElipse1.TargetControl = this;
            // 
            // Close_button
            // 
            this.Close_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(243)))), ((int)(((byte)(241)))));
            this.Close_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close_button.Image = global::Delivery_service.Properties.Resources.Close_button_leave2;
            this.Close_button.Location = new System.Drawing.Point(631, 11);
            this.Close_button.Margin = new System.Windows.Forms.Padding(2);
            this.Close_button.Name = "Close_button";
            this.Close_button.Size = new System.Drawing.Size(38, 41);
            this.Close_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Close_button.TabIndex = 1;
            this.Close_button.TabStop = false;
            this.Close_button.Click += new System.EventHandler(this.Close_button_Click);
            this.Close_button.MouseEnter += new System.EventHandler(this.Close_button_MouseEnter);
            this.Close_button.MouseLeave += new System.EventHandler(this.Close_button_MouseLeave);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.Location = new System.Drawing.Point(166, 11);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(310, 32);
            this.label20.TabIndex = 2;
            this.label20.Text = "Информация о доставке";
            // 
            // gunaButton3
            // 
            this.gunaButton3.Animated = true;
            this.gunaButton3.AnimationHoverSpeed = 0.07F;
            this.gunaButton3.AnimationSpeed = 0.03F;
            this.gunaButton3.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(18)))), ((int)(((byte)(38)))));
            this.gunaButton3.BorderColor = System.Drawing.Color.Black;
            this.gunaButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton3.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gunaButton3.ForeColor = System.Drawing.Color.White;
            this.gunaButton3.Image = null;
            this.gunaButton3.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton3.Location = new System.Drawing.Point(513, 244);
            this.gunaButton3.Name = "gunaButton3";
            this.gunaButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(35)))), ((int)(((byte)(73)))));
            this.gunaButton3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton3.OnHoverImage = null;
            this.gunaButton3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton3.Radius = 7;
            this.gunaButton3.Size = new System.Drawing.Size(155, 31);
            this.gunaButton3.TabIndex = 13;
            this.gunaButton3.Text = "Изменить";
            this.gunaButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton3.Click += new System.EventHandler(this.gunaButton3_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Location = new System.Drawing.Point(8, 167);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 20);
            this.label12.TabIndex = 15;
            this.label12.Text = "Комментарий";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // CommentaryTextBox
            // 
            this.CommentaryTextBox.BackColor = System.Drawing.Color.Transparent;
            this.CommentaryTextBox.BaseColor = System.Drawing.Color.White;
            this.CommentaryTextBox.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.CommentaryTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CommentaryTextBox.FocusedBaseColor = System.Drawing.Color.WhiteSmoke;
            this.CommentaryTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CommentaryTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.CommentaryTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CommentaryTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CommentaryTextBox.Location = new System.Drawing.Point(12, 190);
            this.CommentaryTextBox.MultiLine = true;
            this.CommentaryTextBox.Name = "CommentaryTextBox";
            this.CommentaryTextBox.PasswordChar = '\0';
            this.CommentaryTextBox.Radius = 7;
            this.CommentaryTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CommentaryTextBox.Size = new System.Drawing.Size(310, 85);
            this.CommentaryTextBox.TabIndex = 14;
            this.CommentaryTextBox.Text = "Комментарий";
            this.CommentaryTextBox.TextOffsetX = 7;
            this.CommentaryTextBox.TextChanged += new System.EventHandler(this.CommentaryTextBox_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(324, 167);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(168, 20);
            this.label11.TabIndex = 13;
            this.label11.Text = "Дата и время доставки";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.Color.DimGray;
            this.label14.Location = new System.Drawing.Point(324, 111);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(117, 20);
            this.label14.TabIndex = 8;
            this.label14.Text = "Адрес доставки";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // DesTextBox
            // 
            this.DesTextBox.BackColor = System.Drawing.Color.Transparent;
            this.DesTextBox.BaseColor = System.Drawing.Color.White;
            this.DesTextBox.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.DesTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DesTextBox.FocusedBaseColor = System.Drawing.Color.WhiteSmoke;
            this.DesTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DesTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.DesTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DesTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DesTextBox.Location = new System.Drawing.Point(328, 134);
            this.DesTextBox.Name = "DesTextBox";
            this.DesTextBox.PasswordChar = '\0';
            this.DesTextBox.Radius = 7;
            this.DesTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DesTextBox.Size = new System.Drawing.Size(340, 30);
            this.DesTextBox.TabIndex = 7;
            this.DesTextBox.Text = "Адрес доставки";
            this.DesTextBox.TextOffsetX = 7;
            this.DesTextBox.TextChanged += new System.EventHandler(this.DesTextBox_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.ForeColor = System.Drawing.Color.DimGray;
            this.label16.Location = new System.Drawing.Point(324, 56);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(130, 20);
            this.label16.TabIndex = 4;
            this.label16.Text = "Адрес получения";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // RecTextBox
            // 
            this.RecTextBox.BackColor = System.Drawing.Color.Transparent;
            this.RecTextBox.BaseColor = System.Drawing.Color.White;
            this.RecTextBox.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.RecTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RecTextBox.FocusedBaseColor = System.Drawing.Color.WhiteSmoke;
            this.RecTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.RecTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.RecTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RecTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RecTextBox.Location = new System.Drawing.Point(328, 79);
            this.RecTextBox.Name = "RecTextBox";
            this.RecTextBox.PasswordChar = '\0';
            this.RecTextBox.Radius = 7;
            this.RecTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RecTextBox.Size = new System.Drawing.Size(340, 30);
            this.RecTextBox.TabIndex = 3;
            this.RecTextBox.Text = "Адрес получения";
            this.RecTextBox.TextOffsetX = 7;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.ForeColor = System.Drawing.Color.DimGray;
            this.label19.Location = new System.Drawing.Point(8, 56);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(188, 20);
            this.label19.TabIndex = 2;
            this.label19.Text = "Описание объекта заказа";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // ObjTextBox
            // 
            this.ObjTextBox.BackColor = System.Drawing.Color.Transparent;
            this.ObjTextBox.BaseColor = System.Drawing.Color.White;
            this.ObjTextBox.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.ObjTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ObjTextBox.FocusedBaseColor = System.Drawing.Color.WhiteSmoke;
            this.ObjTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ObjTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.ObjTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ObjTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ObjTextBox.Location = new System.Drawing.Point(12, 79);
            this.ObjTextBox.MultiLine = true;
            this.ObjTextBox.Name = "ObjTextBox";
            this.ObjTextBox.PasswordChar = '\0';
            this.ObjTextBox.Radius = 7;
            this.ObjTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ObjTextBox.Size = new System.Drawing.Size(310, 85);
            this.ObjTextBox.TabIndex = 1;
            this.ObjTextBox.Text = "Описание объекта заказа";
            this.ObjTextBox.TextOffsetX = 7;
            this.ObjTextBox.TextChanged += new System.EventHandler(this.ObjTextBox_TextChanged);
            // 
            // DeliveryDateTimePicker
            // 
            this.DeliveryDateTimePicker.BackColor = System.Drawing.Color.Transparent;
            this.DeliveryDateTimePicker.BaseColor = System.Drawing.Color.White;
            this.DeliveryDateTimePicker.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.DeliveryDateTimePicker.CustomFormat = null;
            this.DeliveryDateTimePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DeliveryDateTimePicker.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DeliveryDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.DeliveryDateTimePicker.ForeColor = System.Drawing.Color.Black;
            this.DeliveryDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DeliveryDateTimePicker.Location = new System.Drawing.Point(328, 190);
            this.DeliveryDateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DeliveryDateTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DeliveryDateTimePicker.Name = "DeliveryDateTimePicker";
            this.DeliveryDateTimePicker.OnHoverBaseColor = System.Drawing.Color.White;
            this.DeliveryDateTimePicker.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DeliveryDateTimePicker.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DeliveryDateTimePicker.OnPressedColor = System.Drawing.Color.Black;
            this.DeliveryDateTimePicker.Radius = 7;
            this.DeliveryDateTimePicker.Size = new System.Drawing.Size(341, 30);
            this.DeliveryDateTimePicker.TabIndex = 16;
            this.DeliveryDateTimePicker.Text = "01.10.2019";
            this.DeliveryDateTimePicker.Value = new System.DateTime(2019, 10, 1, 0, 0, 0, 0);
            // 
            // gunaButton1
            // 
            this.gunaButton1.Animated = true;
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(18)))), ((int)(((byte)(38)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(337, 244);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(35)))), ((int)(((byte)(73)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 7;
            this.gunaButton1.Size = new System.Drawing.Size(155, 31);
            this.gunaButton1.TabIndex = 17;
            this.gunaButton1.Text = "Отменить";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // InfoDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(243)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(680, 291);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.DeliveryDateTimePicker);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.CommentaryTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.gunaButton3);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.Close_button);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.ObjTextBox);
            this.Controls.Add(this.DesTextBox);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.RecTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InfoDelivery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InfoDelivery";
            ((System.ComponentModel.ISupportInitialize)(this.Close_button)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.PictureBox Close_button;
        private System.Windows.Forms.Label label20;
        private Guna.UI.WinForms.GunaButton gunaButton3;
        private System.Windows.Forms.Label label12;
        private Guna.UI.WinForms.GunaTextBox CommentaryTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private Guna.UI.WinForms.GunaTextBox ObjTextBox;
        private Guna.UI.WinForms.GunaTextBox DesTextBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label16;
        private Guna.UI.WinForms.GunaTextBox RecTextBox;
        private Guna.UI.WinForms.GunaDateTimePicker DeliveryDateTimePicker;
        private Guna.UI.WinForms.GunaButton gunaButton1;
    }
}