using AchadosEamados.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AchadosEamados.DAL
{
    public class AnimalDAL : Conexao
    {
        public List<TipoAnimalDTO> getTipo()
        {
            try
            {
                Conectar();
                command = new SqlCommand("SELECT * FROM TipoAnimal", conexao);
                dataReader = command.ExecuteReader();

                List<TipoAnimalDTO> Lista = new List<TipoAnimalDTO>();
                while (dataReader.Read())
                {
                    TipoAnimalDTO tipoAnimal = new TipoAnimalDTO();
                    tipoAnimal.IdTpAnimal = Convert.ToInt32(dataReader["IdTpAnimal"]);
                    tipoAnimal.Nome = Convert.ToString(dataReader["Nome"]);
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
        public void CreateAnimal(AnimalDTO animal)
        {
			try
			{
                Conectar();
                command = new SqlCommand("INSERT INTO Animal (Nome, Idade, Sexo, Raca, UrlImgAnimal, EhVacinado, EhCastrado, Descricao, DtaCadastro, IdTpAnimal)" +
                    "VALUES (@nome, @idade, @sexo, @raca, @urlImg, @ehVacinado, @ehCastrado, @descricao, @dtaCadastro, @tpAnimal);", conexao);

                command.Parameters.AddWithValue("@nome", animal.Nome);
                command.Parameters.AddWithValue("@idade", animal.Idade);
                command.Parameters.AddWithValue("@sexo", animal.Sexo);
                command.Parameters.AddWithValue("@raca", animal.Raca);
                command.Parameters.AddWithValue("@urlImg", animal.UrlImgAnimal);
                command.Parameters.AddWithValue("@ehVacinado", animal.EhVacinado);
                command.Parameters.AddWithValue("@ehCastrado", animal.EhCastrado);
                command.Parameters.AddWithValue("@descricao", animal.Descricao);
                command.Parameters.AddWithValue("@dtaCadastro", animal.DtaCadastro);
                command.Parameters.AddWithValue("@tpAnimal", animal.TpAnimal);
                command.ExecuteNonQuery();


            }
            catch (Exception erro)
            {

                throw new Exception($"Erro ao cadastrar animal: erro do sistema: {erro.Message}");
            }
            finally
            {
                Desconectar();
            }
        } 

        public void UpdateAnimal(AnimalDTO animalDTO)
        {
            try
            {
                Conectar();
                command = new SqlCommand("UPDATE Animal SET Nome=@nome, Idade=@idade, Sexo=@sexo, Raca=@raca,  UrlImgAnimal=@urlImg, EhVacinado=@ehVacinado, EhCastrado=@ehCastrado, Descricao=@descricao, DtaCadastro=@dtaCadastro, IdTpAnimal=@tpAnimal WHERE IdAnimal=@id", conexao);
                command.Parameters.AddWithValue("@nome", animalDTO.Nome);
                command.Parameters.AddWithValue("@idade", animalDTO.Idade);
                command.Parameters.AddWithValue("@sexo", animalDTO.Sexo);
                command.Parameters.AddWithValue("@raca", animalDTO.Raca);
                command.Parameters.AddWithValue("@urlImg", animalDTO.UrlImgAnimal);
                command.Parameters.AddWithValue("@ehVacinado", animalDTO.EhVacinado);
                command.Parameters.AddWithValue("@ehCastrado", animalDTO.EhCastrado);
                command.Parameters.AddWithValue("@descricao", animalDTO.Descricao);
                command.Parameters.AddWithValue("@dtaCadastro", animalDTO.DtaCadastro);
                command.Parameters.AddWithValue("@tpAnimal", animalDTO.TpAnimal);
                command.Parameters.AddWithValue("@id", animalDTO.IdAnimal);

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

        public AnimalDTO Pesquisar(int id)
        {
            try
            {
                Conectar();
                command = new SqlCommand("SELECT * FROM Animal WHERE IdAnimal = @idAnimal;", conexao);
                command.Parameters.AddWithValue("@idAnimal", id);
                AnimalDTO animalDTO = new AnimalDTO();
                dataReader = command.ExecuteReader();
                if (dataReader.Read())
                {
                    animalDTO = new AnimalDTO();

                    animalDTO.IdAnimal = Convert.ToInt32(dataReader["IdAnimal"]);
                    animalDTO.Nome = dataReader["Nome"].ToString();
                    animalDTO.Idade = dataReader["Idade"].ToString();
                    animalDTO.Sexo = dataReader["Sexo"].ToString();
                    animalDTO.Raca = dataReader["Raca"].ToString();
                    animalDTO.UrlImgAnimal = dataReader["UrlImgAnimal"].ToString();
                    animalDTO.EhVacinado = Convert.ToBoolean(dataReader["EhVacinado"]);
                    animalDTO.EhCastrado = Convert.ToBoolean(dataReader["EhCastrado"]);
                    animalDTO.Descricao = dataReader["Descricao"].ToString();
                    animalDTO.DtaCadastro = Convert.ToDateTime(dataReader["DtaCadastro"]);
                    animalDTO.TpAnimal = Convert.ToInt32(dataReader["IdTpAnimal"]);
                }
                return animalDTO;
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
        

        public List<AnimalDTO> Read()
        {
            try
            {
                Conectar();
                command = new SqlCommand("SELECT IdAnimais, Nome, Idade, Sexo, Raca, UrlImgAnimal, EhVacinado, EhCastrado, Descricao, DtaCadastro, TpAnimal FROM Animal INNER JOIN TipoAnimal ON TpAnimal = idTipoAnimal", conexao);
                dataReader = command.ExecuteReader();
                List<AnimalDTO> Lista = new List<AnimalDTO>();

                while (dataReader.Read())
                {
                    AnimalDTO animal = new AnimalDTO();
                    animal.IdAnimal = Convert.ToInt32(dataReader["IdAnimal"]);
                    animal.Nome = dataReader["Nome"].ToString();
                    animal.Idade = dataReader["Idade"].ToString();
                    animal.Sexo = dataReader["Sexo"].ToString();
                    animal.Raca = dataReader["Raca"].ToString();
                    animal.UrlImgAnimal = dataReader["UrlImgAnimal"].ToString();
                    animal.EhVacinado = Convert.ToBoolean(dataReader["EhVacinado"]);
                    animal.EhCastrado = Convert.ToBoolean(dataReader["EhCastrado"]);
                    animal.Descricao = dataReader["Descricao"].ToString();
                    animal.DtaCadastro = Convert.ToDateTime(dataReader["DtaCadastro"]);
                    animal.TpAnimal = Convert.ToInt32(dataReader["TpAnimal"]);

                    Lista.Add(animal);
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
                command = new SqlCommand("DELETE FROM Animal WHERE IdAnimal =@id", conexao);
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
