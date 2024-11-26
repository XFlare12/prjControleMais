namespace prjIntegradoBD
{
    partial class AlteraCategoria
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
            this.label1 = new System.Windows.Forms.Label();
            this.Teste = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtNomeCategoria = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Cooper Black", 20F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(53, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 30);
            this.label1.TabIndex = 15;
            this.label1.Text = "Alterar Categoria";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Teste
            // 
            this.Teste.Font = new System.Drawing.Font("Cooper Black", 14F);
            this.Teste.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Teste.Location = new System.Drawing.Point(166, 168);
            this.Teste.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Teste.Name = "Teste";
            this.Teste.Size = new System.Drawing.Size(127, 24);
            this.Teste.TabIndex = 42;
            this.Teste.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(59, 199);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(354, 20);
            this.txtDescricao.TabIndex = 41;
            // 
            // txtNomeCategoria
            // 
            this.txtNomeCategoria.Location = new System.Drawing.Point(63, 136);
            this.txtNomeCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeCategoria.Name = "txtNomeCategoria";
            this.txtNomeCategoria.Size = new System.Drawing.Size(354, 20);
            this.txtNomeCategoria.TabIndex = 34;
//            this.txtNomeCategoria.TextChanged += new System.EventHandler(this.txtNomeCategoria_TextChanged);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Cooper Black", 14F);
            this.txtNome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNome.Location = new System.Drawing.Point(137, 110);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(199, 24);
            this.txtNome.TabIndex = 33;
            this.txtNome.Text = "Nome da Categoria";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(59, 74);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(61, 20);
            this.txtID.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Cooper Black", 14F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(15, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 24);
            this.label2.TabIndex = 31;
            this.label2.Text = "ID";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnVoltar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVoltar.Font = new System.Drawing.Font("Cooper Black", 10F);
            this.btnVoltar.Location = new System.Drawing.Point(11, 267);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(85, 32);
            this.btnVoltar.TabIndex = 29;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAlterar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAlterar.Font = new System.Drawing.Font("Cooper Black", 16F);
            this.btnAlterar.Location = new System.Drawing.Point(141, 267);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(172, 32);
            this.btnAlterar.TabIndex = 28;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // AlteraCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(439, 318);
            this.Controls.Add(this.Teste);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtNomeCategoria);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.label1);
            this.Name = "AlteraCategoria";
            this.Text = "AlteraCategoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Teste;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtNomeCategoria;
        private System.Windows.Forms.Label txtNome;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnAlterar;
    }
}