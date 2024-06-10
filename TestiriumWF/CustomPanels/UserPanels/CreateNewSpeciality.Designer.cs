namespace TestiriumWF.ProgrammWindows
{
    partial class CreateNewSpeciality
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateNewSpeciality));
            this.btnSave = new System.Windows.Forms.Button();
            this.specialityTextBox = new TestiriumWF.CustomControls.CustomOverrideControls.CustomTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExitWindow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(203)))), ((int)(((byte)(129)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(16, 72);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(400, 40);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Сохранить новую специальность";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // specialityTextBox
            // 
            this.specialityTextBox.Location = new System.Drawing.Point(16, 40);
            this.specialityTextBox.Name = "specialityTextBox";
            this.specialityTextBox.Size = new System.Drawing.Size(400, 24);
            this.specialityTextBox.TabIndex = 8;
            this.specialityTextBox.TextValue = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Название специальности";
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
            this.btnExitWindow.Location = new System.Drawing.Point(392, 8);
            this.btnExitWindow.Name = "btnExitWindow";
            this.btnExitWindow.Size = new System.Drawing.Size(24, 24);
            this.btnExitWindow.TabIndex = 17;
            this.btnExitWindow.UseVisualStyleBackColor = false;
            this.btnExitWindow.Click += new System.EventHandler(this.btnExitWindow_Click);
            // 
            // CreateNewSpeciality
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(433, 129);
            this.Controls.Add(this.btnExitWindow);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.specialityTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateNewSpeciality";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateNewSpeciality";
            this.Load += new System.EventHandler(this.CreateNewSpeciality_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private CustomControls.CustomOverrideControls.CustomTextBox specialityTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExitWindow;
    }
}