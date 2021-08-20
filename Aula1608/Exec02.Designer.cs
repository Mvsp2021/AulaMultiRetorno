
namespace Aula1608
{
    partial class Exec02
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
            this.dgVagas = new System.Windows.Forms.DataGridView();
            this.cbVagasLivres = new System.Windows.Forms.ComboBox();
            this.lblVagas = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.rbEntrando = new System.Windows.Forms.RadioButton();
            this.rbSaindo = new System.Windows.Forms.RadioButton();
            this.NumeroVagaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlacaVeiculoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstaPreenchidaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExecuta = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblHora = new System.Windows.Forms.Label();
            this.txtHora = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgVagas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgVagas
            // 
            this.dgVagas.AllowUserToAddRows = false;
            this.dgVagas.AllowUserToDeleteRows = false;
            this.dgVagas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVagas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroVagaCol,
            this.PlacaVeiculoCol,
            this.EstaPreenchidaCol});
            this.dgVagas.Location = new System.Drawing.Point(12, 23);
            this.dgVagas.Name = "dgVagas";
            this.dgVagas.ReadOnly = true;
            this.dgVagas.RowTemplate.Height = 50;
            this.dgVagas.Size = new System.Drawing.Size(747, 243);
            this.dgVagas.TabIndex = 0;
            // 
            // cbVagasLivres
            // 
            this.cbVagasLivres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVagasLivres.FormattingEnabled = true;
            this.cbVagasLivres.Location = new System.Drawing.Point(265, 353);
            this.cbVagasLivres.Name = "cbVagasLivres";
            this.cbVagasLivres.Size = new System.Drawing.Size(157, 32);
            this.cbVagasLivres.TabIndex = 1;
            // 
            // lblVagas
            // 
            this.lblVagas.AutoSize = true;
            this.lblVagas.Location = new System.Drawing.Point(265, 312);
            this.lblVagas.Name = "lblVagas";
            this.lblVagas.Size = new System.Drawing.Size(117, 24);
            this.lblVagas.TabIndex = 2;
            this.lblVagas.Text = "Vagas Livres";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(261, 439);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(161, 29);
            this.txtPlaca.TabIndex = 3;
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(265, 406);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(56, 24);
            this.lblPlaca.TabIndex = 4;
            this.lblPlaca.Text = "Placa";
            // 
            // rbEntrando
            // 
            this.rbEntrando.AutoSize = true;
            this.rbEntrando.Location = new System.Drawing.Point(48, 319);
            this.rbEntrando.Name = "rbEntrando";
            this.rbEntrando.Size = new System.Drawing.Size(105, 28);
            this.rbEntrando.TabIndex = 5;
            this.rbEntrando.TabStop = true;
            this.rbEntrando.Text = "Entrando";
            this.rbEntrando.UseVisualStyleBackColor = true;
            this.rbEntrando.CheckedChanged += new System.EventHandler(this.rbEntrando_CheckedChanged);
            // 
            // rbSaindo
            // 
            this.rbSaindo.AutoSize = true;
            this.rbSaindo.Location = new System.Drawing.Point(48, 374);
            this.rbSaindo.Name = "rbSaindo";
            this.rbSaindo.Size = new System.Drawing.Size(87, 28);
            this.rbSaindo.TabIndex = 6;
            this.rbSaindo.TabStop = true;
            this.rbSaindo.Text = "Saindo";
            this.rbSaindo.UseVisualStyleBackColor = true;
            this.rbSaindo.CheckedChanged += new System.EventHandler(this.rbSaindo_CheckedChanged);
            // 
            // NumeroVagaCol
            // 
            this.NumeroVagaCol.HeaderText = "Numero Vaga";
            this.NumeroVagaCol.Name = "NumeroVagaCol";
            this.NumeroVagaCol.ReadOnly = true;
            this.NumeroVagaCol.Width = 200;
            // 
            // PlacaVeiculoCol
            // 
            this.PlacaVeiculoCol.HeaderText = "Placa";
            this.PlacaVeiculoCol.Name = "PlacaVeiculoCol";
            this.PlacaVeiculoCol.ReadOnly = true;
            this.PlacaVeiculoCol.Width = 200;
            // 
            // EstaPreenchidaCol
            // 
            this.EstaPreenchidaCol.HeaderText = "Ocupada";
            this.EstaPreenchidaCol.Name = "EstaPreenchidaCol";
            this.EstaPreenchidaCol.ReadOnly = true;
            this.EstaPreenchidaCol.Width = 200;
            // 
            // btnExecuta
            // 
            this.btnExecuta.Location = new System.Drawing.Point(636, 323);
            this.btnExecuta.Name = "btnExecuta";
            this.btnExecuta.Size = new System.Drawing.Size(112, 62);
            this.btnExecuta.TabIndex = 7;
            this.btnExecuta.Text = "Executa";
            this.btnExecuta.UseVisualStyleBackColor = true;
            this.btnExecuta.Click += new System.EventHandler(this.btnExecuta_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSair.Location = new System.Drawing.Point(636, 444);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(112, 47);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(480, 342);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(51, 24);
            this.lblHora.TabIndex = 9;
            this.lblHora.Text = "Hora";
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(484, 381);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(100, 29);
            this.txtHora.TabIndex = 10;
            // 
            // Exec02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExecuta);
            this.Controls.Add(this.rbSaindo);
            this.Controls.Add(this.rbEntrando);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.lblVagas);
            this.Controls.Add(this.cbVagasLivres);
            this.Controls.Add(this.dgVagas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Exec02";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exec02";
            this.Load += new System.EventHandler(this.Exec02_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgVagas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgVagas;
        private System.Windows.Forms.ComboBox cbVagasLivres;
        private System.Windows.Forms.Label lblVagas;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.RadioButton rbEntrando;
        private System.Windows.Forms.RadioButton rbSaindo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroVagaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlacaVeiculoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstaPreenchidaCol;
        private System.Windows.Forms.Button btnExecuta;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.TextBox txtHora;
    }
}