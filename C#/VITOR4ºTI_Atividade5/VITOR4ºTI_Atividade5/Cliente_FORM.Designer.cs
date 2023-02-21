namespace VITOR4ºTI_Atividade5
{
    partial class Cliente_FORM
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVOLTAR = new System.Windows.Forms.Button();
            this.btnCADASTRAR = new System.Windows.Forms.Button();
            this.mskTELEFONE = new System.Windows.Forms.MaskedTextBox();
            this.nmcIDADE = new System.Windows.Forms.NumericUpDown();
            this.txtNOME = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmcIDADE)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnVOLTAR);
            this.panel1.Controls.Add(this.btnCADASTRAR);
            this.panel1.Controls.Add(this.mskTELEFONE);
            this.panel1.Controls.Add(this.nmcIDADE);
            this.panel1.Controls.Add(this.txtNOME);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 296);
            this.panel1.TabIndex = 0;
            // 
            // btnVOLTAR
            // 
            this.btnVOLTAR.Location = new System.Drawing.Point(269, 244);
            this.btnVOLTAR.Name = "btnVOLTAR";
            this.btnVOLTAR.Size = new System.Drawing.Size(134, 29);
            this.btnVOLTAR.TabIndex = 7;
            this.btnVOLTAR.Text = "Voltar";
            this.btnVOLTAR.UseVisualStyleBackColor = true;
            this.btnVOLTAR.Click += new System.EventHandler(this.btnVOLTAR_Click);
            // 
            // btnCADASTRAR
            // 
            this.btnCADASTRAR.Location = new System.Drawing.Point(36, 244);
            this.btnCADASTRAR.Name = "btnCADASTRAR";
            this.btnCADASTRAR.Size = new System.Drawing.Size(134, 29);
            this.btnCADASTRAR.TabIndex = 6;
            this.btnCADASTRAR.Text = "Cadastrar";
            this.btnCADASTRAR.UseVisualStyleBackColor = true;
            this.btnCADASTRAR.Click += new System.EventHandler(this.btnCADASTRAR_Click);
            // 
            // mskTELEFONE
            // 
            this.mskTELEFONE.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mskTELEFONE.Location = new System.Drawing.Point(167, 158);
            this.mskTELEFONE.Mask = "(99) 90000-0000";
            this.mskTELEFONE.Name = "mskTELEFONE";
            this.mskTELEFONE.Size = new System.Drawing.Size(111, 27);
            this.mskTELEFONE.TabIndex = 5;
            // 
            // nmcIDADE
            // 
            this.nmcIDADE.Location = new System.Drawing.Point(201, 99);
            this.nmcIDADE.Name = "nmcIDADE";
            this.nmcIDADE.Size = new System.Drawing.Size(41, 23);
            this.nmcIDADE.TabIndex = 4;
            // 
            // txtNOME
            // 
            this.txtNOME.Location = new System.Drawing.Point(129, 38);
            this.txtNOME.Name = "txtNOME";
            this.txtNOME.Size = new System.Drawing.Size(186, 23);
            this.txtNOME.TabIndex = 3;
            this.txtNOME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Idade:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // Cliente_FORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 320);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Cliente_FORM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmcIDADE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btnVOLTAR;
        private Button btnCADASTRAR;
        private MaskedTextBox mskTELEFONE;
        private NumericUpDown nmcIDADE;
        private TextBox txtNOME;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}