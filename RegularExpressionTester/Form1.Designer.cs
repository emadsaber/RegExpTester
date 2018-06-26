namespace RegularExpressionTester
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
            this.txtString = new System.Windows.Forms.TextBox();
            this.txtPattern = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResultLog = new System.Windows.Forms.TextBox();
            this.lblResultColor = new System.Windows.Forms.Label();
            this.btnShowLog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtString
            // 
            this.txtString.Location = new System.Drawing.Point(67, 14);
            this.txtString.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtString.Multiline = true;
            this.txtString.Name = "txtString";
            this.txtString.Size = new System.Drawing.Size(353, 109);
            this.txtString.TabIndex = 1;
            this.txtString.TextChanged += new System.EventHandler(this.txtString_TextChanged);
            // 
            // txtPattern
            // 
            this.txtPattern.Location = new System.Drawing.Point(67, 142);
            this.txtPattern.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPattern.Multiline = true;
            this.txtPattern.Name = "txtPattern";
            this.txtPattern.Size = new System.Drawing.Size(353, 109);
            this.txtPattern.TabIndex = 1;
            this.txtPattern.TextChanged += new System.EventHandler(this.txtPattern_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "String";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 147);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pattern";
            // 
            // txtResultLog
            // 
            this.txtResultLog.Location = new System.Drawing.Point(452, 14);
            this.txtResultLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtResultLog.Multiline = true;
            this.txtResultLog.Name = "txtResultLog";
            this.txtResultLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultLog.Size = new System.Drawing.Size(273, 237);
            this.txtResultLog.TabIndex = 1;
            // 
            // lblResultColor
            // 
            this.lblResultColor.BackColor = System.Drawing.Color.Gray;
            this.lblResultColor.Location = new System.Drawing.Point(67, 116);
            this.lblResultColor.Name = "lblResultColor";
            this.lblResultColor.Size = new System.Drawing.Size(353, 36);
            this.lblResultColor.TabIndex = 3;
            // 
            // btnShowLog
            // 
            this.btnShowLog.Location = new System.Drawing.Point(423, 14);
            this.btnShowLog.Name = "btnShowLog";
            this.btnShowLog.Size = new System.Drawing.Size(25, 237);
            this.btnShowLog.TabIndex = 4;
            this.btnShowLog.Text = ">>";
            this.btnShowLog.UseVisualStyleBackColor = true;
            this.btnShowLog.Click += new System.EventHandler(this.btnShowLog_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 273);
            this.Controls.Add(this.btnShowLog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResultLog);
            this.Controls.Add(this.txtPattern);
            this.Controls.Add(this.txtString);
            this.Controls.Add(this.lblResultColor);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Regular Expression Tester";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtString;
        private System.Windows.Forms.TextBox txtPattern;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResultLog;
        private System.Windows.Forms.Label lblResultColor;
        private System.Windows.Forms.Button btnShowLog;
    }
}

