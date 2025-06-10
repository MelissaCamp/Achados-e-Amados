using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AchadosEamados.DTO
{
    public class AnimalDTO
    {
        public int IdAnimal {  get; set; }
        public string Nome { get; set; }
        public string Idade { get; set; }
        public string Sexo { get; set; }
        public string Raca {  get; set; }
        public string UrlImgAnimal { get; set; } 
        public bool EhVacinado { get; set; }
        public bool EhCastrado {  get; set; }
        public string Descricao { get; set; }
        public DateTime DtaCadastro { get; set; }
        public int TpAnimal { get; set; }
        public int IdTpFuncionario { get; set; }


        public TipoAnimalDTO tipoAnimalDTO { get; set; }
        public FuncionarioDTO IdTpFuncionarioDTO { get; set; }
    }
}
