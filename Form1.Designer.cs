namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnSete = new System.Windows.Forms.Button();
            this.btnOito = new System.Windows.Forms.Button();
            this.btnNove = new System.Windows.Forms.Button();
            this.btnQuatro = new System.Windows.Forms.Button();
            this.btnCinco = new System.Windows.Forms.Button();
            this.btnSeis = new System.Windows.Forms.Button();
            this.btnUm = new System.Windows.Forms.Button();
            this.btnDois = new System.Windows.Forms.Button();
            this.btnTres = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnPonto = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnDivisao = new System.Windows.Forms.Button();
            this.btnMultiplicacao = new System.Windows.Forms.Button();
            this.btnDiminuicao = new System.Windows.Forms.Button();
            this.btnAdicao = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.Color.White;
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(12, 12);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(272, 29);
            this.txtResultado.TabIndex = 0;
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSete
            // 
            this.btnSete.Location = new System.Drawing.Point(12, 98);
            this.btnSete.Name = "btnSete";
            this.btnSete.Size = new System.Drawing.Size(68, 49);
            this.btnSete.TabIndex = 1;
            this.btnSete.Text = "7";
            this.btnSete.UseVisualStyleBackColor = true;
            this.btnSete.Click += new System.EventHandler(this.btnSete_Click);
            // 
            // btnOito
            // 
            this.btnOito.Location = new System.Drawing.Point(80, 98);
            this.btnOito.Name = "btnOito";
            this.btnOito.Size = new System.Drawing.Size(68, 49);
            this.btnOito.TabIndex = 2;
            this.btnOito.Text = "8";
            this.btnOito.UseVisualStyleBackColor = true;
            this.btnOito.Click += new System.EventHandler(this.btnOito_Click);
            // 
            // btnNove
            // 
            this.btnNove.Location = new System.Drawing.Point(148, 98);
            this.btnNove.Name = "btnNove";
            this.btnNove.Size = new System.Drawing.Size(68, 49);
            this.btnNove.TabIndex = 3;
            this.btnNove.Text = "9";
            this.btnNove.UseVisualStyleBackColor = true;
            this.btnNove.Click += new System.EventHandler(this.btnNove_Click);
            // 
            // btnQuatro
            // 
            this.btnQuatro.Location = new System.Drawing.Point(12, 153);
            this.btnQuatro.Name = "btnQuatro";
            this.btnQuatro.Size = new System.Drawing.Size(68, 49);
            this.btnQuatro.TabIndex = 4;
            this.btnQuatro.Text = "4";
            this.btnQuatro.UseVisualStyleBackColor = true;
            this.btnQuatro.Click += new System.EventHandler(this.btnQuatro_Click);
            // 
            // btnCinco
            // 
            this.btnCinco.Location = new System.Drawing.Point(80, 153);
            this.btnCinco.Name = "btnCinco";
            this.btnCinco.Size = new System.Drawing.Size(68, 49);
            this.btnCinco.TabIndex = 5;
            this.btnCinco.Text = "5";
            this.btnCinco.UseVisualStyleBackColor = true;
            this.btnCinco.Click += new System.EventHandler(this.btnCinco_Click);
            // 
            // btnSeis
            // 
            this.btnSeis.Location = new System.Drawing.Point(148, 153);
            this.btnSeis.Name = "btnSeis";
            this.btnSeis.Size = new System.Drawing.Size(68, 49);
            this.btnSeis.TabIndex = 6;
            this.btnSeis.Text = "6";
            this.btnSeis.UseVisualStyleBackColor = true;
            this.btnSeis.Click += new System.EventHandler(this.btnSeis_Click);
            // 
            // btnUm
            // 
            this.btnUm.Location = new System.Drawing.Point(12, 209);
            this.btnUm.Name = "btnUm";
            this.btnUm.Size = new System.Drawing.Size(68, 49);
            this.btnUm.TabIndex = 7;
            this.btnUm.Text = "1";
            this.btnUm.UseVisualStyleBackColor = true;
            this.btnUm.Click += new System.EventHandler(this.btnUm_Click);
            // 
            // btnDois
            // 
            this.btnDois.Location = new System.Drawing.Point(80, 208);
            this.btnDois.Name = "btnDois";
            this.btnDois.Size = new System.Drawing.Size(68, 49);
            this.btnDois.TabIndex = 8;
            this.btnDois.Text = "2";
            this.btnDois.UseVisualStyleBackColor = true;
            this.btnDois.Click += new System.EventHandler(this.btnDois_Click);
            // 
            // btnTres
            // 
            this.btnTres.Location = new System.Drawing.Point(148, 209);
            this.btnTres.Name = "btnTres";
            this.btnTres.Size = new System.Drawing.Size(68, 49);
            this.btnTres.TabIndex = 9;
            this.btnTres.Text = "3";
            this.btnTres.UseVisualStyleBackColor = true;
            this.btnTres.Click += new System.EventHandler(this.btnTres_Click);
            // 
            // btnZero
            // 
            this.btnZero.Location = new System.Drawing.Point(80, 263);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(68, 49);
            this.btnZero.TabIndex = 10;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnPonto
            // 
            this.btnPonto.Location = new System.Drawing.Point(12, 264);
            this.btnPonto.Name = "btnPonto";
            this.btnPonto.Size = new System.Drawing.Size(68, 49);
            this.btnPonto.TabIndex = 11;
            this.btnPonto.Text = ".";
            this.btnPonto.UseVisualStyleBackColor = true;
            this.btnPonto.Click += new System.EventHandler(this.btnPonto_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.Location = new System.Drawing.Point(148, 263);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(68, 49);
            this.btnIgual.TabIndex = 12;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnDivisao
            // 
            this.btnDivisao.Location = new System.Drawing.Point(216, 98);
            this.btnDivisao.Name = "btnDivisao";
            this.btnDivisao.Size = new System.Drawing.Size(68, 49);
            this.btnDivisao.TabIndex = 14;
            this.btnDivisao.Text = "/";
            this.btnDivisao.UseVisualStyleBackColor = true;
            this.btnDivisao.Click += new System.EventHandler(this.btnDivisao_Click);
            // 
            // btnMultiplicacao
            // 
            this.btnMultiplicacao.Location = new System.Drawing.Point(216, 153);
            this.btnMultiplicacao.Name = "btnMultiplicacao";
            this.btnMultiplicacao.Size = new System.Drawing.Size(68, 49);
            this.btnMultiplicacao.TabIndex = 15;
            this.btnMultiplicacao.Text = "X";
            this.btnMultiplicacao.UseVisualStyleBackColor = true;
            this.btnMultiplicacao.Click += new System.EventHandler(this.btnMultiplicacao_Click);
            // 
            // btnDiminuicao
            // 
            this.btnDiminuicao.Location = new System.Drawing.Point(216, 209);
            this.btnDiminuicao.Name = "btnDiminuicao";
            this.btnDiminuicao.Size = new System.Drawing.Size(68, 49);
            this.btnDiminuicao.TabIndex = 16;
            this.btnDiminuicao.Text = "-";
            this.btnDiminuicao.UseVisualStyleBackColor = true;
            this.btnDiminuicao.Click += new System.EventHandler(this.btnDiminuicao_Click);
            // 
            // btnAdicao
            // 
            this.btnAdicao.Location = new System.Drawing.Point(216, 263);
            this.btnAdicao.Name = "btnAdicao";
            this.btnAdicao.Size = new System.Drawing.Size(68, 49);
            this.btnAdicao.TabIndex = 17;
            this.btnAdicao.Text = "+";
            this.btnAdicao.UseVisualStyleBackColor = true;
            this.btnAdicao.Click += new System.EventHandler(this.btnAdicao_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(216, 57);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(68, 35);
            this.btnLimpar.TabIndex = 18;
            this.btnLimpar.Text = "C";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 325);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAdicao);
            this.Controls.Add(this.btnDiminuicao);
            this.Controls.Add(this.btnMultiplicacao);
            this.Controls.Add(this.btnDivisao);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnPonto);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnTres);
            this.Controls.Add(this.btnDois);
            this.Controls.Add(this.btnUm);
            this.Controls.Add(this.btnSeis);
            this.Controls.Add(this.btnCinco);
            this.Controls.Add(this.btnQuatro);
            this.Controls.Add(this.btnNove);
            this.Controls.Add(this.btnOito);
            this.Controls.Add(this.btnSete);
            this.Controls.Add(this.txtResultado);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnSete;
        private System.Windows.Forms.Button btnOito;
        private System.Windows.Forms.Button btnNove;
        private System.Windows.Forms.Button btnQuatro;
        private System.Windows.Forms.Button btnCinco;
        private System.Windows.Forms.Button btnSeis;
        private System.Windows.Forms.Button btnUm;
        private System.Windows.Forms.Button btnDois;
        private System.Windows.Forms.Button btnTres;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnPonto;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnDivisao;
        private System.Windows.Forms.Button btnMultiplicacao;
        private System.Windows.Forms.Button btnDiminuicao;
        private System.Windows.Forms.Button btnAdicao;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label2;
    }
}

