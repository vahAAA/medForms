namespace medForms
{
    partial class mainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.btnF083_0 = new System.Windows.Forms.Button();
            this.gbButton = new System.Windows.Forms.GroupBox();
            this.btnF026_0 = new System.Windows.Forms.Button();
            this.btnF003_0 = new System.Windows.Forms.Button();
            this.btnF025_8_0 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnShowDB = new System.Windows.Forms.Button();
            this.gbButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnF083_0
            // 
            this.btnF083_0.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnF083_0.Location = new System.Drawing.Point(22, 36);
            this.btnF083_0.Name = "btnF083_0";
            this.btnF083_0.Size = new System.Drawing.Size(145, 38);
            this.btnF083_0.TabIndex = 0;
            this.btnF083_0.Text = "Форма f083_0";
            this.btnF083_0.UseVisualStyleBackColor = true;
            this.btnF083_0.Click += new System.EventHandler(this.btnF083_0_Click);
            // 
            // gbButton
            // 
            this.gbButton.BackColor = System.Drawing.SystemColors.Control;
            this.gbButton.Controls.Add(this.btnF026_0);
            this.gbButton.Controls.Add(this.btnF003_0);
            this.gbButton.Controls.Add(this.btnF025_8_0);
            this.gbButton.Controls.Add(this.btnF083_0);
            this.gbButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbButton.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.gbButton.Location = new System.Drawing.Point(12, 12);
            this.gbButton.Name = "gbButton";
            this.gbButton.Size = new System.Drawing.Size(190, 225);
            this.gbButton.TabIndex = 5;
            this.gbButton.TabStop = false;
            this.gbButton.Text = "Создать новую форму:";
            // 
            // btnF026_0
            // 
            this.btnF026_0.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnF026_0.Location = new System.Drawing.Point(22, 168);
            this.btnF026_0.Name = "btnF026_0";
            this.btnF026_0.Size = new System.Drawing.Size(145, 38);
            this.btnF026_0.TabIndex = 3;
            this.btnF026_0.Text = "Форма f026_0";
            this.btnF026_0.UseVisualStyleBackColor = true;
            this.btnF026_0.Click += new System.EventHandler(this.btnF026_0_Click);
            // 
            // btnF003_0
            // 
            this.btnF003_0.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnF003_0.Location = new System.Drawing.Point(22, 124);
            this.btnF003_0.Name = "btnF003_0";
            this.btnF003_0.Size = new System.Drawing.Size(145, 38);
            this.btnF003_0.TabIndex = 2;
            this.btnF003_0.Text = "Форма f003_0";
            this.btnF003_0.UseVisualStyleBackColor = true;
            this.btnF003_0.Click += new System.EventHandler(this.btnF003_0_Click);
            // 
            // btnF025_8_0
            // 
            this.btnF025_8_0.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnF025_8_0.Location = new System.Drawing.Point(22, 80);
            this.btnF025_8_0.Name = "btnF025_8_0";
            this.btnF025_8_0.Size = new System.Drawing.Size(145, 38);
            this.btnF025_8_0.TabIndex = 1;
            this.btnF025_8_0.Text = "Форма f025_8_0";
            this.btnF025_8_0.UseVisualStyleBackColor = true;
            this.btnF025_8_0.Click += new System.EventHandler(this.btnF025_8_0_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(185, 243);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Control;
            this.btnExit.Location = new System.Drawing.Point(72, 287);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Выйти";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnShowDB
            // 
            this.btnShowDB.Location = new System.Drawing.Point(34, 243);
            this.btnShowDB.Name = "btnShowDB";
            this.btnShowDB.Size = new System.Drawing.Size(145, 38);
            this.btnShowDB.TabIndex = 6;
            this.btnShowDB.Text = "Просмотреть БД";
            this.btnShowDB.UseVisualStyleBackColor = true;
            this.btnShowDB.Click += new System.EventHandler(this.btnShowDB_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 316);
            this.Controls.Add(this.gbButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnShowDB);
            this.Name = "mainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.gbButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnF083_0;
        private System.Windows.Forms.GroupBox gbButton;
        private System.Windows.Forms.Button btnF026_0;
        private System.Windows.Forms.Button btnF003_0;
        private System.Windows.Forms.Button btnF025_8_0;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnShowDB;
    }
}

