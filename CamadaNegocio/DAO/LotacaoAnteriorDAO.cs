using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaNegocio.MODEL;

namespace CamadaNegocio.DAO
{
    /// <summary>
    /// Classe com os comandos CRUD da lotação anterior.
    /// </summary>
    public class LotacaoAnteriorDAO
    {
        /// <summary>
        /// Método para Gravar uma locação anterior.
        /// </summary>
        /// <param name="lotacaoAnterior">Variável do tipo lotação anterior com os atributos preenchidos para serem gravados na base de dados.</param>
        public void Salvar(LotacaoAnterior lotacaoAnterior)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO Unidade (dataCadastro, unidadeDescricao) values(@dataCadastro, @unidadeDescricao)";

                cmd.Parameters.AddWithValue("@dataCadastro", unidade._DataCadastro);
                cmd.Parameters.AddWithValue("@unidadeDescricao", unidade._UnidadeDescricao);

                Conexao.manterCrud(cmd);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível salvar essa lotação anterior " + ex.Message);
            }

        }

        /// <summary>
        /// Método para atualizar uma lotação anterior.
        /// </summary>
        /// <param name="lotacaoAnterior">Variável do tipo lotação anterior com os atributos preenchidos para serem gravados na base de dados.</param>
        public void Atualizar(LotacaoAnterior lotacaoAnterior)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE Unidade SET dataCadastro=@dataCadastro, unidadeDescricao=@unidadeDescricao WHERE unidadeID=@unidadeID";

                cmd.Parameters.AddWithValue("@unidadeID", unidade._UnidadeID);
                cmd.Parameters.AddWithValue("@dataCadastro", unidade._DataCadastro);
                cmd.Parameters.AddWithValue("@unidadeDescricao", unidade._UnidadeDescricao);

                Conexao.manterCrud(cmd);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível atualizar essa lotação anterior " + ex.Message);
            }

        }

        /// <summary>
        /// Método para excluir uma lotação anterior.
        /// </summary>
        /// <param name="unidade">Variável do tipo lotação anterior com o valor do id para fazer a exclusão.</param>
        public void Excluir(LotacaoAnterior lotacaoAnterior)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM Unidade WHERE unidadeID = @unidadeID";

                cmd.Parameters.AddWithValue("@unidadeID", unidade._UnidadeID);

                Conexao.manterCrud(cmd);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível excluir essa lotação anterior " + ex.Message);
            }

        }

        /// <summary>
        /// Método para buscar uma lotação anterior pelo seu id(primary key).
        /// </summary>
        /// <param name="id">Atributo com o valor do id.</param>
        /// <returns>Retorna uma variável com os atributos da lotação anterior preenchidas.</returns>
        public LotacaoAnterior BuscarPorID(int id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Unidade WHERE unidadeID = @unidadeID";

                cmd.Parameters.AddWithValue("@unidadeID", id);

                SqlDataReader dr = Conexao.selecionar(cmd);

                Unidade unidade = new Unidade();

                if (dr.HasRows)
                {
                    dr.Read();
                    unidade._UnidadeID = (int)dr["unidadeID"];
                    unidade._DataCadastro = dr["dataCadastro"].ToString();
                    unidade._UnidadeDescricao = dr["unidadeDescricao"].ToString();
                }
                else
                {
                    unidade = null;
                }
                dr.Close();
                return unidade;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível buscar essa lotação anterior pelo id " + ex.Message);
            }
        }

        /// <summary>
        /// Método para buscar uma lotação anterior pela descrição.
        /// </summary>
        /// <param name="descricao">Variável com o valor da descrição.</param>
        /// <returns>Retorna uma Lista com os atributos da lotação anterior preenchidas.</returns>
        public IList<LotacaoAnterior> BuscarPorDescricao(string descricao)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Unidade WHERE unidadeDescricao like @unidadeDescricao";

                cmd.Parameters.AddWithValue("@unidadeDescricao", descricao + "%");

                SqlDataReader dr = Conexao.selecionar(cmd);

                IList<Unidade> listaUnidade = new List<Unidade>();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Unidade unidade = new Unidade();
                        unidade._UnidadeID = (int)dr["unidadeID"];
                        unidade._DataCadastro = dr["dataCadastro"].ToString();
                        unidade._UnidadeDescricao = dr["unidadeDescricao"].ToString();

                        listaUnidade.Add(unidade);
                    }
                }
                else
                {
                    listaUnidade = null;
                }
                dr.Close();
                return listaUnidade;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível buscar essa lotação anterior pela descrição  " + ex.Message);
            }
        }

        /// <summary>
        /// Método para buscar todos as lotações anteriores da base de dados.
        /// </summary>
        /// <returns>Retorna uma lista com todas as lotações anteriores e seus atributos.</returns>
        public IList<LotacaoAnterior> BuscarTodasLotacoesAnteriores()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Unidade";

                SqlDataReader dr = Conexao.selecionar(cmd);

                IList<Unidade> listaUnidade = new List<Unidade>();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Unidade unidade = new Unidade();
                        unidade._UnidadeID = (int)dr["unidadeID"];
                        unidade._DataCadastro = dr["dataCadastro"].ToString();
                        unidade._UnidadeDescricao = dr["unidadeDescricao"].ToString();

                        listaUnidade.Add(unidade);
                    }
                }
                else
                {
                    listaUnidade = null;
                }
                dr.Close();
                return listaUnidade;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível buscar todas as lotações anteriores " + ex.Message);
            }
        }
    }
}
