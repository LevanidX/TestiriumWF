﻿namespace TestiriumWF.ProgrammWindows
{
    partial class UserEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.isAdminCheckBox = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.isAdminPanel = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSaveUserInfo = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.userBirthdateTextBox = new System.Windows.Forms.MaskedTextBox();
            this.userPictureBox = new System.Windows.Forms.PictureBox();
            this.btnExitWindow = new System.Windows.Forms.Button();
            this.userLoginTextBox = new TestiriumWF.CustomControls.CustomOverrideControls.CustomTextBox();
            this.userPasswordTextBox = new TestiriumWF.CustomControls.CustomPasswordTextBox();
            this.userPatronymicTextBox = new TestiriumWF.CustomControls.CustomOverrideControls.CustomTextBox();
            this.userSurnameTextBox = new TestiriumWF.CustomControls.CustomOverrideControls.CustomTextBox();
            this.userNameTextBox = new TestiriumWF.CustomControls.CustomOverrideControls.CustomTextBox();
            this.isAdminPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // isAdminCheckBox
            // 
            this.isAdminCheckBox.AutoSize = true;
            this.isAdminCheckBox.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.isAdminCheckBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.isAdminCheckBox.Location = new System.Drawing.Point(8, 24);
            this.isAdminCheckBox.Name = "isAdminCheckBox";
            this.isAdminCheckBox.Size = new System.Drawing.Size(69, 20);
            this.isAdminCheckBox.TabIndex = 30;
            this.isAdminCheckBox.Text = "Да/Нет";
            this.isAdminCheckBox.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(201, 19);
            this.label10.TabIndex = 29;
            this.label10.Text = "Имеет права администратора";
            // 
            // isAdminPanel
            // 
            this.isAdminPanel.Controls.Add(this.isAdminCheckBox);
            this.isAdminPanel.Controls.Add(this.label10);
            this.isAdminPanel.Location = new System.Drawing.Point(16, 368);
            this.isAdminPanel.Name = "isAdminPanel";
            this.isAdminPanel.Size = new System.Drawing.Size(408, 48);
            this.isAdminPanel.TabIndex = 50;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(16, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(193, 19);
            this.label9.TabIndex = 49;
            this.label9.Text = "Дата рождения (гггг/мм/дд)";
            // 
            // btnSaveUserInfo
            // 
            this.btnSaveUserInfo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSaveUserInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(203)))), ((int)(((byte)(129)))));
            this.btnSaveUserInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSaveUserInfo.FlatAppearance.BorderSize = 0;
            this.btnSaveUserInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveUserInfo.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveUserInfo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSaveUserInfo.Location = new System.Drawing.Point(16, 424);
            this.btnSaveUserInfo.Name = "btnSaveUserInfo";
            this.btnSaveUserInfo.Size = new System.Drawing.Size(408, 48);
            this.btnSaveUserInfo.TabIndex = 46;
            this.btnSaveUserInfo.Text = "Сохранить";
            this.btnSaveUserInfo.UseVisualStyleBackColor = false;
            this.btnSaveUserInfo.Click += new System.EventHandler(this.btnSaveUserInfo_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(16, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 19);
            this.label6.TabIndex = 44;
            this.label6.Text = "Логин";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(16, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 19);
            this.label5.TabIndex = 43;
            this.label5.Text = "Пароль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(176, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 19);
            this.label4.TabIndex = 40;
            this.label4.Text = "Отчество (если нет, то прочерк)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(176, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 19);
            this.label3.TabIndex = 38;
            this.label3.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(176, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 19);
            this.label2.TabIndex = 36;
            this.label2.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(16, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 35;
            this.label1.Text = "Фото профиля";
            // 
            // userBirthdateTextBox
            // 
            this.userBirthdateTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.userBirthdateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userBirthdateTextBox.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.userBirthdateTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.userBirthdateTextBox.Location = new System.Drawing.Point(16, 224);
            this.userBirthdateTextBox.Mask = "0000/00/00";
            this.userBirthdateTextBox.Name = "userBirthdateTextBox";
            this.userBirthdateTextBox.Size = new System.Drawing.Size(408, 23);
            this.userBirthdateTextBox.TabIndex = 53;
            this.userBirthdateTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // userPictureBox
            // 
            this.userPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.userPictureBox.Image = global::TestiriumWF.Properties.Resources.user_default_img;
            this.userPictureBox.Location = new System.Drawing.Point(16, 32);
            this.userPictureBox.Name = "userPictureBox";
            this.userPictureBox.Size = new System.Drawing.Size(152, 160);
            this.userPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPictureBox.TabIndex = 34;
            this.userPictureBox.TabStop = false;
            this.userPictureBox.Click += new System.EventHandler(this.userPictureBox_Click);
            // 
            // btnExitWindow
            // 
            this.btnExitWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btnExitWindow.BackgroundImage = global::TestiriumWF.Properties.Resources.back;
            this.btnExitWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExitWindow.FlatAppearance.BorderSize = 0;
            this.btnExitWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitWindow.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExitWindow.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExitWindow.Location = new System.Drawing.Point(408, 8);
            this.btnExitWindow.Name = "btnExitWindow";
            this.btnExitWindow.Size = new System.Drawing.Size(24, 24);
            this.btnExitWindow.TabIndex = 54;
            this.btnExitWindow.UseVisualStyleBackColor = false;
            this.btnExitWindow.Click += new System.EventHandler(this.btnExitWindow_Click);
            // 
            // userLoginTextBox
            // 
            this.userLoginTextBox.Location = new System.Drawing.Point(16, 280);
            this.userLoginTextBox.Name = "userLoginTextBox";
            this.userLoginTextBox.Size = new System.Drawing.Size(408, 24);
            this.userLoginTextBox.TabIndex = 45;
            this.userLoginTextBox.TextValue = "";
            // 
            // userPasswordTextBox
            // 
            this.userPasswordTextBox.Location = new System.Drawing.Point(16, 336);
            this.userPasswordTextBox.Name = "userPasswordTextBox";
            this.userPasswordTextBox.Size = new System.Drawing.Size(408, 23);
            this.userPasswordTextBox.TabIndex = 42;
            this.userPasswordTextBox.TextValue = "";
            // 
            // userPatronymicTextBox
            // 
            this.userPatronymicTextBox.Location = new System.Drawing.Point(176, 168);
            this.userPatronymicTextBox.Name = "userPatronymicTextBox";
            this.userPatronymicTextBox.Size = new System.Drawing.Size(248, 24);
            this.userPatronymicTextBox.TabIndex = 41;
            this.userPatronymicTextBox.TextValue = "";
            // 
            // userSurnameTextBox
            // 
            this.userSurnameTextBox.Location = new System.Drawing.Point(176, 112);
            this.userSurnameTextBox.Name = "userSurnameTextBox";
            this.userSurnameTextBox.Size = new System.Drawing.Size(248, 24);
            this.userSurnameTextBox.TabIndex = 39;
            this.userSurnameTextBox.TextValue = "";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(176, 56);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(248, 24);
            this.userNameTextBox.TabIndex = 37;
            this.userNameTextBox.TextValue = "";
            // 
            // UserEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(440, 480);
            this.ControlBox = false;
            this.Controls.Add(this.btnExitWindow);
            this.Controls.Add(this.userBirthdateTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnSaveUserInfo);
            this.Controls.Add(this.userLoginTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.userPasswordTextBox);
            this.Controls.Add(this.userPatronymicTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.userSurnameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userPictureBox);
            this.Controls.Add(this.isAdminPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserEditor";
            this.Load += new System.EventHandler(this.UserEditor_Load);
            this.isAdminPanel.ResumeLayout(false);
            this.isAdminPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox isAdminCheckBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel isAdminPanel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSaveUserInfo;
        private CustomControls.CustomOverrideControls.CustomTextBox userLoginTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private CustomControls.CustomPasswordTextBox userPasswordTextBox;
        private CustomControls.CustomOverrideControls.CustomTextBox userPatronymicTextBox;
        private System.Windows.Forms.Label label4;
        private CustomControls.CustomOverrideControls.CustomTextBox userSurnameTextBox;
        private System.Windows.Forms.Label label3;
        private CustomControls.CustomOverrideControls.CustomTextBox userNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox userPictureBox;
        private System.Windows.Forms.MaskedTextBox userBirthdateTextBox;
        private System.Windows.Forms.Button btnExitWindow;
    }
}