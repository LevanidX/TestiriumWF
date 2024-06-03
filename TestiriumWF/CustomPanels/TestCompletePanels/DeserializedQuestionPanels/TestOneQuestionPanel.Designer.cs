namespace TestiriumWF.CustomPanels.DeserializedQuestionPanels
{
    partial class TestOneQuestionPanel
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.oneQuestionScreenPanel = new System.Windows.Forms.Panel();
            this.lblTestTitle = new System.Windows.Forms.Label();
            this.answersTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lblQuestionAnswerVariants = new System.Windows.Forms.Label();
            this.oneQuestionScreenPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // oneQuestionScreenPanel
            // 
            this.oneQuestionScreenPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.oneQuestionScreenPanel.Controls.Add(this.lblTestTitle);
            this.oneQuestionScreenPanel.Controls.Add(this.answersTableLayoutPanel);
            this.oneQuestionScreenPanel.Controls.Add(this.lblQuestionAnswerVariants);
            this.oneQuestionScreenPanel.Location = new System.Drawing.Point(0, 0);
            this.oneQuestionScreenPanel.Name = "oneQuestionScreenPanel";
            this.oneQuestionScreenPanel.Size = new System.Drawing.Size(784, 496);
            this.oneQuestionScreenPanel.TabIndex = 6;
            // 
            // lblTestTitle
            // 
            this.lblTestTitle.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTestTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTestTitle.Location = new System.Drawing.Point(32, 32);
            this.lblTestTitle.MaximumSize = new System.Drawing.Size(450, 80);
            this.lblTestTitle.MinimumSize = new System.Drawing.Size(450, 25);
            this.lblTestTitle.Name = "lblTestTitle";
            this.lblTestTitle.Size = new System.Drawing.Size(450, 80);
            this.lblTestTitle.TabIndex = 11;
            this.lblTestTitle.Text = "Текст вопроса";
            this.lblTestTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // answersTableLayoutPanel
            // 
            this.answersTableLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.answersTableLayoutPanel.ColumnCount = 2;
            this.answersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.answersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.answersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 736F));
            this.answersTableLayoutPanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.answersTableLayoutPanel.Location = new System.Drawing.Point(32, 144);
            this.answersTableLayoutPanel.Name = "answersTableLayoutPanel";
            this.answersTableLayoutPanel.RowCount = 3;
            this.answersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.answersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.answersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.answersTableLayoutPanel.Size = new System.Drawing.Size(720, 320);
            this.answersTableLayoutPanel.TabIndex = 9;
            // 
            // lblQuestionAnswerVariants
            // 
            this.lblQuestionAnswerVariants.AutoSize = true;
            this.lblQuestionAnswerVariants.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblQuestionAnswerVariants.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblQuestionAnswerVariants.Location = new System.Drawing.Point(32, 128);
            this.lblQuestionAnswerVariants.Name = "lblQuestionAnswerVariants";
            this.lblQuestionAnswerVariants.Size = new System.Drawing.Size(161, 16);
            this.lblQuestionAnswerVariants.TabIndex = 3;
            this.lblQuestionAnswerVariants.Text = "Выберите вариант ответа";
            // 
            // TestOneQuestionPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.oneQuestionScreenPanel);
            this.Name = "TestOneQuestionPanel";
            this.Size = new System.Drawing.Size(784, 496);
            this.oneQuestionScreenPanel.ResumeLayout(false);
            this.oneQuestionScreenPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel oneQuestionScreenPanel;
        private System.Windows.Forms.TableLayoutPanel answersTableLayoutPanel;
        private System.Windows.Forms.Label lblQuestionAnswerVariants;
        private System.Windows.Forms.Label lblTestTitle;
    }
}
