using AchadosEamados.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AchadosEamados.DAL
{
    public class ClienteDAL : Conexao
    {
        public void Update(ClienteDTO cliente)
        {
            try
            {
                Conectar();
                command = new SqlCommand("UPDATE Cliente SET Nome=@nome, Senha=@senha, DtaNascimento=@dtaNasc, UrlImgCliente=@urlImg, Cpf=@cpf, Email=@email, Telefone=@telefone, Endereco=@endereco, Nro=@nrm, Bairro=@bairro, Cidade=@cidade, Estado=@estado", conexao);
                command.Parameters.AddWithValue("@nome", cliente.Nome);
                command.Parameters.AddWithValue("@senha", cliente.Senha);
                command.Parameters.AddWithValue("@dtaNasc", cliente.DtaNascimento);
                command.Parameters.AddWithValue("@urlImg", cliente.UrlImgCliente);
                command.Parameters.AddWithValue("@cpf", cliente.CPF);
                command.Parameters.AddWithValue("@email", cliente.Email);
                command.Parameters.AddWithValue("@telefone", cliente.Telefone);
                command.Parameters.AddWithValue("@endereco", cliente.Endereco);
                command.Parameters.AddWithValue("@nrm", cliente.Nro);
                command.Parameters.AddWithValue("@bairro", cliente.Bairro);
                command.Parameters.AddWithValue("@cidade", cliente.Cidade);
                command.Parameters.AddWithValue("@estado", cliente.Estado);
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

        public ClienteDTO Pesquisar(int id)
        {
            try
            {
                Conectar();
                command = new SqlCommand("SELECT * FROM Cliente WHERE IdCliente = @idCliente;", conexao);
                command.Parameters.AddWithValue("@idCliente", id);
                ClienteDTO clienteDTO = new ClienteDTO();
                dataReader = command.ExecuteReader();
                if (dataReader.Read())
                {
                    clienteDTO = new ClienteDTO();

                    clienteDTO.IdCliente = Convert.ToInt32(dataReader["IdCliente"]);
                    clienteDTO.Nome = dataReader["Nome"].ToString();
                    clienteDTO.Senha = dataReader["Senha"].ToString();
                    clienteDTO.DtaNascimento = Convert.ToDateTime(dataReader["DtaNascimento"]);
                    clienteDTO.UrlImgCliente = dataReader["UrlImgCliente"].ToString();
                    clienteDTO.CPF = dataReader["Cpf"].ToString(); ;
                    clienteDTO.Email = dataReader["Email"].ToString();
                    clienteDTO.Telefone = dataReader["Telefone"].ToString();
                    clienteDTO.Endereco = dataReader["Endereco"].ToString();
                    clienteDTO.Nro = dataReader["Nro"].ToString();
                    clienteDTO.Bairro = dataReader["Bairro"].ToString();
                    clienteDTO.Cidade = dataReader["Cidade"].ToString();
                    clienteDTO.Estado = dataReader["Estado"].ToString();
                }
                return clienteDTO;
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

       public List<ClienteDTO> Read()
        {
            try
            {
                Conectar();
                command = new SqlCommand("SELECT IdCliente, Nome, Senha, DtaNascimento, UrlImgCliente, Cpf, Email, Telefone, Endereco, Nro, Bairro, Cidade, Estado", conexao);
                dataReader = command.ExecuteReader();
                List<ClienteDTO> Lista = new List<ClienteDTO>();

                while (dataReader.Read())
                {
                    ClienteDTO cliente = new ClienteDTO();
                    cliente.IdCliente = Convert.ToInt32(dataReader["IdCliente"]);
                    cliente.Nome = dataReader["Nome"].ToString();
                    cliente.Senha = dataReader["Senha"].ToString();
                    cliente.DtaNascimento = Convert.ToDateTime(dataReader["DtaNascimento"]);
                    cliente.UrlImgCliente = dataReader["UrlImgCliente"].ToString();
                    cliente.CPF = dataReader["Cpf"].ToString(); ;
                    cliente.Email = dataReader["Email"].ToString();
                    cliente.Telefone = dataReader["Telefone"].ToString();
                    cliente.Endereco = dataReader["Endereco"].ToString();
                    cliente.Nro = dataReader["Nro"].ToString();
                    cliente.Bairro = dataReader["Bairro"].ToString();
                    cliente.Cidade = dataReader["Cidade"].ToString();
                    cliente.Estado = dataReader["Estado"].ToString();

                    Lista.Add(cliente);
                }
                return Lista;
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

       public void Deletar(int id)
        {
            try
            {
                Conectar();
                command = new SqlCommand("DELETE FROM Cliente WHERE IdCliente = @id", conexao);
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
