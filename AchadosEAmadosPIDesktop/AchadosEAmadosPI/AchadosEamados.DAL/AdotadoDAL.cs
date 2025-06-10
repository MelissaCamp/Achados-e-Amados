using AchadosEamados.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AchadosEamados.DAL
{
    public class AdotadoDAL : Conexao
    {
        public void Create(AdotadoDTO adotado)
        {
            try
            {
                Conectar();
                command = new SqlCommand("INSERT INTO Adotado (DtaAdocao, IdCliente, IdAnimal)" +
                    "VALUES (@dtaAdocao, @idCliente, @idAnimal)", conexao);

                command.Parameters.AddWithValue("@dtaAdocao", adotado.DtaAdocao);
                command.Parameters.AddWithValue("@idCliente", adotado.IdCliente);
                command.Parameters.AddWithValue("@idAnimal", adotado.IdAdotado);

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

        public void Update(AdotadoDTO adotado)
        {
            try
            {
                Conectar();
                command = new SqlCommand("UPDATE Adotado SET DtaAdocao=@dtaAdocao, IdCliente=@idCliente, IdAnimal=@idAnimal WHERE IdAdotado=@id", conexao);
                command.Parameters.AddWithValue("@dtaAdocao", adotado.DtaAdocao);
                command.Parameters.AddWithValue("@idCliente", adotado.IdCliente);
                command.Parameters.AddWithValue("@idAnimal", adotado.IdAnimal);
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

        public AdotadoDTO Pesquisar(int id)
        {
            try
            {
                Conectar();
                command = new SqlCommand("SELECT * FROM Adotado WHERE IdAdotado = @idAdotado", conexao);
                command.Parameters.AddWithValue("idAdotado",id);
                AdotadoDTO adotadoDTO = new AdotadoDTO();
                dataReader = command.ExecuteReader();
                if (dataReader.Read())
                {
                    adotadoDTO= new AdotadoDTO();
                    adotadoDTO.IdAdotado = Convert.ToInt32(dataReader["IdAdotado"]);
                    adotadoDTO.DtaAdocao = Convert.ToDateTime(dataReader["DtaAdocao"]);
                    adotadoDTO.IdCliente = Convert.ToInt32(dataReader["IdCliente"]);
                    adotadoDTO.IdAnimal = Convert.ToInt32(dataReader["IdAnimal"]);
                }
                return adotadoDTO;
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

        public List<AdotadoDTO> Read()
        {
            try
            {
                Conectar();
                command = new SqlCommand("SELECT IdAdotado, DtaAdocao, IdCliente, IdAnimal", conexao);
                dataReader = command.ExecuteReader();
                List<AdotadoDTO> Lista = new List<AdotadoDTO>();
                while (dataReader.Read())
                {
                    AdotadoDTO adotado = new AdotadoDTO();
                    adotado.IdAdotado = Convert.ToInt32(dataReader["IdAdotado"]);
                    adotado.DtaAdocao = Convert.ToDateTime(dataReader["DtaAdocao"]);
                    adotado.IdCliente = Convert.ToInt32(dataReader["IdCliente"]);
                    adotado.IdAnimal = Convert.ToInt32(dataReader["IdAnimal"]);

                    Lista.Add(adotado);
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
                command = new SqlCommand("DELETE FROM Adotado WHERE IdAdotado =@id", conexao);
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
