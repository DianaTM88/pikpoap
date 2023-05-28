namespace pikpoap
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonsave = new System.Windows.Forms.Button();
            this.buttondel = new System.Windows.Forms.Button();
            this.buttonnew = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxprep = new System.Windows.Forms.TextBox();
            this.textBoxpostav = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxcount = new System.Windows.Forms.TextBox();
            this.textBoxapt = new System.Windows.Forms.TextBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.textBoxstoim = new System.Windows.Forms.TextBox();
            this.labelprice = new System.Windows.Forms.Label();
            this.labelprovider = new System.Windows.Forms.Label();
            this.labelcount = new System.Windows.Forms.Label();
            this.labeltype = new System.Windows.Forms.Label();
            this.labelid = new System.Windows.Forms.Label();
            this.label_entry = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.buttonsave);
            this.panel4.Controls.Add(this.buttondel);
            this.panel4.Controls.Add(this.buttonnew);
            this.panel4.Location = new System.Drawing.Point(12, 449);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(584, 220);
            this.panel4.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(188, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Управление записями";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonsave
            // 
            this.buttonsave.Location = new System.Drawing.Point(193, 107);
            this.buttonsave.Name = "buttonsave";
            this.buttonsave.Size = new System.Drawing.Size(184, 43);
            this.buttonsave.TabIndex = 3;
            this.buttonsave.Text = "Сохранить";
            this.buttonsave.UseVisualStyleBackColor = true;
            this.buttonsave.Click += new System.EventHandler(this.buttonsave_Click);
            // 
            // buttondel
            // 
            this.buttondel.Location = new System.Drawing.Point(383, 107);
            this.buttondel.Name = "buttondel";
            this.buttondel.Size = new System.Drawing.Size(184, 43);
            this.buttondel.TabIndex = 1;
            this.buttondel.Text = "Удалить";
            this.buttondel.UseVisualStyleBackColor = true;
            this.buttondel.Click += new System.EventHandler(this.buttondel_Click_1);
            // 
            // buttonnew
            // 
            this.buttonnew.Location = new System.Drawing.Point(3, 107);
            this.buttonnew.Name = "buttonnew";
            this.buttonnew.Size = new System.Drawing.Size(184, 43);
            this.buttonnew.TabIndex = 0;
            this.buttonnew.Text = "Новая запись";
            this.buttonnew.UseVisualStyleBackColor = true;
            this.buttonnew.Click += new System.EventHandler(this.buttonnew_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBoxprep);
            this.panel3.Controls.Add(this.textBoxpostav);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.textBoxcount);
            this.panel3.Controls.Add(this.textBoxapt);
            this.panel3.Controls.Add(this.textBox);
            this.panel3.Controls.Add(this.textBoxstoim);
            this.panel3.Controls.Add(this.labelprice);
            this.panel3.Controls.Add(this.labelprovider);
            this.panel3.Controls.Add(this.labelcount);
            this.panel3.Controls.Add(this.labeltype);
            this.panel3.Controls.Add(this.labelid);
            this.panel3.Controls.Add(this.label_entry);
            this.panel3.Location = new System.Drawing.Point(640, 449);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(610, 230);
            this.panel3.TabIndex = 6;
            // 
            // textBoxprep
            // 
            this.textBoxprep.Location = new System.Drawing.Point(305, 100);
            this.textBoxprep.Name = "textBoxprep";
            this.textBoxprep.Size = new System.Drawing.Size(231, 22);
            this.textBoxprep.TabIndex = 15;
            // 
            // textBoxpostav
            // 
            this.textBoxpostav.Location = new System.Drawing.Point(305, 185);
            this.textBoxpostav.Name = "textBoxpostav";
            this.textBoxpostav.Size = new System.Drawing.Size(231, 22);
            this.textBoxpostav.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Наименование препарата";
            // 
            // textBoxcount
            // 
            this.textBoxcount.Location = new System.Drawing.Point(305, 128);
            this.textBoxcount.Name = "textBoxcount";
            this.textBoxcount.Size = new System.Drawing.Size(231, 22);
            this.textBoxcount.TabIndex = 10;
            // 
            // textBoxapt
            // 
            this.textBoxapt.Location = new System.Drawing.Point(305, 72);
            this.textBoxapt.Name = "textBoxapt";
            this.textBoxapt.Size = new System.Drawing.Size(231, 22);
            this.textBoxapt.TabIndex = 9;
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(305, 44);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(231, 22);
            this.textBox.TabIndex = 8;
            // 
            // textBoxstoim
            // 
            this.textBoxstoim.Location = new System.Drawing.Point(305, 157);
            this.textBoxstoim.Name = "textBoxstoim";
            this.textBoxstoim.Size = new System.Drawing.Size(231, 22);
            this.textBoxstoim.TabIndex = 7;
            // 
            // labelprice
            // 
            this.labelprice.AutoSize = true;
            this.labelprice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelprice.Location = new System.Drawing.Point(176, 157);
            this.labelprice.Name = "labelprice";
            this.labelprice.Size = new System.Drawing.Size(102, 20);
            this.labelprice.TabIndex = 6;
            this.labelprice.Text = "Стоимость";
            // 
            // labelprovider
            // 
            this.labelprovider.AutoSize = true;
            this.labelprovider.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelprovider.Location = new System.Drawing.Point(45, 185);
            this.labelprovider.Name = "labelprovider";
            this.labelprovider.Size = new System.Drawing.Size(240, 20);
            this.labelprovider.TabIndex = 5;
            this.labelprovider.Text = "Наименование поставщика";
            // 
            // labelcount
            // 
            this.labelcount.AutoSize = true;
            this.labelcount.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcount.Location = new System.Drawing.Point(176, 130);
            this.labelcount.Name = "labelcount";
            this.labelcount.Size = new System.Drawing.Size(109, 20);
            this.labelcount.TabIndex = 4;
            this.labelcount.Text = "Количество";
            // 
            // labeltype
            // 
            this.labeltype.AutoSize = true;
            this.labeltype.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltype.Location = new System.Drawing.Point(88, 72);
            this.labeltype.Name = "labeltype";
            this.labeltype.Size = new System.Drawing.Size(197, 20);
            this.labeltype.TabIndex = 3;
            this.labeltype.Text = "Наименование аптеки";
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelid.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelid.Location = new System.Drawing.Point(260, 46);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(25, 20);
            this.labelid.TabIndex = 2;
            this.labelid.Text = "id";
            // 
            // label_entry
            // 
            this.label_entry.AutoSize = true;
            this.label_entry.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_entry.ForeColor = System.Drawing.Color.Green;
            this.label_entry.Location = new System.Drawing.Point(228, 14);
            this.label_entry.Name = "label_entry";
            this.label_entry.Size = new System.Drawing.Size(80, 27);
            this.label_entry.TabIndex = 0;
            this.label_entry.Text = "Запись";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(867, 329);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Moccasin;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1178, 89);
            this.panel1.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(10, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 38);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::pikpoap.Properties.Resources.free_icon_magnifier_2319177__1_;
            this.pictureBox2.Location = new System.Drawing.Point(226, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(77, 86);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::pikpoap.Properties.Resources.free_icon_pharmacy_1686939__1_;
            this.pictureBox4.Location = new System.Drawing.Point(1084, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(77, 83);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::pikpoap.Properties.Resources.free_icon_two_clockwise_circular;
            this.pictureBox3.Location = new System.Drawing.Point(891, 107);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(82, 71);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 691);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonsave;
        private System.Windows.Forms.Button buttondel;
        private System.Windows.Forms.Button buttonnew;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxcount;
        private System.Windows.Forms.TextBox textBoxapt;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.TextBox textBoxstoim;
        private System.Windows.Forms.Label labelprice;
        private System.Windows.Forms.Label labelprovider;
        private System.Windows.Forms.Label labelcount;
        private System.Windows.Forms.Label labeltype;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.Label label_entry;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxpostav;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox textBoxprep;
    }
}

