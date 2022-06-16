
namespace Draw_line
{
    partial class Circle
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
            this.draw = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.xCenterTxt = new System.Windows.Forms.TextBox();
            this.radiusTxt = new System.Windows.Forms.TextBox();
            this.yCenterTxt = new System.Windows.Forms.TextBox();
            this.xCenter = new System.Windows.Forms.Label();
            this.yCenter = new System.Windows.Forms.Label();
            this.radius = new System.Windows.Forms.Label();
            this.drawEllipse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.yRadiusTxt = new System.Windows.Forms.TextBox();
            this.xRadius = new System.Windows.Forms.Label();
            this.xRadiusTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // draw
            // 
            this.draw.Location = new System.Drawing.Point(115, 293);
            this.draw.Name = "draw";
            this.draw.Size = new System.Drawing.Size(75, 40);
            this.draw.TabIndex = 0;
            this.draw.Text = "Draw circle";
            this.draw.UseVisualStyleBackColor = true;
            this.draw.Click += new System.EventHandler(this.draw_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(235, 559);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 38);
            this.clear.TabIndex = 1;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(537, 12);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(2);
            this.panel2.Size = new System.Drawing.Size(600, 600);
            this.panel2.TabIndex = 16;
            // 
            // xCenterTxt
            // 
            this.xCenterTxt.Location = new System.Drawing.Point(115, 227);
            this.xCenterTxt.Name = "xCenterTxt";
            this.xCenterTxt.Size = new System.Drawing.Size(100, 20);
            this.xCenterTxt.TabIndex = 17;
            // 
            // radiusTxt
            // 
            this.radiusTxt.Location = new System.Drawing.Point(396, 227);
            this.radiusTxt.Name = "radiusTxt";
            this.radiusTxt.Size = new System.Drawing.Size(100, 20);
            this.radiusTxt.TabIndex = 18;
            // 
            // yCenterTxt
            // 
            this.yCenterTxt.Location = new System.Drawing.Point(248, 227);
            this.yCenterTxt.Name = "yCenterTxt";
            this.yCenterTxt.Size = new System.Drawing.Size(100, 20);
            this.yCenterTxt.TabIndex = 19;
            // 
            // xCenter
            // 
            this.xCenter.AutoSize = true;
            this.xCenter.Location = new System.Drawing.Point(112, 198);
            this.xCenter.Name = "xCenter";
            this.xCenter.Size = new System.Drawing.Size(43, 13);
            this.xCenter.TabIndex = 20;
            this.xCenter.Text = "xCenter";
            // 
            // yCenter
            // 
            this.yCenter.AutoSize = true;
            this.yCenter.Location = new System.Drawing.Point(245, 198);
            this.yCenter.Name = "yCenter";
            this.yCenter.Size = new System.Drawing.Size(43, 13);
            this.yCenter.TabIndex = 21;
            this.yCenter.Text = "yCenter";
            // 
            // radius
            // 
            this.radius.AutoSize = true;
            this.radius.Location = new System.Drawing.Point(393, 198);
            this.radius.Name = "radius";
            this.radius.Size = new System.Drawing.Size(40, 13);
            this.radius.TabIndex = 22;
            this.radius.Text = "Radius";
            // 
            // drawEllipse
            // 
            this.drawEllipse.Location = new System.Drawing.Point(115, 435);
            this.drawEllipse.Name = "drawEllipse";
            this.drawEllipse.Size = new System.Drawing.Size(75, 40);
            this.drawEllipse.TabIndex = 23;
            this.drawEllipse.Text = "Draw ellipse";
            this.drawEllipse.UseVisualStyleBackColor = true;
            this.drawEllipse.Click += new System.EventHandler(this.drawEllipse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Y Radius";
            // 
            // yRadiusTxt
            // 
            this.yRadiusTxt.Location = new System.Drawing.Point(248, 390);
            this.yRadiusTxt.Name = "yRadiusTxt";
            this.yRadiusTxt.Size = new System.Drawing.Size(100, 20);
            this.yRadiusTxt.TabIndex = 36;
            // 
            // xRadius
            // 
            this.xRadius.AutoSize = true;
            this.xRadius.Location = new System.Drawing.Point(115, 363);
            this.xRadius.Name = "xRadius";
            this.xRadius.Size = new System.Drawing.Size(50, 13);
            this.xRadius.TabIndex = 35;
            this.xRadius.Text = "X Radius";
            // 
            // xRadiusTxt
            // 
            this.xRadiusTxt.Location = new System.Drawing.Point(115, 390);
            this.xRadiusTxt.Name = "xRadiusTxt";
            this.xRadiusTxt.Size = new System.Drawing.Size(100, 20);
            this.xRadiusTxt.TabIndex = 34;
            // 
            // Circle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1190, 676);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yRadiusTxt);
            this.Controls.Add(this.xRadius);
            this.Controls.Add(this.xRadiusTxt);
            this.Controls.Add(this.drawEllipse);
            this.Controls.Add(this.radius);
            this.Controls.Add(this.yCenter);
            this.Controls.Add(this.xCenter);
            this.Controls.Add(this.yCenterTxt);
            this.Controls.Add(this.radiusTxt);
            this.Controls.Add(this.xCenterTxt);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.draw);
            this.Name = "Circle";
            this.Text = "Circle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button draw;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox xCenterTxt;
        private System.Windows.Forms.TextBox radiusTxt;
        private System.Windows.Forms.TextBox yCenterTxt;
        private System.Windows.Forms.Label xCenter;
        private System.Windows.Forms.Label yCenter;
        private System.Windows.Forms.Label radius;
        private System.Windows.Forms.Button drawEllipse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox yRadiusTxt;
        private System.Windows.Forms.Label xRadius;
        private System.Windows.Forms.TextBox xRadiusTxt;
    }
}