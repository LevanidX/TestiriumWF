namespace TestiriumWF.CustomPanels
{
    partial class SequencingQuestionPanel
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
            this.sequencingQuestionScreenPanel = new System.Windows.Forms.Panel();
            this.customQuestionTextBox = new TestiriumWF.CustomQuestionTextBox();
            this.btnAddAnswer = new System.Windows.Forms.Button();
            this.btnAddPhotoVideo = new System.Windows.Forms.LinkLabel();
            this.lblQuestionAnswerVariants = new System.Windows.Forms.Label();
            this.lblQuestionTitle = new System.Windows.Forms.Label();
            this.lblSequencingQuestionTitle = new System.Windows.Forms.Label();
            this.answersTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.sequencingQuestionScreenPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sequencingQuestionScreenPanel
            // 
            this.sequencingQuestionScreenPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.sequencingQuestionScreenPanel.Controls.Add(this.answersTableLayoutPanel);
            this.sequencingQuestionScreenPanel.Controls.Add(this.customQuestionTextBox);
            this.sequencingQuestionScreenPanel.Controls.Add(this.btnAddAnswer);
            this.sequencingQuestionScreenPanel.Controls.Add(this.btnAddPhotoVideo);
            this.sequencingQuestionScreenPanel.Controls.Add(this.lblQuestionAnswerVariants);
            this.sequencingQuestionScreenPanel.Controls.Add(this.lblQuestionTitle);
            this.sequencingQuestionScreenPanel.Controls.Add(this.lblSequencingQuestionTitle);
            this.sequencingQuestionScreenPanel.Location = new System.Drawing.Point(0, 0);
            this.sequencingQuestionScreenPanel.Name = "sequencingQuestionScreenPanel";
            this.sequencingQuestionScreenPanel.Size = new System.Drawing.Size(800, 520);
            this.sequencingQuestionScreenPanel.TabIndex = 8;
            // 
            // customQuestionTextBox
            // 
            this.customQuestionTextBox.Location = new System.Drawing.Point(32, 112);
            this.customQuestionTextBox.Name = "customQuestionTextBox";
            this.customQuestionTextBox.Size = new System.Drawing.Size(736, 64);
            this.customQuestionTextBox.TabIndex = 10;
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
            this.btnAddAnswer.Size = new System.Drawing.Size(736, 56);
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
            this.lblQuestionAnswerVariants.Location = new System.Drawing.Point(32, 200);
            this.lblQuestionAnswerVariants.Name = "lblQuestionAnswerVariants";
            this.lblQuestionAnswerVariants.Size = new System.Drawing.Size(184, 16);
            this.lblQuestionAnswerVariants.TabIndex = 3;
            this.lblQuestionAnswerVariants.Text = "Вариант последовательности";
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
            // lblSequencingQuestionTitle
            // 
            this.lblSequencingQuestionTitle.AutoSize = true;
            this.lblSequencingQuestionTitle.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSequencingQuestionTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSequencingQuestionTitle.Location = new System.Drawing.Point(32, 40);
            this.lblSequencingQuestionTitle.Name = "lblSequencingQuestionTitle";
            this.lblSequencingQuestionTitle.Size = new System.Drawing.Size(273, 25);
            this.lblSequencingQuestionTitle.TabIndex = 0;
            this.lblSequencingQuestionTitle.Text = "Вопрос на последовательность";
            // 
            // answersTableLayoutPanel
            // 
            this.answersTableLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.answersTableLayoutPanel.ColumnCount = 5;
            this.answersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.answersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.answersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.answersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.answersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.answersTableLayoutPanel.Location = new System.Drawing.Point(32, 216);
            this.answersTableLayoutPanel.Name = "answersTableLayoutPanel";
            this.answersTableLayoutPanel.RowCount = 3;
            this.answersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.answersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.answersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.answersTableLayoutPanel.Size = new System.Drawing.Size(736, 208);
            this.answersTableLayoutPanel.TabIndex = 11;
            // 
            // SequencingQuestionPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sequencingQuestionScreenPanel);
            this.Name = "SequencingQuestionPanel";
            this.Size = new System.Drawing.Size(800, 520);
            this.Load += new System.EventHandler(this.SequencingQuestionPanel_Load);
            this.sequencingQuestionScreenPanel.ResumeLayout(false);
            this.sequencingQuestionScreenPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sequencingQuestionScreenPanel;
        private CustomQuestionTextBox customQuestionTextBox;
        private System.Windows.Forms.Button btnAddAnswer;
        private System.Windows.Forms.LinkLabel btnAddPhotoVideo;
        private System.Windows.Forms.Label lblQuestionAnswerVariants;
        private System.Windows.Forms.Label lblQuestionTitle;
        private System.Windows.Forms.Label lblSequencingQuestionTitle;
        private System.Windows.Forms.TableLayoutPanel answersTableLayoutPanel;
    }
}
