using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CamadaNegocio.MODEL;


namespace CamadaNegocio.DAO
{
    /// <summary>
    /// Classe com os comandos CRUD do cargo.
    /// </summary>
    public class CargoDAO
    {
        /// <summary>
        /// Método para Gravar um cargo.
        /// </summary>
        /// <param name="cargo">Variável do tipo cargo com os atributos preenchidos para serem gravados na base de dados.</param>
        public void Salvar(Cargo cargo)
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
                throw new Exception("Não foi possível salvar essa cargo " + ex.Message);
            }

        }

        /// <summary>
        /// Método para atualizar um cargo.
        /// </summary>
        /// <param name="cargo">Variável do tipo cargo com os atributos preenchidos para serem gravados na base de dados.</param>
        public void Atualizar(Cargo cargo)
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
                throw new Exception("Não foi possível atualizar esse cargo " + ex.Message);
            }

        }

        /// <summary>
        /// Método para excluir um cargo.
        /// </summary>
        /// <param name="unidade">Variável do tipo cargo com o valor do id para fazer a exclusão.</param>
        public void Excluir(Cargo cargo)
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
                throw new Exception("Não foi possível excluir esse cargo " + ex.Message);
            }

        }

        /// <summary>
        /// Método para buscar um cargo pelo seu id(primary key).
        /// </summary>
        /// <param name="id">Atributo com o valor do id.</param>
        /// <returns>Retorna uma variável com os atributos do cargo preenchidos.</returns>
        public Cargo BuscarPorID(int id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Unidade WHERE unidadeID = @unidadeID";

                cmd.Parameters.AddWithValue("@unidadeID", id);

                SqlDataReader dr = Conexao.selecionar(cmd);

                Cargo cargo = new Cargo();

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
                throw new Exception("Não foi possível buscar esse cargo pelo id " + ex.Message);
            }
        }

        /// <summary>
        /// Método para buscar um cargo pela descrição.
        /// </summary>
        /// <param name="descricao">Variável com o valor da descrição.</param>
        /// <returns>Retorna uma Lista com os atributos do cargo preenchidas.</returns>
        public IList<Cargo> BuscarPorDescricao(string descricao)
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
                throw new Exception("Não foi possível buscar esse cargo pela descrição  " + ex.Message);
            }
        }

        /// <summary>
        /// Método para buscar todos os cargos da base de dados.
        /// </summary>
        /// <returns>Retorna uma lista com todas os cargos e seus atributos.</returns>
        public IList<Cargo> BuscarTodasCargos()
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
                throw new Exception("Não foi possível buscar todos os cargos " + ex.Message);
            }
        }
    }
}
