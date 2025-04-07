namespace guiTesting
{
    partial class Main
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
            txtInput = new TextBox();
            lblEnter = new Label();
            btnGenerate = new Button();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new Point(397, 109);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(173, 23);
            txtInput.TabIndex = 0;
            // 
            // lblEnter
            // 
            lblEnter.AutoSize = true;
            lblEnter.Location = new Point(226, 112);
            lblEnter.Name = "lblEnter";
            lblEnter.Size = new Size(94, 15);
            lblEnter.TabIndex = 1;
            lblEnter.Text = "Enter a number: ";
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(335, 192);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(142, 23);
            btnGenerate.TabIndex = 2;
            btnGenerate.Text = "Generate numbers";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += this.btnGenerate_Click;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);

            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGenerate);
            Controls.Add(lblEnter);
            Controls.Add(txtInput);
            Name = "Main";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput;
        private Label lblEnter;
        private Button btnGenerate;
    }
}
