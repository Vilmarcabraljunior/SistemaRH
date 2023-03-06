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
    public class Parentesco
    {
        /// <summary>
        /// Variável que guarda o valor da data do cadastro.
        /// </summary>
        private string dataCadastro;
        /// <summary>
        /// Variável que guarda o valor do id do parentesco.
        /// </summary>
        private int parentescoID;
        /// <summary>
        /// Variável que guarda o valor do nome do parentesco.
        /// </summary>
        private string parentescoNome;


        /// <summary>
        /// Método destrutor 
        /// </summary>
        ~Parentesco()
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
        /// Propriedade da variável parentescoID.
        /// </summary>
        public int _ParentescoID
        {
            get
            {
                return parentescoID;
            }
            set
            {
                parentescoID = value;
            }
        }

        /// <summary>
        /// Propriedade da variável parentescoNome.
        /// </summary>
        public string _ParentescoNome
        {
            get
            {
                return parentescoNome;
            }
            set
            {
                parentescoNome = value;
            }
        }
    }
}
