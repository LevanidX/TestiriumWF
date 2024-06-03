namespace TestiriumWF.CustomPanels.DeserializedQuestionPanels
{
    partial class TestMatchQuestionPanel
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
            this.label1 = new System.Windows.Forms.Label();
            this.definitionsAndAlignmentsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.oneQuestionScreenPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // oneQuestionScreenPanel
            // 
            this.oneQuestionScreenPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.oneQuestionScreenPanel.Controls.Add(this.label1);
            this.oneQuestionScreenPanel.Controls.Add(this.definitionsAndAlignmentsTableLayoutPanel);
            this.oneQuestionScreenPanel.Controls.Add(this.label2);
            this.oneQuestionScreenPanel.Controls.Add(this.lblTestTitle);
            this.oneQuestionScreenPanel.Location = new System.Drawing.Point(0, 0);
            this.oneQuestionScreenPanel.Name = "oneQuestionScreenPanel";
            this.oneQuestionScreenPanel.Size = new System.Drawing.Size(784, 496);
            this.oneQuestionScreenPanel.TabIndex = 9;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(384, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Варианты соответствий";
            // 
            // definitionsAndAlignmentsTableLayoutPanel
            // 
            this.definitionsAndAlignmentsTableLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.definitionsAndAlignmentsTableLayoutPanel.ColumnCount = 7;
            this.definitionsAndAlignmentsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.definitionsAndAlignmentsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.definitionsAndAlignmentsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.definitionsAndAlignmentsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.definitionsAndAlignmentsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.definitionsAndAlignmentsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.definitionsAndAlignmentsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.definitionsAndAlignmentsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.definitionsAndAlignmentsTableLayoutPanel.Location = new System.Drawing.Point(32, 152);
            this.definitionsAndAlignmentsTableLayoutPanel.Name = "definitionsAndAlignmentsTableLayoutPanel";
            this.definitionsAndAlignmentsTableLayoutPanel.RowCount = 4;
            this.definitionsAndAlignmentsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.definitionsAndAlignmentsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.definitionsAndAlignmentsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.definitionsAndAlignmentsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.definitionsAndAlignmentsTableLayoutPanel.Size = new System.Drawing.Size(720, 312);
            this.definitionsAndAlignmentsTableLayoutPanel.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(32, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Варианты определений";
            // 
            // TestMatchQuestionPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.oneQuestionScreenPanel);
            this.Name = "TestMatchQuestionPanel";
            this.Size = new System.Drawing.Size(784, 496);
            this.oneQuestionScreenPanel.ResumeLayout(false);
            this.oneQuestionScreenPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel oneQuestionScreenPanel;
        private System.Windows.Forms.Label lblTestTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel definitionsAndAlignmentsTableLayoutPanel;
        private System.Windows.Forms.Label label2;
    }
}
