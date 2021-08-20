
namespace Aula1608
{
    partial class Exec03
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
            this.dgHistorico = new System.Windows.Forms.DataGridView();
            this.IdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorEmCaixaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DespesasDoMesCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GanhosDoMesCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorLiquidoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeLucrouCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblGanhos = new System.Windows.Forms.Label();
            this.lblDespesa = new System.Windows.Forms.Label();
            this.btnCalcula = new System.Windows.Forms.Button();
            this.txtGanhos = new System.Windows.Forms.TextBox();
            this.txtDespesas = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgHistorico)).BeginInit();
            this.SuspendLayout();
            // 
            // dgHistorico
            // 
            this.dgHistorico.AllowUserToAddRows = false;
            this.dgHistorico.AllowUserToDeleteRows = false;
            this.dgHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHistorico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCol,
            this.ValorEmCaixaCol,
            this.DespesasDoMesCol,
            this.GanhosDoMesCol,
            this.ValorLiquidoCol,
            this.SeLucrouCol});
            this.dgHistorico.Location = new System.Drawing.Point(12, 12);
            this.dgHistorico.Name = "dgHistorico";
            this.dgHistorico.ReadOnly = true;
            this.dgHistorico.RowTemplate.Height = 50;
            this.dgHistorico.Size = new System.Drawing.Size(1001, 271);
            this.dgHistorico.TabIndex = 0;
            // 
            // IdCol
            // 
            this.IdCol.HeaderText = "ID";
            this.IdCol.Name = "IdCol";
            this.IdCol.ReadOnly = true;
            this.IdCol.Width = 50;
            // 
            // ValorEmCaixaCol
            // 
            this.ValorEmCaixaCol.HeaderText = "Valor em Caixa";
            this.ValorEmCaixaCol.Name = "ValorEmCaixaCol";
            this.ValorEmCaixaCol.ReadOnly = true;
            this.ValorEmCaixaCol.Width = 200;
            // 
            // DespesasDoMesCol
            // 
            this.DespesasDoMesCol.HeaderText = "Despesas do Mês";
            this.DespesasDoMesCol.Name = "DespesasDoMesCol";
            this.DespesasDoMesCol.ReadOnly = true;
            this.DespesasDoMesCol.Width = 200;
            // 
            // GanhosDoMesCol
            // 
            this.GanhosDoMesCol.HeaderText = "Ganhos do Mês";
            this.GanhosDoMesCol.Name = "GanhosDoMesCol";
            this.GanhosDoMesCol.ReadOnly = true;
            this.GanhosDoMesCol.Width = 200;
            // 
            // ValorLiquidoCol
            // 
            this.ValorLiquidoCol.HeaderText = "Valor Líquido";
            this.ValorLiquidoCol.Name = "ValorLiquidoCol";
            this.ValorLiquidoCol.ReadOnly = true;
            this.ValorLiquidoCol.Width = 200;
            // 
            // SeLucrouCol
            // 
            this.SeLucrouCol.HeaderText = "Se Lucrou";
            this.SeLucrouCol.Name = "SeLucrouCol";
            this.SeLucrouCol.ReadOnly = true;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(833, 357);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(133, 60);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblGanhos
            // 
            this.lblGanhos.AutoSize = true;
            this.lblGanhos.Location = new System.Drawing.Point(48, 357);
            this.lblGanhos.Name = "lblGanhos";
            this.lblGanhos.Size = new System.Drawing.Size(144, 24);
            this.lblGanhos.TabIndex = 2;
            this.lblGanhos.Text = "Ganhos do Mês";
            // 
            // lblDespesa
            // 
            this.lblDespesa.AutoSize = true;
            this.lblDespesa.Location = new System.Drawing.Point(52, 419);
            this.lblDespesa.Name = "lblDespesa";
            this.lblDespesa.Size = new System.Drawing.Size(152, 24);
            this.lblDespesa.TabIndex = 3;
            this.lblDespesa.Text = "Despesa do Mês";
            // 
            // btnCalcula
            // 
            this.btnCalcula.Location = new System.Drawing.Point(270, 479);
            this.btnCalcula.Name = "btnCalcula";
            this.btnCalcula.Size = new System.Drawing.Size(110, 49);
            this.btnCalcula.TabIndex = 4;
            this.btnCalcula.Text = "Calcula Mês";
            this.btnCalcula.UseVisualStyleBackColor = true;
            this.btnCalcula.Click += new System.EventHandler(this.btnCalcula_Click);
            // 
            // txtGanhos
            // 
            this.txtGanhos.Location = new System.Drawing.Point(221, 357);
            this.txtGanhos.Name = "txtGanhos";
            this.txtGanhos.Size = new System.Drawing.Size(254, 29);
            this.txtGanhos.TabIndex = 5;
            // 
            // txtDespesas
            // 
            this.txtDespesas.Location = new System.Drawing.Point(221, 419);
            this.txtDespesas.Name = "txtDespesas";
            this.txtDespesas.Size = new System.Drawing.Size(254, 29);
            this.txtDespesas.TabIndex = 6;
            // 
            // Exec03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 561);
            this.Controls.Add(this.txtDespesas);
            this.Controls.Add(this.txtGanhos);
            this.Controls.Add(this.btnCalcula);
            this.Controls.Add(this.lblDespesa);
            this.Controls.Add(this.lblGanhos);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.dgHistorico);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Exec03";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exec03";
            this.Load += new System.EventHandler(this.Exec03_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgHistorico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgHistorico;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorEmCaixaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DespesasDoMesCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn GanhosDoMesCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorLiquidoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeLucrouCol;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblGanhos;
        private System.Windows.Forms.Label lblDespesa;
        private System.Windows.Forms.Button btnCalcula;
        private System.Windows.Forms.TextBox txtGanhos;
        private System.Windows.Forms.TextBox txtDespesas;
    }
}