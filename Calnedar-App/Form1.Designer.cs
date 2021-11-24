
namespace Calnedar_App
{
    partial class Form1
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
            this.daycontainer = new System.Windows.Forms.FlowLayoutPanel();
            this.button_Previous = new System.Windows.Forms.Button();
            this.button_next = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel_top = new System.Windows.Forms.Panel();
            this.button_exit = new System.Windows.Forms.Button();
            this.LBDate = new System.Windows.Forms.Label();
            this.panel_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // daycontainer
            // 
            this.daycontainer.Location = new System.Drawing.Point(12, 156);
            this.daycontainer.Name = "daycontainer";
            this.daycontainer.Size = new System.Drawing.Size(1247, 577);
            this.daycontainer.TabIndex = 0;
            // 
            // button_Previous
            // 
            this.button_Previous.Location = new System.Drawing.Point(1064, 774);
            this.button_Previous.Name = "button_Previous";
            this.button_Previous.Size = new System.Drawing.Size(75, 23);
            this.button_Previous.TabIndex = 1;
            this.button_Previous.Text = "Previous";
            this.button_Previous.UseVisualStyleBackColor = true;
            this.button_Previous.Click += new System.EventHandler(this.button_Previous_Click);
            // 
            // button_next
            // 
            this.button_next.Location = new System.Drawing.Point(1165, 774);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(75, 23);
            this.button_next.TabIndex = 2;
            this.button_next.Text = "Next";
            this.button_next.UseVisualStyleBackColor = true;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sunday";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(230, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Monday";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(563, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Wednesday";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(406, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tuesday";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(938, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Friday";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(748, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "Thursday";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1095, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 23);
            this.label7.TabIndex = 9;
            this.label7.Text = "Saturday";
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.Black;
            this.panel_top.Controls.Add(this.button_exit);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(1274, 31);
            this.panel_top.TabIndex = 10;
            // 
            // button_exit
            // 
            this.button_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_exit.BackColor = System.Drawing.Color.Transparent;
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.ForeColor = System.Drawing.Color.White;
            this.button_exit.Location = new System.Drawing.Point(1238, 0);
            this.button_exit.Margin = new System.Windows.Forms.Padding(4);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(36, 31);
            this.button_exit.TabIndex = 1;
            this.button_exit.Text = "X";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // LBDate
            // 
            this.LBDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LBDate.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBDate.Location = new System.Drawing.Point(335, 46);
            this.LBDate.Name = "LBDate";
            this.LBDate.Size = new System.Drawing.Size(586, 40);
            this.LBDate.TabIndex = 11;
            this.LBDate.Text = "MONTH YEAR";
            this.LBDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBDate.Click += new System.EventHandler(this.LBDate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 828);
            this.Controls.Add(this.LBDate);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.button_Previous);
            this.Controls.Add(this.daycontainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calendar_Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_top.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel daycontainer;
        private System.Windows.Forms.Button button_Previous;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Label LBDate;
    }
}

