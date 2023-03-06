using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaNegocio.MODEL;
using CamadaNegocio.DAO;

namespace CamadaNegocio.BO
{
    /// <summary>
    /// Classe que faz a validação dos dados do cargo.
    /// </summary>
    public class CargoBO
    {
        /// <summary>
        /// Variável do tipo unidade com os atributos para serem preenchidos.
        /// </summary>
        Cargo cargo;
        /// <summary>
        /// Váriavel da classe unidadeDAO para chamar os métdos da classe DAO.
        /// </summary>
        UnidadeDAO unidadeDAO;
        /// <summary>
        /// Variável do tipo Lista para retorna os dados da unidade.
        /// </summary>
        IList<Unidade> listaUnidade;

        /// <summary>
        /// Método que faz a Validação dos Dados da Unidade.
        /// </summary>
        /// <param name="unidade">Atributo do tipo unidade com os atributos que serão validados.</param>
        #region Métodos Auxiliares
        public void ValidacaoSalvar(Unidade unidade)
        {
            if (string.IsNullOrEmpty(unidade._DataCadastro))
            {
                throw new Exception("Campo DATA DO CADASTRO é Obrigatório.");
            }
            else if (string.IsNullOrEmpty(unidade._UnidadeDescricao))
            {
                throw new Exception("Campo DESCRIÇÃO é Obrigatório.");
            }
        }
        /// <summary>
        /// Método que não deixa excluir uma unidade sem que o seu id seja informado.
        /// </summary>
        /// <param name="unidade">Atributo do tipo unidade com os atributos que serão validados.</param>
        public void ValidacaoExcluir(Unidade unidade)
        {
            if (unidade._UnidadeID.Equals(0))
            {
                throw new Exception("Selecione uma UNIDADE para efetuar a Exclusão.");
            }
        }
        #endregion

        /// <summary>
        /// Método para Gravar um cargo.
        /// </summary>
        /// <param name="cargo">Variável do tipo cargo com os atributos preenchidos para serem gravados na base de dados.</param>
        public void Salvar(Cargo cargo)
        {
            try
            {
                ValidacaoSalvar(unidade);

                unidadeDAO = new UnidadeDAO();

                if (unidade._UnidadeID != 0)
                {
                    unidadeDAO.Atualizar(unidade);
                }
                else
                {
                    unidadeDAO.Salvar(unidade);
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Método para excluir um cargo.
        /// </summary>
        /// <param name="cargo">Variável do tipo cargo com o valor do id para fazer a exclusão.</param>
        public void Excluir(Cargo cargo)
        {
            try
            {
                ValidacaoExcluir(unidade);

                unidadeDAO = new UnidadeDAO();
                unidadeDAO.Excluir(unidade);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Método para buscar um cargo pelo seu id(primary key).
        /// </summary>
        /// <param name="id">Atributo com o valor do id.</param>
        /// <returns>Retorna uma variável com os atributos do cargo preenchidas.</returns>
        public Cargo BuscarPorID(int id)
        {
            try
            {
                unidade = new Unidade();
                unidadeDAO = new UnidadeDAO();

                unidade = unidadeDAO.BuscarPorID(id);
                return unidade;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Método para buscar um cargo pela descrição.
        /// </summary>
        /// <param name="descricao">Variável com a descrição.</param>
        /// <returns>retorna uma lista com os atributos daquele cargo que foi consultado.</returns>
        public IList<Cargo> BuscarPorDescricao(string descricao)
        {
            try
            {
                listaUnidade = new List<Unidade>();
                unidadeDAO = new UnidadeDAO();

                listaUnidade = unidadeDAO.BuscarPorDescricao(descricao);
                return listaUnidade;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Método para buscar todos os cargos da base de dados.
        /// </summary>
        /// <returns>Retorna uma lista com todos os cargos e seus atributos.</returns>
        public IList<Cargo> BuscarTodasCargos()
        {
            try
            {
                listaUnidade = new List<Unidade>();
                unidadeDAO = new UnidadeDAO();

                listaUnidade = unidadeDAO.BuscarTodasUnidades();
                return listaUnidade;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
