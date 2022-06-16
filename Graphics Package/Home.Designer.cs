
namespace Draw_line
{
    partial class Home
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
            this.dda = new System.Windows.Forms.Button();
            this.bresenham = new System.Windows.Forms.Button();
            this.circle = new System.Windows.Forms.Button();
            this.ellipse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dda
            // 
            this.dda.Location = new System.Drawing.Point(36, 35);
            this.dda.Name = "dda";
            this.dda.Size = new System.Drawing.Size(106, 39);
            this.dda.TabIndex = 0;
            this.dda.Text = "Draw line with DDA";
            this.dda.UseVisualStyleBackColor = true;
            this.dda.Click += new System.EventHandler(this.dda_Click);
            // 
            // bresenham
            // 
            this.bresenham.Location = new System.Drawing.Point(159, 35);
            this.bresenham.Name = "bresenham";
            this.bresenham.Size = new System.Drawing.Size(106, 39);
            this.bresenham.TabIndex = 1;
            this.bresenham.Text = "Draw line with  Bresenham";
            this.bresenham.UseVisualStyleBackColor = true;
            this.bresenham.Click += new System.EventHandler(this.bresenham_Click);
            // 
            // circle
            // 
            this.circle.Location = new System.Drawing.Point(305, 35);
            this.circle.Name = "circle";
            this.circle.Size = new System.Drawing.Size(75, 39);
            this.circle.TabIndex = 2;
            this.circle.Text = "Draw circle";
            this.circle.UseVisualStyleBackColor = true;
            this.circle.Click += new System.EventHandler(this.circle_Click);
            // 
            // ellipse
            // 
            this.ellipse.Location = new System.Drawing.Point(436, 35);
            this.ellipse.Name = "ellipse";
            this.ellipse.Size = new System.Drawing.Size(75, 39);
            this.ellipse.TabIndex = 3;
            this.ellipse.Text = "button1";
            this.ellipse.UseVisualStyleBackColor = true;
            this.ellipse.Click += new System.EventHandler(this.ellipse_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ellipse);
            this.Controls.Add(this.circle);
            this.Controls.Add(this.bresenham);
            this.Controls.Add(this.dda);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dda;
        private System.Windows.Forms.Button bresenham;
        private System.Windows.Forms.Button circle;
        private System.Windows.Forms.Button ellipse;
    }
}