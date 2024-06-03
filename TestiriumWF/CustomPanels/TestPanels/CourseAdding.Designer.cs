namespace TestiriumWF.ProgrammWindows
{
    partial class CourseAdding
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.courseNameTextBox = new TestiriumWF.CustomControls.CustomOverrideControls.CustomTextBox();
            this.btnExitWindow = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.classComboBox = new TestiriumWF.CustomControls.CustomComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название курса";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(16, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Класс";
            // 
            // courseNameTextBox
            // 
            this.courseNameTextBox.Location = new System.Drawing.Point(16, 40);
            this.courseNameTextBox.Name = "courseNameTextBox";
            this.courseNameTextBox.Size = new System.Drawing.Size(400, 40);
            this.courseNameTextBox.TabIndex = 6;
            this.courseNameTextBox.TextValue = "";
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
            this.btnExitWindow.TabIndex = 22;
            this.btnExitWindow.UseVisualStyleBackColor = false;
            this.btnExitWindow.Click += new System.EventHandler(this.btnExitWindow_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(203)))), ((int)(((byte)(129)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(16, 144);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(400, 40);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Сохранить новый курс";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // classComboBox
            // 
            this.classComboBox.BackColorValue = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.classComboBox.ComboItems = new string[] {
        "5",
        "6",
        "7",
        "8",
        "9",
        "10",
        "11"};
            this.classComboBox.Location = new System.Drawing.Point(16, 112);
            this.classComboBox.Name = "classComboBox";
            this.classComboBox.Size = new System.Drawing.Size(400, 25);
            this.classComboBox.TabIndex = 24;
            this.classComboBox.TextValue = "";
            // 
            // CourseAdding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(433, 201);
            this.Controls.Add(this.classComboBox);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnExitWindow);
            this.Controls.Add(this.courseNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CourseAdding";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private CustomControls.CustomOverrideControls.CustomTextBox courseNameTextBox;
        private System.Windows.Forms.Button btnExitWindow;
        private System.Windows.Forms.Button btnSave;
        private CustomControls.CustomComboBox classComboBox;
    }
}