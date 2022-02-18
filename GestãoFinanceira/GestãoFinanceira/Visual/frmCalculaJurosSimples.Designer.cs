namespace GestãoFinanceira.Visual
{
    partial class frmCalculaJurosSimples
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculaJurosSimples));
            this.txtValorPagar = new MetroFramework.Controls.MetroTextBox();
            this.txtDiasAtraso = new MetroFramework.Controls.MetroTextBox();
            this.txtValorParcela = new MetroFramework.Controls.MetroTextBox();
            this.txtTaxaJuros = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnLimparCampos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCalcular = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // txtValorPagar
            // 
            this.txtValorPagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            this.txtValorPagar.CustomButton.Image = null;
            this.txtValorPagar.CustomButton.Location = new System.Drawing.Point(182, 1);
            this.txtValorPagar.CustomButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtValorPagar.CustomButton.Name = "";
            this.txtValorPagar.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtValorPagar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtValorPagar.CustomButton.TabIndex = 1;
            this.txtValorPagar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtValorPagar.CustomButton.UseSelectable = true;
            this.txtValorPagar.CustomButton.Visible = false;
            this.txtValorPagar.DisplayIcon = true;
            this.txtValorPagar.Enabled = false;
            this.txtValorPagar.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtValorPagar.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtValorPagar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtValorPagar.Lines = new string[0];
            this.txtValorPagar.Location = new System.Drawing.Point(254, 199);
            this.txtValorPagar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtValorPagar.MaxLength = 32767;
            this.txtValorPagar.Name = "txtValorPagar";
            this.txtValorPagar.PasswordChar = '\0';
            this.txtValorPagar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtValorPagar.SelectedText = "";
            this.txtValorPagar.SelectionLength = 0;
            this.txtValorPagar.SelectionStart = 0;
            this.txtValorPagar.ShortcutsEnabled = true;
            this.txtValorPagar.Size = new System.Drawing.Size(214, 33);
            this.txtValorPagar.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtValorPagar.TabIndex = 38;
            this.txtValorPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtValorPagar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtValorPagar.UseSelectable = true;
            this.txtValorPagar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtValorPagar.WaterMarkFont = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorPagar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorPagar_KeyPress);
            this.txtValorPagar.Leave += new System.EventHandler(this.txtValorPagar_Leave);
            // 
            // txtDiasAtraso
            // 
            // 
            // 
            // 
            this.txtDiasAtraso.CustomButton.Image = null;
            this.txtDiasAtraso.CustomButton.Location = new System.Drawing.Point(182, 1);
            this.txtDiasAtraso.CustomButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtDiasAtraso.CustomButton.Name = "";
            this.txtDiasAtraso.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtDiasAtraso.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDiasAtraso.CustomButton.TabIndex = 1;
            this.txtDiasAtraso.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDiasAtraso.CustomButton.UseSelectable = true;
            this.txtDiasAtraso.CustomButton.Visible = false;
            this.txtDiasAtraso.DisplayIcon = true;
            this.txtDiasAtraso.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtDiasAtraso.Lines = new string[0];
            this.txtDiasAtraso.Location = new System.Drawing.Point(254, 158);
            this.txtDiasAtraso.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtDiasAtraso.MaxLength = 32767;
            this.txtDiasAtraso.Name = "txtDiasAtraso";
            this.txtDiasAtraso.PasswordChar = '\0';
            this.txtDiasAtraso.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDiasAtraso.SelectedText = "";
            this.txtDiasAtraso.SelectionLength = 0;
            this.txtDiasAtraso.SelectionStart = 0;
            this.txtDiasAtraso.ShortcutsEnabled = true;
            this.txtDiasAtraso.Size = new System.Drawing.Size(214, 33);
            this.txtDiasAtraso.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDiasAtraso.TabIndex = 37;
            this.txtDiasAtraso.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDiasAtraso.UseSelectable = true;
            this.txtDiasAtraso.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDiasAtraso.WaterMarkFont = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtValorParcela
            // 
            // 
            // 
            // 
            this.txtValorParcela.CustomButton.Image = null;
            this.txtValorParcela.CustomButton.Location = new System.Drawing.Point(182, 1);
            this.txtValorParcela.CustomButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtValorParcela.CustomButton.Name = "";
            this.txtValorParcela.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtValorParcela.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtValorParcela.CustomButton.TabIndex = 1;
            this.txtValorParcela.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtValorParcela.CustomButton.UseSelectable = true;
            this.txtValorParcela.CustomButton.Visible = false;
            this.txtValorParcela.DisplayIcon = true;
            this.txtValorParcela.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtValorParcela.Lines = new string[0];
            this.txtValorParcela.Location = new System.Drawing.Point(254, 77);
            this.txtValorParcela.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtValorParcela.MaxLength = 32767;
            this.txtValorParcela.Name = "txtValorParcela";
            this.txtValorParcela.PasswordChar = '\0';
            this.txtValorParcela.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtValorParcela.SelectedText = "";
            this.txtValorParcela.SelectionLength = 0;
            this.txtValorParcela.SelectionStart = 0;
            this.txtValorParcela.ShortcutsEnabled = true;
            this.txtValorParcela.Size = new System.Drawing.Size(214, 33);
            this.txtValorParcela.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtValorParcela.TabIndex = 35;
            this.txtValorParcela.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtValorParcela.UseSelectable = true;
            this.txtValorParcela.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtValorParcela.WaterMarkFont = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorParcela.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorParcela_KeyPress);
            this.txtValorParcela.Leave += new System.EventHandler(this.txtValorParcela_Leave);
            // 
            // txtTaxaJuros
            // 
            // 
            // 
            // 
            this.txtTaxaJuros.CustomButton.Image = null;
            this.txtTaxaJuros.CustomButton.Location = new System.Drawing.Point(182, 1);
            this.txtTaxaJuros.CustomButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtTaxaJuros.CustomButton.Name = "";
            this.txtTaxaJuros.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtTaxaJuros.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTaxaJuros.CustomButton.TabIndex = 1;
            this.txtTaxaJuros.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTaxaJuros.CustomButton.UseSelectable = true;
            this.txtTaxaJuros.CustomButton.Visible = false;
            this.txtTaxaJuros.DisplayIcon = true;
            this.txtTaxaJuros.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtTaxaJuros.Lines = new string[0];
            this.txtTaxaJuros.Location = new System.Drawing.Point(254, 118);
            this.txtTaxaJuros.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtTaxaJuros.MaxLength = 32767;
            this.txtTaxaJuros.Name = "txtTaxaJuros";
            this.txtTaxaJuros.PasswordChar = '\0';
            this.txtTaxaJuros.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTaxaJuros.SelectedText = "";
            this.txtTaxaJuros.SelectionLength = 0;
            this.txtTaxaJuros.SelectionStart = 0;
            this.txtTaxaJuros.ShortcutsEnabled = true;
            this.txtTaxaJuros.Size = new System.Drawing.Size(214, 33);
            this.txtTaxaJuros.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTaxaJuros.TabIndex = 36;
            this.txtTaxaJuros.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTaxaJuros.UseSelectable = true;
            this.txtTaxaJuros.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTaxaJuros.WaterMarkFont = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(32, 207);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(88, 20);
            this.metroLabel4.TabIndex = 41;
            this.metroLabel4.Text = "Valor a Pagar";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(32, 166);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(98, 20);
            this.metroLabel3.TabIndex = 42;
            this.metroLabel3.Text = "Dias de Atraso";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(32, 126);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(130, 20);
            this.metroLabel2.TabIndex = 43;
            this.metroLabel2.Text = "Taxa de Juros (A.M.)";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(32, 85);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(106, 20);
            this.metroLabel1.TabIndex = 44;
            this.metroLabel1.Text = "Valor da Parcela";
            // 
            // btnLimparCampos
            // 
            this.btnLimparCampos.Active = false;
            this.btnLimparCampos.Activecolor = System.Drawing.Color.Gainsboro;
            this.btnLimparCampos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnLimparCampos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLimparCampos.BorderRadius = 4;
            this.btnLimparCampos.ButtonText = "               Limpar";
            this.btnLimparCampos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimparCampos.DisabledColor = System.Drawing.Color.Gainsboro;
            this.btnLimparCampos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLimparCampos.Iconimage = null;
            this.btnLimparCampos.Iconimage_right = null;
            this.btnLimparCampos.Iconimage_right_Selected = null;
            this.btnLimparCampos.Iconimage_Selected = null;
            this.btnLimparCampos.IconMarginLeft = 0;
            this.btnLimparCampos.IconMarginRight = 0;
            this.btnLimparCampos.IconRightVisible = true;
            this.btnLimparCampos.IconRightZoom = 0D;
            this.btnLimparCampos.IconVisible = true;
            this.btnLimparCampos.IconZoom = 90D;
            this.btnLimparCampos.IsTab = false;
            this.btnLimparCampos.Location = new System.Drawing.Point(32, 273);
            this.btnLimparCampos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimparCampos.Name = "btnLimparCampos";
            this.btnLimparCampos.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnLimparCampos.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnLimparCampos.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnLimparCampos.selected = false;
            this.btnLimparCampos.Size = new System.Drawing.Size(215, 50);
            this.btnLimparCampos.TabIndex = 40;
            this.btnLimparCampos.Text = "               Limpar";
            this.btnLimparCampos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimparCampos.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnLimparCampos.TextFont = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparCampos.Click += new System.EventHandler(this.btnLimparCampos_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Active = false;
            this.btnCalcular.Activecolor = System.Drawing.Color.Gainsboro;
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnCalcular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCalcular.BorderRadius = 4;
            this.btnCalcular.ButtonText = "              Calcular";
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.DisabledColor = System.Drawing.Color.Gainsboro;
            this.btnCalcular.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCalcular.Iconimage = null;
            this.btnCalcular.Iconimage_right = null;
            this.btnCalcular.Iconimage_right_Selected = null;
            this.btnCalcular.Iconimage_Selected = null;
            this.btnCalcular.IconMarginLeft = 0;
            this.btnCalcular.IconMarginRight = 0;
            this.btnCalcular.IconRightVisible = true;
            this.btnCalcular.IconRightZoom = 0D;
            this.btnCalcular.IconVisible = true;
            this.btnCalcular.IconZoom = 90D;
            this.btnCalcular.IsTab = false;
            this.btnCalcular.Location = new System.Drawing.Point(253, 273);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnCalcular.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnCalcular.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnCalcular.selected = false;
            this.btnCalcular.Size = new System.Drawing.Size(215, 50);
            this.btnCalcular.TabIndex = 39;
            this.btnCalcular.Text = "              Calcular";
            this.btnCalcular.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalcular.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnCalcular.TextFont = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // frmCalculaJurosSimples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 350);
            this.Controls.Add(this.txtValorPagar);
            this.Controls.Add(this.txtDiasAtraso);
            this.Controls.Add(this.txtValorParcela);
            this.Controls.Add(this.txtTaxaJuros);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnLimparCampos);
            this.Controls.Add(this.btnCalcular);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCalculaJurosSimples";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Calculadora de Juros Simples";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCalculaJurosSimples_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtValorPagar;
        private MetroFramework.Controls.MetroTextBox txtDiasAtraso;
        private MetroFramework.Controls.MetroTextBox txtValorParcela;
        private MetroFramework.Controls.MetroTextBox txtTaxaJuros;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnLimparCampos;
        private Bunifu.Framework.UI.BunifuFlatButton btnCalcular;
    }
}