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
            this.oneQuestionScreenPanel = new System.Windows.Forms.Panel();
            this.questionTextBox = new TestiriumWF.CustomQuestionTextBox();
            this.answersTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddAnswer = new System.Windows.Forms.Button();
            this.lblQuestionAnswerVariants = new System.Windows.Forms.Label();
            this.lblQuestionTitle = new System.Windows.Forms.Label();
            this.lblOneQuestionPanelTitle = new System.Windows.Forms.Label();
            this.btnAddPhotoVideo = new System.Windows.Forms.LinkLabel();
            this.oneQuestionScreenPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // oneQuestionScreenPanel
            // 
            this.oneQuestionScreenPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.oneQuestionScreenPanel.Controls.Add(this.btnAddPhotoVideo);
            this.oneQuestionScreenPanel.Controls.Add(this.questionTextBox);
            this.oneQuestionScreenPanel.Controls.Add(this.answersTableLayoutPanel);
            this.oneQuestionScreenPanel.Controls.Add(this.btnAddAnswer);
            this.oneQuestionScreenPanel.Controls.Add(this.lblQuestionAnswerVariants);
            this.oneQuestionScreenPanel.Controls.Add(this.lblQuestionTitle);
            this.oneQuestionScreenPanel.Controls.Add(this.lblOneQuestionPanelTitle);
            this.oneQuestionScreenPanel.Location = new System.Drawing.Point(0, 0);
            this.oneQuestionScreenPanel.Name = "oneQuestionScreenPanel";
            this.oneQuestionScreenPanel.Size = new System.Drawing.Size(784, 496);
            this.oneQuestionScreenPanel.TabIndex = 5;
            // 
            // questionTextBox
            // 
            this.questionTextBox.Location = new System.Drawing.Point(32, 112);
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.Size = new System.Drawing.Size(720, 64);
            this.questionTextBox.TabIndex = 10;
            // 
            // answersTableLayoutPanel
            // 
            this.answersTableLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.answersTableLayoutPanel.ColumnCount = 3;
            this.answersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.answersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.answersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 736F));
            this.answersTableLayoutPanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.answersTableLayoutPanel.Location = new System.Drawing.Point(32, 208);
            this.answersTableLayoutPanel.Name = "answersTableLayoutPanel";
            this.answersTableLayoutPanel.RowCount = 3;
            this.answersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.answersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.answersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.answersTableLayoutPanel.Size = new System.Drawing.Size(720, 216);
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
            this.btnAddAnswer.Size = new System.Drawing.Size(720, 32);
            this.btnAddAnswer.TabIndex = 8;
            this.btnAddAnswer.Text = "Добавить вариант ответа";
            this.btnAddAnswer.UseVisualStyleBackColor = false;
            this.btnAddAnswer.Click += new System.EventHandler(this.btnAddAnswer_Click);
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
            // lblOneQuestionPanelTitle
            // 
            this.lblOneQuestionPanelTitle.AutoSize = true;
            this.lblOneQuestionPanelTitle.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOneQuestionPanelTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblOneQuestionPanelTitle.Location = new System.Drawing.Point(32, 40);
            this.lblOneQuestionPanelTitle.Name = "lblOneQuestionPanelTitle";
            this.lblOneQuestionPanelTitle.Size = new System.Drawing.Size(213, 25);
            this.lblOneQuestionPanelTitle.TabIndex = 0;
            this.lblOneQuestionPanelTitle.Text = "Вопрос с одним ответом";
            // 
            // btnAddPhotoVideo
            // 
            this.btnAddPhotoVideo.ActiveLinkColor = System.Drawing.Color.White;
            this.btnAddPhotoVideo.AutoSize = true;
            this.btnAddPhotoVideo.Font = new System.Drawing.Font("Bahnschrift Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddPhotoVideo.LinkColor = System.Drawing.Color.White;
            this.btnAddPhotoVideo.Location = new System.Drawing.Point(576, 176);
            this.btnAddPhotoVideo.Name = "btnAddPhotoVideo";
            this.btnAddPhotoVideo.Size = new System.Drawing.Size(176, 14);
            this.btnAddPhotoVideo.TabIndex = 11;
            this.btnAddPhotoVideo.TabStop = true;
            this.btnAddPhotoVideo.Text = "Добавить картинку или видео";
            this.btnAddPhotoVideo.VisitedLinkColor = System.Drawing.Color.White;
            this.btnAddPhotoVideo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnAddPhotoVideo_LinkClicked);
            // 
            // OneQuestionPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.oneQuestionScreenPanel);
            this.Name = "OneQuestionPanel";
            this.Size = new System.Drawing.Size(784, 496);
            this.Load += new System.EventHandler(this.OneQuestionPanel_Load);
            this.oneQuestionScreenPanel.ResumeLayout(false);
            this.oneQuestionScreenPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel oneQuestionScreenPanel;
        private System.Windows.Forms.Label lblQuestionAnswerVariants;
        private System.Windows.Forms.Label lblQuestionTitle;
        private System.Windows.Forms.Label lblOneQuestionPanelTitle;
        private System.Windows.Forms.Button btnAddAnswer;
        private CustomQuestionTextBox questionTextBox;
        private System.Windows.Forms.TableLayoutPanel answersTableLayoutPanel;
        private System.Windows.Forms.LinkLabel btnAddPhotoVideo;
    }
}
