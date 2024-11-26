namespace prjIntegradoBD
{
    partial class AlteraFuncionario
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
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtNomeCategoria = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Teste
            // 
            this.Teste.Font = new System.Drawing.Font("Cooper Black", 14F);
            this.Teste.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Teste.Location = new System.Drawing.Point(159, 156);
            this.Teste.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Teste.Name = "Teste";
            this.Teste.Size = new System.Drawing.Size(119, 24);
            this.Teste.TabIndex = 51;
            this.Teste.Text = "Endereço";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(52, 187);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(2);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(346, 20);
            this.txtEndereco.TabIndex = 50;
            // 
            // txtNomeCategoria
            // 
            this.txtNomeCategoria.Location = new System.Drawing.Point(52, 134);
            this.txtNomeCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeCategoria.Name = "txtNomeCategoria";
            this.txtNomeCategoria.Size = new System.Drawing.Size(346, 20);
            this.txtNomeCategoria.TabIndex = 49;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Cooper Black", 14F);
            this.txtNome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNome.Location = new System.Drawing.Point(113, 102);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(218, 24);
            this.txtNome.TabIndex = 48;
            this.txtNome.Text = "Nome do Funcionário";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(40, 71);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(53, 20);
            this.txtID.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Cooper Black", 14F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(8, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 24);
            this.label2.TabIndex = 46;
            this.label2.Text = "ID";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnVoltar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVoltar.Font = new System.Drawing.Font("Cooper Black", 10F);
            this.btnVoltar.Location = new System.Drawing.Point(11, 317);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(77, 32);
            this.btnVoltar.TabIndex = 45;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAlterar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAlterar.Font = new System.Drawing.Font("Cooper Black", 16F);
            this.btnAlterar.Location = new System.Drawing.Point(141, 317);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(164, 32);
            this.btnAlterar.TabIndex = 44;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Cooper Black", 20F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(46, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 30);
            this.label1.TabIndex = 43;
            this.label1.Text = "Alterar Funcionário";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(287, 279);
            this.txtSalario.Margin = new System.Windows.Forms.Padding(2);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(60, 20);
            this.txtSalario.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(215, 278);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 25);
            this.label5.TabIndex = 54;
            this.label5.Text = "Salário";
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(141, 278);
            this.txtIdade.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(46, 20);
            this.txtIdade.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(80, 277);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 24);
            this.label4.TabIndex = 52;
            this.label4.Text = "Idade";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Cooper Black", 14F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(162, 209);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 24);
            this.label3.TabIndex = 57;
            this.label3.Text = "Cargo";
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(52, 240);
            this.txtCargo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(346, 20);
            this.txtCargo.TabIndex = 56;
            // 
            // AlteraFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(422, 371);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Teste);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtNomeCategoria);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.label1);
            this.Name = "AlteraFuncionario";
            this.Text = "AlteraFuncionario";
            this.Load += new System.EventHandler(this.AlteraFuncionario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Teste;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtNomeCategoria;
        private System.Windows.Forms.Label txtNome;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCargo;
    }
}