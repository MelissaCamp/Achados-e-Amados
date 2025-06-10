using AchadosEamados.DAL;
using AchadosEamados.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AchadosEamados.BLL
{
    public class AnimalBLL
    {
        AnimalDAL animalDAL = new AnimalDAL();

        public void CreateAnimal(AnimalDTO animal)
        {
            animalDAL.CreateAnimal(animal);
        }

        public void UpdateAnimal(AnimalDTO animalDTO)
        {
            animalDAL.UpdateAnimal(animalDTO);
        }

        public AnimalDTO PesquisarId(int id)
        {
            return animalDAL.Pesquisar(id);
        } 
      

        public List<AnimalDTO> ListAnimal()
        {
            return animalDAL.Read();
        }

        public void DeleteAnimal(int id)
        {
            animalDAL.Deletar(id);
        }
    }   
}
