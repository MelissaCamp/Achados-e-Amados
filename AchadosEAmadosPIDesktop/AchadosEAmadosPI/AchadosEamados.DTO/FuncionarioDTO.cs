using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AchadosEamados.DTO
{
    public class FuncionarioDTO
    {
        public int IdFuncionario { get; set; }
        public string Nome { get; set; }

        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DtaNascimento { get; set; }
        public string UrlImgFuncionario { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string Sexo { get; set; }
        public int IdTpFuncionario { get; set; }


        //chave estrangeira
        public TpFuncionarioDTO IdFuncionarioDTO { get; set; }
    }
}
