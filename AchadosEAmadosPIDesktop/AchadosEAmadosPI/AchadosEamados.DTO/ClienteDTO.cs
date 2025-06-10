using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AchadosEamados.DTO
{
    public class ClienteDTO
    {
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }

        public DateTime DtaNascimento { get; set; }
        public string UrlImgCliente { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string Nro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
    }
}
