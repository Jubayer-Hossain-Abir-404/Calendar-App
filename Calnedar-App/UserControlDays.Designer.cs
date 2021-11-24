
namespace Calnedar_App
{
    partial class UserControlDays
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
            this.label_days = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_days
            // 
            this.label_days.AutoSize = true;
            this.label_days.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_days.Location = new System.Drawing.Point(73, 41);
            this.label_days.Name = "label_days";
            this.label_days.Size = new System.Drawing.Size(32, 23);
            this.label_days.TabIndex = 0;
            this.label_days.Text = "00";
            // 
            // UserControlDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(170, 108);
            this.Controls.Add(this.label_days);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserControlDays";
            this.Text = "UserControlDays";
            this.Load += new System.EventHandler(this.UserControlDays_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_days;
    }
}