namespace prjIntegradoBD
{
    partial class AdicionarCategoria
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
            this.Teste = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtNomeCategoria = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Teste
            // 
            this.Teste.Font = new System.Drawing.Font("Cooper Black", 14F);
            this.Teste.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Teste.Location = new System.Drawing.Point(135, 140);
            this.Teste.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Teste.Name = "Teste";
            this.Teste.Size = new System.Drawing.Size(127, 24);
            this.Teste.TabIndex = 51;
            this.Teste.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(28, 166);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(354, 20);
            this.txtDescricao.TabIndex = 50;
            // 
            // txtNomeCategoria
            // 
            this.txtNomeCategoria.Location = new System.Drawing.Point(28, 108);
            this.txtNomeCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeCategoria.Name = "txtNomeCategoria";
            this.txtNomeCategoria.Size = new System.Drawing.Size(354, 20);
            this.txtNomeCategoria.TabIndex = 49;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Cooper Black", 14F);
            this.txtNome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNome.Location = new System.Drawing.Point(106, 82);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(199, 24);
            this.txtNome.TabIndex = 48;
            this.txtNome.Text = "Nome da Categoria";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnVoltar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVoltar.Font = new System.Drawing.Font("Cooper Black", 10F);
            this.btnVoltar.Location = new System.Drawing.Point(11, 215);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(85, 32);
            this.btnVoltar.TabIndex = 45;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAdicionar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAdicionar.Font = new System.Drawing.Font("Cooper Black", 16F);
            this.btnAdicionar.Location = new System.Drawing.Point(133, 213);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(172, 32);
            this.btnAdicionar.TabIndex = 44;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Cooper Black", 20F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 30);
            this.label1.TabIndex = 43;
            this.label1.Text = "Adicionar Categoria";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AdicionarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(408, 259);
            this.Controls.Add(this.Teste);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtNomeCategoria);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.label1);
            this.Name = "AdicionarCategoria";
            this.Text = "AdicionarCategoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Teste;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtNomeCategoria;
        private System.Windows.Forms.Label txtNome;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label label1;
    }
}