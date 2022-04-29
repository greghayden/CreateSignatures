namespace CreateSignatures
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TitleLbl = new System.Windows.Forms.Label();
            this.ProcessBtn = new System.Windows.Forms.Button();
            this.InputFileTxt = new System.Windows.Forms.TextBox();
            this.OutputFileTxt = new System.Windows.Forms.TextBox();
            this.InputFileLbl = new System.Windows.Forms.Label();
            this.OutputFileLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitleLbl.Location = new System.Drawing.Point(48, 29);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(616, 39);
            this.TitleLbl.TabIndex = 0;
            this.TitleLbl.Text = "Select File to Convert Words to Signatures";
            // 
            // ProcessBtn
            // 
            this.ProcessBtn.Location = new System.Drawing.Point(48, 136);
            this.ProcessBtn.Name = "ProcessBtn";
            this.ProcessBtn.Size = new System.Drawing.Size(140, 51);
            this.ProcessBtn.TabIndex = 1;
            this.ProcessBtn.Text = "Select File";
            this.ProcessBtn.UseVisualStyleBackColor = true;
            this.ProcessBtn.Click += new System.EventHandler(this.ProcessBtn_Click);
            // 
            // InputFileTxt
            // 
            this.InputFileTxt.Location = new System.Drawing.Point(48, 264);
            this.InputFileTxt.Name = "InputFileTxt";
            this.InputFileTxt.Size = new System.Drawing.Size(850, 31);
            this.InputFileTxt.TabIndex = 2;
            // 
            // OutputFileTxt
            // 
            this.OutputFileTxt.Location = new System.Drawing.Point(48, 358);
            this.OutputFileTxt.Name = "OutputFileTxt";
            this.OutputFileTxt.Size = new System.Drawing.Size(850, 31);
            this.OutputFileTxt.TabIndex = 3;
            // 
            // InputFileLbl
            // 
            this.InputFileLbl.AutoSize = true;
            this.InputFileLbl.Location = new System.Drawing.Point(50, 236);
            this.InputFileLbl.Name = "InputFileLbl";
            this.InputFileLbl.Size = new System.Drawing.Size(85, 25);
            this.InputFileLbl.TabIndex = 4;
            this.InputFileLbl.Text = "Input File";
            // 
            // OutputFileLbl
            // 
            this.OutputFileLbl.AutoSize = true;
            this.OutputFileLbl.Location = new System.Drawing.Point(48, 330);
            this.OutputFileLbl.Name = "OutputFileLbl";
            this.OutputFileLbl.Size = new System.Drawing.Size(100, 25);
            this.OutputFileLbl.TabIndex = 5;
            this.OutputFileLbl.Text = "Output File";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 452);
            this.Controls.Add(this.OutputFileLbl);
            this.Controls.Add(this.InputFileLbl);
            this.Controls.Add(this.OutputFileTxt);
            this.Controls.Add(this.InputFileTxt);
            this.Controls.Add(this.ProcessBtn);
            this.Controls.Add(this.TitleLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label TitleLbl;
        private Button ProcessBtn;
        private TextBox InputFileTxt;
        private TextBox OutputFileTxt;
        private Label InputFileLbl;
        private Label OutputFileLbl;
    }
}