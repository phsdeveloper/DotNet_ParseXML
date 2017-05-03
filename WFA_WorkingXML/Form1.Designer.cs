namespace WFA_WorkingXML
{
    partial class Form1
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
            this.txt_saida = new System.Windows.Forms.TextBox();
            this.cbo_Arquivos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_TipoLeitura = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_executarCodigo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_saida
            // 
            this.txt_saida.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_saida.Location = new System.Drawing.Point(13, 81);
            this.txt_saida.Multiline = true;
            this.txt_saida.Name = "txt_saida";
            this.txt_saida.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_saida.Size = new System.Drawing.Size(774, 315);
            this.txt_saida.TabIndex = 3;
            // 
            // cbo_Arquivos
            // 
            this.cbo_Arquivos.FormattingEnabled = true;
            this.cbo_Arquivos.Location = new System.Drawing.Point(84, 45);
            this.cbo_Arquivos.Name = "cbo_Arquivos";
            this.cbo_Arquivos.Size = new System.Drawing.Size(369, 21);
            this.cbo_Arquivos.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Arquivo";
            // 
            // cbo_TipoLeitura
            // 
            this.cbo_TipoLeitura.FormattingEnabled = true;
            this.cbo_TipoLeitura.Location = new System.Drawing.Point(84, 12);
            this.cbo_TipoLeitura.Name = "cbo_TipoLeitura";
            this.cbo_TipoLeitura.Size = new System.Drawing.Size(369, 21);
            this.cbo_TipoLeitura.TabIndex = 5;
            this.cbo_TipoLeitura.SelectedIndexChanged += new System.EventHandler(this.cbo_TipoLeitura_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tipo leitura";
            // 
            // btn_executarCodigo
            // 
            this.btn_executarCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_executarCodigo.Location = new System.Drawing.Point(677, 402);
            this.btn_executarCodigo.Name = "btn_executarCodigo";
            this.btn_executarCodigo.Size = new System.Drawing.Size(110, 23);
            this.btn_executarCodigo.TabIndex = 7;
            this.btn_executarCodigo.Text = "Executar Codigo";
            this.btn_executarCodigo.UseVisualStyleBackColor = true;
            this.btn_executarCodigo.Click += new System.EventHandler(this.btn_executarCodigo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 437);
            this.Controls.Add(this.btn_executarCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo_TipoLeitura);
            this.Controls.Add(this.cbo_Arquivos);
            this.Controls.Add(this.txt_saida);
            this.Name = "Form1";
            this.Text = "Working XML";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_saida;
        private System.Windows.Forms.ComboBox cbo_Arquivos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_TipoLeitura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_executarCodigo;
    }
}

