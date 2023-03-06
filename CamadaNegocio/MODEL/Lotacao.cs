using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaNegocio.MODEL
{
    /// <summary>
    /// Classe Lotacao com os atributos e propriedades.
    /// </summary>
    public class Lotacao
    {
        /// <summary>
        /// Variável que guarda o valor da data do cadastro.
        /// </summary>
        private string dataCadastro;
        /// <summary>
        /// Variável que guarda o valor da chave primária.
        /// </summary>
        private int lotacaoID;
        /// <summary>
        /// Variável que guarda o valor do nome da lotação.
        /// </summary>
        private string lotacaoNome;


        /// <summary>
        /// Método destrutor 
        /// </summary>
        ~Lotacao()
        {

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
        /// Propriedade da variável lotacaoID.
        /// </summary>
        public int _LotacaoID
        {
            get
            {
                return lotacaoID;
            }
            set
            {
                lotacaoID = value;
            }
        }


        /// <summary>
        /// Propriedade da variável lotacaoNome.
        /// </summary>
        public string _LotacaoNome
        {
            get
            {
                return lotacaoNome;
            }
            set
            {
                lotacaoNome = value;
            }
        }
    }
}
