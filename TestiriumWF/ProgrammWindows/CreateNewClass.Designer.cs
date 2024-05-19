namespace TestiriumWF.ProgrammWindows
{
    partial class CreateNewClass
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
            this.btnExitWindow = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.classYearTextBox = new System.Windows.Forms.MaskedTextBox();
            this.classNameTextBox = new TestiriumWF.CustomControls.CustomOverrideControls.CustomTextBox();
            this.SuspendLayout();
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
            this.btnExitWindow.TabIndex = 21;
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
            this.btnSave.Location = new System.Drawing.Point(16, 128);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(400, 40);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Сохранить новый класс";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "Наименование класса";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(16, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 22;
            this.label2.Text = "Год набора";
            // 
            // classYearTextBox
            // 
            this.classYearTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.classYearTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.classYearTextBox.Culture = new System.Globalization.CultureInfo("rwk-TZ");
            this.classYearTextBox.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.classYearTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.classYearTextBox.Location = new System.Drawing.Point(16, 96);
            this.classYearTextBox.Mask = "0000/00";
            this.classYearTextBox.Name = "classYearTextBox";
            this.classYearTextBox.Size = new System.Drawing.Size(400, 23);
            this.classYearTextBox.TabIndex = 54;
            this.classYearTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // classNameTextBox
            // 
            this.classNameTextBox.Location = new System.Drawing.Point(16, 40);
            this.classNameTextBox.Name = "classNameTextBox";
            this.classNameTextBox.Size = new System.Drawing.Size(400, 24);
            this.classNameTextBox.TabIndex = 19;
            this.classNameTextBox.TextValue = "";
            // 
            // CreateNewClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(433, 185);
            this.Controls.Add(this.classYearTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExitWindow);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.classNameTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateNewClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateNewClass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExitWindow;
        private System.Windows.Forms.Button btnSave;
        private CustomControls.CustomOverrideControls.CustomTextBox classNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox classYearTextBox;
    }
}