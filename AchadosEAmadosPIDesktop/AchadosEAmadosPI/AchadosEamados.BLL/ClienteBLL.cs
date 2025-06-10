using AchadosEamados.DAL;
using AchadosEamados.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AchadosEamados.BLL
{
    public class ClienteBLL
    {
        ClienteDAL clienteDAL = new ClienteDAL();

        public void Update(ClienteDTO clienteDTO)
        {
                clienteDAL.Update(clienteDTO);
        }

        public ClienteDTO PesquisarId(int id)
        {
            return clienteDAL.Pesquisar(id);
        }

        public List<ClienteDTO> ListCliente()
        {
            return clienteDAL.Read();
        }

        public void DeletarCliente(int id)
        {
            clienteDAL.Deletar(id);
        }
    }
}
