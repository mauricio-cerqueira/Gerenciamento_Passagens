namespace WindowsFormsApp2
{
    partial class Tela_login
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
            this.txt_cpf = new System.Windows.Forms.TextBox();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.btn_entrar = new System.Windows.Forms.Button();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_cpf
            // 
            this.txt_cpf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_cpf.Location = new System.Drawing.Point(56, 257);
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(236, 13);
            this.txt_cpf.TabIndex = 0;
            this.txt_cpf.Text = "CPF";
            this.txt_cpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_senha
            // 
            this.txt_senha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_senha.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_senha.Location = new System.Drawing.Point(56, 298);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(236, 13);
            this.txt_senha.TabIndex = 1;
            this.txt_senha.Text = "SENHA";
            this.txt_senha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_senha.TextChanged += new System.EventHandler(this.txt_senha_TextChanged);
            // 
            // btn_entrar
            // 
            this.btn_entrar.BackColor = System.Drawing.Color.Gold;
            this.btn_entrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_entrar.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.btn_entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_entrar.Location = new System.Drawing.Point(139, 369);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(141, 26);
            this.btn_entrar.TabIndex = 2;
            this.btn_entrar.Text = "ENTRAR";
            this.btn_entrar.UseVisualStyleBackColor = false;
            this.btn_entrar.UseWaitCursor = true;
            // 
            // btn_registrar
            // 
            this.btn_registrar.BackColor = System.Drawing.Color.Gold;
            this.btn_registrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_registrar.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.btn_registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrar.Location = new System.Drawing.Point(139, 423);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(141, 26);
            this.btn_registrar.TabIndex = 3;
            this.btn_registrar.Text = "REGISTRAR";
            this.btn_registrar.UseVisualStyleBackColor = false;
            this.btn_registrar.UseWaitCursor = true;
        // 
            // Tela_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.Capturar;
            this.ClientSize = new System.Drawing.Size(341, 561);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.btn_entrar);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.txt_cpf);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Tela_login";
            this.Text = "BUZZ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_cpf;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Button btn_entrar;
        private System.Windows.Forms.Button btn_registrar;
    }
}

