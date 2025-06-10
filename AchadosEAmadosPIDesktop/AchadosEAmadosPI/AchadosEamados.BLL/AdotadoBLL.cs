using AchadosEamados.DAL;
using AchadosEamados.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AchadosEamados.BLL
{

    public class AdotadoBLL
    {
        AdotadoDAL adotadoDAL = new AdotadoDAL();
        public void CreateAdotado(AdotadoDTO adotado)
        {
            adotadoDAL.Create(adotado);
        }

        public void UpdateAdotado(AdotadoDTO adotadoDTO)
        {
            adotadoDAL.Update(adotadoDTO);
        }

        public AdotadoDTO PesquisarId(int id)
        {
            return adotadoDAL.Pesquisar(id);
        }
        public void Deletar(int id)
        {
            adotadoDAL.Deletar(id);
        }
    }
}
