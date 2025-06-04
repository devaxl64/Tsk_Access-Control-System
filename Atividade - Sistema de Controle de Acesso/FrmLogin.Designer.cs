namespace Atividade___Sistema_de_Controle_de_Acesso
{
    partial class FrmLogin
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
            btnEntrar = new Button();
            txtCpf = new TextBox();
            txtSenha = new TextBox();
            lnkRecuperar = new LinkLabel();
            lnkCadastro = new LinkLabel();
            lbLogin = new Label();
            lbSeparador = new Label();
            SuspendLayout();
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(120, 222);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(75, 23);
            btnEntrar.TabIndex = 3;
            btnEntrar.Text = "&Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(41, 111);
            txtCpf.Name = "txtCpf";
            txtCpf.PlaceholderText = "CPF";
            txtCpf.Size = new Size(232, 23);
            txtCpf.TabIndex = 1;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(41, 169);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '•';
            txtSenha.PlaceholderText = "Senha";
            txtSenha.Size = new Size(232, 23);
            txtSenha.TabIndex = 2;
            // 
            // lnkRecuperar
            // 
            lnkRecuperar.AutoSize = true;
            lnkRecuperar.Location = new Point(41, 278);
            lnkRecuperar.Name = "lnkRecuperar";
            lnkRecuperar.Size = new Size(119, 15);
            lnkRecuperar.TabIndex = 4;
            lnkRecuperar.TabStop = true;
            lnkRecuperar.Text = "Esqueci Minha Senha";
            // 
            // lnkCadastro
            // 
            lnkCadastro.AutoSize = true;
            lnkCadastro.Location = new Point(181, 278);
            lnkCadastro.Name = "lnkCadastro";
            lnkCadastro.Size = new Size(92, 15);
            lnkCadastro.TabIndex = 5;
            lnkCadastro.TabStop = true;
            lnkCadastro.Text = "Primeiro Acesso";
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLogin.ImageAlign = ContentAlignment.TopCenter;
            lbLogin.Location = new Point(111, 43);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(93, 35);
            lbLogin.TabIndex = 0;
            lbLogin.Text = "LOGIN";
            // 
            // lbSeparador
            // 
            lbSeparador.AutoSize = true;
            lbSeparador.Location = new Point(166, 278);
            lbSeparador.Name = "lbSeparador";
            lbSeparador.Size = new Size(10, 15);
            lbSeparador.TabIndex = 6;
            lbSeparador.Text = "|";
            // 
            // FrmLogin
            // 
            AcceptButton = btnEntrar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 325);
            Controls.Add(lbSeparador);
            Controls.Add(lbLogin);
            Controls.Add(lnkCadastro);
            Controls.Add(lnkRecuperar);
            Controls.Add(txtSenha);
            Controls.Add(txtCpf);
            Controls.Add(btnEntrar);
            MaximizeBox = false;
            Name = "FrmLogin";
            Text = "FrmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEntrar;
        private TextBox txtCpf;
        private TextBox txtSenha;
        private LinkLabel lnkRecuperar;
        private LinkLabel lnkCadastro;
        private Label lbLogin;
        private Label lbSeparador;
    }
}
