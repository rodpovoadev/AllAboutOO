using AllAboutOO.Controllers;

namespace AllAboutOO.Class
{

        public class Aluno : Person

        {

        
            public Aluno()

            {
                //Aqui fica o código a ser implementado no método Construtor
            }

            ~Aluno()
            {
                //Aqui fica o código do método destrutor
            }

          public int Matricula { get; set; }
          public string DataDeCadastro { get; set; }

        
          public Aluno NovoAluno()
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
           classe Person, um Aluno tem nome, sobrenome, data de nascimento, Rua, Bairro, Telefone Celuler e etc. Para não precisar reencrever esses atributos em outra classe
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




    }

}
