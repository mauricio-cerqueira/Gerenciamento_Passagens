namespace DESIGN
{
    partial class main_page
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
            this.btnAgendar = new System.Windows.Forms.Button();
            this.btnViagens = new System.Windows.Forms.Button();
            this.cbListaCidades = new System.Windows.Forms.ComboBox();
            this.cbListaCidadesVolta = new System.Windows.Forms.ComboBox();
            this.txtDataViagem = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAgendar
            // 
            this.btnAgendar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgendar.FlatAppearance.BorderSize = 0;
            this.btnAgendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgendar.Location = new System.Drawing.Point(39, 272);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(159, 25);
            this.btnAgendar.TabIndex = 0;
            this.btnAgendar.UseVisualStyleBackColor = false;
            this.btnAgendar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnViagens
            // 
            this.btnViagens.BackColor = System.Drawing.Color.Transparent;
            this.btnViagens.FlatAppearance.BorderSize = 0;
            this.btnViagens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViagens.Location = new System.Drawing.Point(39, 364);
            this.btnViagens.Name = "btnViagens";
            this.btnViagens.Size = new System.Drawing.Size(159, 25);
            this.btnViagens.TabIndex = 1;
            this.btnViagens.UseVisualStyleBackColor = false;
            this.btnViagens.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbListaCidades
            // 
            this.cbListaCidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbListaCidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbListaCidades.ForeColor = System.Drawing.Color.Goldenrod;
            this.cbListaCidades.FormattingEnabled = true;
            this.cbListaCidades.Location = new System.Drawing.Point(39, 94);
            this.cbListaCidades.Name = "cbListaCidades";
            this.cbListaCidades.Size = new System.Drawing.Size(210, 23);
            this.cbListaCidades.TabIndex = 2;
            this.cbListaCidades.Text = "PONTO DE SAIDA";
            this.cbListaCidades.SelectedIndexChanged += new System.EventHandler(this.cbListaCidades_SelectedIndexChanged);
            // 
            // cbListaCidadesVolta
            // 
            this.cbListaCidadesVolta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbListaCidadesVolta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbListaCidadesVolta.ForeColor = System.Drawing.Color.Goldenrod;
            this.cbListaCidadesVolta.FormattingEnabled = true;
            this.cbListaCidadesVolta.Location = new System.Drawing.Point(39, 137);
            this.cbListaCidadesVolta.Name = "cbListaCidadesVolta";
            this.cbListaCidadesVolta.Size = new System.Drawing.Size(210, 23);
            this.cbListaCidadesVolta.TabIndex = 3;
            this.cbListaCidadesVolta.Text = "PONTO DE CHEGADA";
            // 
            // txtDataViagem
            // 
            this.txtDataViagem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDataViagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataViagem.ForeColor = System.Drawing.Color.Goldenrod;
            this.txtDataViagem.Location = new System.Drawing.Point(39, 183);
            this.txtDataViagem.Name = "txtDataViagem";
            this.txtDataViagem.Size = new System.Drawing.Size(133, 14);
            this.txtDataViagem.TabIndex = 4;
            this.txtDataViagem.Text = "DATA DA VIAGEM";
            // 
            // main_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DESIGN.Properties.Resources.Slide33;
            this.ClientSize = new System.Drawing.Size(304, 601);
            this.Controls.Add(this.txtDataViagem);
            this.Controls.Add(this.cbListaCidadesVolta);
            this.Controls.Add(this.cbListaCidades);
            this.Controls.Add(this.btnViagens);
            this.Controls.Add(this.btnAgendar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "main_page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "main_page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgendar;
        private System.Windows.Forms.Button btnViagens;
        private System.Windows.Forms.ComboBox cbListaCidades;
        private System.Windows.Forms.ComboBox cbListaCidadesVolta;
        private System.Windows.Forms.TextBox txtDataViagem;
    }
}