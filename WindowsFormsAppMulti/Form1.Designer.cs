namespace WindowsFormsAppMulti
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
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnDouble = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblNumber = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblRandom = new System.Windows.Forms.Label();
            this.btnBackup = new System.Windows.Forms.Button();
            this.lblCountCommand = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(49, 29);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(87, 23);
            this.btnPlus.TabIndex = 0;
            this.btnPlus.Text = "+1";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnDouble
            // 
            this.btnDouble.Location = new System.Drawing.Point(49, 58);
            this.btnDouble.Name = "btnDouble";
            this.btnDouble.Size = new System.Drawing.Size(87, 23);
            this.btnDouble.TabIndex = 1;
            this.btnDouble.Text = "x2";
            this.btnDouble.UseVisualStyleBackColor = true;
            this.btnDouble.Click += new System.EventHandler(this.btnDouble_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(49, 87);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(87, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Сброс";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblNumber.Location = new System.Drawing.Point(0, 0);
            this.lblNumber.Margin = new System.Windows.Forms.Padding(0);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(16, 17);
            this.lblNumber.TabIndex = 3;
            this.lblNumber.Text = "0";
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(49, 0);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(87, 23);
            this.btnPlay.TabIndex = 5;
            this.btnPlay.Text = "Играть";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblRandom
            // 
            this.lblRandom.AutoSize = true;
            this.lblRandom.Location = new System.Drawing.Point(142, 3);
            this.lblRandom.Name = "lblRandom";
            this.lblRandom.Size = new System.Drawing.Size(124, 17);
            this.lblRandom.TabIndex = 7;
            this.lblRandom.Text = "Заданное число: ";
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(49, 116);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(87, 23);
            this.btnBackup.TabIndex = 8;
            this.btnBackup.Text = "Отменить команду";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // lblCountCommand
            // 
            this.lblCountCommand.AutoSize = true;
            this.lblCountCommand.Location = new System.Drawing.Point(142, 32);
            this.lblCountCommand.Name = "lblCountCommand";
            this.lblCountCommand.Size = new System.Drawing.Size(146, 17);
            this.lblCountCommand.TabIndex = 9;
            this.lblCountCommand.Text = "Количество команд: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 180);
            this.Controls.Add(this.lblCountCommand);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.lblRandom);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDouble);
            this.Controls.Add(this.btnPlus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnDouble;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblRandom;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Label lblCountCommand;
    }
}

