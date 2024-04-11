namespace TestiriumWF.CustomPanels.DeserializedQuestionPanels
{
    partial class TestEndScreen
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
            this.endScreenPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFinalPercentage = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFinalMark = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.endScreenPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // endScreenPanel
            // 
            this.endScreenPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.endScreenPanel.Controls.Add(this.label2);
            this.endScreenPanel.Controls.Add(this.label3);
            this.endScreenPanel.Controls.Add(this.lblFinalPercentage);
            this.endScreenPanel.Controls.Add(this.label1);
            this.endScreenPanel.Controls.Add(this.lblFinalMark);
            this.endScreenPanel.Location = new System.Drawing.Point(0, 0);
            this.endScreenPanel.Name = "endScreenPanel";
            this.endScreenPanel.Size = new System.Drawing.Size(784, 496);
            this.endScreenPanel.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(48, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(688, 88);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ваш результат";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblFinalPercentage
            // 
            this.lblFinalPercentage.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFinalPercentage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFinalPercentage.Location = new System.Drawing.Point(48, 176);
            this.lblFinalPercentage.Name = "lblFinalPercentage";
            this.lblFinalPercentage.Size = new System.Drawing.Size(688, 112);
            this.lblFinalPercentage.TabIndex = 1;
            this.lblFinalPercentage.Text = "10";
            this.lblFinalPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(48, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(568, 112);
            this.label3.TabIndex = 2;
            this.label3.Text = "Оценка за работу -";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFinalMark
            // 
            this.lblFinalMark.BackColor = System.Drawing.Color.Transparent;
            this.lblFinalMark.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFinalMark.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFinalMark.Location = new System.Drawing.Point(536, 288);
            this.lblFinalMark.Name = "lblFinalMark";
            this.lblFinalMark.Size = new System.Drawing.Size(200, 112);
            this.lblFinalMark.TabIndex = 3;
            this.lblFinalMark.Text = "2";
            this.lblFinalMark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(424, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 112);
            this.label2.TabIndex = 4;
            this.label2.Text = "%";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TestEndScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.endScreenPanel);
            this.Name = "TestEndScreen";
            this.Size = new System.Drawing.Size(784, 496);
            this.endScreenPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel endScreenPanel;
        private System.Windows.Forms.Label lblFinalPercentage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFinalMark;
        private System.Windows.Forms.Label label2;
    }
}
