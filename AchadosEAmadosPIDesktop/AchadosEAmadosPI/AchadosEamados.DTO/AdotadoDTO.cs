using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AchadosEamados.DTO
{
    public class AdotadoDTO
    {
        public int IdAdotado {  get; set; }
        public DateTime DtaAdocao { get; set; }
        public int IdCliente { get; set; }
        public int IdAnimal { get; set; }


        public ClienteDTO IdClienteDTO { get; set; }
        public AnimalDTO IdAnimalDTO { get; set; }
    }
}
