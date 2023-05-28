namespace pikpoap
{
    partial class Add_Form
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
            this.label_add = new System.Windows.Forms.Label();
            this.textBox_aptek = new System.Windows.Forms.TextBox();
            this.textBox_prepar = new System.Windows.Forms.TextBox();
            this.textBox_colvo = new System.Windows.Forms.TextBox();
            this.textBox_st = new System.Windows.Forms.TextBox();
            this.button_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_post = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_add
            // 
            this.label_add.AutoSize = true;
            this.label_add.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label_add.Font = new System.Drawing.Font("Showcard Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_add.ForeColor = System.Drawing.Color.YellowGreen;
            this.label_add.Location = new System.Drawing.Point(201, 22);
            this.label_add.Name = "label_add";
            this.label_add.Size = new System.Drawing.Size(438, 59);
            this.label_add.TabIndex = 17;
            this.label_add.Text = "НОВАЯ ЗАПИСЬ";
            // 
            // textBox_aptek
            // 
            this.textBox_aptek.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_aptek.Location = new System.Drawing.Point(469, 122);
            this.textBox_aptek.Name = "textBox_aptek";
            this.textBox_aptek.Size = new System.Drawing.Size(211, 34);
            this.textBox_aptek.TabIndex = 20;
            this.textBox_aptek.TextChanged += new System.EventHandler(this.textBox_aptek_TextChanged);
            // 
            // textBox_prepar
            // 
            this.textBox_prepar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_prepar.Location = new System.Drawing.Point(469, 173);
            this.textBox_prepar.Name = "textBox_prepar";
            this.textBox_prepar.Size = new System.Drawing.Size(211, 34);
            this.textBox_prepar.TabIndex = 21;
            // 
            // textBox_colvo
            // 
            this.textBox_colvo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_colvo.Location = new System.Drawing.Point(469, 219);
            this.textBox_colvo.Name = "textBox_colvo";
            this.textBox_colvo.Size = new System.Drawing.Size(211, 34);
            this.textBox_colvo.TabIndex = 22;
            // 
            // textBox_st
            // 
            this.textBox_st.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_st.Location = new System.Drawing.Point(469, 273);
            this.textBox_st.Name = "textBox_st";
            this.textBox_st.Size = new System.Drawing.Size(211, 34);
            this.textBox_st.TabIndex = 23;
            // 
            // button_save
            // 
            this.button_save.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.ForeColor = System.Drawing.Color.Green;
            this.button_save.Location = new System.Drawing.Point(315, 388);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(203, 35);
            this.button_save.TabIndex = 24;
            this.button_save.Text = "Сохранить";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 21);
            this.label1.TabIndex = 25;
            this.label1.Text = "Наименование аптеки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 21);
            this.label2.TabIndex = 26;
            this.label2.Text = "Наименование препарата";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(126, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 21);
            this.label3.TabIndex = 27;
            this.label3.Text = "Количество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(126, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 21);
            this.label4.TabIndex = 28;
            this.label4.Text = "Стоимость";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(126, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 21);
            this.label5.TabIndex = 29;
            this.label5.Text = "Наименование поставщика";
            // 
            // textBox_post
            // 
            this.textBox_post.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_post.Location = new System.Drawing.Point(469, 320);
            this.textBox_post.Name = "textBox_post";
            this.textBox_post.Size = new System.Drawing.Size(211, 34);
            this.textBox_post.TabIndex = 30;
            // 
            // Add_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_post);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.textBox_st);
            this.Controls.Add(this.textBox_colvo);
            this.Controls.Add(this.textBox_prepar);
            this.Controls.Add(this.textBox_aptek);
            this.Controls.Add(this.label_add);
            this.Name = "Add_Form";
            this.Text = "Add_Form";
            this.Load += new System.EventHandler(this.Add_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_add;
        private System.Windows.Forms.TextBox textBox_aptek;
        private System.Windows.Forms.TextBox textBox_prepar;
        private System.Windows.Forms.TextBox textBox_colvo;
        private System.Windows.Forms.TextBox textBox_st;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_post;
    }
}