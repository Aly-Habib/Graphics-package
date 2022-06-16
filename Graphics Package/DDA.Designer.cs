
namespace Draw_line
{
    partial class DDALine
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.drawButton = new System.Windows.Forms.Button();
            this.x0Txt = new System.Windows.Forms.TextBox();
            this.y0Txt = new System.Windows.Forms.TextBox();
            this.xEndTxt = new System.Windows.Forms.TextBox();
            this.yEndTxt = new System.Windows.Forms.TextBox();
            this.x0Label = new System.Windows.Forms.Label();
            this.y0Label = new System.Windows.Forms.Label();
            this.xEndLabel = new System.Windows.Forms.Label();
            this.yEndLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(570, 2);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(2);
            this.panel2.Size = new System.Drawing.Size(600, 600);
            this.panel2.TabIndex = 1;
            // 
            // drawButton
            // 
            this.drawButton.Location = new System.Drawing.Point(286, 450);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(87, 33);
            this.drawButton.TabIndex = 2;
            this.drawButton.Text = "Draw";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.drawLine);
            // 
            // x0Txt
            // 
            this.x0Txt.Location = new System.Drawing.Point(115, 89);
            this.x0Txt.Name = "x0Txt";
            this.x0Txt.Size = new System.Drawing.Size(100, 20);
            this.x0Txt.TabIndex = 3;
            // 
            // y0Txt
            // 
            this.y0Txt.Location = new System.Drawing.Point(286, 89);
            this.y0Txt.Name = "y0Txt";
            this.y0Txt.Size = new System.Drawing.Size(100, 20);
            this.y0Txt.TabIndex = 4;
            // 
            // xEndTxt
            // 
            this.xEndTxt.Location = new System.Drawing.Point(115, 177);
            this.xEndTxt.Name = "xEndTxt";
            this.xEndTxt.Size = new System.Drawing.Size(100, 20);
            this.xEndTxt.TabIndex = 6;
            // 
            // yEndTxt
            // 
            this.yEndTxt.Location = new System.Drawing.Point(286, 177);
            this.yEndTxt.Name = "yEndTxt";
            this.yEndTxt.Size = new System.Drawing.Size(100, 20);
            this.yEndTxt.TabIndex = 7;
            // 
            // x0Label
            // 
            this.x0Label.AutoSize = true;
            this.x0Label.Location = new System.Drawing.Point(112, 62);
            this.x0Label.Name = "x0Label";
            this.x0Label.Size = new System.Drawing.Size(20, 13);
            this.x0Label.TabIndex = 8;
            this.x0Label.Text = "X0";
            // 
            // y0Label
            // 
            this.y0Label.AutoSize = true;
            this.y0Label.Location = new System.Drawing.Point(283, 62);
            this.y0Label.Name = "y0Label";
            this.y0Label.Size = new System.Drawing.Size(20, 13);
            this.y0Label.TabIndex = 9;
            this.y0Label.Text = "Y0";
            // 
            // xEndLabel
            // 
            this.xEndLabel.AutoSize = true;
            this.xEndLabel.Location = new System.Drawing.Point(112, 152);
            this.xEndLabel.Name = "xEndLabel";
            this.xEndLabel.Size = new System.Drawing.Size(36, 13);
            this.xEndLabel.TabIndex = 10;
            this.xEndLabel.Text = "X End";
            // 
            // yEndLabel
            // 
            this.yEndLabel.AutoSize = true;
            this.yEndLabel.Location = new System.Drawing.Point(283, 152);
            this.yEndLabel.Name = "yEndLabel";
            this.yEndLabel.Size = new System.Drawing.Size(36, 13);
            this.yEndLabel.TabIndex = 11;
            this.yEndLabel.Text = "Y End";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Point1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Point2";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(115, 450);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(87, 33);
            this.clearButton.TabIndex = 14;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // DDALine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1208, 664);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yEndLabel);
            this.Controls.Add(this.xEndLabel);
            this.Controls.Add(this.y0Label);
            this.Controls.Add(this.x0Label);
            this.Controls.Add(this.yEndTxt);
            this.Controls.Add(this.xEndTxt);
            this.Controls.Add(this.y0Txt);
            this.Controls.Add(this.x0Txt);
            this.Controls.Add(this.drawButton);
            this.Controls.Add(this.panel2);
            this.Name = "DDALine";
            this.Text = "Draw line using DDA ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.TextBox x0Txt;
        private System.Windows.Forms.TextBox y0Txt;
        private System.Windows.Forms.TextBox xEndTxt;
        private System.Windows.Forms.TextBox yEndTxt;
        private System.Windows.Forms.Label x0Label;
        private System.Windows.Forms.Label y0Label;
        private System.Windows.Forms.Label xEndLabel;
        private System.Windows.Forms.Label yEndLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clearButton;
    }
}

