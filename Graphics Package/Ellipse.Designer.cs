
namespace Draw_line
{
    partial class Ellipse
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
            this.xRadius = new System.Windows.Forms.Label();
            this.yCenter = new System.Windows.Forms.Label();
            this.xCenter = new System.Windows.Forms.Label();
            this.yCenterTxt = new System.Windows.Forms.TextBox();
            this.xRadiusTxt = new System.Windows.Forms.TextBox();
            this.xCenterTxt = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.clear = new System.Windows.Forms.Button();
            this.draw = new System.Windows.Forms.Button();
            this.yRadiusTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // xRadius
            // 
            this.xRadius.AutoSize = true;
            this.xRadius.Location = new System.Drawing.Point(86, 317);
            this.xRadius.Name = "xRadius";
            this.xRadius.Size = new System.Drawing.Size(50, 13);
            this.xRadius.TabIndex = 31;
            this.xRadius.Text = "X Radius";
            // 
            // yCenter
            // 
            this.yCenter.AutoSize = true;
            this.yCenter.Location = new System.Drawing.Point(216, 224);
            this.yCenter.Name = "yCenter";
            this.yCenter.Size = new System.Drawing.Size(43, 13);
            this.yCenter.TabIndex = 30;
            this.yCenter.Text = "yCenter";
            // 
            // xCenter
            // 
            this.xCenter.AutoSize = true;
            this.xCenter.Location = new System.Drawing.Point(83, 224);
            this.xCenter.Name = "xCenter";
            this.xCenter.Size = new System.Drawing.Size(43, 13);
            this.xCenter.TabIndex = 29;
            this.xCenter.Text = "xCenter";
            // 
            // yCenterTxt
            // 
            this.yCenterTxt.Location = new System.Drawing.Point(219, 253);
            this.yCenterTxt.Name = "yCenterTxt";
            this.yCenterTxt.Size = new System.Drawing.Size(100, 20);
            this.yCenterTxt.TabIndex = 28;
            // 
            // xRadiusTxt
            // 
            this.xRadiusTxt.Location = new System.Drawing.Point(86, 344);
            this.xRadiusTxt.Name = "xRadiusTxt";
            this.xRadiusTxt.Size = new System.Drawing.Size(100, 20);
            this.xRadiusTxt.TabIndex = 27;
            // 
            // xCenterTxt
            // 
            this.xCenterTxt.Location = new System.Drawing.Point(86, 253);
            this.xCenterTxt.Name = "xCenterTxt";
            this.xCenterTxt.Size = new System.Drawing.Size(100, 20);
            this.xCenterTxt.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(508, 38);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(2);
            this.panel2.Size = new System.Drawing.Size(600, 600);
            this.panel2.TabIndex = 25;
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(86, 553);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 24;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // draw
            // 
            this.draw.Location = new System.Drawing.Point(297, 553);
            this.draw.Name = "draw";
            this.draw.Size = new System.Drawing.Size(75, 23);
            this.draw.TabIndex = 23;
            this.draw.Text = "Draw ellipse";
            this.draw.UseVisualStyleBackColor = true;
            this.draw.Click += new System.EventHandler(this.draw_Click);
            // 
            // yRadiusTxt
            // 
            this.yRadiusTxt.Location = new System.Drawing.Point(219, 344);
            this.yRadiusTxt.Name = "yRadiusTxt";
            this.yRadiusTxt.Size = new System.Drawing.Size(100, 20);
            this.yRadiusTxt.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Y Radius";
            // 
            // Ellipse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 676);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yRadiusTxt);
            this.Controls.Add(this.xRadius);
            this.Controls.Add(this.yCenter);
            this.Controls.Add(this.xCenter);
            this.Controls.Add(this.yCenterTxt);
            this.Controls.Add(this.xRadiusTxt);
            this.Controls.Add(this.xCenterTxt);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.draw);
            this.Name = "Ellipse";
            this.Text = "Ellipse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label xRadius;
        private System.Windows.Forms.Label yCenter;
        private System.Windows.Forms.Label xCenter;
        private System.Windows.Forms.TextBox yCenterTxt;
        private System.Windows.Forms.TextBox xRadiusTxt;
        private System.Windows.Forms.TextBox xCenterTxt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button draw;
        private System.Windows.Forms.TextBox yRadiusTxt;
        private System.Windows.Forms.Label label1;
    }
}