namespace Calculadora_simples
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
            this.btnSOMA = new System.Windows.Forms.Button();
            this.btnDIVISAO = new System.Windows.Forms.Button();
            this.btnMULTIPLICACAO = new System.Windows.Forms.Button();
            this.btnSUBTRACAO = new System.Windows.Forms.Button();
            this.btnLIMPAR = new System.Windows.Forms.Button();
            this.btnSAIR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRESULTADO = new System.Windows.Forms.Label();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSOMA
            // 
            this.btnSOMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSOMA.Location = new System.Drawing.Point(363, 51);
            this.btnSOMA.Name = "btnSOMA";
            this.btnSOMA.Size = new System.Drawing.Size(122, 60);
            this.btnSOMA.TabIndex = 0;
            this.btnSOMA.Text = "SOMA";
            this.btnSOMA.UseVisualStyleBackColor = true;
            this.btnSOMA.Click += new System.EventHandler(this.btnSOMA_Click);
            // 
            // btnDIVISAO
            // 
            this.btnDIVISAO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDIVISAO.Location = new System.Drawing.Point(363, 278);
            this.btnDIVISAO.Name = "btnDIVISAO";
            this.btnDIVISAO.Size = new System.Drawing.Size(122, 60);
            this.btnDIVISAO.TabIndex = 1;
            this.btnDIVISAO.Text = "DIVISÃO";
            this.btnDIVISAO.UseVisualStyleBackColor = true;
            this.btnDIVISAO.Click += new System.EventHandler(this.btnDIVISAO_Click);
            // 
            // btnMULTIPLICACAO
            // 
            this.btnMULTIPLICACAO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMULTIPLICACAO.Location = new System.Drawing.Point(363, 203);
            this.btnMULTIPLICACAO.Name = "btnMULTIPLICACAO";
            this.btnMULTIPLICACAO.Size = new System.Drawing.Size(122, 60);
            this.btnMULTIPLICACAO.TabIndex = 2;
            this.btnMULTIPLICACAO.Text = "MULTIPLICAÇÃO";
            this.btnMULTIPLICACAO.UseVisualStyleBackColor = true;
            this.btnMULTIPLICACAO.Click += new System.EventHandler(this.btnMULTIPLICACAO_Click);
            // 
            // btnSUBTRACAO
            // 
            this.btnSUBTRACAO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSUBTRACAO.Location = new System.Drawing.Point(363, 127);
            this.btnSUBTRACAO.Name = "btnSUBTRACAO";
            this.btnSUBTRACAO.Size = new System.Drawing.Size(122, 60);
            this.btnSUBTRACAO.TabIndex = 3;
            this.btnSUBTRACAO.Text = "SUBTRAÇÃO";
            this.btnSUBTRACAO.UseVisualStyleBackColor = true;
            this.btnSUBTRACAO.Click += new System.EventHandler(this.btnSUBTRACAO_Click);
            // 
            // btnLIMPAR
            // 
            this.btnLIMPAR.Location = new System.Drawing.Point(40, 301);
            this.btnLIMPAR.Name = "btnLIMPAR";
            this.btnLIMPAR.Size = new System.Drawing.Size(95, 34);
            this.btnLIMPAR.TabIndex = 4;
            this.btnLIMPAR.Text = "LIMPAR";
            this.btnLIMPAR.UseVisualStyleBackColor = true;
            this.btnLIMPAR.Click += new System.EventHandler(this.btnLIMPAR_Click);
            // 
            // btnSAIR
            // 
            this.btnSAIR.Location = new System.Drawing.Point(202, 300);
            this.btnSAIR.Name = "btnSAIR";
            this.btnSAIR.Size = new System.Drawing.Size(95, 37);
            this.btnSAIR.TabIndex = 5;
            this.btnSAIR.Text = "SAIR";
            this.btnSAIR.UseVisualStyleBackColor = true;
            this.btnSAIR.Click += new System.EventHandler(this.btnSAIR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(50, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "1º NÚMERO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(50, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "2º NÚMERO:";
            // 
            // lblRESULTADO
            // 
            this.lblRESULTADO.AutoSize = true;
            this.lblRESULTADO.BackColor = System.Drawing.Color.Silver;
            this.lblRESULTADO.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRESULTADO.ForeColor = System.Drawing.Color.Black;
            this.lblRESULTADO.Location = new System.Drawing.Point(124, 203);
            this.lblRESULTADO.Name = "lblRESULTADO";
            this.lblRESULTADO.Size = new System.Drawing.Size(28, 32);
            this.lblRESULTADO.TabIndex = 8;
            this.lblRESULTADO.Text = "0";
            this.lblRESULTADO.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(140, 56);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(72, 23);
            this.txtN1.TabIndex = 9;
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(140, 108);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(72, 23);
            this.txtN2.TabIndex = 10;
            this.txtN2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 369);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.lblRESULTADO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSAIR);
            this.Controls.Add(this.btnLIMPAR);
            this.Controls.Add(this.btnSUBTRACAO);
            this.Controls.Add(this.btnMULTIPLICACAO);
            this.Controls.Add(this.btnDIVISAO);
            this.Controls.Add(this.btnSOMA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSOMA;
        private Button btnDIVISAO;
        private Button btnMULTIPLICACAO;
        private Button btnSUBTRACAO;
        private Button btnLIMPAR;
        private Button btnSAIR;
        private Label label1;
        private Label label2;
        private Label lblRESULTADO;
        private TextBox txtN1;
        private TextBox txtN2;
    }
}