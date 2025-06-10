using AchadosEamados.DAL;
using AchadosEamados.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AchadosEamados.BLL
{
    public class FuncionarioBLL
    {
        FuncionarioDAL funcionarioDAL = new FuncionarioDAL();

        public FuncionarioDTO AutenticaFuncionario(string nome, string senha)
        {
            return funcionarioDAL.Autenticar(nome, senha);
        }

        public List<TpFuncionarioDTO> GetTpFuncionarios()
        {
            return funcionarioDAL.getTipo();
        }

        public void CreateFuncionario(FuncionarioDTO funcionario)
        {
            funcionarioDAL.Create(funcionario);
        }

        public FuncionarioDTO PesquisarId(int id)
        {
            return funcionarioDAL.Pesquisar(id);
        }

        public void UpdateFuncionario(FuncionarioDTO funcionarioDTO)
        {
            funcionarioDAL.Update(funcionarioDTO);
        }

        public List<FuncionarioDTO> ListFuncionario()
        {
            return funcionarioDAL.Read();
        }

        public void DeletarFuncionario(int id)
        {
            funcionarioDAL.Deletar(id);
        }
    }
}
