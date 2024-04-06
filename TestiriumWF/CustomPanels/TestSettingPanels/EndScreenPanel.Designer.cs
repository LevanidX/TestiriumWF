namespace TestiriumWF.CustomPanels
{
    partial class EndScreenPanel
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
            this.EndPanel = new System.Windows.Forms.Panel();
            this.btnEndTestCreation = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.nonMarkPercentageTextBox = new TestiriumWF.CustomControls.CustomPercentageTextBox();
            this.nonMarkRadioButton = new System.Windows.Forms.RadioButton();
            this.lblTestTitle = new System.Windows.Forms.Label();
            this.markRadioButton = new System.Windows.Forms.RadioButton();
            this.markPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.excellentMarkPercentageTextBox = new TestiriumWF.CustomControls.CustomPercentageTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.normalMarkPercentageTextBox = new TestiriumWF.CustomControls.CustomPercentageTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.satisfactoryMarkPercentageTextBox = new TestiriumWF.CustomControls.CustomPercentageTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.badMarkPercentageTextBox = new TestiriumWF.CustomControls.CustomPercentageTextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.timeLimitedRadioButton = new System.Windows.Forms.RadioButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.minuteTextBox = new TestiriumWF.CustomControls.CustomMinuteTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.noTimeLimitedRadioButton = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.passwordTextBox = new TestiriumWF.CustomControls.CustomPasswordTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.passwordRadioButton = new System.Windows.Forms.RadioButton();
            this.noPasswordRadioButton = new System.Windows.Forms.RadioButton();
            this.lblWelcomeScreenTitle = new System.Windows.Forms.Label();
            this.EndPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel2.SuspendLayout();
            this.markPanel.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // EndPanel
            // 
            this.EndPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.EndPanel.Controls.Add(this.btnEndTestCreation);
            this.EndPanel.Controls.Add(this.label7);
            this.EndPanel.Controls.Add(this.panel4);
            this.EndPanel.Controls.Add(this.lblWelcomeScreenTitle);
            this.EndPanel.Location = new System.Drawing.Point(0, 0);
            this.EndPanel.Name = "EndPanel";
            this.EndPanel.Size = new System.Drawing.Size(784, 496);
            this.EndPanel.TabIndex = 6;
            // 
            // btnEndTestCreation
            // 
            this.btnEndTestCreation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(203)))), ((int)(((byte)(129)))));
            this.btnEndTestCreation.FlatAppearance.BorderSize = 0;
            this.btnEndTestCreation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEndTestCreation.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEndTestCreation.ForeColor = System.Drawing.Color.White;
            this.btnEndTestCreation.Location = new System.Drawing.Point(32, 400);
            this.btnEndTestCreation.Name = "btnEndTestCreation";
            this.btnEndTestCreation.Size = new System.Drawing.Size(720, 56);
            this.btnEndTestCreation.TabIndex = 14;
            this.btnEndTestCreation.Text = "Завершить создание тестирования";
            this.btnEndTestCreation.UseVisualStyleBackColor = false;
            this.btnEndTestCreation.Click += new System.EventHandler(this.btnEndTestCreation_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(32, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Настройки тестирования";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Location = new System.Drawing.Point(32, 120);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(720, 272);
            this.panel4.TabIndex = 12;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.panel8.Controls.Add(this.panel2);
            this.panel8.Controls.Add(this.nonMarkRadioButton);
            this.panel8.Controls.Add(this.lblTestTitle);
            this.panel8.Controls.Add(this.markRadioButton);
            this.panel8.Controls.Add(this.markPanel);
            this.panel8.Location = new System.Drawing.Point(0, 8);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(288, 256);
            this.panel8.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.nonMarkPercentageTextBox);
            this.panel2.Location = new System.Drawing.Point(0, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 40);
            this.panel2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(0, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Пороговый процент для зачёта";
            // 
            // nonMarkPercentageTextBox
            // 
            this.nonMarkPercentageTextBox.Location = new System.Drawing.Point(232, 8);
            this.nonMarkPercentageTextBox.Name = "nonMarkPercentageTextBox";
            this.nonMarkPercentageTextBox.Size = new System.Drawing.Size(40, 23);
            this.nonMarkPercentageTextBox.TabIndex = 0;
            // 
            // nonMarkRadioButton
            // 
            this.nonMarkRadioButton.AutoSize = true;
            this.nonMarkRadioButton.Checked = true;
            this.nonMarkRadioButton.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nonMarkRadioButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nonMarkRadioButton.Location = new System.Drawing.Point(0, 24);
            this.nonMarkRadioButton.Name = "nonMarkRadioButton";
            this.nonMarkRadioButton.Size = new System.Drawing.Size(60, 20);
            this.nonMarkRadioButton.TabIndex = 7;
            this.nonMarkRadioButton.TabStop = true;
            this.nonMarkRadioButton.Text = "Зачёт";
            this.nonMarkRadioButton.UseVisualStyleBackColor = true;
            // 
            // lblTestTitle
            // 
            this.lblTestTitle.AutoSize = true;
            this.lblTestTitle.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTestTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTestTitle.Location = new System.Drawing.Point(0, 8);
            this.lblTestTitle.Name = "lblTestTitle";
            this.lblTestTitle.Size = new System.Drawing.Size(179, 16);
            this.lblTestTitle.TabIndex = 1;
            this.lblTestTitle.Text = "Выберите метод оценивания";
            // 
            // markRadioButton
            // 
            this.markRadioButton.AutoSize = true;
            this.markRadioButton.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.markRadioButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.markRadioButton.Location = new System.Drawing.Point(0, 88);
            this.markRadioButton.Name = "markRadioButton";
            this.markRadioButton.Size = new System.Drawing.Size(69, 20);
            this.markRadioButton.TabIndex = 8;
            this.markRadioButton.Text = "Оценка";
            this.markRadioButton.UseVisualStyleBackColor = true;
            // 
            // markPanel
            // 
            this.markPanel.Controls.Add(this.label5);
            this.markPanel.Controls.Add(this.excellentMarkPercentageTextBox);
            this.markPanel.Controls.Add(this.label4);
            this.markPanel.Controls.Add(this.normalMarkPercentageTextBox);
            this.markPanel.Controls.Add(this.label3);
            this.markPanel.Controls.Add(this.satisfactoryMarkPercentageTextBox);
            this.markPanel.Controls.Add(this.label2);
            this.markPanel.Controls.Add(this.badMarkPercentageTextBox);
            this.markPanel.Location = new System.Drawing.Point(0, 112);
            this.markPanel.Name = "markPanel";
            this.markPanel.Size = new System.Drawing.Size(280, 136);
            this.markPanel.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(0, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Пороговый процент для оценки \"5\"";
            // 
            // excellentMarkPercentageTextBox
            // 
            this.excellentMarkPercentageTextBox.Location = new System.Drawing.Point(232, 104);
            this.excellentMarkPercentageTextBox.Name = "excellentMarkPercentageTextBox";
            this.excellentMarkPercentageTextBox.Size = new System.Drawing.Size(40, 23);
            this.excellentMarkPercentageTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(0, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Пороговый процент для оценки \"4\"";
            // 
            // normalMarkPercentageTextBox
            // 
            this.normalMarkPercentageTextBox.Location = new System.Drawing.Point(232, 72);
            this.normalMarkPercentageTextBox.Name = "normalMarkPercentageTextBox";
            this.normalMarkPercentageTextBox.Size = new System.Drawing.Size(40, 23);
            this.normalMarkPercentageTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(0, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Пороговый процент для оценки \"3\"";
            // 
            // satisfactoryMarkPercentageTextBox
            // 
            this.satisfactoryMarkPercentageTextBox.Location = new System.Drawing.Point(232, 40);
            this.satisfactoryMarkPercentageTextBox.Name = "satisfactoryMarkPercentageTextBox";
            this.satisfactoryMarkPercentageTextBox.Size = new System.Drawing.Size(40, 23);
            this.satisfactoryMarkPercentageTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(0, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пороговый процент для оценки \"2\"";
            // 
            // badMarkPercentageTextBox
            // 
            this.badMarkPercentageTextBox.Location = new System.Drawing.Point(232, 8);
            this.badMarkPercentageTextBox.Name = "badMarkPercentageTextBox";
            this.badMarkPercentageTextBox.Size = new System.Drawing.Size(40, 23);
            this.badMarkPercentageTextBox.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.timeLimitedRadioButton);
            this.panel7.Controls.Add(this.panel5);
            this.panel7.Controls.Add(this.noTimeLimitedRadioButton);
            this.panel7.Location = new System.Drawing.Point(296, 8);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(424, 120);
            this.panel7.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(8, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Ограничение по времени";
            // 
            // timeLimitedRadioButton
            // 
            this.timeLimitedRadioButton.AutoSize = true;
            this.timeLimitedRadioButton.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeLimitedRadioButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.timeLimitedRadioButton.Location = new System.Drawing.Point(8, 24);
            this.timeLimitedRadioButton.Name = "timeLimitedRadioButton";
            this.timeLimitedRadioButton.Size = new System.Drawing.Size(41, 20);
            this.timeLimitedRadioButton.TabIndex = 12;
            this.timeLimitedRadioButton.Text = "Да";
            this.timeLimitedRadioButton.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.minuteTextBox);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(8, 72);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(424, 40);
            this.panel5.TabIndex = 14;
            // 
            // minuteTextBox
            // 
            this.minuteTextBox.Location = new System.Drawing.Point(264, 8);
            this.minuteTextBox.Name = "minuteTextBox";
            this.minuteTextBox.Size = new System.Drawing.Size(56, 23);
            this.minuteTextBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(0, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(260, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Выберите время тестирования (в минутах)";
            // 
            // noTimeLimitedRadioButton
            // 
            this.noTimeLimitedRadioButton.AutoSize = true;
            this.noTimeLimitedRadioButton.Checked = true;
            this.noTimeLimitedRadioButton.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.noTimeLimitedRadioButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.noTimeLimitedRadioButton.Location = new System.Drawing.Point(8, 48);
            this.noTimeLimitedRadioButton.Name = "noTimeLimitedRadioButton";
            this.noTimeLimitedRadioButton.Size = new System.Drawing.Size(47, 20);
            this.noTimeLimitedRadioButton.TabIndex = 13;
            this.noTimeLimitedRadioButton.TabStop = true;
            this.noTimeLimitedRadioButton.Text = "Нет";
            this.noTimeLimitedRadioButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.passwordRadioButton);
            this.panel1.Controls.Add(this.noPasswordRadioButton);
            this.panel1.Location = new System.Drawing.Point(296, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 128);
            this.panel1.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(8, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Вход по паролю";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.passwordTextBox);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Location = new System.Drawing.Point(8, 72);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(408, 48);
            this.panel6.TabIndex = 15;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(0, 24);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(360, 23);
            this.passwordTextBox.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "Введите пароль";
            // 
            // passwordRadioButton
            // 
            this.passwordRadioButton.AutoSize = true;
            this.passwordRadioButton.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordRadioButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.passwordRadioButton.Location = new System.Drawing.Point(8, 24);
            this.passwordRadioButton.Name = "passwordRadioButton";
            this.passwordRadioButton.Size = new System.Drawing.Size(41, 20);
            this.passwordRadioButton.TabIndex = 16;
            this.passwordRadioButton.Text = "Да";
            this.passwordRadioButton.UseVisualStyleBackColor = true;
            // 
            // noPasswordRadioButton
            // 
            this.noPasswordRadioButton.AutoSize = true;
            this.noPasswordRadioButton.Checked = true;
            this.noPasswordRadioButton.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.noPasswordRadioButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.noPasswordRadioButton.Location = new System.Drawing.Point(8, 48);
            this.noPasswordRadioButton.Name = "noPasswordRadioButton";
            this.noPasswordRadioButton.Size = new System.Drawing.Size(47, 20);
            this.noPasswordRadioButton.TabIndex = 17;
            this.noPasswordRadioButton.TabStop = true;
            this.noPasswordRadioButton.Text = "Нет";
            this.noPasswordRadioButton.UseVisualStyleBackColor = true;
            // 
            // lblWelcomeScreenTitle
            // 
            this.lblWelcomeScreenTitle.AutoSize = true;
            this.lblWelcomeScreenTitle.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWelcomeScreenTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblWelcomeScreenTitle.Location = new System.Drawing.Point(32, 40);
            this.lblWelcomeScreenTitle.Name = "lblWelcomeScreenTitle";
            this.lblWelcomeScreenTitle.Size = new System.Drawing.Size(195, 25);
            this.lblWelcomeScreenTitle.TabIndex = 0;
            this.lblWelcomeScreenTitle.Text = "Экран с результатами";
            // 
            // EndScreenPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EndPanel);
            this.Name = "EndScreenPanel";
            this.Size = new System.Drawing.Size(784, 496);
            this.EndPanel.ResumeLayout(false);
            this.EndPanel.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.markPanel.ResumeLayout(false);
            this.markPanel.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel EndPanel;
        private System.Windows.Forms.Label lblTestTitle;
        private System.Windows.Forms.Label lblWelcomeScreenTitle;
        private System.Windows.Forms.RadioButton markRadioButton;
        private System.Windows.Forms.RadioButton nonMarkRadioButton;
        private System.Windows.Forms.Panel panel2;
        private CustomControls.CustomPercentageTextBox nonMarkPercentageTextBox;
        private System.Windows.Forms.Panel markPanel;
        private System.Windows.Forms.Label label2;
        private CustomControls.CustomPercentageTextBox badMarkPercentageTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private CustomControls.CustomPercentageTextBox excellentMarkPercentageTextBox;
        private System.Windows.Forms.Label label4;
        private CustomControls.CustomPercentageTextBox normalMarkPercentageTextBox;
        private System.Windows.Forms.Label label3;
        private CustomControls.CustomPercentageTextBox satisfactoryMarkPercentageTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton noTimeLimitedRadioButton;
        private System.Windows.Forms.RadioButton timeLimitedRadioButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.RadioButton noPasswordRadioButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton passwordRadioButton;
        private System.Windows.Forms.Panel panel5;
        private CustomControls.CustomPasswordTextBox passwordTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private CustomControls.CustomMinuteTextBox minuteTextBox;
        private System.Windows.Forms.Button btnEndTestCreation;
        private System.Windows.Forms.Label label10;
    }
}
