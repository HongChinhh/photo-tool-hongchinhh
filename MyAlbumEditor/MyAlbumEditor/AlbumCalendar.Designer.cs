﻿namespace MyAlbumEditor
{
    partial class AlbumCalendar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.calDate = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // calDate
            // 
            this.calDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calDate.Location = new System.Drawing.Point(0, 0);
            this.calDate.MaxSelectionCount = 1;
            this.calDate.Name = "calDate";
            this.calDate.ShowToday = false;
            this.calDate.TabIndex = 0;
            this.calDate.MouseDown += new System.Windows.Forms.MouseEventHandler(this.calDate_MouseDown);
            // 
            // AlbumCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.calDate);
            this.Name = "AlbumCalendar";
            this.Size = new System.Drawing.Size(299, 168);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar calDate;
    }
}
