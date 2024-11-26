namespace prjIntegradoBD
{
    partial class EmpregadoForm
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
            this.btnMostrarCategoria = new System.Windows.Forms.Button();
            this.btnMostrarProduto = new System.Windows.Forms.Button();
            this.dgvTabela = new System.Windows.Forms.DataGridView();
            this.btnDelProd = new System.Windows.Forms.Button();
            this.btnAdcProd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelCategoria = new System.Windows.Forms.Button();
            this.btnAdcCategoria = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAlterarProduto = new System.Windows.Forms.Button();
            this.btnAlterarCategoria = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabela)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMostrarCategoria
            // 
            this.btnMostrarCategoria.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnMostrarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnMostrarCategoria.Location = new System.Drawing.Point(27, 40);
            this.btnMostrarCategoria.Name = "btnMostrarCategoria";
            this.btnMostrarCategoria.Size = new System.Drawing.Size(138, 47);
            this.btnMostrarCategoria.TabIndex = 2;
            this.btnMostrarCategoria.Text = "Categoria";
            this.btnMostrarCategoria.UseVisualStyleBackColor = false;
            this.btnMostrarCategoria.Click += new System.EventHandler(this.btnMostrarCategoria_Click);
            // 
            // btnMostrarProduto
            // 
            this.btnMostrarProduto.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnMostrarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnMostrarProduto.Location = new System.Drawing.Point(27, 158);
            this.btnMostrarProduto.Name = "btnMostrarProduto";
            this.btnMostrarProduto.Size = new System.Drawing.Size(138, 46);
            this.btnMostrarProduto.TabIndex = 3;
            this.btnMostrarProduto.Text = "Produto";
            this.btnMostrarProduto.UseVisualStyleBackColor = false;
            this.btnMostrarProduto.Click += new System.EventHandler(this.btnMostrarProduto_Click);
            // 
            // dgvTabela
            // 
            this.dgvTabela.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.dgvTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabela.GridColor = System.Drawing.SystemColors.Desktop;
            this.dgvTabela.Location = new System.Drawing.Point(184, 12);
            this.dgvTabela.Name = "dgvTabela";
            this.dgvTabela.Size = new System.Drawing.Size(712, 297);
            this.dgvTabela.TabIndex = 13;
            // 
            // btnDelProd
            // 
            this.btnDelProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnDelProd.Location = new System.Drawing.Point(295, 432);
            this.btnDelProd.Name = "btnDelProd";
            this.btnDelProd.Size = new System.Drawing.Size(137, 33);
            this.btnDelProd.TabIndex = 16;
            this.btnDelProd.Text = "Deletar";
            this.btnDelProd.UseVisualStyleBackColor = true;
            this.btnDelProd.Click += new System.EventHandler(this.btnDelProd_Click);
            // 
            // btnAdcProd
            // 
            this.btnAdcProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnAdcProd.Location = new System.Drawing.Point(296, 344);
            this.btnAdcProd.Name = "btnAdcProd";
            this.btnAdcProd.Size = new System.Drawing.Size(137, 35);
            this.btnAdcProd.TabIndex = 15;
            this.btnAdcProd.Text = "Adicionar";
            this.btnAdcProd.UseVisualStyleBackColor = true;
            this.btnAdcProd.Click += new System.EventHandler(this.btnAdcProd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 16F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(312, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Produto";
            // 
            // btnDelCategoria
            // 
            this.btnDelCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnDelCategoria.Location = new System.Drawing.Point(624, 430);
            this.btnDelCategoria.Name = "btnDelCategoria";
            this.btnDelCategoria.Size = new System.Drawing.Size(137, 33);
            this.btnDelCategoria.TabIndex = 19;
            this.btnDelCategoria.Text = "Deletar";
            this.btnDelCategoria.UseVisualStyleBackColor = true;
            this.btnDelCategoria.Click += new System.EventHandler(this.btnDelCategoria_Click);
            // 
            // btnAdcCategoria
            // 
            this.btnAdcCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnAdcCategoria.Location = new System.Drawing.Point(624, 344);
            this.btnAdcCategoria.Name = "btnAdcCategoria";
            this.btnAdcCategoria.Size = new System.Drawing.Size(137, 35);
            this.btnAdcCategoria.TabIndex = 18;
            this.btnAdcCategoria.Text = "Adicionar";
            this.btnAdcCategoria.UseVisualStyleBackColor = true;
            this.btnAdcCategoria.Click += new System.EventHandler(this.btnAdcCategoria_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 16F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(630, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Categoria";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(12, 445);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 19);
            this.label5.TabIndex = 20;
            this.label5.Text = "Controle+";
            // 
            // btnAlterarProduto
            // 
            this.btnAlterarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnAlterarProduto.Location = new System.Drawing.Point(296, 387);
            this.btnAlterarProduto.Name = "btnAlterarProduto";
            this.btnAlterarProduto.Size = new System.Drawing.Size(137, 35);
            this.btnAlterarProduto.TabIndex = 21;
            this.btnAlterarProduto.Text = "Alterar";
            this.btnAlterarProduto.UseVisualStyleBackColor = true;
            this.btnAlterarProduto.Click += new System.EventHandler(this.btnAlterarProduto_Click);
            // 
            // btnAlterarCategoria
            // 
            this.btnAlterarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnAlterarCategoria.Location = new System.Drawing.Point(624, 387);
            this.btnAlterarCategoria.Name = "btnAlterarCategoria";
            this.btnAlterarCategoria.Size = new System.Drawing.Size(137, 35);
            this.btnAlterarCategoria.TabIndex = 22;
            this.btnAlterarCategoria.Text = "Alterar";
            this.btnAlterarCategoria.UseVisualStyleBackColor = true;
            this.btnAlterarCategoria.Click += new System.EventHandler(this.btnAlterarCategoria_Click);
            // 
            // EmpregadoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(912, 473);
            this.Controls.Add(this.btnAlterarCategoria);
            this.Controls.Add(this.btnAlterarProduto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDelCategoria);
            this.Controls.Add(this.btnAdcCategoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDelProd);
            this.Controls.Add(this.btnAdcProd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTabela);
            this.Controls.Add(this.btnMostrarProduto);
            this.Controls.Add(this.btnMostrarCategoria);
            this.Name = "EmpregadoForm";
            this.Text = "EmpregadoForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMostrarCategoria;
        private System.Windows.Forms.Button btnMostrarProduto;
        private System.Windows.Forms.DataGridView dgvTabela;
        private System.Windows.Forms.Button btnDelProd;
        private System.Windows.Forms.Button btnAdcProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelCategoria;
        private System.Windows.Forms.Button btnAdcCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAlterarProduto;
        private System.Windows.Forms.Button btnAlterarCategoria;
    }
}