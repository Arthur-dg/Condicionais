namespace Condicional
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLimpar = new Button();
            btnEntrar = new Button();
            lbUsuário = new Label();
            lbSenha = new Label();
            txtSenha = new TextBox();
            txtUsuário = new TextBox();
            SuspendLayout();
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(215, 227);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(112, 51);
            btnLimpar.TabIndex = 0;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(66, 227);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(112, 51);
            btnEntrar.TabIndex = 1;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // lbUsuário
            // 
            lbUsuário.AutoSize = true;
            lbUsuário.Location = new Point(66, 69);
            lbUsuário.Name = "lbUsuário";
            lbUsuário.Size = new Size(72, 25);
            lbUsuário.TabIndex = 2;
            lbUsuário.Text = "Usuário";
            // 
            // lbSenha
            // 
            lbSenha.AutoSize = true;
            lbSenha.Location = new Point(66, 161);
            lbSenha.Name = "lbSenha";
            lbSenha.Size = new Size(60, 25);
            lbSenha.TabIndex = 3;
            lbSenha.Text = "Senha";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(177, 161);
            txtSenha.MaxLength = 40;
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(178, 31);
            txtSenha.TabIndex = 4;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // txtUsuário
            // 
            txtUsuário.Location = new Point(177, 69);
            txtUsuário.MaxLength = 25;
            txtUsuário.Name = "txtUsuário";
            txtUsuário.Size = new Size(178, 31);
            txtUsuário.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1268, 609);
            Controls.Add(txtUsuário);
            Controls.Add(txtSenha);
            Controls.Add(lbSenha);
            Controls.Add(lbUsuário);
            Controls.Add(btnEntrar);
            Controls.Add(btnLimpar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLimpar;
        private Button btnEntrar;
        private Label lbUsuário;
        private Label lbSenha;
        private TextBox txtSenha;
        private TextBox txtUsuário;
    }
}
