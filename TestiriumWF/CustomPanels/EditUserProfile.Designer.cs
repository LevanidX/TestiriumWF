namespace TestiriumWF.CustomPanels
{
    partial class EditUserProfile
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
            this.availableTestsPanel = new System.Windows.Forms.Panel();
            this.btnSaveEdits = new System.Windows.Forms.Button();
            this.lblPatronymic = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.userPictureBox = new System.Windows.Forms.PictureBox();
            this.newPasswordTextBox = new TestiriumWF.CustomControls.CustomOverrideControls.CustomTextBox();
            this.initialPasswordTextBox = new TestiriumWF.CustomControls.CustomOverrideControls.CustomTextBox();
            this.availableTestsPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // availableTestsPanel
            // 
            this.availableTestsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.availableTestsPanel.Controls.Add(this.btnSaveEdits);
            this.availableTestsPanel.Controls.Add(this.lblPatronymic);
            this.availableTestsPanel.Controls.Add(this.lblSurname);
            this.availableTestsPanel.Controls.Add(this.lblName);
            this.availableTestsPanel.Controls.Add(this.panel1);
            this.availableTestsPanel.Controls.Add(this.label5);
            this.availableTestsPanel.Controls.Add(this.label4);
            this.availableTestsPanel.Controls.Add(this.label3);
            this.availableTestsPanel.Controls.Add(this.label2);
            this.availableTestsPanel.Controls.Add(this.label1);
            this.availableTestsPanel.Controls.Add(this.userPictureBox);
            this.availableTestsPanel.Location = new System.Drawing.Point(16, 16);
            this.availableTestsPanel.Name = "availableTestsPanel";
            this.availableTestsPanel.Size = new System.Drawing.Size(968, 496);
            this.availableTestsPanel.TabIndex = 12;
            // 
            // btnSaveEdits
            // 
            this.btnSaveEdits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(203)))), ((int)(((byte)(129)))));
            this.btnSaveEdits.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSaveEdits.FlatAppearance.BorderSize = 0;
            this.btnSaveEdits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveEdits.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveEdits.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSaveEdits.Location = new System.Drawing.Point(16, 424);
            this.btnSaveEdits.Name = "btnSaveEdits";
            this.btnSaveEdits.Size = new System.Drawing.Size(904, 48);
            this.btnSaveEdits.TabIndex = 22;
            this.btnSaveEdits.Text = "Сохранить изменения";
            this.btnSaveEdits.UseVisualStyleBackColor = false;
            // 
            // lblPatronymic
            // 
            this.lblPatronymic.AutoSize = true;
            this.lblPatronymic.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPatronymic.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPatronymic.Location = new System.Drawing.Point(280, 104);
            this.lblPatronymic.Name = "lblPatronymic";
            this.lblPatronymic.Size = new System.Drawing.Size(71, 19);
            this.lblPatronymic.TabIndex = 21;
            this.lblPatronymic.Text = "Иванович";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSurname.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSurname.Location = new System.Drawing.Point(280, 72);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(55, 19);
            this.lblSurname.TabIndex = 20;
            this.lblSurname.Text = "Иванов";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblName.Location = new System.Drawing.Point(280, 40);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 19);
            this.lblName.TabIndex = 19;
            this.lblName.Text = "Иван";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.newPasswordTextBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.initialPasswordTextBox);
            this.panel1.Location = new System.Drawing.Point(16, 256);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 120);
            this.panel1.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(8, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 18);
            this.label7.TabIndex = 9;
            this.label7.Text = "Новый пароль";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(8, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Текущий пароль";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(208, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "Отчество: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(208, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "Фамилия:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(208, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "Имя: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(16, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "Изменение пароля";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Фото профиля";
            // 
            // userPictureBox
            // 
            this.userPictureBox.BackColor = System.Drawing.Color.Gainsboro;
            this.userPictureBox.Image = global::TestiriumWF.Properties.Resources.user_account;
            this.userPictureBox.Location = new System.Drawing.Point(16, 40);
            this.userPictureBox.Name = "userPictureBox";
            this.userPictureBox.Size = new System.Drawing.Size(176, 176);
            this.userPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPictureBox.TabIndex = 12;
            this.userPictureBox.TabStop = false;
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.Location = new System.Drawing.Point(8, 88);
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.Size = new System.Drawing.Size(384, 24);
            this.newPasswordTextBox.TabIndex = 10;
            this.newPasswordTextBox.TextValue = "";
            // 
            // initialPasswordTextBox
            // 
            this.initialPasswordTextBox.Location = new System.Drawing.Point(8, 32);
            this.initialPasswordTextBox.Name = "initialPasswordTextBox";
            this.initialPasswordTextBox.Size = new System.Drawing.Size(384, 24);
            this.initialPasswordTextBox.TabIndex = 3;
            this.initialPasswordTextBox.TextValue = "";
            // 
            // EditUserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.Controls.Add(this.availableTestsPanel);
            this.Name = "EditUserProfile";
            this.Size = new System.Drawing.Size(1000, 528);
            this.availableTestsPanel.ResumeLayout(false);
            this.availableTestsPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel availableTestsPanel;
        private System.Windows.Forms.Button btnSaveEdits;
        private System.Windows.Forms.Label lblPatronymic;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panel1;
        private CustomControls.CustomOverrideControls.CustomTextBox newPasswordTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private CustomControls.CustomOverrideControls.CustomTextBox initialPasswordTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox userPictureBox;
    }
}
