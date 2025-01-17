﻿namespace TestiriumWF.CustomControls
{
    partial class CustomDataGridView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.customDataGrid = new System.Windows.Forms.DataGridView();
            this.teachersDataGridMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.completeTestAsStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endOrOpenTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.customDataGrid)).BeginInit();
            this.teachersDataGridMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // customDataGrid
            // 
            this.customDataGrid.AllowUserToAddRows = false;
            this.customDataGrid.AllowUserToDeleteRows = false;
            this.customDataGrid.AllowUserToResizeColumns = false;
            this.customDataGrid.AllowUserToResizeRows = false;
            this.customDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.customDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.customDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.customDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.customDataGrid.ColumnHeadersHeight = 50;
            this.customDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.customDataGrid.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(8);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.customDataGrid.EnableHeadersVisualStyles = false;
            this.customDataGrid.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.customDataGrid.Location = new System.Drawing.Point(0, 0);
            this.customDataGrid.MultiSelect = false;
            this.customDataGrid.Name = "customDataGrid";
            this.customDataGrid.ReadOnly = true;
            this.customDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.customDataGrid.RowHeadersVisible = false;
            this.customDataGrid.RowTemplate.Height = 100;
            this.customDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.customDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customDataGrid.Size = new System.Drawing.Size(736, 392);
            this.customDataGrid.TabIndex = 10;
            this.customDataGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.customDataGrid_CellMouseDoubleClick);
            this.customDataGrid.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.customDataGrid_CellMouseDown);
            this.customDataGrid.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.customDataGrid_CellMouseLeave);
            this.customDataGrid.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.customDataGrid_CellMouseMove);
            this.customDataGrid.LocationChanged += new System.EventHandler(this.customDataGrid_LocationChanged);
            // 
            // teachersDataGridMenuStrip
            // 
            this.teachersDataGridMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.teachersDataGridMenuStrip.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teachersDataGridMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editTestToolStripMenuItem,
            this.completeTestAsStudentToolStripMenuItem,
            this.endOrOpenTestToolStripMenuItem,
            this.deleteTestToolStripMenuItem});
            this.teachersDataGridMenuStrip.Name = "availableTestsMenuStrip";
            this.teachersDataGridMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.teachersDataGridMenuStrip.ShowImageMargin = false;
            this.teachersDataGridMenuStrip.Size = new System.Drawing.Size(188, 92);
            this.teachersDataGridMenuStrip.Text = "Настройки";
            this.teachersDataGridMenuStrip.Click += new System.EventHandler(this.dataGridMenuStrip_Click);
            // 
            // editTestToolStripMenuItem
            // 
            this.editTestToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.editTestToolStripMenuItem.Name = "editTestToolStripMenuItem";
            this.editTestToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.editTestToolStripMenuItem.Text = "Редактировать";
            // 
            // completeTestAsStudentToolStripMenuItem
            // 
            this.completeTestAsStudentToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.completeTestAsStudentToolStripMenuItem.Name = "completeTestAsStudentToolStripMenuItem";
            this.completeTestAsStudentToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.completeTestAsStudentToolStripMenuItem.Text = "Пройти как студент";
            this.completeTestAsStudentToolStripMenuItem.Click += new System.EventHandler(this.completeTestAsStudentToolStripMenuItem_Click);
            // 
            // endOrOpenTestToolStripMenuItem
            // 
            this.endOrOpenTestToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.endOrOpenTestToolStripMenuItem.Name = "endOrOpenTestToolStripMenuItem";
            this.endOrOpenTestToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.endOrOpenTestToolStripMenuItem.Text = "Закрыть для прохождения";
            this.endOrOpenTestToolStripMenuItem.Click += new System.EventHandler(this.endOrOpenTestToolStripMenuItem_Click);
            // 
            // deleteTestToolStripMenuItem
            // 
            this.deleteTestToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteTestToolStripMenuItem.Name = "deleteTestToolStripMenuItem";
            this.deleteTestToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.deleteTestToolStripMenuItem.Text = "Удалить тестирование";
            this.deleteTestToolStripMenuItem.Click += new System.EventHandler(this.deleteTestToolStripMenuItem_Click);
            // 
            // CustomDataGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.customDataGrid);
            this.Name = "CustomDataGridView";
            this.Size = new System.Drawing.Size(736, 392);
            ((System.ComponentModel.ISupportInitialize)(this.customDataGrid)).EndInit();
            this.teachersDataGridMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView customDataGrid;
        private System.Windows.Forms.ContextMenuStrip teachersDataGridMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem editTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem completeTestAsStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem endOrOpenTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteTestToolStripMenuItem;
    }
}
