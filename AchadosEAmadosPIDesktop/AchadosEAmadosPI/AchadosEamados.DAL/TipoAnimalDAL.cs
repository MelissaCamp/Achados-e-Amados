using AchadosEamados.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AchadosEamados.DAL
{
    public class TipoAnimalDAL : Conexao
    {
        public void Create(TipoAnimalDTO tipoAnimal)
        {
			try
			{
                Conectar();
                command = new SqlCommand("INSERT INTO TipoAnimal(Nome)" + "VALUES (@nome);", conexao);

                command.Parameters.AddWithValue("@nome", tipoAnimal.Nome);
                command.ExecuteNonQuery();
			}
            catch (Exception erro)
            {

                throw new Exception($"Erro ao cadastrar tipo de animal: erro do sistema: {erro.Message}");
            }
            finally
            {
                Desconectar();
            }
        }
        public void Update(TipoAnimalDTO tipoAnimalDTO)
        {
            try
            {
                Conectar();
                command = new SqlCommand("UPDATE TipoAnimal SET Nome=@nome WHERE IdTpAnimal=@id", conexao);
                command.Parameters.AddWithValue("@nome",tipoAnimalDTO.Nome);
                command.Parameters.AddWithValue("@id", tipoAnimalDTO.IdTpAnimal);
                command.ExecuteNonQuery();
            }
            catch(Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }
        public TipoAnimalDTO Pesquisar(int id)
        {
            try
            {
                Conectar();
                command = new SqlCommand("SELECT * FROM TipoAnimal WHERE IdTpAnimal = @idTipoAnimal;", conexao);
                command.Parameters.AddWithValue("idTipoAnimal", id);
                TipoAnimalDTO tipoAnimalDTO = null;
                dataReader = command.ExecuteReader();
                if (dataReader.Read())
                {
                    tipoAnimalDTO = new TipoAnimalDTO();
                    tipoAnimalDTO.IdTpAnimal = Convert.ToInt32(dataReader["IdTpAnimal"]);
                    tipoAnimalDTO.Nome = dataReader["Nome"].ToString();
                }
                return tipoAnimalDTO;
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
        public List<TipoAnimalDTO> Read()
        {
            try
            {
                Conectar();
                command = new SqlCommand("SELECT IdTpAnimal, Nome", conexao);
                dataReader = command.ExecuteReader();
                List<TipoAnimalDTO> Lista = new List<TipoAnimalDTO>();
                while (dataReader.Read())
                {
                    TipoAnimalDTO tipoAnimal = new TipoAnimalDTO();
                    tipoAnimal.IdTpAnimal = Convert.ToInt32(dataReader["IdTpAnimal"]);
                    tipoAnimal.Nome = dataReader["Nome"].ToString();
                    Lista.Add(tipoAnimal);
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
                command = new SqlCommand("DELETE FROM TipoAnimal WHERE IdTpAnimal = @id", conexao);
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
