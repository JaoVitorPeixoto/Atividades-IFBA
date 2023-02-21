namespace LISTA3_LP
{

    partial class Forms_QUESTAO1

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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNUM = new System.Windows.Forms.TextBox();
            this.btnFATORIAL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "INFORME UM NÚMERO PARA SABER SEU FATORIAL:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtNUM
            // 
            this.txtNUM.Location = new System.Drawing.Point(151, 85);
            this.txtNUM.Name = "txtNUM";
            this.txtNUM.Size = new System.Drawing.Size(57, 23);
            this.txtNUM.TabIndex = 1;
            // 
            // btnFATORIAL
            // 
            this.btnFATORIAL.Location = new System.Drawing.Point(129, 162);
            this.btnFATORIAL.Name = "btnFATORIAL";
            this.btnFATORIAL.Size = new System.Drawing.Size(100, 53);
            this.btnFATORIAL.TabIndex = 2;
            this.btnFATORIAL.Text = "VER FATORIAL";
            this.btnFATORIAL.UseVisualStyleBackColor = true;
            this.btnFATORIAL.Click += new System.EventHandler(this.btnFATORIAL_Click);
            // 
            // Forms_QUESTAO1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 227);
            this.Controls.Add(this.btnFATORIAL);
            this.Controls.Add(this.txtNUM);
            this.Controls.Add(this.label1);
            this.Name = "Forms_QUESTAO1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtNUM;
        private Button btnFATORIAL;
    }
}