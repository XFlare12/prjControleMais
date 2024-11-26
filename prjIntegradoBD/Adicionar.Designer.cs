namespace prjIntegradoBD
{
    partial class Adicionar
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
            this.btnCriar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.checkOpcoes = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSenhaConfirm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCriar
            // 
            this.btnCriar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCriar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCriar.Font = new System.Drawing.Font("Cooper Black", 15F);
            this.btnCriar.Location = new System.Drawing.Point(152, 329);
            this.btnCriar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(164, 32);
            this.btnCriar.TabIndex = 0;
            this.btnCriar.Text = "Criar";
            this.btnCriar.UseVisualStyleBackColor = false;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnVoltar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVoltar.Font = new System.Drawing.Font("Cooper Black", 10F);
            this.btnVoltar.Location = new System.Drawing.Point(11, 329);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(77, 32);
            this.btnVoltar.TabIndex = 1;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // checkOpcoes
            // 
            this.checkOpcoes.BackColor = System.Drawing.SystemColors.HotTrack;
            this.checkOpcoes.CheckOnClick = true;
            this.checkOpcoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkOpcoes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkOpcoes.FormattingEnabled = true;
            this.checkOpcoes.Items.AddRange(new object[] {
            "ADMIN",
            "EMPREGADO"});
            this.checkOpcoes.Location = new System.Drawing.Point(152, 261);
            this.checkOpcoes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkOpcoes.Name = "checkOpcoes";
            this.checkOpcoes.Size = new System.Drawing.Size(180, 46);
            this.checkOpcoes.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Cooper Black", 20F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(78, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Criar Usuário";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(150, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome do Usuário";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(152, 101);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(181, 20);
            this.txtUsuario.TabIndex = 6;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(154, 153);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(179, 20);
            this.txtSenha.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(153, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Senha";
            // 
            // txtSenhaConfirm
            // 
            this.txtSenhaConfirm.Location = new System.Drawing.Point(152, 206);
            this.txtSenhaConfirm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSenhaConfirm.Name = "txtSenhaConfirm";
            this.txtSenhaConfirm.Size = new System.Drawing.Size(180, 20);
            this.txtSenhaConfirm.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(151, 182);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Confirme a senha";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(150, 234);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Selecione o cargo:";
            // 
            // Adicionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(484, 374);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSenhaConfirm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkOpcoes);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnCriar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Adicionar";
            this.Text = "Adicionar";
            this.Load += new System.EventHandler(this.Adicionar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.CheckedListBox checkOpcoes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSenhaConfirm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}