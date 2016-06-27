/*Autor: Rodolfo Póvoa Leal */

using AllAboutOO.Controllers;

namespace AllAboutOO.Class
{

    public class Aluno : Person

    {

        //Método Construtor da Classe Aluno
        public Aluno()

        {
            //Aqui fica o código a ser implementado no método Construtor
        }

        //Método destrutor Classe Aluno
        ~Aluno()
        {
            //Aqui fica o código do método destrutor
        }

        //Atributos especificos da Classe Pessoa. Os outros atributos Nome , Sobrenome, CPF, DataDeNascimento, são herdados da classe Person
        public long Matricula { get; set; }
        public string DataDeCadastro { get; set; }

        //Método para criação de um novo aluno
        public virtual Aluno NovoAluno()
        {

            Aluno aluno = new Aluno();

            aluno.CPF = "100.677.243-55";
            aluno.Nome = "Anderson";
            aluno.Sobrenome = "Silva";
            aluno.DataDeNascimento = "13/01/1990";
            aluno.TelefoneCelular = "21 98832-6699";
            aluno.Rua = "Av Nossa Senhora de Copacabana";
            aluno.Bairro = "Copacabana";
            aluno.Numero = 79;
            aluno.Matricula = 25452;
            aluno.DataDeCadastro = "15/10/2005";

            return aluno;

        }


        /* Na classe aluno estamos fazendo uma Herança, herdando atributos e métodos da classse Person. Vamos pensar no seguinte, um aluno tem os mesmos atributos da 
           classe Person, um Aluno tem nome, sobrenome, data de nascimento, Rua, Bairro, Telefone Celuler e etc. Para não precisar reescrever esses atributos em outra classe
           implementaremos a herança. A interface é implementada da seguinte forma, SuaClasse : ClasseQueQueroHerdar.

           Note que no método NovoAluno(), estamos preenchendo atributos que estão na classe Person e foram herdados para a classe Aluno. Os atributos Matricula e Data de Cadastro
           não foram herdados pois são atributos criados dentro da classe Aluno e por isso são atriutos específicos dessa classe, ou seja, nem toda pessoa tem Matricula e Data de Cadastro.

        */


        /*
           Métodos construtores são métodos que serão chamados sempre quando a classe é criada. As regras de definição de construtortes são:

            - o construtor deve ter o mesmo nome da classe;
            - não tem tipo de retorno;
            - é executado apenas um, apenas uma vez, no momento da criação do objeto;
            - não pode ser chamado diretamente;
            - deve ser “public”;

           O método Aluno() é um método construtor e será executado na criação do objeto, ou seja, assim que a classe é instanciada.
       */

        //Método para validar um campo
        public bool ValidField(long matricula)
        {
            if (matricula == 0)
            {
                return true;
            }
            else
            { 
                return false;
            }
        }

        //Sobrecarga do método acima
        public bool ValidField(string CPF)
        {

            if (CPF.Length == 11)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /*O método  - public bool ValidField(long matricula) - está sendo sobrecarregado. Existe um outro método ( - public bool ValidField(string CPF) - ) com mesmo nome porem com o tipo de parâmetro
          diferente, no primeiro o método recebe um parâmetro do tipo Long  e no segundo o método recebe um parâmetro do tipo string. Na hora de chamar o método o tipo de dado que eu passar pra ele,
          define qual método será chamado.

          A sobrecarga de métodos é utilizada quando queremos criar um vários métodos com funções parecidas, ou até iguais, mas que tenham diferentes tipos de dados.
         */
    }




}
