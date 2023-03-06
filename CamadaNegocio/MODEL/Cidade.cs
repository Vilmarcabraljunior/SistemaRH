using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaNegocio.MODEL
{
    /// <summary>
    /// Classe Cidade com os atributos e propriedades.
    /// </summary>
    public class Cidade
    {
        /// <summary>
        /// Variável que guarda o valor da chave primária.
        /// </summary>
        private int cidadeID;
        /// <summary>
        /// Variável que guarda o valor do nome da cidade.
        /// </summary>
        private string cidadeNome;
        /// <summary>
        /// Variável que guarda o valor da data do cadastro.
        /// </summary>
        private string dataCadastro;
        /// <summary>
        /// Variável que guarda o valor da uf.
        /// </summary>
        private string uf;

        /// <summary>
        /// Método destrutor 
        /// </summary>
        ~Cidade()
        {

        }


        /// <summary>
        /// Propriedade da variável cidadeID.
        /// </summary>
        public int _CidadeID
        {
            get
            {
                return cidadeID;
            }
            set
            {
                cidadeID = value;
            }
        }

        /// <summary>
        /// Propriedade da variável cidadeNome.
        /// </summary>
        public string _CidadeNome
        {
            get
            {
                return cidadeNome;
            }
            set
            {
                cidadeNome = value;
            }
        }

        /// <summary>
        /// Propriedade da variável dataCadastro.
        /// </summary>
        public string _DataCadastro
        {
            get
            {
                return dataCadastro;
            }
            set
            {
                dataCadastro = value;
            }
        }

        /// <summary>
        /// Propriedade da variável uf.
        /// </summary>
        public string _Uf
        {
            get
            {
                return uf;
            }
            set
            {
                uf = value;
            }
        }
    }
}
