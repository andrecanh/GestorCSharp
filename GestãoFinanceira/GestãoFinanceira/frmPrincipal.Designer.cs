namespace GestãoFinanceira
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelHora = new System.Windows.Forms.Label();
            this.btnContato = new System.Windows.Forms.Button();
            this.labelData = new System.Windows.Forms.Label();
            this.btnCalcJuros = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.labelUsuarioConectado = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.labelHora);
            this.panel1.Controls.Add(this.btnContato);
            this.panel1.Controls.Add(this.labelData);
            this.panel1.Controls.Add(this.btnCalcJuros);
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.btnRelatorio);
            this.panel1.Controls.Add(this.btnCadastro);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 600);
            this.panel1.TabIndex = 1;
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.labelHora.Location = new System.Drawing.Point(113, 487);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(52, 19);
            this.labelHora.TabIndex = 3;
            this.labelHora.Text = "label2";
            // 
            // btnContato
            // 
            this.btnContato.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnContato.FlatAppearance.BorderSize = 0;
            this.btnContato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContato.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContato.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnContato.Image = global::GestãoFinanceira.Properties.Resources.Conact;
            this.btnContato.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnContato.Location = new System.Drawing.Point(0, 516);
            this.btnContato.Name = "btnContato";
            this.btnContato.Size = new System.Drawing.Size(186, 42);
            this.btnContato.TabIndex = 2;
            this.btnContato.Text = "Contato";
            this.btnContato.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnContato.UseVisualStyleBackColor = true;
            this.btnContato.Click += new System.EventHandler(this.btnContato_Click);
            this.btnContato.Leave += new System.EventHandler(this.btnContato_Leave);
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.labelData.Location = new System.Drawing.Point(17, 487);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(52, 19);
            this.labelData.TabIndex = 2;
            this.labelData.Text = "label1";
            // 
            // btnCalcJuros
            // 
            this.btnCalcJuros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCalcJuros.FlatAppearance.BorderSize = 0;
            this.btnCalcJuros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcJuros.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcJuros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnCalcJuros.Image = global::GestãoFinanceira.Properties.Resources.calc;
            this.btnCalcJuros.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCalcJuros.Location = new System.Drawing.Point(0, 228);
            this.btnCalcJuros.Name = "btnCalcJuros";
            this.btnCalcJuros.Size = new System.Drawing.Size(186, 42);
            this.btnCalcJuros.TabIndex = 2;
            this.btnCalcJuros.Text = "Calcula Juros";
            this.btnCalcJuros.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCalcJuros.UseVisualStyleBackColor = true;
            this.btnCalcJuros.Click += new System.EventHandler(this.btnCalcJuros_Click);
            this.btnCalcJuros.Leave += new System.EventHandler(this.btnCalcJuros_Leave);
            // 
            // btnSair
            // 
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSair.Image = global::GestãoFinanceira.Properties.Resources.exit;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.Location = new System.Drawing.Point(0, 558);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(186, 42);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRelatorio.FlatAppearance.BorderSize = 0;
            this.btnRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorio.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnRelatorio.Image = global::GestãoFinanceira.Properties.Resources.relatorio;
            this.btnRelatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRelatorio.Location = new System.Drawing.Point(0, 186);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(186, 42);
            this.btnRelatorio.TabIndex = 2;
            this.btnRelatorio.Text = "Relatório";
            this.btnRelatorio.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRelatorio.UseVisualStyleBackColor = true;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            this.btnRelatorio.Leave += new System.EventHandler(this.btnRelatorio_Leave);
            // 
            // btnCadastro
            // 
            this.btnCadastro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadastro.FlatAppearance.BorderSize = 0;
            this.btnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastro.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnCadastro.Image = global::GestãoFinanceira.Properties.Resources.home;
            this.btnCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastro.Location = new System.Drawing.Point(0, 144);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(186, 42);
            this.btnCadastro.TabIndex = 2;
            this.btnCadastro.Text = "Cadastro";
            this.btnCadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            this.btnCadastro.Leave += new System.EventHandler(this.btnCadastro_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlNav);
            this.panel2.Controls.Add(this.labelUsuarioConectado);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 144);
            this.panel2.TabIndex = 1;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnlNav.Location = new System.Drawing.Point(0, 150);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(5, 285);
            this.pnlNav.TabIndex = 2;
            // 
            // labelUsuarioConectado
            // 
            this.labelUsuarioConectado.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuarioConectado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.labelUsuarioConectado.Location = new System.Drawing.Point(0, 100);
            this.labelUsuarioConectado.Name = "labelUsuarioConectado";
            this.labelUsuarioConectado.Size = new System.Drawing.Size(186, 20);
            this.labelUsuarioConectado.TabIndex = 2;
            this.labelUsuarioConectado.Text = "User Name";
            this.labelUsuarioConectado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GestãoFinanceira.Properties.Resources.Untitled_11;
            this.pictureBox1.Location = new System.Drawing.Point(0, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GestãoFinanceira.Properties.Resources.Mr_Calc_2;
            this.pictureBox2.Location = new System.Drawing.Point(276, 78);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(821, 428);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label4.Location = new System.Drawing.Point(513, 570);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(335, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Mr. Calc @ Todos os direitos reservado - 2022";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelUsuarioConectado;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnCalcJuros;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnContato;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
    }
}

