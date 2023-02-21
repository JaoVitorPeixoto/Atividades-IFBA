namespace LISTA3_LP
{
    partial class Forms_QUESTAO2
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
            this.txtNums = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNums
            // 
            this.txtNums.Enabled = false;
            this.txtNums.Location = new System.Drawing.Point(12, 40);
            this.txtNums.Multiline = true;
            this.txtNums.Name = "txtNums";
            this.txtNums.Size = new System.Drawing.Size(310, 184);
            this.txtNums.TabIndex = 0;
            // 
            // Forms_QUESTAO2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 237);
            this.Controls.Add(this.txtNums);
            this.MaximizeBox = false;
            this.Name = "Forms_QUESTAO2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtPrimNum;
        private TextBox txtPrimoNum;
        private TextBox txtNums;
    }
}