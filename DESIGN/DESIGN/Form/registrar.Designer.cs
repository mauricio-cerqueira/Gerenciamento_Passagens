namespace DESIGN
{
    partial class registrar
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
            this.btn_registro = new System.Windows.Forms.Button();
            this.btn_logo = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSobrenome = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_registro
            // 
            this.btn_registro.BackColor = System.Drawing.Color.Transparent;
            this.btn_registro.FlatAppearance.BorderSize = 0;
            this.btn_registro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registro.Location = new System.Drawing.Point(75, 394);
            this.btn_registro.Name = "btn_registro";
            this.btn_registro.Size = new System.Drawing.Size(151, 25);
            this.btn_registro.TabIndex = 6;
            this.btn_registro.UseVisualStyleBackColor = false;
            this.btn_registro.Click += new System.EventHandler(this.btn_registro_Click);
            // 
            // btn_logo
            // 
            this.btn_logo.BackColor = System.Drawing.Color.Transparent;
            this.btn_logo.FlatAppearance.BorderSize = 0;
            this.btn_logo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logo.Location = new System.Drawing.Point(23, 50);
            this.btn_logo.Name = "btn_logo";
            this.btn_logo.Size = new System.Drawing.Size(50, 45);
            this.btn_logo.TabIndex = 7;
            this.btn_logo.UseVisualStyleBackColor = false;
            this.btn_logo.Click += new System.EventHandler(this.btn_logo_Click);
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.txtNome.Location = new System.Drawing.Point(23, 170);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(252, 13);
            this.txtNome.TabIndex = 8;
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSobrenome.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.txtSobrenome.Location = new System.Drawing.Point(23, 216);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(252, 13);
            this.txtSobrenome.TabIndex = 9;
            // 
            // txtCPF
            // 
            this.txtCPF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCPF.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.txtCPF.Location = new System.Drawing.Point(23, 258);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(252, 13);
            this.txtCPF.TabIndex = 10;
            // 
            // txtTelefone
            // 
            this.txtTelefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefone.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.txtTelefone.Location = new System.Drawing.Point(23, 298);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(252, 13);
            this.txtTelefone.TabIndex = 11;
            // 
            // txtSenha
            // 
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.txtSenha.Location = new System.Drawing.Point(23, 343);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(252, 13);
            this.txtSenha.TabIndex = 12;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.SystemColors.Window;
            this.lblNome.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblNome.Location = new System.Drawing.Point(34, 170);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(39, 13);
            this.lblNome.TabIndex = 13;
            this.lblNome.Text = "NOME";
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.AutoSize = true;
            this.lblSobrenome.BackColor = System.Drawing.SystemColors.Window;
            this.lblSobrenome.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblSobrenome.Location = new System.Drawing.Point(34, 216);
            this.lblSobrenome.Name = "lblSobrenome";
            this.lblSobrenome.Size = new System.Drawing.Size(76, 13);
            this.lblSobrenome.TabIndex = 14;
            this.lblSobrenome.Text = "SOBRENOME";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.BackColor = System.Drawing.SystemColors.Window;
            this.lblCPF.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblCPF.Location = new System.Drawing.Point(34, 258);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(27, 13);
            this.lblCPF.TabIndex = 15;
            this.lblCPF.Text = "CPF";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.BackColor = System.Drawing.SystemColors.Window;
            this.lblTelefone.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblTelefone.Location = new System.Drawing.Point(34, 298);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(63, 13);
            this.lblTelefone.TabIndex = 16;
            this.lblTelefone.Text = "TELEFONE";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.BackColor = System.Drawing.SystemColors.Window;
            this.lblSenha.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblSenha.Location = new System.Drawing.Point(34, 343);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(44, 13);
            this.lblSenha.TabIndex = 17;
            this.lblSenha.Text = "SENHA";
            // 
            // registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DESIGN.Properties.Resources.Slide22;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(304, 601);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblSobrenome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtSobrenome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btn_logo);
            this.Controls.Add(this.btn_registro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "registrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BUZZ - REGISTRAR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_registro;
        private System.Windows.Forms.Button btn_logo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSobrenome;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblSenha;
    }
}