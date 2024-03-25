namespace TestiriumWF
{
    partial class OneQuestionPanel
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
            this.welcomeScreenPanel = new System.Windows.Forms.Panel();
            this.customQuestionTextBox1 = new TestiriumWF.CustomQuestionTextBox();
            this.answersTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddAnswer = new System.Windows.Forms.Button();
            this.btnAddPhotoVideo = new System.Windows.Forms.LinkLabel();
            this.lblQuestionAnswerVariants = new System.Windows.Forms.Label();
            this.lblQuestionTitle = new System.Windows.Forms.Label();
            this.lblWelcomeScreenTitle = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.customAnswerTextBox1 = new TestiriumWF.CustomAnswerTextBox();
            this.customAnswerTextBox2 = new TestiriumWF.CustomAnswerTextBox();
            this.welcomeScreenPanel.SuspendLayout();
            this.answersTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcomeScreenPanel
            // 
            this.welcomeScreenPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.welcomeScreenPanel.Controls.Add(this.customQuestionTextBox1);
            this.welcomeScreenPanel.Controls.Add(this.answersTableLayoutPanel);
            this.welcomeScreenPanel.Controls.Add(this.btnAddAnswer);
            this.welcomeScreenPanel.Controls.Add(this.btnAddPhotoVideo);
            this.welcomeScreenPanel.Controls.Add(this.lblQuestionAnswerVariants);
            this.welcomeScreenPanel.Controls.Add(this.lblQuestionTitle);
            this.welcomeScreenPanel.Controls.Add(this.lblWelcomeScreenTitle);
            this.welcomeScreenPanel.Location = new System.Drawing.Point(0, 0);
            this.welcomeScreenPanel.Name = "welcomeScreenPanel";
            this.welcomeScreenPanel.Size = new System.Drawing.Size(800, 520);
            this.welcomeScreenPanel.TabIndex = 5;
            // 
            // customQuestionTextBox1
            // 
            this.customQuestionTextBox1.Location = new System.Drawing.Point(32, 112);
            this.customQuestionTextBox1.Name = "customQuestionTextBox1";
            this.customQuestionTextBox1.Size = new System.Drawing.Size(736, 64);
            this.customQuestionTextBox1.TabIndex = 10;
            // 
            // answersTableLayoutPanel
            // 
            this.answersTableLayoutPanel.AutoScroll = true;
            this.answersTableLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.answersTableLayoutPanel.ColumnCount = 2;
            this.answersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.answersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.answersTableLayoutPanel.Controls.Add(this.radioButton1, 0, 0);
            this.answersTableLayoutPanel.Controls.Add(this.radioButton2, 0, 1);
            this.answersTableLayoutPanel.Controls.Add(this.customAnswerTextBox1, 1, 0);
            this.answersTableLayoutPanel.Controls.Add(this.customAnswerTextBox2, 1, 1);
            this.answersTableLayoutPanel.Location = new System.Drawing.Point(32, 208);
            this.answersTableLayoutPanel.Name = "answersTableLayoutPanel";
            this.answersTableLayoutPanel.RowCount = 3;
            this.answersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.answersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.answersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.answersTableLayoutPanel.Size = new System.Drawing.Size(736, 216);
            this.answersTableLayoutPanel.TabIndex = 9;
            // 
            // btnAddAnswer
            // 
            this.btnAddAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnAddAnswer.FlatAppearance.BorderSize = 0;
            this.btnAddAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAnswer.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddAnswer.ForeColor = System.Drawing.Color.White;
            this.btnAddAnswer.Location = new System.Drawing.Point(32, 432);
            this.btnAddAnswer.Name = "btnAddAnswer";
            this.btnAddAnswer.Size = new System.Drawing.Size(736, 50);
            this.btnAddAnswer.TabIndex = 8;
            this.btnAddAnswer.Text = "Добавить вариант ответа";
            this.btnAddAnswer.UseVisualStyleBackColor = false;
            this.btnAddAnswer.Click += new System.EventHandler(this.btnAddAnswer_Click);
            // 
            // btnAddPhotoVideo
            // 
            this.btnAddPhotoVideo.ActiveLinkColor = System.Drawing.Color.White;
            this.btnAddPhotoVideo.AutoSize = true;
            this.btnAddPhotoVideo.Font = new System.Drawing.Font("Bahnschrift Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddPhotoVideo.LinkColor = System.Drawing.Color.White;
            this.btnAddPhotoVideo.Location = new System.Drawing.Point(592, 176);
            this.btnAddPhotoVideo.Name = "btnAddPhotoVideo";
            this.btnAddPhotoVideo.Size = new System.Drawing.Size(176, 14);
            this.btnAddPhotoVideo.TabIndex = 6;
            this.btnAddPhotoVideo.TabStop = true;
            this.btnAddPhotoVideo.Text = "Добавить картинку или видео";
            this.btnAddPhotoVideo.VisitedLinkColor = System.Drawing.Color.White;
            // 
            // lblQuestionAnswerVariants
            // 
            this.lblQuestionAnswerVariants.AutoSize = true;
            this.lblQuestionAnswerVariants.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblQuestionAnswerVariants.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblQuestionAnswerVariants.Location = new System.Drawing.Point(32, 192);
            this.lblQuestionAnswerVariants.Name = "lblQuestionAnswerVariants";
            this.lblQuestionAnswerVariants.Size = new System.Drawing.Size(109, 16);
            this.lblQuestionAnswerVariants.TabIndex = 3;
            this.lblQuestionAnswerVariants.Text = "Варианты ответа";
            // 
            // lblQuestionTitle
            // 
            this.lblQuestionTitle.AutoSize = true;
            this.lblQuestionTitle.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblQuestionTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblQuestionTitle.Location = new System.Drawing.Point(32, 96);
            this.lblQuestionTitle.Name = "lblQuestionTitle";
            this.lblQuestionTitle.Size = new System.Drawing.Size(89, 16);
            this.lblQuestionTitle.TabIndex = 1;
            this.lblQuestionTitle.Text = "Текст вопроса";
            // 
            // lblWelcomeScreenTitle
            // 
            this.lblWelcomeScreenTitle.AutoSize = true;
            this.lblWelcomeScreenTitle.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWelcomeScreenTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblWelcomeScreenTitle.Location = new System.Drawing.Point(32, 40);
            this.lblWelcomeScreenTitle.Name = "lblWelcomeScreenTitle";
            this.lblWelcomeScreenTitle.Size = new System.Drawing.Size(213, 25);
            this.lblWelcomeScreenTitle.TabIndex = 0;
            this.lblWelcomeScreenTitle.Text = "Вопрос с одним ответом";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(3, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(14, 13);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(3, 32);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(14, 13);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // customAnswerTextBox1
            // 
            this.customAnswerTextBox1.Location = new System.Drawing.Point(23, 3);
            this.customAnswerTextBox1.Name = "customAnswerTextBox1";
            this.customAnswerTextBox1.Size = new System.Drawing.Size(688, 23);
            this.customAnswerTextBox1.TabIndex = 12;
            // 
            // customAnswerTextBox2
            // 
            this.customAnswerTextBox2.Location = new System.Drawing.Point(23, 32);
            this.customAnswerTextBox2.Name = "customAnswerTextBox2";
            this.customAnswerTextBox2.Size = new System.Drawing.Size(688, 23);
            this.customAnswerTextBox2.TabIndex = 13;
            // 
            // OneQuestionPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.welcomeScreenPanel);
            this.Name = "OneQuestionPanel";
            this.Size = new System.Drawing.Size(800, 520);
            this.Load += new System.EventHandler(this.OneQuestionPanel_Load);
            this.welcomeScreenPanel.ResumeLayout(false);
            this.welcomeScreenPanel.PerformLayout();
            this.answersTableLayoutPanel.ResumeLayout(false);
            this.answersTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel welcomeScreenPanel;
        private System.Windows.Forms.LinkLabel btnAddPhotoVideo;
        private System.Windows.Forms.Label lblQuestionAnswerVariants;
        private System.Windows.Forms.Label lblQuestionTitle;
        private System.Windows.Forms.Label lblWelcomeScreenTitle;
        private System.Windows.Forms.Button btnAddAnswer;
        private System.Windows.Forms.TableLayoutPanel answersTableLayoutPanel;
        private CustomQuestionTextBox customQuestionTextBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private CustomAnswerTextBox customAnswerTextBox1;
        private CustomAnswerTextBox customAnswerTextBox2;
    }
}
