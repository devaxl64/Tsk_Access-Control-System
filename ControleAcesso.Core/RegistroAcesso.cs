using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mysqlx.Crud;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ControleAcesso.Core
{
    public enum TipoOperacao { Entrada, Saida }
    public class RegistroAcesso
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public DateTime DataHora { get; set; }
        public string TipoOperacao { get; set; } // Entrada ou Saída


        // Copiado da Classe Senha do Professor, Ainda precisa analisar e ajustar os comando abaixo
        public RegistroAcesso()
        {

        }
        public RegistroAcesso(int id, int usuarioId, DateTime dataHora, string tipoOperacao)
        {
            Id = id;
            UsuarioId = usuarioId;
            DataHora = dataHora;
            TipoOperacao = tipoOperacao;
        }
        public RegistroAcesso(int usuarioId, DateTime dataHora, string tipoOperacao)
        {
            UsuarioId = usuarioId;
            DataHora = dataHora;
            TipoOperacao = tipoOperacao;
        }
        public RegistroAcesso(DateTime dataHora, string tipoOperacao)
        {
            DataHora = dataHora;
            TipoOperacao = tipoOperacao;
        }
        public RegistroAcesso(int usuarioId)
        {
            UsuarioId = usuarioId;
        }

        public static void EntradaPorId(int usuarioId)
        {
            //update registros set data_hora = current_timestamp(), tipo_operacao = 'Entrada' where id = 2;
            // INSERT INTO atvcontroledb.registros (id_usuario, data_hora, tipo_operacao) VALUES(1, current_timestamp(), 'Entrada');
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"INSERT INTO atvcontroledb.registros (id_usuario, data_hora, tipo_operacao) " +
                $"VALUES({usuarioId}, current_timestamp(), 'Entrada');";
            var dr = cmd.ExecuteReader();
        }
        public static void SaidaPorId(int usuarioId)
        {
            //update registros set data_hora = current_timestamp(), tipo_operacao = 'Saida' where id = 2;
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"INSERT INTO atvcontroledb.registros (id_usuario, data_hora, tipo_operacao) " +
                $"VALUES({usuarioId}, current_timestamp(), 'Saida');";
            var dr = cmd.ExecuteReader();
        }
    }
    
    
}
