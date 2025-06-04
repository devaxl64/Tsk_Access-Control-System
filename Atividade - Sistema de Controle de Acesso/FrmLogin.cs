using ControleAcesso.Core;
namespace Atividade___Sistema_de_Controle_de_Acesso
{
    public partial class FrmLogin : Form
    {
        private bool logado = false;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtCpf.Text != string.Empty && txtSenha.Text != string.Empty)
            {
                var usuario = Usuario.EfetuarLogin(txtCpf.Text, txtSenha.Text);
                if (usuario.Id > 0)
                {
                    logado = true;
                    FrmRegistroAcesso registro = new FrmRegistroAcesso(usuario.Id, usuario.Nome);
                    RegistroAcesso entrada = new RegistroAcesso(usuario.Id);
                    registro.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Deu ruim!");
                }
            }
            else
            {
                MessageBox.Show("Os campos 'CPF' e 'Senha' são obrigatórios!");
            }
        }
    }
}
