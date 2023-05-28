namespace pikpoap
{
    partial class log_in
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
            this.label_auto = new System.Windows.Forms.Label();
            this.label_login1 = new System.Windows.Forms.Label();
            this.label_password2 = new System.Windows.Forms.Label();
            this.button_reg = new System.Windows.Forms.Button();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_auto
            // 
            this.label_auto.AutoSize = true;
            this.label_auto.Font = new System.Drawing.Font("Showcard Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_auto.ForeColor = System.Drawing.Color.YellowGreen;
            this.label_auto.Location = new System.Drawing.Point(224, 61);
            this.label_auto.Name = "label_auto";
            this.label_auto.Size = new System.Drawing.Size(345, 59);
            this.label_auto.TabIndex = 16;
            this.label_auto.Text = "Авторизация";
            // 
            // label_login1
            // 
            this.label_login1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_login1.Font = new System.Drawing.Font("Sitka Banner", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_login1.ForeColor = System.Drawing.Color.Green;
            this.label_login1.Location = new System.Drawing.Point(168, 181);
            this.label_login1.Margin = new System.Windows.Forms.Padding(30, 10, 30, 10);
            this.label_login1.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.label_login1.Name = "label_login1";
            this.label_login1.Size = new System.Drawing.Size(184, 55);
            this.label_login1.TabIndex = 17;
            this.label_login1.Text = "Логин";
            // 
            // label_password2
            // 
            this.label_password2.BackColor = System.Drawing.SystemColors.Control;
            this.label_password2.Font = new System.Drawing.Font("Sitka Banner", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_password2.ForeColor = System.Drawing.Color.Green;
            this.label_password2.Location = new System.Drawing.Point(169, 246);
            this.label_password2.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.label_password2.Name = "label_password2";
            this.label_password2.Size = new System.Drawing.Size(275, 83);
            this.label_password2.TabIndex = 18;
            this.label_password2.Text = "Пароль";
            // 
            // button_reg
            // 
            this.button_reg.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_reg.ForeColor = System.Drawing.Color.DarkGreen;
            this.button_reg.Location = new System.Drawing.Point(310, 377);
            this.button_reg.Name = "button_reg";
            this.button_reg.Size = new System.Drawing.Size(203, 35);
            this.button_reg.TabIndex = 21;
            this.button_reg.Text = "Авторизоваться";
            this.button_reg.UseVisualStyleBackColor = true;
            this.button_reg.Click += new System.EventHandler(this.button_reg_Click_1);
            // 
            // textBox_login
            // 
            this.textBox_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_login.Location = new System.Drawing.Point(459, 199);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(187, 34);
            this.textBox_login.TabIndex = 22;
            this.textBox_login.TextChanged += new System.EventHandler(this.textBox_login_TextChanged);
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_password.Location = new System.Drawing.Point(459, 262);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(187, 34);
            this.textBox_password.TabIndex = 23;
            this.textBox_password.TextChanged += new System.EventHandler(this.textBox_password_TextChanged);
            // 
            // log_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.button_reg);
            this.Controls.Add(this.label_password2);
            this.Controls.Add(this.label_login1);
            this.Controls.Add(this.label_auto);
            this.Name = "log_in";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.log_in_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_auto;
        private System.Windows.Forms.Label label_login1;
        public System.Windows.Forms.Label label_password2;
        private System.Windows.Forms.Button button_reg;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.TextBox textBox_password;
    }
}