
namespace Aula1608
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
            this.btnExec02 = new System.Windows.Forms.Button();
            this.btnExec03FM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExec02
            // 
            this.btnExec02.Location = new System.Drawing.Point(47, 38);
            this.btnExec02.Name = "btnExec02";
            this.btnExec02.Size = new System.Drawing.Size(75, 23);
            this.btnExec02.TabIndex = 0;
            this.btnExec02.Text = "Exec02";
            this.btnExec02.UseVisualStyleBackColor = true;
            this.btnExec02.Click += new System.EventHandler(this.btnExec02_Click);
            // 
            // btnExec03FM
            // 
            this.btnExec03FM.Location = new System.Drawing.Point(47, 312);
            this.btnExec03FM.Name = "btnExec03FM";
            this.btnExec03FM.Size = new System.Drawing.Size(75, 23);
            this.btnExec03FM.TabIndex = 1;
            this.btnExec03FM.Text = "Exec03FM";
            this.btnExec03FM.UseVisualStyleBackColor = true;
            this.btnExec03FM.Click += new System.EventHandler(this.btnExec01FM_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExec03FM);
            this.Controls.Add(this.btnExec02);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExec02;
        private System.Windows.Forms.Button btnExec03FM;
    }
}

