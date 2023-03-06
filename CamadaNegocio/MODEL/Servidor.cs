using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaNegocio.MODEL
{
    /// <summary>
    /// Classe Servidor com os atributos e propriedades.
    /// </summary>
    public class Servidor
    {
        /// <summary>
        /// Variável que guarda o valor do id do servidor.
        /// </summary>
        private int servidorID;
        /// <summary>
        /// Variável que guarda o valor da agencia.
        /// </summary>
        private string agencia;
        /// <summary>
        /// Variável que guarda o valor do ato da nomeação.
        /// </summary>
        private string atoNomeacao;
        /// <summary>
        /// Variável que guarda o valor do bairro.
        /// </summary>
        private string bairro;
        /// <summary>
        /// Variável que guarda o valor do banco.
        /// </summary>
        private string banco;
        /// <summary>
        /// Variável que guarda o valor do beneficiádo.
        /// </summary>
        private string beneficiado;
        /// <summary>
        /// Variável que guarda o valor do cep.
        /// </summary>
        private string cep;
        /// <summary>
        /// Variável que guarda o valor da classe.
        /// </summary>
        private string classe;
        /// <summary>
        /// Variável que guarda o valor da conta corrente.
        /// </summary>
        private string contaCorrente;
        /// <summary>
        /// Variável que guarda o valor do cpf.
        /// </summary>
        private string cpf;
        /// <summary>
        /// Variável que guarda o valor da data da admissão.
        /// </summary>
        private string dataAdmissao;
        /// <summary>
        /// Variável que guarda o valor da data da aposentadoria.
        /// </summary>
        private string dataAposentadoria;
        /// <summary>
        /// Variável que guarda o valor da data do cadastro.
        /// </summary>
        private string dataCadastro;
        /// <summary>
        /// Variável que guarda o valor da data da expedição.
        /// </summary>
        private string dataExpedicao;
        /// <summary>
        /// Variável que guarda o valor da data do falecimento.
        /// </summary>
        private string dataFalecimento;
        /// <summary>
        /// Variável que guarda o valor da data de nascimento.
        /// </summary>
        private string dataNascimento;
        /// <summary>
        /// Variável que guarda o valor da data do primneiro emprego.
        /// </summary>
        private string dataPrimeiroEmprego;
        /// <summary>
        /// Variável que guarda o valor da data da vigencia.
        /// </summary>
        private string dataVigencia;
        /// <summary>
        /// Variável que guarda o valor do dependente 1.
        /// </summary>
        private string dependente1;
        /// <summary>
        /// Variável que guarda o valor do dependente 10.
        /// </summary>
        private string dependente10;
        /// <summary>
        /// Variável que guarda o valor do dependente 2.
        /// </summary>
        private string dependente2;
        /// <summary>
        /// Variável que guarda o valor do dependente 3.
        /// </summary>
        private string dependente3;
        /// <summary>
        /// Variável que guarda o valor do dependente 4.
        /// </summary>
        private string dependente4;
        /// <summary>
        /// Variável que guarda o valor do dependente 5.
        /// </summary>
        private string dependente5;
        /// <summary>
        /// Variável que guarda o valor do dependente 6.
        /// </summary>
        private string dependente6;
        /// <summary>
        /// Variável que guarda o valor do dependente 7.
        /// </summary>
        private string dependente7;
        /// <summary>
        /// Variável que guarda o valor do dependente 8.
        /// </summary>
        private string dependente8;
        /// <summary>
        /// Variável que guarda o valor do dependente 9.
        /// </summary>
        private string dependente9;
        /// <summary>
        /// Variável que guarda o valor da data do nascimento do dependente 1.
        /// </summary>
        private string dependenteDataNascimento1;
        /// <summary>
        /// Variável que guarda o valor da data do nascimento do dependente 10.
        /// </summary>
        private string dependenteDataNascimento10;
        /// <summary>
        /// Variável que guarda o valor da data do nascimento do dependente 2.
        /// </summary>
        private string dependenteDataNascimento2;
        /// <summary>
        /// Variável que guarda o valor da data do nascimento do dependente 3.
        /// </summary>
        private string dependenteDataNascimento3;
        /// <summary>
        /// Variável que guarda o valor da data do nascimento do dependente 4.
        /// </summary>
        private string dependenteDataNascimento4;
        /// <summary>
        /// Variável que guarda o valor da data do nascimento do dependente 5.
        /// </summary>
        private string dependenteDataNascimento5;
        /// <summary>
        /// Variável que guarda o valor da data do nascimento do dependente 6.
        /// </summary>
        private string dependenteDataNascimento6;
        /// <summary>
        /// Variável que guarda o valor da data do nascimento do dependente 7.
        /// </summary>
        private string dependenteDataNascimento7;
        /// <summary>
        /// Variável que guarda o valor da data do nascimento do dependente 8.
        /// </summary>
        private string dependenteDataNascimento8;
        /// <summary>
        /// Variável que guarda o valor da data do nascimento do dependente 9.
        /// </summary>
        private string dependenteDataNascimento9;
        /// <summary>
        /// Variável que guarda o valor do email.
        /// </summary>
        private string email;
        /// <summary>
        /// Variável que guarda o valor do endereço.
        /// </summary>
        private string endereco;
        /// <summary>
        /// Variável que guarda o valor da escolaridade.
        /// </summary>
        private string escolaridade;
        /// <summary>
        /// Variável que guarda o valor do estado civil.
        /// </summary>
        private string estadoCivil;
        /// <summary>
        /// Variável que guarda o valor da formação/especialização.
        /// </summary>
        private string formacaoEspecializacao;
        /// <summary>
        /// Variável que guarda o valor da função.
        /// </summary>
        private string funcao;
        /// <summary>
        /// Variável que guarda o valor da fundamentação.
        /// </summary>
        private string fundamentacao;
        /// <summary>
        /// Variável que guarda o valor do local da transferencia.
        /// </summary>
        private string localTransferencia;
        /// <summary>
        /// Variável que guarda o valor do local da aposentadoria.
        /// </summary>
        private string lotacaoAposentadoria;
        /// <summary>
        /// Variável que guarda o valor do matricula do siepa.
        /// </summary>
        private string matSiape;
        /// <summary>
        /// Variável que guarda o valor do nível de escolaridade.
        /// </summary>
        private string nivelEscolaridade;
        /// <summary>
        /// Variável que guarda o valor do nome do servidor.
        /// </summary>
        private string nome;
        /// <summary>
        /// Variável que guarda o valor do nome da mãe do servidor.
        /// </summary>
        private string nomeMae;
        /// <summary>
        /// Variável que guarda o valor do nome do pai do servidor.
        /// </summary>
        private string nomePai;
        /// <summary>
        /// Variável que guarda o valor do número do ponto.
        /// </summary>
        private string numeroPonto;
        /// <summary>
        /// Variável que guarda o valor do número da portaria.
        /// </summary>
        private string numeroPortaria;
        /// <summary>
        /// Variável que guarda o valor do padrão.
        /// </summary>
        private string padrao;
        /// <summary>
        /// Variável que guarda o valor da portaria.
        /// </summary>
        private string portaria;
        /// <summary>
        /// Variável que guarda o valor da proporcionalidade.
        /// </summary>
        private string proporcionalidade;
        /// <summary>
        /// Variável que guarda o valor dos registros profissionais.
        /// </summary>
        private string registrosProfessionais;
        /// <summary>
        /// Variável que guarda o valor do reservista.
        /// </summary>
        private string reservista;
        /// <summary>
        /// Variável que guarda o valor do rg.
        /// </summary>
        private string rg;
        /// <summary>
        /// Variável que guarda o valor do telefone.
        /// </summary>
        private string telefone;
        /// <summary>
        /// Variável que guarda o valor do tipo do dependente 1.
        /// </summary>
        private string tipoDependente1;
        /// <summary>
        /// Variável que guarda o valor do tipo do dependente 10.
        /// </summary>
        private string tipoDependente10;
        /// <summary>
        /// Variável que guarda o valor do tipo do dependente 2.
        /// </summary>
        private string tipoDependente2;
        /// <summary>
        /// Variável que guarda o valor do tipo do dependente 3.
        /// </summary>
        private string tipoDependente3;
        /// <summary>
        /// Variável que guarda o valor do tipo do dependente 4.
        /// </summary>
        private string tipoDependente4;
        /// <summary>
        /// Variável que guarda o valor do tipo do dependente 5.
        /// </summary>
        private string tipoDependente5;
        /// <summary>
        /// Variável que guarda o valor do tipo do dependente 6.
        /// </summary>
        private string tipoDependente6;
        /// <summary>
        /// Variável que guarda o valor do tipo do dependente 7.
        /// </summary>
        private string tipoDependente7;
        /// <summary>
        /// Variável que guarda o valor do tipo do dependente 8.
        /// </summary>
        private string tipoDependente8;
        /// <summary>
        /// Variável que guarda o valor do tipo do dependente 9.
        /// </summary>
        private string tipoDependente9;
        /// <summary>
        /// Variável que guarda o valor do tipo de remoção
        /// </summary>
        private string tipoRemocao;
        /// <summary>
        /// Variável que guarda o valor do titulo de eleitor
        /// </summary>
        private string tituloEleitor;
        /// <summary>
        /// Variável que guarda o valor da seção do titulo
        /// </summary>
        private string tituloSecao;
        /// <summary>
        /// Variável que guarda o valor da zona do titulo
        /// </summary>
        private string tituloZona;


        /// <summary>
        /// Variável do tipo usuário que guarda os atributos do usuário.
        /// </summary>
        private Usuario usuario;
        /// <summary>
        /// Variável do tipo locação anterior que guarda os atributos da locação anterior.
        /// </summary>
        private LotacaoAnterior lotacaoAnterior;
        /// <summary>
        /// Variável do tipo locação que guarda os atributos da locação.
        /// </summary>
        private Lotacao lotacao;
        /// <summary>
        /// Variável do tipo cidade que guarda os atributos do cidade.
        /// </summary>
        private Cidade cidade;
        /// <summary>
        /// Variável do tipo parentesco que guarda os atributos do parentesco.
        /// </summary>
        private Parentesco parentesco;
        /// <summary>
        /// Variável do tipo cargo que guarda os atributos do cargo.
        /// </summary>
        private Cargo cargo;


        /// <summary>
        /// Enum do tipo Ativo com os atributos da sede.
        /// </summary>
        private Ativo ativo;
        /// <summary>
        /// Enum do tipo sede com os atributos da sede.
        /// </summary>
        private Sede sede;


        /// <summary>
        /// Método construtor
        /// </summary>
        public Servidor()
        {
            usuario = new Usuario();
            lotacaoAnterior = new LotacaoAnterior();
            lotacao = new Lotacao();
            cidade = new Cidade();
            parentesco = new Parentesco();
            cargo = new Cargo();
        }


        /// <summary>
        /// Método destrutor 
        /// </summary>
        ~Servidor()
        {

        }


        /// <summary>
        /// Propriedade da variável servidorID.
        /// </summary>
        public int _ServidorID
        {
            get
            {
                return servidorID;
            }
            set
            {
                servidorID = value;
            }
        }

        /// <summary>
        /// Propriedade da variável agencia.
        /// </summary>
        public string _Agencia
        {
            get
            {
                return agencia;
            }
            set
            {
                agencia = value;
            }
        }

        /// <summary>
        /// Propriedade da variável atoNomeacao.
        /// </summary>
        public string _AtoNomeacao
        {
            get
            {
                return atoNomeacao;
            }
            set
            {
                atoNomeacao = value;
            }
        }

        /// <summary>
        /// Propriedade da variável bairro.
        /// </summary>
        public string _Bairro
        {
            get
            {
                return bairro;
            }
            set
            {
                bairro = value;
            }
        }

        /// <summary>
        /// Propriedade da variável banco.
        /// </summary>
        public string _Banco
        {
            get
            {
                return banco;
            }
            set
            {
                banco = value;
            }
        }

        /// <summary>
        /// Propriedade da variável beneficiado.
        /// </summary>
        public string _Beneficiado
        {
            get
            {
                return beneficiado;
            }
            set
            {
                beneficiado = value;
            }
        }

        /// <summary>
        /// Propriedade da variável cep.
        /// </summary>
        public string _Cep
        {
            get
            {
                return cep;
            }
            set
            {
                cep = value;
            }
        }

        /// <summary>
        /// Propriedade da variável classe.
        /// </summary>
        public string _Classe
        {
            get
            {
                return classe;
            }
            set
            {
                classe = value;
            }
        }

        /// <summary>
        /// Propriedade da variável contaCorrente.
        /// </summary>
        public string _ContaCorrente
        {
            get
            {
                return contaCorrente;
            }
            set
            {
                contaCorrente = value;
            }
        }

        /// <summary>
        /// Propriedade da variável cpf.
        /// </summary>
        public string _Cpf
        {
            get
            {
                return cpf;
            }
            set
            {
                cpf = value;
            }
        }

        /// <summary>
        /// Propriedade da variável dataAdmissao.
        /// </summary>
        public string _DataAdmissao
        {
            get
            {
                return dataAdmissao;
            }
            set
            {
                dataAdmissao = value;
            }
        }

        /// <summary>
        /// Propriedade da variável dataAposentadoria.
        /// </summary>
        public string _DataAposentadoria
        {
            get
            {
                return dataAposentadoria;
            }
            set
            {
                dataAposentadoria = value;
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
        /// Propriedade da variável dataExpedicao.
        /// </summary>
        public string _DataExpedicao
        {
            get
            {
                return dataExpedicao;
            }
            set
            {
                dataExpedicao = value;
            }
        }

        /// <summary>
        /// Propriedade da variável dataFalecimento.
        /// </summary>
        public string _DataFalecimento
        {
            get
            {
                return dataFalecimento;
            }
            set
            {
                dataFalecimento = value;
            }
        }

        /// <summary>
        /// Propriedade da variável dataNascimento.
        /// </summary>
        public string _DataNascimento
        {
            get
            {
                return dataNascimento;
            }
            set
            {
                dataNascimento = value;
            }
        }

        /// <summary>
        /// Propriedade da variável dataPrimeiroEmprego.
        /// </summary>
        public string _DataPrimeiroEmprego
        {
            get
            {
                return dataPrimeiroEmprego;
            }
            set
            {
                dataPrimeiroEmprego = value;
            }
        }

        /// <summary>
        /// Propriedade da variável dataVigencia.
        /// </summary>
        public string _DataVigencia
        {
            get
            {
                return dataVigencia;
            }
            set
            {
                dataVigencia = value;
            }
        }

        /// <summary>
        /// Propriedade da variável dependente1.
        /// </summary>
        public string _Dependente1
        {
            get
            {
                return dependente1;
            }
            set
            {
                dependente1 = value;
            }
        }

        /// <summary>
        /// Propriedade da variável dependente10.
        /// </summary>
        public string _Dependente10
        {
            get
            {
                return dependente10;
            }
            set
            {
                dependente10 = value;
            }
        }

        /// <summary>
        /// Propriedade da variável dependente2.
        /// </summary>
        public string _Dependente2
        {
            get
            {
                return dependente2;
            }
            set
            {
                dependente2 = value;
            }
        }

        /// <summary>
        /// Propriedade da variável dependente3.
        /// </summary>
        public string _Dependente3
        {
            get
            {
                return dependente3;
            }
            set
            {
                dependente3 = value;
            }
        }

        /// <summary>
        /// Propriedade da variável dependente4.
        /// </summary>
        public string _Dependente4
        {
            get
            {
                return dependente4;
            }
            set
            {
                dependente4 = value;
            }
        }

        /// <summary>
        /// Propriedade da variável dependente5.
        /// </summary>
        public string _Dependente5
        {
            get
            {
                return dependente5;
            }
            set
            {
                dependente5 = value;
            }
        }

        /// <summary>
        /// Propriedade da variável dependente6.
        /// </summary>
        public string _Dependente6
        {
            get
            {
                return dependente6;
            }
            set
            {
                dependente6 = value;
            }
        }

        /// <summary>
        /// Propriedade da variável dependente7.
        /// </summary>
        public string _Dependente7
        {
            get
            {
                return dependente7;
            }
            set
            {
                dependente7 = value;
            }
        }

        /// <summary>
        /// Propriedade da variável dependente8.
        /// </summary>
        public string _Dependente8
        {
            get
            {
                return dependente8;
            }
            set
            {
                dependente8 = value;
            }
        }

        /// <summary>
        /// Propriedade da variável dependente9.
        /// </summary>
        public string _Dependente9
        {
            get
            {
                return dependente9;
            }
            set
            {
                dependente9 = value;
            }
        }

        /// <summary>
        /// Propriedade da variável dependenteDataNascimento1.
        /// </summary>
        public string _DependenteDataNascimento1
        {
            get
            {
                return dependenteDataNascimento1;
            }
            set
            {
                dependenteDataNascimento1 = value;
            }
        }

        /// <summary>
        /// Propriedade da variável dependenteDataNascimento10.
        /// </summary>
        public string _DependenteDataNascimento10
        {
            get
            {
                return dependenteDataNascimento10;
            }
            set
            {
                dependenteDataNascimento10 = value;
            }
        }

        /// <summary>
        /// Propriedade da variável dependenteDataNascimento2.
        /// </summary>
        public string _DependenteDataNascimento2
        {
            get
            {
                return dependenteDataNascimento2;
            }
            set
            {
                dependenteDataNascimento2 = value;
            }
        }

        /// <summary>
        /// Propriedade da variável dependenteDataNascimento3.
        /// </summary>
        public string _DependenteDataNascimento3
        {
            get
            {
                return dependenteDataNascimento3;
            }
            set
            {
                dependenteDataNascimento3 = value;
            }
        }

        /// <summary>
        /// Propriedade da variável dependenteDataNascimento4.
        /// </summary>
        public string _DependenteDataNascimento4
        {
            get
            {
                return dependenteDataNascimento4;
            }
            set
            {
                dependenteDataNascimento4 = value;
            }
        }

        /// <summary>
        /// Propriedade da variável dependenteDataNascimento5.
        /// </summary>
        public string _DependenteDataNascimento5
        {
            get
            {
                return dependenteDataNascimento5;
            }
            set
            {
                dependenteDataNascimento5 = value;
            }
        }

        /// <summary>
        /// Propriedade da variável dependenteDataNascimento6.
        /// </summary>
        public string _DependenteDataNascimento6
        {
            get
            {
                return dependenteDataNascimento6;
            }
            set
            {
                dependenteDataNascimento6 = value;
            }
        }

        /// <summary>
        /// Propriedade da variável dependenteDataNascimento7.
        /// </summary>
        public string _DependenteDataNascimento7
        {
            get
            {
                return dependenteDataNascimento7;
            }
            set
            {
                dependenteDataNascimento7 = value;
            }
        }

        /// <summary>
        /// Propriedade da variável dependenteDataNascimento8.
        /// </summary>
        public string _DependenteDataNascimento8
        {
            get
            {
                return dependenteDataNascimento8;
            }
            set
            {
                dependenteDataNascimento8 = value;
            }
        }

        /// <summary>
        /// Propriedade da variável dependenteDataNascimento9.
        /// </summary>
        public string _DependenteDataNascimento9
        {
            get
            {
                return dependenteDataNascimento9;
            }
            set
            {
                dependenteDataNascimento9 = value;
            }
        }

        /// <summary>
        /// Propriedade da variável email.
        /// </summary>
        public string _Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }

        /// <summary>
        /// Propriedade da variável endereco.
        /// </summary>
        public string _Endereco
        {
            get
            {
                return endereco;
            }
            set
            {
                endereco = value;
            }
        }

        /// <summary>
        /// Propriedade da variável escolaridade.
        /// </summary>
        public string _Escolaridade
        {
            get
            {
                return escolaridade;
            }
            set
            {
                escolaridade = value;
            }
        }

        /// <summary>
        /// Propriedade da variável estadoCivil.
        /// </summary>
        public string _EstadoCivil
        {
            get
            {
                return estadoCivil;
            }
            set
            {
                estadoCivil = value;
            }
        }

        /// <summary>
        /// Propriedade da variável formacaoEspecializacao.
        /// </summary>
        public string _FormacaoEspecializacao
        {
            get
            {
                return formacaoEspecializacao;
            }
            set
            {
                formacaoEspecializacao = value;
            }
        }

        /// <summary>
        /// Propriedade da variável funcao.
        /// </summary>
        public string _Funcao
        {
            get
            {
                return funcao;
            }
            set
            {
                funcao = value;
            }
        }

        /// <summary>
        /// Propriedade da variável fundamentacao.
        /// </summary>
        public string _Fundamentacao
        {
            get
            {
                return fundamentacao;
            }
            set
            {
                fundamentacao = value;
            }
        }

        /// <summary>
        /// Propriedade da variável localTransferencia.
        /// </summary>
        public string _LocalTransferencia
        {
            get
            {
                return localTransferencia;
            }
            set
            {
                localTransferencia = value;
            }
        }

        /// <summary>
        /// Propriedade da variável localAposentadoria.
        /// </summary>
        public string _LotacaoAposentadoria
        {
            get
            {
                return lotacaoAposentadoria;
            }
            set
            {
                lotacaoAposentadoria = value;
            }
        }

        /// <summary>
        /// Propriedade da variável matSiape.
        /// </summary>
        public string _MatSiape
        {
            get
            {
                return matSiape;
            }
            set
            {
                matSiape = value;
            }
        }

        /// <summary>
        /// Propriedade da variável nivelEscolaridade.
        /// </summary>
        public string _NivelEscolaridade
        {
            get
            {
                return nivelEscolaridade;
            }
            set
            {
                nivelEscolaridade = value;
            }
        }

        /// <summary>
        /// Propriedade da variável nome.
        /// </summary>
        public string _Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }

        /// <summary>
        /// Propriedade da variável nomeMae.
        /// </summary>
        public string _NomeMae
        {
            get
            {
                return nomeMae;
            }
            set
            {
                nomeMae = value;
            }
        }

        /// <summary>
        /// Propriedade da variável nomePai.
        /// </summary>
        public string _NomePai
        {
            get
            {
                return nomePai;
            }
            set
            {
                nomePai = value;
            }
        }

        /// <summary>
        /// Propriedade da variável numeroPonto.
        /// </summary>
        public string _NumeroPonto
        {
            get
            {
                return numeroPonto;
            }
            set
            {
                numeroPonto = value;
            }
        }

        /// <summary>
        /// Propriedade da variável numeroPortaria.
        /// </summary>
        public string _NumeroPortaria
        {
            get
            {
                return numeroPortaria;
            }
            set
            {
                numeroPortaria = value;
            }
        }

        /// <summary>
        /// Propriedade da variável padrao.
        /// </summary>
        public string _Padrao
        {
            get
            {
                return padrao;
            }
            set
            {
                padrao = value;
            }
        }

        /// <summary>
        /// Propriedade da variável portaria.
        /// </summary>
        public string _Portaria
        {
            get
            {
                return portaria;
            }
            set
            {
                portaria = value;
            }
        }

        /// <summary>
        /// Propriedade da variável proporcionalidade.
        /// </summary>
        public string _Proporcionalidade
        {
            get
            {
                return proporcionalidade;
            }
            set
            {
                proporcionalidade = value;
            }
        }

        /// <summary>
        /// Propriedade da variável registrosProfissionais.
        /// </summary>
        public string _RegistrosProfessionais
        {
            get
            {
                return registrosProfessionais;
            }
            set
            {
                registrosProfessionais = value;
            }
        }

        /// <summary>
        /// Propriedade da variável reservista.
        /// </summary>
        public string _Reservista
        {
            get
            {
                return reservista;
            }
            set
            {
                reservista = value;
            }
        }

        /// <summary>
        /// Propriedade da variável rg.
        /// </summary>
        public string _Rg
        {
            get
            {
                return rg;
            }
            set
            {
                rg = value;
            }
        }

        /// <summary>
        /// Propriedade da variável telefone.
        /// </summary>
        public string _Telefone
        {
            get
            {
                return telefone;
            }
            set
            {
                telefone = value;
            }
        }

        /// <summary>
        /// Propriedade da variável tipoDependente1.
        /// </summary>
        public string _TipoDependente1
        {
            get
            {
                return tipoDependente1;
            }
            set
            {
                tipoDependente1 = value;
            }
        }
        
        /// <summary>
        /// Propriedade da variável tipoDependente10.
        /// </summary>
        public string _TipoDependente10
        {
            get
            {
                return tipoDependente10;
            }
            set
            {
                tipoDependente10 = value;
            }
        }

        /// <summary>
        /// Propriedade da variável tipoDependente2.
        /// </summary>
        public string _TipoDependente2
        {
            get
            {
                return tipoDependente2;
            }
            set
            {
                tipoDependente2 = value;
            }
        }

        /// <summary>
        /// Propriedade da variável tipoDependente3.
        /// </summary>
        public string _TipoDependente3
        {
            get
            {
                return tipoDependente3;
            }
            set
            {
                tipoDependente3 = value;
            }
        }

        /// <summary>
        /// Propriedade da variável tipoDependente4.
        /// </summary>
        public string _TipoDependente4
        {
            get
            {
                return tipoDependente4;
            }
            set
            {
                tipoDependente4 = value;
            }
        }

        /// <summary>
        /// Propriedade da variável tipoDependente5.
        /// </summary>
        public string _TipoDependente5
        {
            get
            {
                return tipoDependente5;
            }
            set
            {
                tipoDependente5 = value;
            }
        }
        /// <summary>
        /// Propriedade da variável tipoDependente6.
        /// </summary>
        public string _TipoDependente6
        {
            get
            {
                return tipoDependente6;
            }
            set
            {
                tipoDependente6 = value;
            }
        }

        /// <summary>
        /// Propriedade da variável tipoDependente7.
        /// </summary>
        public string _TipoDependente7
        {
            get
            {
                return tipoDependente7;
            }
            set
            {
                tipoDependente7 = value;
            }
        }

        /// <summary>
        /// Propriedade da variável tipoDependente8.
        /// </summary>
        public string _TipoDependente8
        {
            get
            {
                return tipoDependente8;
            }
            set
            {
                tipoDependente8 = value;
            }
        }

        /// <summary>
        /// Propriedade da variável tipoDependente9.
        /// </summary>
        public string _TipoDependente9
        {
            get
            {
                return tipoDependente9;
            }
            set
            {
                tipoDependente9 = value;
            }
        }

        /// <summary>
        /// Propriedade da variável tipoRemocao.
        /// </summary>
        public string _TipoRemocao
        {
            get
            {
                return tipoRemocao;
            }
            set
            {
                tipoRemocao = value;
            }
        }

        /// <summary>
        /// Propriedade da variável tituloEleitor.
        /// </summary>
        public string _TituloEleitor
        {
            get
            {
                return tituloEleitor;
            }
            set
            {
                tituloEleitor = value;
            }
        }


        /// <summary>
        /// Propriedade da variável tituloSecao.
        /// </summary>
        public string _TituloSecao
        {
            get
            {
                return tituloSecao;
            }
            set
            {
                tituloSecao = value;
            }
        }

        /// <summary>
        /// Propriedade da variável tituloZona.
        /// </summary>
        public string _TituloZona
        {
            get
            {
                return tituloZona;
            }
            set
            {
                tituloZona = value;
            }
        }

        /// <summary>
        /// Propriedade da variável usuario.
        /// </summary>
        public Usuario _Usuario
        {
            get
            {
                return usuario;
            }
            set
            {
                usuario = value;
            }
        }

        /// <summary>
        /// Propriedade da variável locacaoAnterior.
        /// </summary>
        public LotacaoAnterior _LotacaoAnterior
        {
            get
            {
                return lotacaoAnterior;
            }
            set
            {
                lotacaoAnterior = value;
            }
        }

        /// <summary>
        /// Propriedade da variável lotacao.
        /// </summary>
        public Lotacao _Lotacao
        {
            get
            {
                return lotacao;
            }
            set
            {
                lotacao = value;
            }
        }

        /// <summary>
        /// Propriedade da variável cidade.
        /// </summary>
        public Cidade _Cidade
        {
            get
            {
                return cidade;
            }
            set
            {
                cidade = value;
            }
        }

        /// <summary>
        /// Propriedade da variável parentesco.
        /// </summary>
        public Parentesco _Parentesco
        {
            get
            {
                return parentesco;
            }
            set
            {
                parentesco = value;
            }
        }

        /// <summary>
        /// Propriedade da variável cargo.
        /// </summary>
        public Cargo _Cargo
        {
            get
            {
                return cargo;
            }
            set
            {
                cargo = value;
            }
        }

        /// <summary>
        /// Propriedade da variável ativo.
        /// </summary>
        public Ativo _Ativo
        {
            get
            {
                return ativo;
            }
            set
            {
                ativo = value;
            }
        }

        /// <summary>
        /// Propriedade da variável sede.
        /// </summary>
        public Sede _Sede
        {
            get
            {
                return sede;
            }
            set
            {
                sede = value;
            }
        }
    }
}
