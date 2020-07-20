namespace WindowsFormsAppGuess
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
            this.lblMessage = new System.Windows.Forms.Label();
            this.textBoxEnter = new System.Windows.Forms.TextBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(9, 48);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(66, 17);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "Погнали!";
            // 
            // textBoxEnter
            // 
            this.textBoxEnter.Location = new System.Drawing.Point(12, 78);
            this.textBoxEnter.Name = "textBoxEnter";
            this.textBoxEnter.Size = new System.Drawing.Size(100, 22);
            this.textBoxEnter.TabIndex = 1;
            this.textBoxEnter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxEnter_KeyDown);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(12, 12);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "Играть";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 124);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.textBoxEnter);
            this.Controls.Add(this.lblMessage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox textBoxEnter;
        private System.Windows.Forms.Button btnPlay;
    }
}

