using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

using System.Data.SQLite;
using System.IO;

public class BancoDadosHelper
{
    private string caminhoPastaBancoDados = @"d:\Downloads\UNIP\projeto PIM V\repos\WinFormsApp1\WinFormsApp1\BancoDeDados";
    // private string caminhoPastaBancoDados = @"C:\Users\Cop\Documents\Visual Studio 2022\projeto PIM V\repos\WinFormsApp1\WinFormsApp1\BancoDeDados";
    private string caminhoBancoDados;
    private string stringConexao;

    public BancoDadosHelper()
    {
        caminhoBancoDados = Path.Combine(caminhoPastaBancoDados, "reserva_equipamentos.db");
        stringConexao = $"Data Source={caminhoBancoDados};Version=3;";
    }

    public SQLiteConnection AbrirConexao()
    {
        SQLiteConnection conexao = new SQLiteConnection(stringConexao);
        conexao.Open();
        return conexao;
    }

    public void FecharConexao(SQLiteConnection conexao)
    {
        if (conexao != null && conexao.State == System.Data.ConnectionState.Open)
        {
            conexao.Close();
        }
    }

    public int ExecutarComando(string comandoSql, SQLiteParameter[] parametros = null)
    {
        using (SQLiteConnection conexao = AbrirConexao())
        {
            using (SQLiteCommand comando = new SQLiteCommand(comandoSql, conexao))
            {
                if (parametros != null)
                {
                    comando.Parameters.AddRange(parametros);
                }
                return comando.ExecuteNonQuery();
            }
        }
    }

    public SQLiteDataReader ExecutarConsulta(string comandoSql, SQLiteParameter[] parametros = null)
    {
        SQLiteConnection conexao = AbrirConexao();
        SQLiteCommand comando = new SQLiteCommand(comandoSql, conexao);
        if (parametros != null)
        {
            comando.Parameters.AddRange(parametros);
        }
        return comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
    }

    // Métodos para a tabela Equipamentos
    public int InserirEquipamento(string nome, string tipo, string descricao, string status)
    {
        string comandoSql = "INSERT INTO Equipamentos (nome, tipo, descricao, status) VALUES (@nome, @tipo, @descricao, @status)";
        SQLiteParameter[] parametros = {
            new SQLiteParameter("@nome", nome),
            new SQLiteParameter("@tipo", tipo),
            new SQLiteParameter("@descricao", descricao),
            new SQLiteParameter("@status", status)
        };
        return ExecutarComando(comandoSql, parametros);
    }

    public int AtualizarEquipamento(int id, string nome, string tipo, string descricao, string status)
    {
        string comandoSql = "UPDATE Equipamentos SET nome = @nome, tipo = @tipo, descricao = @descricao, status = @status WHERE id = @id";
        SQLiteParameter[] parametros = {
            new SQLiteParameter("@nome", nome),
            new SQLiteParameter("@tipo", tipo),
            new SQLiteParameter("@descricao", descricao),
            new SQLiteParameter("@status", status),
            new SQLiteParameter("@id", id)
        };
        return ExecutarComando(comandoSql, parametros);
    }

    public int ExcluirEquipamento(int id)
    {
        string comandoSql = "DELETE FROM Equipamentos WHERE id = @id";
        SQLiteParameter[] parametros = { new SQLiteParameter("@id", id) };
        return ExecutarComando(comandoSql, parametros);
    }

    public SQLiteDataReader ConsultarEquipamentos()
    {
        string comandoSql = "SELECT * FROM Equipamentos";
        return ExecutarConsulta(comandoSql);
    }

    public SQLiteDataReader ConsultarEquipamentosDisponiveis()
    {
        string comandoSql = "SELECT * FROM Equipamentos WHERE status = 'Disponível'";
        return ExecutarConsulta(comandoSql);
    }

    public int AtualizarStatusEquipamento(int equipamentoId, string status)
    {
        string comandoSql = "UPDATE Equipamentos SET status = @status WHERE id = @id";
        SQLiteParameter[] parametros = {
            new SQLiteParameter("@status", status),
            new SQLiteParameter("@id", equipamentoId)
        };
        return ExecutarComando(comandoSql, parametros);
    }


    // Métodos para a tabela Usuarios
    public int InserirUsuario(string nome, string login, string senha, string tipo)
    {
        string comandoSql = "INSERT INTO Usuarios (nome, login, senha, tipo) VALUES (@nome, @login, @senha, @tipo)";
        SQLiteParameter[] parametros = {
            new SQLiteParameter("@nome", nome),
            new SQLiteParameter("@login", login),
            new SQLiteParameter("@senha", senha),
            new SQLiteParameter("@tipo", tipo)
        };
        return ExecutarComando(comandoSql, parametros);
    }

    public int AtualizarUsuario(int id, string nome, string login, string senha, string tipo)
    {
        string comandoSql = "UPDATE Usuarios SET nome = @nome, login = @login, senha = @senha, tipo = @tipo WHERE id = @id";
        SQLiteParameter[] parametros = {
            new SQLiteParameter("@nome", nome),
            new SQLiteParameter("@login", login),
            new SQLiteParameter("@senha", senha),
            new SQLiteParameter("@tipo", tipo),
            new SQLiteParameter("@id", id)
        };
        return ExecutarComando(comandoSql, parametros);
    }

    public int ExcluirUsuario(int id)
    {
        string comandoSql = "DELETE FROM Usuarios WHERE id = @id";
        SQLiteParameter[] parametros = { new SQLiteParameter("@id", id) };
        return ExecutarComando(comandoSql, parametros);
    }

    public SQLiteDataReader ConsultarUsuarios()
    {
        string comandoSql = "SELECT * FROM Usuarios";
        return ExecutarConsulta(comandoSql);
    }

    // Métodos para a tabela Agendamentos
    public int InserirAgendamento(int equipamentoId, int usuarioId, string data, string hora, string sala)
    {
        string comandoSql = "INSERT INTO Agendamentos (equipamento_id, usuario_id, data, hora, sala) VALUES (@equipamentoId, @usuarioId, @data, @hora, @sala)";
        SQLiteParameter[] parametros = {
            new SQLiteParameter("@equipamentoId", equipamentoId),
            new SQLiteParameter("@usuarioId", usuarioId),
            new SQLiteParameter("@data", data),
            new SQLiteParameter("@hora", hora),
            new SQLiteParameter("@sala", sala)
        };
        return ExecutarComando(comandoSql, parametros);
    }

    public int AtualizarAgendamento(int id, int equipamentoId, int usuarioId, string data, string hora, string sala)
    {
        string comandoSql = "UPDATE Agendamentos SET equipamento_id = @equipamentoId, usuario_id = @usuarioId, data = @data, hora = @hora, sala = @sala WHERE id = @id";
        SQLiteParameter[] parametros = {
            new SQLiteParameter("@equipamentoId", equipamentoId),
            new SQLiteParameter("@usuarioId", usuarioId),
            new SQLiteParameter("@data", data),
            new SQLiteParameter("@hora", hora),
            new SQLiteParameter("@sala", sala),
            new SQLiteParameter("@id", id)
        };
        return ExecutarComando(comandoSql, parametros);
    }

    public int ExcluirAgendamento(int id)
    {
        string comandoSql = "DELETE FROM Agendamentos WHERE id = @id";
        SQLiteParameter[] parametros = { new SQLiteParameter("@id", id) };
        return ExecutarComando(comandoSql, parametros);
    }

    public SQLiteDataReader ConsultarAgendamentos()
    {
        string comandoSql = "SELECT * FROM Agendamentos";
        return ExecutarConsulta(comandoSql);
    }

    public SQLiteDataReader ConsultarAgendamentosComNomes()
    {
        string comandoSql = @"
        SELECT 
            Agendamentos.id,
            Equipamentos.nome AS equipamento_nome,
            Usuarios.nome AS usuario_nome,
            Agendamentos.data,
            Agendamentos.hora,
            Agendamentos.sala
        FROM Agendamentos
        INNER JOIN Equipamentos ON Agendamentos.equipamento_id = Equipamentos.id
        INNER JOIN Usuarios ON Agendamentos.usuario_id = Usuarios.id";
        return ExecutarConsulta(comandoSql);
    }

    // Métodos para a tabela Historico
    public int InserirHistorico(int equipamentoId, int usuarioId, string dataInicio, string dataFim, string observacoes)
    {
        string comandoSql = "INSERT INTO Historico (equipamento_id, usuario_id, data_inicio, data_fim, observacoes) VALUES (@equipamentoId, @usuarioId, @dataInicio, @dataFim, @observacoes)";
        SQLiteParameter[] parametros = {
            new SQLiteParameter("@equipamentoId", equipamentoId),
            new SQLiteParameter("@usuarioId", usuarioId),
            new SQLiteParameter("@dataInicio", dataInicio),
            new SQLiteParameter("@dataFim", dataFim),
            new SQLiteParameter("@observacoes", observacoes)
        };
        return ExecutarComando(comandoSql, parametros);
    }

    public int AtualizarHistorico(int id, int equipamentoId, int usuarioId, string dataInicio, string dataFim, string observacoes)
    {
        string comandoSql = "UPDATE Historico SET equipamento_id = @equipamentoId, usuario_id = @usuarioId, data_inicio = @dataInicio, data_fim = @dataFim, observacoes = @observacoes WHERE id = @id";
        SQLiteParameter[] parametros = {
            new SQLiteParameter("@equipamentoId", equipamentoId),
            new SQLiteParameter("@usuarioId", usuarioId),
            new SQLiteParameter("@dataInicio", dataInicio),
            new SQLiteParameter("@dataFim", dataFim),
            new SQLiteParameter("@observacoes", observacoes),
            new SQLiteParameter("@id", id)
        };
        return ExecutarComando(comandoSql, parametros);
    }

    public int ExcluirHistorico(int id)
    {
        string comandoSql = "DELETE FROM Historico WHERE id = @id";
        SQLiteParameter[] parametros = { new SQLiteParameter("@id", id) };
        return ExecutarComando(comandoSql, parametros);
    }

    public SQLiteDataReader ConsultarHistorico()
    {
        string comandoSql = "SELECT * FROM Historico";
        return ExecutarConsulta(comandoSql);
    }

    // consultar equipamentos disponiveis    

}