using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaNegocio.MODEL
{
    /// <summary>
    /// Classe Lotacão anterior com os atributos e propriedades.
    /// </summary>
    public class LotacaoAnterior
    {
        /// <summary>
        /// Variável que guarda o valor da data do cadastro.
        /// </summary>
        private string dataCadastro;
        /// <summary>
        /// Variável que guarda o valor do id da lotação anterior.
        /// </summary>
        private int lotacaoAnteriorID;
        /// <summary>
        /// Variável que guarda o valor do nome da lotação anterior.
        /// </summary>
        private string lotacaoAnteriorNome;

        /// <summary>
        /// Método destrutor 
        /// </summary>
        ~LotacaoAnterior()
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
        /// Propriedade da variável lotacaoAnteriorID.
        /// </summary>
        public int _LotacaoAnteriorID
        {
            get
            {
                return lotacaoAnteriorID;
            }
            set
            {
                lotacaoAnteriorID = value;
            }
        }

        /// <summary>
        /// Propriedade da variável lotacaoAnteriorNome.
        /// </summary>
        public string _LotacaoAnteriorNome
        {
            get
            {
                return lotacaoAnteriorNome;
            }
            set
            {
                lotacaoAnteriorNome = value;
            }
        }
    }
}
