namespace TestiriumWF
{
    partial class MainMenu
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
            this.btnCreateTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateTest
            // 
            this.btnCreateTest.Location = new System.Drawing.Point(12, 12);
            this.btnCreateTest.Name = "btnCreateTest";
            this.btnCreateTest.Size = new System.Drawing.Size(205, 54);
            this.btnCreateTest.TabIndex = 0;
            this.btnCreateTest.Text = "Создать тестирование";
            this.btnCreateTest.UseVisualStyleBackColor = true;
            this.btnCreateTest.Click += new System.EventHandler(this.btnCreateTest_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 450);
            this.Controls.Add(this.btnCreateTest);
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateTest;
    }
}

