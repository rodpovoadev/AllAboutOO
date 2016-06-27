/*Autor: Rodolfo Póvoa Leal */

namespace AllAboutOO.Controllers
{
    public class Pessoa
    {
        public string CPF { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string DataDeNascimento { get; set; }
        public string TelefoneCelular { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public int Numero { get; set; }

        //Pessoa é uma classe, as classes foram inspiradas no mundo real. Podemos associar uma classe ao ato de denomiar uma entidade que compartilha 
        //alguns comportamentos e que possuem um conjunto de propriedades comuns.

        //CPF, Nome , Sobrenome , DataDeNascimento, TelefoneCelular , Rua, Bairro e Numero sáo propriedades da classe pessoa, ou seja não variáveis que poderam conter
        //informações sobre a classe.

        public void CadastrarPessoa()
        {

            //Aqui teremos o código que implementa esse método

        }

        public Pessoa CriaNovaPessoa()

        {

            Pessoa pessoa = new Pessoa();

            pessoa.CPF = "100.677.243-55";
            pessoa.Nome = "Carlos";
            pessoa.Sobrenome = "Silva";
            pessoa.DataDeNascimento = "13/01/1987";
            pessoa.TelefoneCelular = "21 99876-6789";
            pessoa.Rua = "Rua Borges de Medéiros";
            pessoa.Bairro = "Botafogo";
            pessoa.Numero = 100;

            return pessoa;
        }

        public bool ValidaCPF(string CPF)
        {

            if (CPF.Length == 14)
            {
                return true;
            }
                return false;

        }

        // CadastrarPessoa() é um método, os métodos são ações que as classes podem desempenhar. Trazendo para o mundo real, uma Classe Carro tem como comportamento
        // IrParaFrente(), VirarAEquerda() , Acelerar() e etc. A nomecaltura de construção de um método é: Public ou Private ou protected ou default + Void ou Tipo de Retorno + NomeDoMetodo().
        // Public informa que o método é público e pode ser utilizado por qualuer um no sistema. 
        /*
            
        Private: A única classe que tem acesso ao atributo é a própria classe que o define, ou seja, se uma classe Pessoa declara um método privado chamado CriarNovaPessoa, somente a classe Pessoa terá acesso a ele.
        Public: Qualuqer classe tera acesso ao método

        Método podem ou não ter retorno. Quando é colocado a palavra void na frente dos método queremos indicar que esse método realizará uma ação
        e não retornará nada para quem o chama.

        Se é necessário retornar algo dentro do método. Faremos public + tipo do retorno // int ou string ou double ou algum objeto // + NomeDoMetodo()
        ao final do método temos que colocar a palavra return + //O que estamos retornando//. Podemos ver esse exemplo no método CriarNovaPessoa(), que retorna um
        objeto do tipo Pessoa.

        Objetos são instâncias de uma classe. Indo um pouco mais a fundo objetos são  basicamente um bloco de memória que foi atribuído e configurado de acordo com o modelo.

        No treço do código / Pessoa pessoa = new Pessoa(); / estamos instânciando a classe Pessoa para uso, pessoa é um objeto instanciado para essa classe. Esse objeto pessoa
        tera acesso a todos os atributos e métodos da classe Pessoa.
        Podemos observar isso no código do método CriarNovaPessoa(). Podemos acessar o atributo nome da classe Pessoa fazendo pessoa.Nome = "Carlos";

        O método ValidarCPF() recebe um variável string de parâmetro, esses parâmetros são utilizados quando queremos receber alguma informação de quem está chamando o
        método. Esse parâmetro será utilizado na lógica dentro do método.
        */

    }
}