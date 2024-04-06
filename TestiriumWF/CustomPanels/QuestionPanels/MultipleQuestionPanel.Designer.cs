namespace TestiriumWF
{
    partial class MultipleQuestionPanel
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
            this.multipleQuestionScreenPanel = new System.Windows.Forms.Panel();
            this.customQuestionTextBox = new TestiriumWF.CustomQuestionTextBox();
            this.answersTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddAnswer = new System.Windows.Forms.Button();
            this.btnAddPhotoVideo = new System.Windows.Forms.LinkLabel();
            this.lblQuestionAnswerVariants = new System.Windows.Forms.Label();
            this.lblQuestionTitle = new System.Windows.Forms.Label();
            this.lblMultipleQuestionTitle = new System.Windows.Forms.Label();
            this.multipleQuestionScreenPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // multipleQuestionScreenPanel
            // 
            this.multipleQuestionScreenPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.multipleQuestionScreenPanel.Controls.Add(this.customQuestionTextBox);
            this.multipleQuestionScreenPanel.Controls.Add(this.answersTableLayoutPanel);
            this.multipleQuestionScreenPanel.Controls.Add(this.btnAddAnswer);
            this.multipleQuestionScreenPanel.Controls.Add(this.btnAddPhotoVideo);
            this.multipleQuestionScreenPanel.Controls.Add(this.lblQuestionAnswerVariants);
            this.multipleQuestionScreenPanel.Controls.Add(this.lblQuestionTitle);
            this.multipleQuestionScreenPanel.Controls.Add(this.lblMultipleQuestionTitle);
            this.multipleQuestionScreenPanel.Location = new System.Drawing.Point(0, 0);
            this.multipleQuestionScreenPanel.Name = "multipleQuestionScreenPanel";
            this.multipleQuestionScreenPanel.Size = new System.Drawing.Size(784, 496);
            this.multipleQuestionScreenPanel.TabIndex = 6;
            // 
            // customQuestionTextBox
            // 
            this.customQuestionTextBox.Location = new System.Drawing.Point(32, 112);
            this.customQuestionTextBox.Name = "customQuestionTextBox";
            this.customQuestionTextBox.Size = new System.Drawing.Size(720, 64);
            this.customQuestionTextBox.TabIndex = 10;
            // 
            // answersTableLayoutPanel
            // 
            this.answersTableLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.answersTableLayoutPanel.ColumnCount = 3;
            this.answersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.answersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.answersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 736F));
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
            // btnAddPhotoVideo
            // 
            this.btnAddPhotoVideo.ActiveLinkColor = System.Drawing.Color.White;
            this.btnAddPhotoVideo.AutoSize = true;
            this.btnAddPhotoVideo.Font = new System.Drawing.Font("Bahnschrift Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddPhotoVideo.LinkColor = System.Drawing.Color.White;
            this.btnAddPhotoVideo.Location = new System.Drawing.Point(576, 176);
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
            // lblMultipleQuestionTitle
            // 
            this.lblMultipleQuestionTitle.AutoSize = true;
            this.lblMultipleQuestionTitle.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMultipleQuestionTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMultipleQuestionTitle.Location = new System.Drawing.Point(32, 40);
            this.lblMultipleQuestionTitle.Name = "lblMultipleQuestionTitle";
            this.lblMultipleQuestionTitle.Size = new System.Drawing.Size(280, 25);
            this.lblMultipleQuestionTitle.TabIndex = 0;
            this.lblMultipleQuestionTitle.Text = "Вопрос с несколькими ответами";
            // 
            // MultipleQuestionPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.multipleQuestionScreenPanel);
            this.Name = "MultipleQuestionPanel";
            this.Size = new System.Drawing.Size(784, 496);
            this.Load += new System.EventHandler(this.MultipleQuestionPanel_Load);
            this.multipleQuestionScreenPanel.ResumeLayout(false);
            this.multipleQuestionScreenPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel multipleQuestionScreenPanel;
        private CustomQuestionTextBox customQuestionTextBox;
        private System.Windows.Forms.TableLayoutPanel answersTableLayoutPanel;
        private System.Windows.Forms.Button btnAddAnswer;
        private System.Windows.Forms.LinkLabel btnAddPhotoVideo;
        private System.Windows.Forms.Label lblQuestionAnswerVariants;
        private System.Windows.Forms.Label lblQuestionTitle;
        private System.Windows.Forms.Label lblMultipleQuestionTitle;
    }
}
