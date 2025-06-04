namespace Atividade___Sistema_de_Controle_de_Acesso
{
    partial class FrmConsulta
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
            dvgUsuarios = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnNome = new DataGridViewTextBoxColumn();
            clnCpf = new DataGridViewTextBoxColumn();
            clnTipo = new DataGridViewTextBoxColumn();
            btnBuscar = new Button();
            txtPesquisar = new TextBox();
            txtCpf = new TextBox();
            textBox2 = new TextBox();
            lbCpf = new Label();
            lbNome = new Label();
            ((System.ComponentModel.ISupportInitialize)dvgUsuarios).BeginInit();
            SuspendLayout();
            // 
            // dvgUsuarios
            // 
            dvgUsuarios.AllowUserToAddRows = false;
            dvgUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgUsuarios.Columns.AddRange(new DataGridViewColumn[] { clnId, clnNome, clnCpf, clnTipo });
            dvgUsuarios.Location = new Point(12, 126);
            dvgUsuarios.Name = "dvgUsuarios";
            dvgUsuarios.RowHeadersVisible = false;
            dvgUsuarios.Size = new Size(425, 150);
            dvgUsuarios.TabIndex = 0;
            // 
            // clnId
            // 
            clnId.HeaderText = "ID";
            clnId.Name = "clnId";
            clnId.Width = 40;
            // 
            // clnNome
            // 
            clnNome.HeaderText = "Nome";
            clnNome.Name = "clnNome";
            clnNome.Width = 200;
            // 
            // clnCpf
            // 
            clnCpf.HeaderText = "CPF";
            clnCpf.Name = "clnCpf";
            clnCpf.Width = 80;
            // 
            // clnTipo
            // 
            clnTipo.HeaderText = "Tipo";
            clnTipo.Name = "clnTipo";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(179, 12);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(12, 12);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.PlaceholderText = "Pesquisar";
            txtPesquisar.Size = new Size(148, 23);
            txtPesquisar.TabIndex = 2;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(58, 53);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(148, 23);
            txtCpf.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(58, 82);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(242, 23);
            textBox2.TabIndex = 2;
            // 
            // lbCpf
            // 
            lbCpf.AutoSize = true;
            lbCpf.Location = new Point(12, 56);
            lbCpf.Name = "lbCpf";
            lbCpf.Size = new Size(28, 15);
            lbCpf.TabIndex = 3;
            lbCpf.Text = "CPF";
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Location = new Point(12, 85);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(40, 15);
            lbNome.TabIndex = 3;
            lbNome.Text = "Nome";
            // 
            // FrmConsulta
            // 
            AcceptButton = btnBuscar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 288);
            Controls.Add(lbNome);
            Controls.Add(lbCpf);
            Controls.Add(textBox2);
            Controls.Add(txtCpf);
            Controls.Add(txtPesquisar);
            Controls.Add(btnBuscar);
            Controls.Add(dvgUsuarios);
            Name = "FrmConsulta";
            Text = "FrmConsulta";
            ((System.ComponentModel.ISupportInitialize)dvgUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dvgUsuarios;
        private Button btnBuscar;
        private TextBox txtPesquisar;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnCpf;
        private DataGridViewTextBoxColumn clnTipo;
        private TextBox txtCpf;
        private TextBox textBox2;
        private Label lbCpf;
        private Label lbNome;
    }
}