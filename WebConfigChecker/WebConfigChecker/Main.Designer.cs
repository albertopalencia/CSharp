namespace WebConfigChecker
{
    partial class Main
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
            this.txtCheck = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.txtRegex = new System.Windows.Forms.TextBox();
            this.selectFileBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProjectFolder = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxErrorKeys = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtCheck
            // 
            this.txtCheck.Location = new System.Drawing.Point(105, 148);
            this.txtCheck.Name = "txtCheck";
            this.txtCheck.Size = new System.Drawing.Size(75, 23);
            this.txtCheck.TabIndex = 0;
            this.txtCheck.Text = "Check!!";
            this.txtCheck.UseVisualStyleBackColor = true;
            this.txtCheck.Click += new System.EventHandler(this.txtCheck_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(105, 22);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(100, 20);
            this.txtFilePath.TabIndex = 1;
            // 
            // txtRegex
            // 
            this.txtRegex.Location = new System.Drawing.Point(105, 48);
            this.txtRegex.Name = "txtRegex";
            this.txtRegex.Size = new System.Drawing.Size(100, 20);
            this.txtRegex.TabIndex = 2;
            this.txtRegex.Text = "ConfigurationHelper\\.GetConfiguration\\(\"([A-Za-z0-9]+)\"\\)";
            // 
            // selectFileBtn
            // 
            this.selectFileBtn.Location = new System.Drawing.Point(211, 20);
            this.selectFileBtn.Name = "selectFileBtn";
            this.selectFileBtn.Size = new System.Drawing.Size(23, 23);
            this.selectFileBtn.TabIndex = 3;
            this.selectFileBtn.Text = "...";
            this.selectFileBtn.UseVisualStyleBackColor = true;
            this.selectFileBtn.Click += new System.EventHandler(this.selectFileBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Path(web.config)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Regex";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Project Folder";
            // 
            // txtProjectFolder
            // 
            this.txtProjectFolder.Location = new System.Drawing.Point(105, 113);
            this.txtProjectFolder.Name = "txtProjectFolder";
            this.txtProjectFolder.Size = new System.Drawing.Size(100, 20);
            this.txtProjectFolder.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "This Regex works to this example: \r\nConfigurationHelper.GetConfiguration(\"MyKey\")" +
    "\r\n";
            // 
            // txtBoxErrorKeys
            // 
            this.txtBoxErrorKeys.Location = new System.Drawing.Point(15, 200);
            this.txtBoxErrorKeys.Multiline = true;
            this.txtBoxErrorKeys.Name = "txtBoxErrorKeys";
            this.txtBoxErrorKeys.ReadOnly = true;
            this.txtBoxErrorKeys.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxErrorKeys.Size = new System.Drawing.Size(313, 123);
            this.txtBoxErrorKeys.TabIndex = 10;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 335);
            this.Controls.Add(this.txtBoxErrorKeys);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtProjectFolder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectFileBtn);
            this.Controls.Add(this.txtRegex);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.txtCheck);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "WebConfig Checker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button txtCheck;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.TextBox txtRegex;
        private System.Windows.Forms.Button selectFileBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProjectFolder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxErrorKeys;
    }
}