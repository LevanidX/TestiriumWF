namespace TestiriumWF.CustomPanels
{
    partial class UsersControl
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
            this.allCoursesPanel = new System.Windows.Forms.Panel();
            this.classesFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.teachersFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTests = new System.Windows.Forms.Label();
            this.allStudentsFromClassPanel = new System.Windows.Forms.Panel();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.lblCurrentCourse = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.allCoursesPanel.SuspendLayout();
            this.allStudentsFromClassPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // allCoursesPanel
            // 
            this.allCoursesPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.allCoursesPanel.Controls.Add(this.classesFlowLayoutPanel);
            this.allCoursesPanel.Controls.Add(this.label1);
            this.allCoursesPanel.Controls.Add(this.teachersFlowLayoutPanel);
            this.allCoursesPanel.Controls.Add(this.lblTests);
            this.allCoursesPanel.Location = new System.Drawing.Point(0, 0);
            this.allCoursesPanel.Name = "allCoursesPanel";
            this.allCoursesPanel.Size = new System.Drawing.Size(200, 528);
            this.allCoursesPanel.TabIndex = 9;
            // 
            // classesFlowLayoutPanel
            // 
            this.classesFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.classesFlowLayoutPanel.Location = new System.Drawing.Point(8, 296);
            this.classesFlowLayoutPanel.Name = "classesFlowLayoutPanel";
            this.classesFlowLayoutPanel.Size = new System.Drawing.Size(184, 216);
            this.classesFlowLayoutPanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(8, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Учащиеся - классы";
            // 
            // teachersFlowLayoutPanel
            // 
            this.teachersFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.teachersFlowLayoutPanel.Location = new System.Drawing.Point(8, 40);
            this.teachersFlowLayoutPanel.Name = "teachersFlowLayoutPanel";
            this.teachersFlowLayoutPanel.Size = new System.Drawing.Size(184, 216);
            this.teachersFlowLayoutPanel.TabIndex = 1;
            // 
            // lblTests
            // 
            this.lblTests.AutoSize = true;
            this.lblTests.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTests.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTests.Location = new System.Drawing.Point(8, 8);
            this.lblTests.Name = "lblTests";
            this.lblTests.Size = new System.Drawing.Size(140, 25);
            this.lblTests.TabIndex = 0;
            this.lblTests.Text = "Преподаватели";
            // 
            // allStudentsFromClassPanel
            // 
            this.allStudentsFromClassPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.allStudentsFromClassPanel.Controls.Add(this.btnCreateUser);
            this.allStudentsFromClassPanel.Controls.Add(this.lblCurrentCourse);
            this.allStudentsFromClassPanel.Controls.Add(this.label2);
            this.allStudentsFromClassPanel.Controls.Add(this.label3);
            this.allStudentsFromClassPanel.Location = new System.Drawing.Point(216, 16);
            this.allStudentsFromClassPanel.Name = "allStudentsFromClassPanel";
            this.allStudentsFromClassPanel.Size = new System.Drawing.Size(768, 496);
            this.allStudentsFromClassPanel.TabIndex = 10;
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(203)))), ((int)(((byte)(129)))));
            this.btnCreateUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCreateUser.FlatAppearance.BorderSize = 0;
            this.btnCreateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateUser.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreateUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCreateUser.Location = new System.Drawing.Point(528, 16);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(224, 56);
            this.btnCreateUser.TabIndex = 6;
            this.btnCreateUser.Text = "Добавить пользователя";
            this.btnCreateUser.UseVisualStyleBackColor = false;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // lblCurrentCourse
            // 
            this.lblCurrentCourse.AutoSize = true;
            this.lblCurrentCourse.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCurrentCourse.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCurrentCourse.Location = new System.Drawing.Point(152, 48);
            this.lblCurrentCourse.Name = "lblCurrentCourse";
            this.lblCurrentCourse.Size = new System.Drawing.Size(90, 23);
            this.lblCurrentCourse.TabIndex = 8;
            this.lblCurrentCourse.Text = "Не выбран";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(16, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Специальность:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(16, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Преподаватели";
            // 
            // UsersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.Controls.Add(this.allStudentsFromClassPanel);
            this.Controls.Add(this.allCoursesPanel);
            this.Name = "UsersControl";
            this.Size = new System.Drawing.Size(1000, 528);
            this.allCoursesPanel.ResumeLayout(false);
            this.allCoursesPanel.PerformLayout();
            this.allStudentsFromClassPanel.ResumeLayout(false);
            this.allStudentsFromClassPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel allCoursesPanel;
        private System.Windows.Forms.FlowLayoutPanel classesFlowLayoutPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel teachersFlowLayoutPanel;
        private System.Windows.Forms.Label lblTests;
        private System.Windows.Forms.Panel allStudentsFromClassPanel;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.Label lblCurrentCourse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
