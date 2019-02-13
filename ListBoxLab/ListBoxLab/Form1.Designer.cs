namespace ListBoxLab
{
    partial class frmCars
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
            this.listBoxCars = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butClear = new System.Windows.Forms.Button();
            this.butAdd = new System.Windows.Forms.Button();
            this.tbColor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSNB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMarka = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxCars
            // 
            this.listBoxCars.BackColor = System.Drawing.Color.MistyRose;
            this.listBoxCars.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.listBoxCars.FormattingEnabled = true;
            this.listBoxCars.ItemHeight = 20;
            this.listBoxCars.Location = new System.Drawing.Point(12, 47);
            this.listBoxCars.Name = "listBoxCars";
            this.listBoxCars.Size = new System.Drawing.Size(258, 304);
            this.listBoxCars.TabIndex = 0;
            this.listBoxCars.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.butClear);
            this.groupBox1.Controls.Add(this.butAdd);
            this.groupBox1.Controls.Add(this.tbColor);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbSNB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbNumber);
            this.groupBox1.Controls.Add(this.tbModel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbMarka);
            this.groupBox1.Location = new System.Drawing.Point(437, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 334);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Новая машина";
            // 
            // butClear
            // 
            this.butClear.BackColor = System.Drawing.Color.MistyRose;
            this.butClear.Location = new System.Drawing.Point(107, 276);
            this.butClear.Name = "butClear";
            this.butClear.Size = new System.Drawing.Size(98, 40);
            this.butClear.TabIndex = 11;
            this.butClear.Text = "Очистить";
            this.butClear.UseVisualStyleBackColor = false;
            // 
            // butAdd
            // 
            this.butAdd.BackColor = System.Drawing.Color.MistyRose;
            this.butAdd.Location = new System.Drawing.Point(219, 276);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(98, 40);
            this.butAdd.TabIndex = 10;
            this.butAdd.Text = "Добавить";
            this.butAdd.UseVisualStyleBackColor = false;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // tbColor
            // 
            this.tbColor.BackColor = System.Drawing.Color.MistyRose;
            this.tbColor.Location = new System.Drawing.Point(107, 223);
            this.tbColor.Name = "tbColor";
            this.tbColor.Size = new System.Drawing.Size(210, 26);
            this.tbColor.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Цвет";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 40);
            this.label4.TabIndex = 7;
            this.label4.Text = "ФИО \r\nвладельца";
            // 
            // tbSNB
            // 
            this.tbSNB.BackColor = System.Drawing.Color.MistyRose;
            this.tbSNB.Location = new System.Drawing.Point(107, 162);
            this.tbSNB.Name = "tbSNB";
            this.tbSNB.Size = new System.Drawing.Size(210, 26);
            this.tbSNB.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Номер";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Модель";
            // 
            // tbNumber
            // 
            this.tbNumber.BackColor = System.Drawing.Color.MistyRose;
            this.tbNumber.Location = new System.Drawing.Point(107, 119);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(210, 26);
            this.tbNumber.TabIndex = 3;
            // 
            // tbModel
            // 
            this.tbModel.BackColor = System.Drawing.Color.MistyRose;
            this.tbModel.Location = new System.Drawing.Point(107, 77);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(210, 26);
            this.tbModel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Марка";
            // 
            // tbMarka
            // 
            this.tbMarka.BackColor = System.Drawing.Color.MistyRose;
            this.tbMarka.Location = new System.Drawing.Point(107, 35);
            this.tbMarka.Name = "tbMarka";
            this.tbMarka.Size = new System.Drawing.Size(210, 26);
            this.tbMarka.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Номера машин:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MistyRose;
            this.button1.Location = new System.Drawing.Point(286, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btEdit
            // 
            this.btEdit.BackColor = System.Drawing.Color.MistyRose;
            this.btEdit.Location = new System.Drawing.Point(286, 92);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(137, 39);
            this.btEdit.TabIndex = 4;
            this.btEdit.Text = "Редактировать";
            this.btEdit.UseVisualStyleBackColor = false;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MistyRose;
            this.button3.Location = new System.Drawing.Point(286, 137);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 39);
            this.button3.TabIndex = 5;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // frmCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(800, 362);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBoxCars);
            this.Name = "frmCars";
            this.Text = "Машины";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCars;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button butClear;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.TextBox tbColor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSNB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMarka;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button button3;
    }
}

