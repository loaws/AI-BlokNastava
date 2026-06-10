namespace WinFormsApp2
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
            txtComment = new TextBox();
            btnAnalyze = new Button();
            lblResult = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtComment
            // 
            txtComment.Font = new Font("Segoe UI", 14.25F);
            txtComment.Location = new Point(110, 29);
            txtComment.Name = "txtComment";
            txtComment.Size = new Size(419, 33);
            txtComment.TabIndex = 0;
            // 
            // btnAnalyze
            // 
            btnAnalyze.Font = new Font("Segoe UI", 14.25F);
            btnAnalyze.Location = new Point(205, 81);
            btnAnalyze.Name = "btnAnalyze";
            btnAnalyze.Size = new Size(143, 40);
            btnAnalyze.TabIndex = 1;
            btnAnalyze.Text = "Analiziraj";
            btnAnalyze.UseVisualStyleBackColor = true;
            btnAnalyze.Click += btnAnalyze_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 14.25F);
            lblResult.Location = new Point(110, 147);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(79, 25);
            lblResult.TabIndex = 2;
            lblResult.Text = "Rezultat";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(155, 318);
            label1.Name = "label1";
            label1.Size = new Size(300, 45);
            label1.TabIndex = 3;
            label1.Text = "Zadatak iz Primenjenih Inforfmacionih Tehnologija\r\nTehnicka Dokumentacija i Uvod u vestacku intaligenciju\r\nAljosa Vukadinovic 6/11/2026";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 387);
            Controls.Add(label1);
            Controls.Add(lblResult);
            Controls.Add(btnAnalyze);
            Controls.Add(txtComment);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtComment;
        private Button btnAnalyze;
        private Label lblResult;
        private Label label1;
    }
}
