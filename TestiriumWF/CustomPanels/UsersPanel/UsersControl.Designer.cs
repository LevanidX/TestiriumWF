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
            this.components = new System.ComponentModel.Container();
            this.allCoursesPanel = new System.Windows.Forms.Panel();
            this.btnStudents = new System.Windows.Forms.Button();
            this.btnTeachers = new System.Windows.Forms.Button();
            this.teachersCatalogPanel = new System.Windows.Forms.Panel();
            this.btnAddNewSpeciality = new System.Windows.Forms.Button();
            this.specialitiesFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lblUserCatalog = new System.Windows.Forms.Label();
            this.studentsCatalogPanel = new System.Windows.Forms.Panel();
            this.classesFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lblClasses = new System.Windows.Forms.Label();
            this.usersPanel = new System.Windows.Forms.Panel();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.teachersPanel = new System.Windows.Forms.Panel();
            this.lblCurrentCatalog = new System.Windows.Forms.Label();
            this.lblChoicedSpeciality = new System.Windows.Forms.Label();
            this.lblSeparatorValue = new System.Windows.Forms.Label();
            this.studentsPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblChoicedClass = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.usersDataGridMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersDataGridView = new TestiriumWF.CustomControls.CustomDataGridView();
            this.btnAddNewClass = new System.Windows.Forms.Button();
            this.allCoursesPanel.SuspendLayout();
            this.teachersCatalogPanel.SuspendLayout();
            this.studentsCatalogPanel.SuspendLayout();
            this.usersPanel.SuspendLayout();
            this.teachersPanel.SuspendLayout();
            this.studentsPanel.SuspendLayout();
            this.usersDataGridMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // allCoursesPanel
            // 
            this.allCoursesPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.allCoursesPanel.Controls.Add(this.btnStudents);
            this.allCoursesPanel.Controls.Add(this.btnTeachers);
            this.allCoursesPanel.Controls.Add(this.teachersCatalogPanel);
            this.allCoursesPanel.Controls.Add(this.studentsCatalogPanel);
            this.allCoursesPanel.Location = new System.Drawing.Point(0, 0);
            this.allCoursesPanel.Name = "allCoursesPanel";
            this.allCoursesPanel.Size = new System.Drawing.Size(200, 528);
            this.allCoursesPanel.TabIndex = 9;
            // 
            // btnStudents
            // 
            this.btnStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnStudents.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnStudents.FlatAppearance.BorderSize = 0;
            this.btnStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudents.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStudents.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStudents.Location = new System.Drawing.Point(8, 48);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(184, 32);
            this.btnStudents.TabIndex = 10;
            this.btnStudents.Text = "Учащиеся";
            this.btnStudents.UseVisualStyleBackColor = false;
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);
            // 
            // btnTeachers
            // 
            this.btnTeachers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTeachers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnTeachers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTeachers.FlatAppearance.BorderSize = 0;
            this.btnTeachers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeachers.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTeachers.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTeachers.Location = new System.Drawing.Point(8, 8);
            this.btnTeachers.Name = "btnTeachers";
            this.btnTeachers.Size = new System.Drawing.Size(184, 32);
            this.btnTeachers.TabIndex = 9;
            this.btnTeachers.Text = "Преподаватели";
            this.btnTeachers.UseVisualStyleBackColor = false;
            this.btnTeachers.Click += new System.EventHandler(this.btnTeachers_Click);
            // 
            // teachersCatalogPanel
            // 
            this.teachersCatalogPanel.Controls.Add(this.btnAddNewSpeciality);
            this.teachersCatalogPanel.Controls.Add(this.specialitiesFlowLayoutPanel);
            this.teachersCatalogPanel.Controls.Add(this.lblUserCatalog);
            this.teachersCatalogPanel.Location = new System.Drawing.Point(8, 88);
            this.teachersCatalogPanel.Name = "teachersCatalogPanel";
            this.teachersCatalogPanel.Size = new System.Drawing.Size(184, 424);
            this.teachersCatalogPanel.TabIndex = 11;
            // 
            // btnAddNewSpeciality
            // 
            this.btnAddNewSpeciality.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewSpeciality.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnAddNewSpeciality.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddNewSpeciality.FlatAppearance.BorderSize = 0;
            this.btnAddNewSpeciality.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewSpeciality.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddNewSpeciality.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddNewSpeciality.Location = new System.Drawing.Point(0, 376);
            this.btnAddNewSpeciality.Name = "btnAddNewSpeciality";
            this.btnAddNewSpeciality.Size = new System.Drawing.Size(184, 48);
            this.btnAddNewSpeciality.TabIndex = 13;
            this.btnAddNewSpeciality.Text = "Добавить новую специальность";
            this.btnAddNewSpeciality.UseVisualStyleBackColor = false;
            this.btnAddNewSpeciality.Click += new System.EventHandler(this.btnAddNewSpeciality_Click);
            // 
            // specialitiesFlowLayoutPanel
            // 
            this.specialitiesFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.specialitiesFlowLayoutPanel.Location = new System.Drawing.Point(0, 24);
            this.specialitiesFlowLayoutPanel.Name = "specialitiesFlowLayoutPanel";
            this.specialitiesFlowLayoutPanel.Size = new System.Drawing.Size(184, 344);
            this.specialitiesFlowLayoutPanel.TabIndex = 1;
            // 
            // lblUserCatalog
            // 
            this.lblUserCatalog.AutoSize = true;
            this.lblUserCatalog.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUserCatalog.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUserCatalog.Location = new System.Drawing.Point(0, 0);
            this.lblUserCatalog.Name = "lblUserCatalog";
            this.lblUserCatalog.Size = new System.Drawing.Size(126, 23);
            this.lblUserCatalog.TabIndex = 0;
            this.lblUserCatalog.Text = "Специальности";
            // 
            // studentsCatalogPanel
            // 
            this.studentsCatalogPanel.Controls.Add(this.btnAddNewClass);
            this.studentsCatalogPanel.Controls.Add(this.classesFlowLayoutPanel);
            this.studentsCatalogPanel.Controls.Add(this.lblClasses);
            this.studentsCatalogPanel.Location = new System.Drawing.Point(8, 88);
            this.studentsCatalogPanel.Name = "studentsCatalogPanel";
            this.studentsCatalogPanel.Size = new System.Drawing.Size(184, 424);
            this.studentsCatalogPanel.TabIndex = 12;
            // 
            // classesFlowLayoutPanel
            // 
            this.classesFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.classesFlowLayoutPanel.Location = new System.Drawing.Point(0, 24);
            this.classesFlowLayoutPanel.Name = "classesFlowLayoutPanel";
            this.classesFlowLayoutPanel.Size = new System.Drawing.Size(184, 344);
            this.classesFlowLayoutPanel.TabIndex = 1;
            // 
            // lblClasses
            // 
            this.lblClasses.AutoSize = true;
            this.lblClasses.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblClasses.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblClasses.Location = new System.Drawing.Point(0, 0);
            this.lblClasses.Name = "lblClasses";
            this.lblClasses.Size = new System.Drawing.Size(66, 23);
            this.lblClasses.TabIndex = 0;
            this.lblClasses.Text = "Классы";
            // 
            // usersPanel
            // 
            this.usersPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.usersPanel.Controls.Add(this.usersDataGridView);
            this.usersPanel.Controls.Add(this.btnCreateUser);
            this.usersPanel.Controls.Add(this.teachersPanel);
            this.usersPanel.Controls.Add(this.studentsPanel);
            this.usersPanel.Location = new System.Drawing.Point(216, 16);
            this.usersPanel.Name = "usersPanel";
            this.usersPanel.Size = new System.Drawing.Size(768, 496);
            this.usersPanel.TabIndex = 10;
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(203)))), ((int)(((byte)(129)))));
            this.btnCreateUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCreateUser.Enabled = false;
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
            // teachersPanel
            // 
            this.teachersPanel.Controls.Add(this.lblCurrentCatalog);
            this.teachersPanel.Controls.Add(this.lblChoicedSpeciality);
            this.teachersPanel.Controls.Add(this.lblSeparatorValue);
            this.teachersPanel.Location = new System.Drawing.Point(16, 16);
            this.teachersPanel.Name = "teachersPanel";
            this.teachersPanel.Size = new System.Drawing.Size(504, 56);
            this.teachersPanel.TabIndex = 9;
            // 
            // lblCurrentCatalog
            // 
            this.lblCurrentCatalog.AutoSize = true;
            this.lblCurrentCatalog.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCurrentCatalog.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCurrentCatalog.Location = new System.Drawing.Point(0, 0);
            this.lblCurrentCatalog.Name = "lblCurrentCatalog";
            this.lblCurrentCatalog.Size = new System.Drawing.Size(140, 25);
            this.lblCurrentCatalog.TabIndex = 6;
            this.lblCurrentCatalog.Text = "Преподаватели";
            // 
            // lblChoicedSpeciality
            // 
            this.lblChoicedSpeciality.AutoSize = true;
            this.lblChoicedSpeciality.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblChoicedSpeciality.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblChoicedSpeciality.Location = new System.Drawing.Point(128, 32);
            this.lblChoicedSpeciality.Name = "lblChoicedSpeciality";
            this.lblChoicedSpeciality.Size = new System.Drawing.Size(98, 23);
            this.lblChoicedSpeciality.TabIndex = 8;
            this.lblChoicedSpeciality.Text = "не выбрана";
            // 
            // lblSeparatorValue
            // 
            this.lblSeparatorValue.AutoSize = true;
            this.lblSeparatorValue.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSeparatorValue.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSeparatorValue.Location = new System.Drawing.Point(0, 32);
            this.lblSeparatorValue.Name = "lblSeparatorValue";
            this.lblSeparatorValue.Size = new System.Drawing.Size(130, 23);
            this.lblSeparatorValue.TabIndex = 7;
            this.lblSeparatorValue.Text = "Специальность:";
            // 
            // studentsPanel
            // 
            this.studentsPanel.Controls.Add(this.label1);
            this.studentsPanel.Controls.Add(this.lblChoicedClass);
            this.studentsPanel.Controls.Add(this.label3);
            this.studentsPanel.Location = new System.Drawing.Point(16, 16);
            this.studentsPanel.Name = "studentsPanel";
            this.studentsPanel.Size = new System.Drawing.Size(504, 56);
            this.studentsPanel.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Учащиеся";
            // 
            // lblChoicedClass
            // 
            this.lblChoicedClass.AutoSize = true;
            this.lblChoicedClass.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblChoicedClass.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblChoicedClass.Location = new System.Drawing.Point(56, 32);
            this.lblChoicedClass.Name = "lblChoicedClass";
            this.lblChoicedClass.Size = new System.Drawing.Size(89, 23);
            this.lblChoicedClass.TabIndex = 8;
            this.lblChoicedClass.Text = "не выбран";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(0, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Класс:";
            // 
            // usersDataGridMenuStrip
            // 
            this.usersDataGridMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.usersDataGridMenuStrip.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usersDataGridMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editUserToolStripMenuItem,
            this.deleteUserToolStripMenuItem});
            this.usersDataGridMenuStrip.Name = "availableTestsMenuStrip";
            this.usersDataGridMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.usersDataGridMenuStrip.ShowImageMargin = false;
            this.usersDataGridMenuStrip.Size = new System.Drawing.Size(128, 48);
            this.usersDataGridMenuStrip.Text = "Настройки";
            // 
            // editUserToolStripMenuItem
            // 
            this.editUserToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.editUserToolStripMenuItem.Name = "editUserToolStripMenuItem";
            this.editUserToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.editUserToolStripMenuItem.Text = "Редактировать";
            this.editUserToolStripMenuItem.Click += new System.EventHandler(this.editUserToolStripMenuItem_Click);
            // 
            // deleteUserToolStripMenuItem
            // 
            this.deleteUserToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteUserToolStripMenuItem.Name = "deleteUserToolStripMenuItem";
            this.deleteUserToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.deleteUserToolStripMenuItem.Text = "Удалить";
            this.deleteUserToolStripMenuItem.Click += new System.EventHandler(this.deleteUserToolStripMenuItem_Click);
            // 
            // usersDataGridView
            // 
            this.usersDataGridView.Location = new System.Drawing.Point(16, 88);
            this.usersDataGridView.Name = "usersDataGridView";
            this.usersDataGridView.Size = new System.Drawing.Size(736, 392);
            this.usersDataGridView.TabIndex = 11;
            // 
            // btnAddNewClass
            // 
            this.btnAddNewClass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnAddNewClass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddNewClass.FlatAppearance.BorderSize = 0;
            this.btnAddNewClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewClass.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddNewClass.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddNewClass.Location = new System.Drawing.Point(0, 376);
            this.btnAddNewClass.Name = "btnAddNewClass";
            this.btnAddNewClass.Size = new System.Drawing.Size(184, 48);
            this.btnAddNewClass.TabIndex = 14;
            this.btnAddNewClass.Text = "Добавить новый класс";
            this.btnAddNewClass.UseVisualStyleBackColor = false;
            this.btnAddNewClass.Click += new System.EventHandler(this.btnAddNewClass_Click);
            // 
            // UsersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.Controls.Add(this.usersPanel);
            this.Controls.Add(this.allCoursesPanel);
            this.Name = "UsersControl";
            this.Size = new System.Drawing.Size(1000, 528);
            this.Load += new System.EventHandler(this.UsersControl_Load);
            this.allCoursesPanel.ResumeLayout(false);
            this.teachersCatalogPanel.ResumeLayout(false);
            this.teachersCatalogPanel.PerformLayout();
            this.studentsCatalogPanel.ResumeLayout(false);
            this.studentsCatalogPanel.PerformLayout();
            this.usersPanel.ResumeLayout(false);
            this.teachersPanel.ResumeLayout(false);
            this.teachersPanel.PerformLayout();
            this.studentsPanel.ResumeLayout(false);
            this.studentsPanel.PerformLayout();
            this.usersDataGridMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel allCoursesPanel;
        private System.Windows.Forms.FlowLayoutPanel specialitiesFlowLayoutPanel;
        private System.Windows.Forms.Label lblUserCatalog;
        private System.Windows.Forms.Panel usersPanel;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.Label lblChoicedSpeciality;
        private System.Windows.Forms.Label lblSeparatorValue;
        private System.Windows.Forms.Label lblCurrentCatalog;
        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Button btnTeachers;
        private System.Windows.Forms.Panel teachersPanel;
        private System.Windows.Forms.Panel studentsPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblChoicedClass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel studentsCatalogPanel;
        private System.Windows.Forms.FlowLayoutPanel classesFlowLayoutPanel;
        private System.Windows.Forms.Label lblClasses;
        private System.Windows.Forms.Panel teachersCatalogPanel;
        private CustomControls.CustomDataGridView usersDataGridView;
        private System.Windows.Forms.ContextMenuStrip usersDataGridMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem editUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteUserToolStripMenuItem;
        private System.Windows.Forms.Button btnAddNewSpeciality;
        private System.Windows.Forms.Button btnAddNewClass;
    }
}
