using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleAcesso.Core;

namespace Atividade___Sistema_de_Controle_de_Acesso
{
    public partial class FrmRegistroAcesso : Form
    {
        private int usuarioId { get; set; } // Ajuda do GPT

        public FrmRegistroAcesso(int id, string nome) // Ajuda do GPT
        {
            InitializeComponent();
            usuarioId = id; // Ajuda do GPT

            lbNome.Text = $"Bem-Vindo {nome}"; // Ajuda do GPT
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            try
            {
                RegistroAcesso.EntradaPorId(usuarioId);
                MessageBox.Show($"Registrado com Sucesso");
            }
            catch (Exception ex) // Ajuda do GPT (Só a parte da mensagem de erro)
            {
                MessageBox.Show($"Erro ao registrar entrada: " +
                     ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaida_Click(object sender, EventArgs e)
        {
            try
            {
                RegistroAcesso.SaidaPorId(usuarioId);
                MessageBox.Show($"Registrado com Sucesso");
            }
            catch (Exception ex) // Ajuda do GPT (Só a parte da mensagem de erro)
            {
                MessageBox.Show($"Erro ao registrar saida: " +
                     ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Application.Exit();
        }

    }
}
