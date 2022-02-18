namespace GestãoFinanceira.Visual
{
    partial class frmCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastro));
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnContReceber = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnContPagar = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnCadastroCliente = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnCadastroEmpresa = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnCadastroUsuario = new Bunifu.Framework.UI.BunifuTileButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panel1.TabIndex = 2;
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.labelHora.Location = new System.Drawing.Point(113, 493);
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
            this.labelData.Location = new System.Drawing.Point(17, 493);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(192, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 40);
            this.label1.TabIndex = 31;
            this.label1.Text = "CADASTRAR";
            // 
            // btnContReceber
            // 
            this.btnContReceber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnContReceber.color = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnContReceber.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnContReceber.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContReceber.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnContReceber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnContReceber.Image = global::GestãoFinanceira.Properties.Resources.receber;
            this.btnContReceber.ImagePosition = 20;
            this.btnContReceber.ImageZoom = 45;
            this.btnContReceber.LabelPosition = 35;
            this.btnContReceber.LabelText = "Á RECEBER";
            this.btnContReceber.Location = new System.Drawing.Point(589, 264);
            this.btnContReceber.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnContReceber.Name = "btnContReceber";
            this.btnContReceber.Size = new System.Drawing.Size(190, 159);
            this.btnContReceber.TabIndex = 30;
            this.btnContReceber.Click += new System.EventHandler(this.btnContReceber_Click);
            // 
            // btnContPagar
            // 
            this.btnContPagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnContPagar.color = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnContPagar.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnContPagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContPagar.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnContPagar.ForeColor = System.Drawing.Color.Brown;
            this.btnContPagar.Image = global::GestãoFinanceira.Properties.Resources.pagar;
            this.btnContPagar.ImagePosition = 20;
            this.btnContPagar.ImageZoom = 45;
            this.btnContPagar.LabelPosition = 35;
            this.btnContPagar.LabelText = "Á PAGAR";
            this.btnContPagar.Location = new System.Drawing.Point(394, 264);
            this.btnContPagar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnContPagar.Name = "btnContPagar";
            this.btnContPagar.Size = new System.Drawing.Size(190, 159);
            this.btnContPagar.TabIndex = 29;
            this.btnContPagar.Click += new System.EventHandler(this.btnContPagar_Click);
            // 
            // btnCadastroCliente
            // 
            this.btnCadastroCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnCadastroCliente.color = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnCadastroCliente.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnCadastroCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastroCliente.Font = new System.Drawing.Font("Century Gothic", 14.75F);
            this.btnCadastroCliente.ForeColor = System.Drawing.Color.White;
            this.btnCadastroCliente.Image = global::GestãoFinanceira.Properties.Resources.cliente;
            this.btnCadastroCliente.ImagePosition = 20;
            this.btnCadastroCliente.ImageZoom = 50;
            this.btnCadastroCliente.LabelPosition = 40;
            this.btnCadastroCliente.LabelText = "CLIENTE";
            this.btnCadastroCliente.Location = new System.Drawing.Point(394, 100);
            this.btnCadastroCliente.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnCadastroCliente.Name = "btnCadastroCliente";
            this.btnCadastroCliente.Size = new System.Drawing.Size(190, 159);
            this.btnCadastroCliente.TabIndex = 26;
            this.btnCadastroCliente.Click += new System.EventHandler(this.btnCadastroCliente_Click);
            // 
            // btnCadastroEmpresa
            // 
            this.btnCadastroEmpresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnCadastroEmpresa.color = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnCadastroEmpresa.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnCadastroEmpresa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastroEmpresa.Font = new System.Drawing.Font("Century Gothic", 14.75F);
            this.btnCadastroEmpresa.ForeColor = System.Drawing.Color.White;
            this.btnCadastroEmpresa.Image = global::GestãoFinanceira.Properties.Resources.empresa;
            this.btnCadastroEmpresa.ImagePosition = 20;
            this.btnCadastroEmpresa.ImageZoom = 40;
            this.btnCadastroEmpresa.LabelPosition = 40;
            this.btnCadastroEmpresa.LabelText = "EMPRESA";
            this.btnCadastroEmpresa.Location = new System.Drawing.Point(589, 100);
            this.btnCadastroEmpresa.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnCadastroEmpresa.Name = "btnCadastroEmpresa";
            this.btnCadastroEmpresa.Size = new System.Drawing.Size(190, 159);
            this.btnCadastroEmpresa.TabIndex = 27;
            this.btnCadastroEmpresa.Click += new System.EventHandler(this.btnCadastroEmpresa_Click);
            // 
            // btnCadastroUsuario
            // 
            this.btnCadastroUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnCadastroUsuario.color = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnCadastroUsuario.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnCadastroUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastroUsuario.Font = new System.Drawing.Font("Century Gothic", 14.75F);
            this.btnCadastroUsuario.ForeColor = System.Drawing.Color.White;
            this.btnCadastroUsuario.Image = global::GestãoFinanceira.Properties.Resources.usuario;
            this.btnCadastroUsuario.ImagePosition = 20;
            this.btnCadastroUsuario.ImageZoom = 40;
            this.btnCadastroUsuario.LabelPosition = 40;
            this.btnCadastroUsuario.LabelText = "USUÁRIO";
            this.btnCadastroUsuario.Location = new System.Drawing.Point(199, 100);
            this.btnCadastroUsuario.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnCadastroUsuario.Name = "btnCadastroUsuario";
            this.btnCadastroUsuario.Size = new System.Drawing.Size(190, 159);
            this.btnCadastroUsuario.TabIndex = 28;
            this.btnCadastroUsuario.Click += new System.EventHandler(this.btnCadastroUsuario_Click);
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnContReceber);
            this.Controls.Add(this.btnContPagar);
            this.Controls.Add(this.btnCadastroCliente);
            this.Controls.Add(this.btnCadastroEmpresa);
            this.Controls.Add(this.btnCadastroUsuario);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadastro";
            this.Load += new System.EventHandler(this.frmCadastro_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.Button btnContato;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Button btnCalcJuros;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Label labelUsuarioConectado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuTileButton btnContReceber;
        private Bunifu.Framework.UI.BunifuTileButton btnContPagar;
        private Bunifu.Framework.UI.BunifuTileButton btnCadastroCliente;
        private Bunifu.Framework.UI.BunifuTileButton btnCadastroEmpresa;
        private Bunifu.Framework.UI.BunifuTileButton btnCadastroUsuario;
        private System.Windows.Forms.Label label1;
    }
}