using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaNegocio.MODEL
{
    /// <summary>
    /// Classe Cargo com os atributos e propriedades.
    /// </summary>
    public class Cargo
    {
        /// <summary>
        /// Variável que guarda o valor da chave primária.
        /// </summary>
        private int cargoID;
        /// <summary>
        /// Variável que guarda o valor do nome do cargo.
        /// </summary>
        private string cargoNome;
        /// <summary>
        /// Variável que guarda o valor da data do cadastro.
        /// </summary>
        private string dataCadastro;

        /// <summary>
        /// Método destrutor 
        /// </summary>
        ~Cargo()
        {

        }


        /// <summary>
        /// Propriedade da variável CargoID.
        /// </summary>
        public int _CargoID
        {
            get
            {
                return cargoID;
            }
            set
            {
                cargoID = value;
            }
        }

        /// <summary>
        /// Propriedade da variável cargoNome.
        /// </summary>
        public string _CargoNome
        {
            get
            {
                return cargoNome;
            }
            set
            {
                cargoNome = value;
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
    }
}
