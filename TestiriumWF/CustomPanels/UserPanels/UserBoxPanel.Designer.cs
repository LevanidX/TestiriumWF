namespace TestiriumWF.CustomPanels
{
    partial class UserBoxPanel
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
            this.lblUserName = new System.Windows.Forms.Label();
            this.userBoxTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.userPictureBox = new System.Windows.Forms.PictureBox();
            this.userBoxTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUserName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUserName.Location = new System.Drawing.Point(210, 18);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(91, 19);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "Иванов Иван";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userBoxTableLayoutPanel
            // 
            this.userBoxTableLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userBoxTableLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.userBoxTableLayoutPanel.ColumnCount = 2;
            this.userBoxTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.51913F));
            this.userBoxTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.48086F));
            this.userBoxTableLayoutPanel.Controls.Add(this.lblUserName, 0, 0);
            this.userBoxTableLayoutPanel.Controls.Add(this.userPictureBox, 1, 0);
            this.userBoxTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.userBoxTableLayoutPanel.Name = "userBoxTableLayoutPanel";
            this.userBoxTableLayoutPanel.RowCount = 1;
            this.userBoxTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.userBoxTableLayoutPanel.Size = new System.Drawing.Size(360, 56);
            this.userBoxTableLayoutPanel.TabIndex = 2;
            this.userBoxTableLayoutPanel.Click += new System.EventHandler(this.userBoxTableLayoutPanel_Click);
            // 
            // userPictureBox
            // 
            this.userPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.userPictureBox.Image = global::TestiriumWF.Properties.Resources.user_default_img;
            this.userPictureBox.Location = new System.Drawing.Point(307, 3);
            this.userPictureBox.Name = "userPictureBox";
            this.userPictureBox.Size = new System.Drawing.Size(50, 50);
            this.userPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPictureBox.TabIndex = 1;
            this.userPictureBox.TabStop = false;
            // 
            // UserBoxPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.userBoxTableLayoutPanel);
            this.Name = "UserBoxPanel";
            this.Size = new System.Drawing.Size(358, 56);
            this.userBoxTableLayoutPanel.ResumeLayout(false);
            this.userBoxTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TableLayoutPanel userBoxTableLayoutPanel;
        private System.Windows.Forms.PictureBox userPictureBox;
    }
}
