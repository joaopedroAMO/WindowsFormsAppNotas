namespace WindowsFormsAppNotas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMedia = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMedia = new System.Windows.Forms.Button();
            this.txtNotaTres = new System.Windows.Forms.TextBox();
            this.txtNotaDois = new System.Windows.Forms.TextBox();
            this.txtNotaUm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSituasao = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSituasao = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMedia);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnMedia);
            this.groupBox1.Controls.Add(this.txtNotaTres);
            this.groupBox1.Controls.Add(this.txtNotaDois);
            this.groupBox1.Controls.Add(this.txtNotaUm);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(28, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 321);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Notas";
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedia.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblMedia.Location = new System.Drawing.Point(353, 271);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(24, 25);
            this.lblMedia.TabIndex = 8;
            this.lblMedia.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Média: ";
            // 
            // btnMedia
            // 
            this.btnMedia.Location = new System.Drawing.Point(166, 198);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(128, 41);
            this.btnMedia.TabIndex = 6;
            this.btnMedia.Text = "Calcular Média";
            this.btnMedia.UseVisualStyleBackColor = true;
            this.btnMedia.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // txtNotaTres
            // 
            this.txtNotaTres.Location = new System.Drawing.Point(86, 142);
            this.txtNotaTres.Name = "txtNotaTres";
            this.txtNotaTres.Size = new System.Drawing.Size(311, 22);
            this.txtNotaTres.TabIndex = 5;
            // 
            // txtNotaDois
            // 
            this.txtNotaDois.Location = new System.Drawing.Point(86, 93);
            this.txtNotaDois.Name = "txtNotaDois";
            this.txtNotaDois.Size = new System.Drawing.Size(311, 22);
            this.txtNotaDois.TabIndex = 4;
            // 
            // txtNotaUm
            // 
            this.txtNotaUm.Location = new System.Drawing.Point(86, 45);
            this.txtNotaUm.Name = "txtNotaUm";
            this.txtNotaUm.Size = new System.Drawing.Size(311, 22);
            this.txtNotaUm.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nota 3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nota 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nota 1";
            // 
            // btnSituasao
            // 
            this.btnSituasao.Location = new System.Drawing.Point(191, 386);
            this.btnSituasao.Name = "btnSituasao";
            this.btnSituasao.Size = new System.Drawing.Size(131, 46);
            this.btnSituasao.TabIndex = 1;
            this.btnSituasao.Text = "Verificar Situação";
            this.btnSituasao.UseVisualStyleBackColor = true;
            this.btnSituasao.Click += new System.EventHandler(this.btnSituasao_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 477);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Situação";
            // 
            // lblSituasao
            // 
            this.lblSituasao.AutoSize = true;
            this.lblSituasao.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSituasao.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblSituasao.Location = new System.Drawing.Point(189, 467);
            this.lblSituasao.Name = "lblSituasao";
            this.lblSituasao.Size = new System.Drawing.Size(142, 29);
            this.lblSituasao.TabIndex = 3;
            this.lblSituasao.Text = "SITUAÇÃO";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(83, 529);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(122, 47);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Novo Calculo";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(307, 529);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(118, 47);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Fechar";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 611);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblSituasao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSituasao);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMedia;
        private System.Windows.Forms.TextBox txtNotaTres;
        private System.Windows.Forms.TextBox txtNotaDois;
        private System.Windows.Forms.TextBox txtNotaUm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSituasao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSituasao;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnClose;
    }
}

