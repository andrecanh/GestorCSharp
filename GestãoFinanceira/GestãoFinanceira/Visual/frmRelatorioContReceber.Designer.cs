namespace GestãoFinanceira.Visual
{
    partial class frmRelatorioContReceber
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelatorioContReceber));
            this.btnVoltar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.labelData = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesquisaReceber = new MetroFramework.Controls.MetroTextBox();
            this.dvgReceber = new MetroFramework.Controls.MetroGrid();
            this.btnImprimir = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPesquisar = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dvgReceber)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Active = false;
            this.btnVoltar.Activecolor = System.Drawing.Color.Gainsboro;
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVoltar.BorderRadius = 4;
            this.btnVoltar.ButtonText = "Voltar";
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.DisabledColor = System.Drawing.Color.Gainsboro;
            this.btnVoltar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnVoltar.Iconimage = null;
            this.btnVoltar.Iconimage_right = null;
            this.btnVoltar.Iconimage_right_Selected = null;
            this.btnVoltar.Iconimage_Selected = null;
            this.btnVoltar.IconMarginLeft = 0;
            this.btnVoltar.IconMarginRight = 0;
            this.btnVoltar.IconRightVisible = true;
            this.btnVoltar.IconRightZoom = 0D;
            this.btnVoltar.IconVisible = true;
            this.btnVoltar.IconZoom = 90D;
            this.btnVoltar.IsTab = false;
            this.btnVoltar.Location = new System.Drawing.Point(866, 31);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnVoltar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnVoltar.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnVoltar.selected = false;
            this.btnVoltar.Size = new System.Drawing.Size(165, 39);
            this.btnVoltar.TabIndex = 196;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnVoltar.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnVoltar.TextFont = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.labelData.Location = new System.Drawing.Point(19, 102);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(100, 23);
            this.labelData.TabIndex = 195;
            this.labelData.Text = "Pesquisar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(17, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 30);
            this.label1.TabIndex = 194;
            this.label1.Text = "RELATÓRIO DE CONTAS À RECEBER";
            // 
            // txtPesquisaReceber
            // 
            // 
            // 
            // 
            this.txtPesquisaReceber.CustomButton.Image = null;
            this.txtPesquisaReceber.CustomButton.Location = new System.Drawing.Point(682, 2);
            this.txtPesquisaReceber.CustomButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtPesquisaReceber.CustomButton.Name = "";
            this.txtPesquisaReceber.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txtPesquisaReceber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPesquisaReceber.CustomButton.TabIndex = 1;
            this.txtPesquisaReceber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPesquisaReceber.CustomButton.UseSelectable = true;
            this.txtPesquisaReceber.CustomButton.Visible = false;
            this.txtPesquisaReceber.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPesquisaReceber.Lines = new string[0];
            this.txtPesquisaReceber.Location = new System.Drawing.Point(140, 93);
            this.txtPesquisaReceber.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtPesquisaReceber.MaxLength = 32767;
            this.txtPesquisaReceber.Name = "txtPesquisaReceber";
            this.txtPesquisaReceber.PasswordChar = '\0';
            this.txtPesquisaReceber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPesquisaReceber.SelectedText = "";
            this.txtPesquisaReceber.SelectionLength = 0;
            this.txtPesquisaReceber.SelectionStart = 0;
            this.txtPesquisaReceber.ShortcutsEnabled = true;
            this.txtPesquisaReceber.Size = new System.Drawing.Size(718, 38);
            this.txtPesquisaReceber.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPesquisaReceber.TabIndex = 190;
            this.txtPesquisaReceber.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPesquisaReceber.UseSelectable = true;
            this.txtPesquisaReceber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPesquisaReceber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dvgReceber
            // 
            this.dvgReceber.AllowUserToAddRows = false;
            this.dvgReceber.AllowUserToDeleteRows = false;
            this.dvgReceber.AllowUserToResizeRows = false;
            this.dvgReceber.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dvgReceber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvgReceber.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dvgReceber.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgReceber.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgReceber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgReceber.DefaultCellStyle = dataGridViewCellStyle2;
            this.dvgReceber.EnableHeadersVisualStyles = false;
            this.dvgReceber.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dvgReceber.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dvgReceber.Location = new System.Drawing.Point(22, 151);
            this.dvgReceber.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dvgReceber.Name = "dvgReceber";
            this.dvgReceber.ReadOnly = true;
            this.dvgReceber.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgReceber.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dvgReceber.RowHeadersVisible = false;
            this.dvgReceber.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dvgReceber.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgReceber.Size = new System.Drawing.Size(1009, 370);
            this.dvgReceber.Style = MetroFramework.MetroColorStyle.Blue;
            this.dvgReceber.TabIndex = 193;
            this.dvgReceber.Theme = MetroFramework.MetroThemeStyle.Light;
            this.dvgReceber.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgReceber_CellDoubleClick);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Active = false;
            this.btnImprimir.Activecolor = System.Drawing.Color.Gainsboro;
            this.btnImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnImprimir.BorderRadius = 4;
            this.btnImprimir.ButtonText = "Imprimir";
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.DisabledColor = System.Drawing.Color.Gainsboro;
            this.btnImprimir.Iconcolor = System.Drawing.Color.Transparent;
            this.btnImprimir.Iconimage = null;
            this.btnImprimir.Iconimage_right = null;
            this.btnImprimir.Iconimage_right_Selected = null;
            this.btnImprimir.Iconimage_Selected = null;
            this.btnImprimir.IconMarginLeft = 0;
            this.btnImprimir.IconMarginRight = 0;
            this.btnImprimir.IconRightVisible = true;
            this.btnImprimir.IconRightZoom = 0D;
            this.btnImprimir.IconVisible = true;
            this.btnImprimir.IconZoom = 90D;
            this.btnImprimir.IsTab = false;
            this.btnImprimir.Location = new System.Drawing.Point(866, 548);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnImprimir.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnImprimir.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnImprimir.selected = false;
            this.btnImprimir.Size = new System.Drawing.Size(165, 39);
            this.btnImprimir.TabIndex = 200;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnImprimir.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnImprimir.TextFont = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Active = false;
            this.btnPesquisar.Activecolor = System.Drawing.Color.Gainsboro;
            this.btnPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPesquisar.BorderRadius = 4;
            this.btnPesquisar.ButtonText = "Pesquisar";
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.DisabledColor = System.Drawing.Color.Gainsboro;
            this.btnPesquisar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPesquisar.Iconimage = null;
            this.btnPesquisar.Iconimage_right = null;
            this.btnPesquisar.Iconimage_right_Selected = null;
            this.btnPesquisar.Iconimage_Selected = null;
            this.btnPesquisar.IconMarginLeft = 0;
            this.btnPesquisar.IconMarginRight = 0;
            this.btnPesquisar.IconRightVisible = true;
            this.btnPesquisar.IconRightZoom = 0D;
            this.btnPesquisar.IconVisible = true;
            this.btnPesquisar.IconZoom = 90D;
            this.btnPesquisar.IsTab = false;
            this.btnPesquisar.Location = new System.Drawing.Point(866, 92);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnPesquisar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnPesquisar.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnPesquisar.selected = false;
            this.btnPesquisar.Size = new System.Drawing.Size(165, 39);
            this.btnPesquisar.TabIndex = 199;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPesquisar.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnPesquisar.TextFont = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // frmRelatorioContReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPesquisaReceber);
            this.Controls.Add(this.dvgReceber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRelatorioContReceber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRelatorioContReceber";
            this.Load += new System.EventHandler(this.frmRelatorioContReceber_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgReceber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btnVoltar;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox txtPesquisaReceber;
        private MetroFramework.Controls.MetroGrid dvgReceber;
        private Bunifu.Framework.UI.BunifuFlatButton btnImprimir;
        private Bunifu.Framework.UI.BunifuFlatButton btnPesquisar;
    }
}