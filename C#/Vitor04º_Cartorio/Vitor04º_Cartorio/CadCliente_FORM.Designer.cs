
namespace Vitor04º_Cartorio
{
    partial class CadCliente_FORM
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNOME = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtENDERECO = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mskTELEFONE = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDATA_ADD = new System.Windows.Forms.TextBox();
            this.btnLIMPAR = new System.Windows.Forms.Button();
            this.btnCADASTRAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(41, 47);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(56, 25);
            this.txtID.TabIndex = 3;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID:";
            // 
            // txtNOME
            // 
            this.txtNOME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNOME.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNOME.Location = new System.Drawing.Point(117, 47);
            this.txtNOME.Name = "txtNOME";
            this.txtNOME.Size = new System.Drawing.Size(266, 25);
            this.txtNOME.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome:";
            // 
            // mskCPF
            // 
            this.mskCPF.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.mskCPF.Location = new System.Drawing.Point(404, 47);
            this.mskCPF.Mask = "000,000,000-00";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(103, 25);
            this.mskCPF.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(401, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "CPF:";
            // 
            // txtENDERECO
            // 
            this.txtENDERECO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtENDERECO.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtENDERECO.Location = new System.Drawing.Point(41, 114);
            this.txtENDERECO.Name = "txtENDERECO";
            this.txtENDERECO.Size = new System.Drawing.Size(342, 25);
            this.txtENDERECO.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Endereço:";
            // 
            // mskTELEFONE
            // 
            this.mskTELEFONE.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.mskTELEFONE.Location = new System.Drawing.Point(404, 113);
            this.mskTELEFONE.Mask = "(00) 90000-0000";
            this.mskTELEFONE.Name = "mskTELEFONE";
            this.mskTELEFONE.Size = new System.Drawing.Size(103, 25);
            this.mskTELEFONE.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(400, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Telefone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Data adicionado:";
            // 
            // txtDATA_ADD
            // 
            this.txtDATA_ADD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtDATA_ADD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDATA_ADD.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDATA_ADD.Location = new System.Drawing.Point(41, 185);
            this.txtDATA_ADD.Name = "txtDATA_ADD";
            this.txtDATA_ADD.ReadOnly = true;
            this.txtDATA_ADD.Size = new System.Drawing.Size(134, 25);
            this.txtDATA_ADD.TabIndex = 13;
            this.txtDATA_ADD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLIMPAR
            // 
            this.btnLIMPAR.BackColor = System.Drawing.Color.White;
            this.btnLIMPAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLIMPAR.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLIMPAR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLIMPAR.Location = new System.Drawing.Point(238, 184);
            this.btnLIMPAR.Name = "btnLIMPAR";
            this.btnLIMPAR.Size = new System.Drawing.Size(125, 26);
            this.btnLIMPAR.TabIndex = 17;
            this.btnLIMPAR.Text = "Limpar";
            this.btnLIMPAR.UseVisualStyleBackColor = false;
            this.btnLIMPAR.Click += new System.EventHandler(this.btnLIMPAR_Click);
            // 
            // btnCADASTRAR
            // 
            this.btnCADASTRAR.BackColor = System.Drawing.Color.ForestGreen;
            this.btnCADASTRAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCADASTRAR.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCADASTRAR.ForeColor = System.Drawing.Color.White;
            this.btnCADASTRAR.Location = new System.Drawing.Point(382, 184);
            this.btnCADASTRAR.Name = "btnCADASTRAR";
            this.btnCADASTRAR.Size = new System.Drawing.Size(125, 26);
            this.btnCADASTRAR.TabIndex = 18;
            this.btnCADASTRAR.Text = "Cadastrar";
            this.btnCADASTRAR.UseVisualStyleBackColor = false;
            // 
            // CadCliente_FORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(537, 237);
            this.Controls.Add(this.btnCADASTRAR);
            this.Controls.Add(this.btnLIMPAR);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDATA_ADD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mskTELEFONE);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtENDERECO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mskCPF);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNOME);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadCliente_FORM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de cliente";
            this.Load += new System.EventHandler(this.CadCliente_FORM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNOME;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtENDERECO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mskTELEFONE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDATA_ADD;
        private System.Windows.Forms.Button btnLIMPAR;
        private System.Windows.Forms.Button btnCADASTRAR;
    }
}