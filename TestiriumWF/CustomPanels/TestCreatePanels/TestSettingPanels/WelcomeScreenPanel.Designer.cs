namespace TestiriumWF
{
    partial class WelcomeScreenPanel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.descriptionTestTxtBox = new System.Windows.Forms.TextBox();
            this.lblTestDescription = new System.Windows.Forms.Label();
            this.testTitleTxtBox = new System.Windows.Forms.TextBox();
            this.lblTestTitle = new System.Windows.Forms.Label();
            this.lblWelcomeScreenTitle = new System.Windows.Forms.Label();
            this.btnAddPhotoVideo = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.panel1.Controls.Add(this.btnAddPhotoVideo);
            this.panel1.Controls.Add(this.descriptionTestTxtBox);
            this.panel1.Controls.Add(this.lblTestDescription);
            this.panel1.Controls.Add(this.testTitleTxtBox);
            this.panel1.Controls.Add(this.lblTestTitle);
            this.panel1.Controls.Add(this.lblWelcomeScreenTitle);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 496);
            this.panel1.TabIndex = 5;
            // 
            // descriptionTestTxtBox
            // 
            this.descriptionTestTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.descriptionTestTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descriptionTestTxtBox.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionTestTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.descriptionTestTxtBox.Location = new System.Drawing.Point(32, 168);
            this.descriptionTestTxtBox.Multiline = true;
            this.descriptionTestTxtBox.Name = "descriptionTestTxtBox";
            this.descriptionTestTxtBox.Size = new System.Drawing.Size(720, 257);
            this.descriptionTestTxtBox.TabIndex = 4;
            this.descriptionTestTxtBox.Text = "Введите описание для теста (здесь может быть краткая информация, необходимая обуч" +
    "ающемуся до тестирования)";
            this.descriptionTestTxtBox.Click += new System.EventHandler(this.descriptionTestTxtBox_Click);
            this.descriptionTestTxtBox.Leave += new System.EventHandler(this.descriptionTestTxtBox_Leave);
            // 
            // lblTestDescription
            // 
            this.lblTestDescription.AutoSize = true;
            this.lblTestDescription.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTestDescription.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTestDescription.Location = new System.Drawing.Point(32, 152);
            this.lblTestDescription.Name = "lblTestDescription";
            this.lblTestDescription.Size = new System.Drawing.Size(124, 16);
            this.lblTestDescription.TabIndex = 3;
            this.lblTestDescription.Text = "Описание для теста";
            // 
            // testTitleTxtBox
            // 
            this.testTitleTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.testTitleTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.testTitleTxtBox.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.testTitleTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.testTitleTxtBox.Location = new System.Drawing.Point(32, 112);
            this.testTitleTxtBox.Name = "testTitleTxtBox";
            this.testTitleTxtBox.Size = new System.Drawing.Size(720, 27);
            this.testTitleTxtBox.TabIndex = 2;
            this.testTitleTxtBox.Text = "Введите название теста";
            this.testTitleTxtBox.Click += new System.EventHandler(this.testTitleTxtBox_Click);
            this.testTitleTxtBox.Leave += new System.EventHandler(this.testTitleTxtBox_Leave);
            // 
            // lblTestTitle
            // 
            this.lblTestTitle.AutoSize = true;
            this.lblTestTitle.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTestTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTestTitle.Location = new System.Drawing.Point(32, 96);
            this.lblTestTitle.Name = "lblTestTitle";
            this.lblTestTitle.Size = new System.Drawing.Size(64, 16);
            this.lblTestTitle.TabIndex = 1;
            this.lblTestTitle.Text = "Название";
            // 
            // lblWelcomeScreenTitle
            // 
            this.lblWelcomeScreenTitle.AutoSize = true;
            this.lblWelcomeScreenTitle.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWelcomeScreenTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblWelcomeScreenTitle.Location = new System.Drawing.Point(32, 32);
            this.lblWelcomeScreenTitle.Name = "lblWelcomeScreenTitle";
            this.lblWelcomeScreenTitle.Size = new System.Drawing.Size(153, 25);
            this.lblWelcomeScreenTitle.TabIndex = 0;
            this.lblWelcomeScreenTitle.Text = "Титульный экран";
            // 
            // btnAddPhotoVideo
            // 
            this.btnAddPhotoVideo.ActiveLinkColor = System.Drawing.Color.White;
            this.btnAddPhotoVideo.AutoSize = true;
            this.btnAddPhotoVideo.Font = new System.Drawing.Font("Bahnschrift Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddPhotoVideo.LinkColor = System.Drawing.Color.White;
            this.btnAddPhotoVideo.Location = new System.Drawing.Point(32, 425);
            this.btnAddPhotoVideo.Name = "btnAddPhotoVideo";
            this.btnAddPhotoVideo.Size = new System.Drawing.Size(176, 14);
            this.btnAddPhotoVideo.TabIndex = 6;
            this.btnAddPhotoVideo.TabStop = true;
            this.btnAddPhotoVideo.Text = "Добавить картинку или видео";
            this.btnAddPhotoVideo.VisitedLinkColor = System.Drawing.Color.White;
            this.btnAddPhotoVideo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnAddPhotoVideo_LinkClicked);
            // 
            // WelcomeScreenPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "WelcomeScreenPanel";
            this.Size = new System.Drawing.Size(784, 496);
            this.Load += new System.EventHandler(this.WelcomeScreenPanel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox descriptionTestTxtBox;
        private System.Windows.Forms.Label lblTestDescription;
        private System.Windows.Forms.TextBox testTitleTxtBox;
        private System.Windows.Forms.Label lblTestTitle;
        private System.Windows.Forms.Label lblWelcomeScreenTitle;
        private System.Windows.Forms.LinkLabel btnAddPhotoVideo;
    }
}
