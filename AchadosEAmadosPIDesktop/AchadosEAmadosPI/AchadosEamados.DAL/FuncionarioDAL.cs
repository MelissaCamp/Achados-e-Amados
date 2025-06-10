using AchadosEamados.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AchadosEamados.DAL
{
    public class FuncionarioDAL : Conexao
    {
        public FuncionarioDTO Autenticar(string usuario, string senha)
        {
            try
            {
                Conectar();
                command = new SqlCommand("SELECT * FROM Funcionario WHERE Nome = @Nome AND Senha = @Senha", conexao);
                command.Parameters.AddWithValue("Nome", usuario);
                command.Parameters.AddWithValue("Senha", senha);
                dataReader = command.ExecuteReader();

                FuncionarioDTO funcionario = null;

                if (dataReader.Read())
                {
                    funcionario = new FuncionarioDTO();
                    funcionario.Nome = dataReader["Nome"].ToString();
                    funcionario.Senha = dataReader["Senha"].ToString();
                    funcionario.IdTpFuncionario = int.Parse(dataReader["IdTpFuncionario"].ToString());
                }
                return funcionario;
            }
            catch (Exception erro)
            {

                throw new Exception($"Usuario inexistente {erro.Message}");
            }
            finally
            {
                Desconectar();
            }
        }

        public List<TpFuncionarioDTO> getTipo()
        {
            try
            {
                Conectar();
                command = new SqlCommand("SELECT * FROM TipoFuncionario", conexao);
                dataReader = command.ExecuteReader();

                List<TpFuncionarioDTO> Lista = new List<TpFuncionarioDTO>();

                while (dataReader.Read())
                {
                    TpFuncionarioDTO tpFuncionario = new TpFuncionarioDTO();
                    tpFuncionario.IdTpFuncionario = Convert.ToInt32(dataReader["IdTpFuncionario"]);
                    tpFuncionario.Nome = dataReader["Nome"].ToString();

                    Lista.Add(tpFuncionario);
                }
                return Lista;
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
            finally
            {
                Desconectar();

            }
        }

        public void Create(FuncionarioDTO funcionario)
        {
            try
            {
                Conectar();
                command = new System.Data.SqlClient.SqlCommand("INSERT INTO Funcionario (Nome, Email, Senha, DtaNascimento, UrlImgFuncionario, Cpf, Telefone, Sexo, IdTpFuncionario)" +
                    "VALUES (@nome, @email, @senha, @dtNasc, @urlImg, @cpf ,@telefone, @sexo, @tpFuncionario);", conexao);

                command.Parameters.AddWithValue("@nome", funcionario.Nome);
                command.Parameters.AddWithValue("@email", funcionario.Email);
                command.Parameters.AddWithValue("@senha", funcionario.Senha);
                command.Parameters.AddWithValue("@dtNasc", funcionario.DtaNascimento);
                command.Parameters.AddWithValue("@urlImg", funcionario.UrlImgFuncionario);
                command.Parameters.AddWithValue("@cpf", funcionario.Cpf);
                command.Parameters.AddWithValue("@telefone", funcionario.Telefone);
                command.Parameters.AddWithValue("@sexo", funcionario.Sexo);
                command.Parameters.AddWithValue("@tpFuncionario", funcionario.IdTpFuncionario);

                command.ExecuteNonQuery();
            }
            catch (Exception erro)
            {

                throw new Exception($"Erro ao cadastrar funcionario: erro do sistema: {erro.Message}");
            }
            finally
            {
                Desconectar();
            }
        }

        public void Update(FuncionarioDTO funcionarioDTO)
        {
            try
            {
                Conectar();
                command = new System.Data.SqlClient.SqlCommand("UPDATE Funcionario SET Nome=@nome, Email=@email, Senha=@senha, DtaNascimento=@dtNasc, UrlImgFuncionario=@urlImg, CPF=@cpf, Telefone=@telefone, Sexo=@sexo, IdTpFuncionario=@tpFuncionario WHERE IdFuncionario=@id", conexao);

                command.Parameters.AddWithValue("@id", funcionarioDTO.IdFuncionario);
                command.Parameters.AddWithValue("@nome", funcionarioDTO.Nome);
                command.Parameters.AddWithValue("@email", funcionarioDTO.Email);
                command.Parameters.AddWithValue("@senha", funcionarioDTO.Senha);
                command.Parameters.AddWithValue("@dtNasc", funcionarioDTO.DtaNascimento);
                command.Parameters.AddWithValue("@urlImg", funcionarioDTO.UrlImgFuncionario);
                command.Parameters.AddWithValue("@cpf", funcionarioDTO.Cpf);
                command.Parameters.AddWithValue("@telefone", funcionarioDTO.Telefone);
                command.Parameters.AddWithValue("@sexo", funcionarioDTO.Sexo);
                command.Parameters.AddWithValue("@tpFuncionario", funcionarioDTO.IdTpFuncionario);

                command.ExecuteNonQuery();
            }
            catch (Exception erro)
            {

                throw new Exception(erro.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        public FuncionarioDTO Pesquisar(int id)
        {
            try
            {
                Conectar();
                command = new SqlCommand("SELECT * FROM Funcionario WHERE IdFuncionario=@idFuncionario;", conexao);
                command.Parameters.AddWithValue("@idFuncionario", id);
                FuncionarioDTO funcionarioDTO = null;
                dataReader = command.ExecuteReader();
                if (dataReader.Read())
                {
                    funcionarioDTO = new FuncionarioDTO();

                    funcionarioDTO.IdFuncionario = Convert.ToInt32(dataReader["IdFuncionario"]);
                    funcionarioDTO.Nome = dataReader["Nome"].ToString();
                    funcionarioDTO.Email = dataReader["Email"].ToString();
                    funcionarioDTO.Senha = dataReader["Senha"].ToString();
                    funcionarioDTO.DtaNascimento = Convert.ToDateTime(dataReader["DtaNascimento"]);
                    funcionarioDTO.UrlImgFuncionario = dataReader["UrlImgFuncionario"].ToString();
                    funcionarioDTO.Cpf = dataReader["Cpf"].ToString();
                    funcionarioDTO.Telefone = dataReader["Telefone"].ToString();
                    funcionarioDTO.Sexo = dataReader["Sexo"].ToString();
                    funcionarioDTO.IdTpFuncionario = Convert.ToInt32(dataReader["IdTpFuncionario"]);


                }
                return funcionarioDTO;
            }
            catch (Exception erro)
            {

                throw new Exception(erro.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        public List<FuncionarioDTO> Read() 
        {
            try
            {
                Conectar();
                command = new SqlCommand("SELECT IdFuncionario, NomeFuncionario, EmailFuncionario, SenhaFuncionario, DtNascFuncionario, UrlImgFuncionario, CPF, TelefoneFuncionario, Sexo, TpFuncionario FROM Funcionario INNER JOIN TpFuncionario ON TpFuncionario = IdTipoFuncionario", conexao);
                dataReader = command.ExecuteReader();
                List<FuncionarioDTO> Lista = new List<FuncionarioDTO>();
                while (dataReader.Read())
                {
                    FuncionarioDTO funcionario = new FuncionarioDTO();
                    funcionario.IdFuncionario = Convert.ToInt32(dataReader["IdFuncionario"]);
                    funcionario.Nome = dataReader["NomeFuncionario"].ToString();
                    funcionario.Email = dataReader["EmailFuncionario"].ToString();
                    funcionario.Telefone = dataReader["TelefoneFuncionario"].ToString();
                    funcionario.Senha = dataReader["SenhaFuncionario"].ToString();
                    funcionario.DtaNascimento = Convert.ToDateTime(dataReader["DtNascFuncionario"].ToString());
                    funcionario.UrlImgFuncionario = dataReader["UrlImgFuncionario"].ToString();
                    funcionario.Cpf = dataReader["CPF"].ToString();
                    funcionario.Sexo = dataReader["Sexo"].ToString();
                    funcionario.IdTpFuncionario = Convert.ToInt32(dataReader["TpFuncionario"]);

                    Lista.Add(funcionario);
                }
                return Lista;
            }
            catch (Exception erro)
            {

                throw;
            }
            finally
            {
                Desconectar();
            }
        }

        public void Deletar(int id)
        {
            try
            {
                Conectar();
                command = new SqlCommand("DELETE FROM Funcionario WHERE IdFuncionario = @id", conexao);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }
    }
}
