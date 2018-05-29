namespace app1
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
            this.lstproduct = new System.Windows.Forms.ListBox();
            this.btnDoIt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstproduct
            // 
            this.lstproduct.FormattingEnabled = true;
            this.lstproduct.Location = new System.Drawing.Point(26, 27);
            this.lstproduct.Name = "lstproduct";
            this.lstproduct.Size = new System.Drawing.Size(298, 212);
            this.lstproduct.TabIndex = 0;
            // 
            // btnDoIt
            // 
            this.btnDoIt.Location = new System.Drawing.Point(66, 251);
            this.btnDoIt.Name = "btnDoIt";
            this.btnDoIt.Size = new System.Drawing.Size(220, 52);
            this.btnDoIt.TabIndex = 1;
            this.btnDoIt.Text = "Напиток";
            this.btnDoIt.UseVisualStyleBackColor = true;
            this.btnDoIt.Click += new System.EventHandler(this.btnDoIt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 322);
            this.Controls.Add(this.btnDoIt);
            this.Controls.Add(this.lstproduct);
            this.Name = "Form1";
            this.Text = "Бар";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstproduct;
        private System.Windows.Forms.Button btnDoIt;
    }
}

