namespace VITOR4ºTI_Atividade5
{
    partial class Cadastrar_Produto_FORM
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCADASTRAR = new System.Windows.Forms.Button();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.mskPRECO = new System.Windows.Forms.MaskedTextBox();
            this.dtpVALIDADE = new System.Windows.Forms.DateTimePicker();
            this.nmcESTOQUE = new System.Windows.Forms.NumericUpDown();
            this.txtDESCRICAO = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmcESTOQUE)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtDESCRICAO);
            this.panel1.Controls.Add(this.nmcESTOQUE);
            this.panel1.Controls.Add(this.dtpVALIDADE);
            this.panel1.Controls.Add(this.mskPRECO);
            this.panel1.Controls.Add(this.btnCANCELAR);
            this.panel1.Controls.Add(this.btnCADASTRAR);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 361);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Preço:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Estoque:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Validade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descrição:";
            // 
            // btnCADASTRAR
            // 
            this.btnCADASTRAR.Location = new System.Drawing.Point(44, 312);
            this.btnCADASTRAR.Name = "btnCADASTRAR";
            this.btnCADASTRAR.Size = new System.Drawing.Size(135, 28);
            this.btnCADASTRAR.TabIndex = 4;
            this.btnCADASTRAR.Text = "Cadastrar";
            this.btnCADASTRAR.UseVisualStyleBackColor = true;
            this.btnCADASTRAR.Click += new System.EventHandler(this.btnCADASTRAR_Click);
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.Location = new System.Drawing.Point(291, 312);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(135, 28);
            this.btnCANCELAR.TabIndex = 5;
            this.btnCANCELAR.Text = "Cancelar";
            this.btnCANCELAR.UseVisualStyleBackColor = true;
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click);
            // 
            // mskPRECO
            // 
            this.mskPRECO.Location = new System.Drawing.Point(160, 38);
            this.mskPRECO.Mask = "$000,000.00";
            this.mskPRECO.Name = "mskPRECO";
            this.mskPRECO.PromptChar = '0';
            this.mskPRECO.Size = new System.Drawing.Size(146, 23);
            this.mskPRECO.TabIndex = 6;
            // 
            // dtpVALIDADE
            // 
            this.dtpVALIDADE.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVALIDADE.Location = new System.Drawing.Point(160, 141);
            this.dtpVALIDADE.Name = "dtpVALIDADE";
            this.dtpVALIDADE.Size = new System.Drawing.Size(146, 23);
            this.dtpVALIDADE.TabIndex = 7;
            // 
            // nmcESTOQUE
            // 
            this.nmcESTOQUE.Location = new System.Drawing.Point(160, 95);
            this.nmcESTOQUE.Name = "nmcESTOQUE";
            this.nmcESTOQUE.Size = new System.Drawing.Size(146, 23);
            this.nmcESTOQUE.TabIndex = 8;
            // 
            // txtDESCRICAO
            // 
            this.txtDESCRICAO.Location = new System.Drawing.Point(160, 195);
            this.txtDESCRICAO.Multiline = true;
            this.txtDESCRICAO.Name = "txtDESCRICAO";
            this.txtDESCRICAO.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDESCRICAO.Size = new System.Drawing.Size(203, 74);
            this.txtDESCRICAO.TabIndex = 9;
            // 
            // Cadastrar_Produto_FORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 385);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Cadastrar_Produto_FORM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Produto";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmcESTOQUE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TextBox txtDESCRICAO;
        private NumericUpDown nmcESTOQUE;
        private DateTimePicker dtpVALIDADE;
        private MaskedTextBox mskPRECO;
        private Button btnCANCELAR;
        private Button btnCADASTRAR;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}