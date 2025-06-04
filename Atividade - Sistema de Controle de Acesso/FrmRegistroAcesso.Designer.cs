namespace Atividade___Sistema_de_Controle_de_Acesso
{
    partial class FrmRegistroAcesso
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
            components = new System.ComponentModel.Container();
            btnEntrada = new Button();
            btnSaida = new Button();
            cmsAdmin = new ContextMenuStrip(components);
            lbNome = new Label();
            SuspendLayout();
            // 
            // btnEntrada
            // 
            btnEntrada.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrada.Location = new Point(28, 76);
            btnEntrada.Name = "btnEntrada";
            btnEntrada.Size = new Size(177, 65);
            btnEntrada.TabIndex = 0;
            btnEntrada.Text = "ENTRADA";
            btnEntrada.UseVisualStyleBackColor = true;
            btnEntrada.Click += btnEntrada_Click;
            // 
            // btnSaida
            // 
            btnSaida.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaida.Location = new Point(28, 184);
            btnSaida.Name = "btnSaida";
            btnSaida.Size = new Size(177, 65);
            btnSaida.TabIndex = 0;
            btnSaida.Text = "SAIDA";
            btnSaida.UseVisualStyleBackColor = true;
            btnSaida.Click += btnSaida_Click;
            // 
            // cmsAdmin
            // 
            cmsAdmin.Name = "cmsAdmin";
            cmsAdmin.Size = new Size(61, 4);
            cmsAdmin.Text = "Administrador";
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Location = new Point(63, 30);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(38, 15);
            lbNome.TabIndex = 1;
            lbNome.Text = "label1";
            // 
            // FrmRegistroAcesso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(244, 300);
            Controls.Add(lbNome);
            Controls.Add(btnSaida);
            Controls.Add(btnEntrada);
            MaximizeBox = false;
            Name = "FrmRegistroAcesso";
            Text = "FrmRegistroAcesso";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEntrada;
        private Button btnSaida;
        private ContextMenuStrip cmsAdmin;
        private Label lbNome;
    }
}