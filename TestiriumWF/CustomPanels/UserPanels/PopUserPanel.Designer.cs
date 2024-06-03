namespace TestiriumWF.CustomPanels
{
    partial class PopUserPanel
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
            this.btnExitProgramm = new System.Windows.Forms.Button();
            this.btnExitUser = new System.Windows.Forms.Button();
            this.btnEditProfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExitProgramm
            // 
            this.btnExitProgramm.BackColor = System.Drawing.Color.Red;
            this.btnExitProgramm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExitProgramm.FlatAppearance.BorderSize = 0;
            this.btnExitProgramm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitProgramm.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExitProgramm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExitProgramm.Location = new System.Drawing.Point(0, 96);
            this.btnExitProgramm.Name = "btnExitProgramm";
            this.btnExitProgramm.Size = new System.Drawing.Size(360, 48);
            this.btnExitProgramm.TabIndex = 6;
            this.btnExitProgramm.Text = "Выход из программы";
            this.btnExitProgramm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExitProgramm.UseVisualStyleBackColor = false;
            this.btnExitProgramm.Click += new System.EventHandler(this.btnExitProgramm_Click);
            // 
            // btnExitUser
            // 
            this.btnExitUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.btnExitUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExitUser.FlatAppearance.BorderSize = 0;
            this.btnExitUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitUser.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExitUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExitUser.Location = new System.Drawing.Point(0, 48);
            this.btnExitUser.Name = "btnExitUser";
            this.btnExitUser.Size = new System.Drawing.Size(360, 48);
            this.btnExitUser.TabIndex = 7;
            this.btnExitUser.Text = "Выход из пользователя";
            this.btnExitUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExitUser.UseVisualStyleBackColor = false;
            this.btnExitUser.Click += new System.EventHandler(this.btnExitUser_Click);
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.btnEditProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEditProfile.FlatAppearance.BorderSize = 0;
            this.btnEditProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProfile.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditProfile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditProfile.Location = new System.Drawing.Point(0, 0);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(360, 48);
            this.btnEditProfile.TabIndex = 8;
            this.btnEditProfile.Text = "Редактирование профиля";
            this.btnEditProfile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditProfile.UseVisualStyleBackColor = false;
            this.btnEditProfile.Click += new System.EventHandler(this.btnEditProfile_Click);
            // 
            // PopUserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.Controls.Add(this.btnEditProfile);
            this.Controls.Add(this.btnExitUser);
            this.Controls.Add(this.btnExitProgramm);
            this.Name = "PopUserPanel";
            this.Size = new System.Drawing.Size(360, 144);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExitProgramm;
        private System.Windows.Forms.Button btnExitUser;
        private System.Windows.Forms.Button btnEditProfile;
    }
}
