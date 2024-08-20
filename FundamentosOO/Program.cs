using FundamentosOO;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

internal class Program
{



    private static void Main(string[] args)
    {
        //Livro livro1 = new Livro();
        //livro1.Titulo = "Harry Potter";
        //livro1.Autor = "J.K Rowlings";
        //livro1.Editora = "Editora Abril";
        //livro1.AnoLancamento = 2001;

        //Livro livro2 = new Livro();
        //livro2.Titulo = "Revolução dos Bixos";
        //livro2.Autor = "George Orwell";
        //livro2.Editora = "BBC";
        //livro2.AnoLancamento = 1984;

        //Livro livro3 = new Livro();
        //livro3.Titulo = "Programando em C#";
        //livro3.Autor = "Gustavo Castello";
        //livro3.Editora = "Editora Nova";
        //livro3.AnoLancamento = 1982;

        //Instanciar um objeto do tipo Aluno
        //Aluno aluno1 = new Aluno();
        //Aluno aluno2 = new Aluno();
        //Aluno aluno3 = new Aluno();

        ////Preencher os atributos do objeto
        //aluno1.Nome = "Joaquim";
        //aluno1.RM = "4795";
        //aluno1.Email = "jotagesr@gmail.com";
        //aluno1.Nascimento = new DateOnly(2007, 08, 10);

        //aluno2.Nome = "Bruno Henrique Martins Alves";
        //aluno2.RM = "6666";
        //aluno2.Email = "bruno.contato2007@gmail.com";
        //aluno2.Nascimento = new DateOnly(2007, 08, 28);

        //aluno3.Nome = "João Rodolfo Fiamengui Costa";
        //aluno3.RM = "1234";
        //aluno3.Email = "jones@gmail.com";
        //aluno3.Nascimento = new DateOnly(2008, 05, 16);


        ////Imprimir na tela
        //Console.WriteLine("Aluno 1");
        //Console.WriteLine("Nome: " + aluno1.Nome);
        //Console.WriteLine("RM: " + aluno1.RM);
        //Console.WriteLine("Email: " + aluno1.Email);
        //Console.WriteLine("Nascimento: " + aluno1.Nascimento);
        //Console.WriteLine("===================================================");
        //Console.WriteLine("Aluno 2");
        //Console.WriteLine("Nome: " + aluno2.Nome);
        //Console.WriteLine("RM: " + aluno2.RM);
        //Console.WriteLine("Email: " + aluno2.Email);
        //Console.WriteLine("Nascimento: " + aluno2.Nascimento);
        //Console.WriteLine("===================================================");
        //Console.WriteLine("Aluno 3");
        //Console.WriteLine("Nome: " + aluno3.Nome);
        //Console.WriteLine("RM: " + aluno3.RM);
        //Console.WriteLine("Email: " + aluno3.Email);
        //Console.WriteLine("Nascimento: " + aluno3.Nascimento);
        //Console.WriteLine("===================================================");

        ////Instanciar um objeto do tipo produto
        //Produto p1 = new Produto();

        ////Preencher os atributos do objeto
        //p1.Codigo = 123456;
        //p1.Nome = "Coca-Cola 2 Litros";
        //p1.Preco = 12.99;
        //p1.Estoque = 96;

        ////Chamar o método PRodutos em Estoque
        //p1.QuantidadeEstoque();

        //p1.Estoque = 85;
        //p1.QuantidadeEstoque();
        //Console.WriteLine("===================================================");

        //Console.WriteLine(" ");

        ////Instanciar um objeto do tipo carro
        //Carro carro1 = new Carro();

        ////Preencher os atributos do objeto
        //carro1.Marca = "Lamborghini";
        //carro1.Modelo = "Miura";
        //carro1.Velocidade = 80;

        ////Acelerar ou desacelerar

        //carro1.Acelerar();
        //carro1.Desacelerar();
        //carro1.Desacelerar();
        //carro1.Desacelerar();
        //carro1.Desacelerar();
        //carro1.Desacelerar();
        //carro1.Acelerar();
        //carro1.Acelerar();
        //carro1.Acelerar();
        //carro1.Acelerar();
        //carro1.Acelerar();
        //carro1.Acelerar();
        //carro1.Acelerar();
        //carro1.Acelerar();
        //carro1.Acelerar();
        //carro1.Acelerar();
        //carro1.Acelerar();
        //carro1.Acelerar();
        //carro1.Acelerar();
        //carro1.Acelerar();



        //Console.WriteLine("===================================================");

        //Console.WriteLine(" ");
        ////Instanciando um objeto Pessoa
        //Pessoa pessoa1 = new Pessoa();

        ////Preencher os atributos da pessoa
        //pessoa1.Nome = "Joaquim";
        //pessoa1.Idade = 17;

        ////Envelhecer
        //pessoa1.Envelhecer(5);
        //Console.WriteLine("===================================================");

        //Console.WriteLine(" ");

        //Funcionario func1 = new Funcionario();
        //func1.Nome = "Fábio";
        //func1.Idade = 34;
        //func1.Cargo = "Caixa";
        //func1.Salario = 1320.00;
        //func1.Apresentar();

        //Console.WriteLine("===================================================");

        //Console.WriteLine(" ");
        //Instanciando um objeto Animal
        //Animal animal1 = new Animal();

        ////Preencher os atributos do Animal
        //animal1.Especie = "Cachorro";

        ////Chamando o Método do Objeto
        //animal1.emitirSom();

        ////Imprimindo a informação na tela
        //Console.WriteLine("O Animal " + animal1.Especie + " emitiu um som");

        //Instanciando um objeto da classe animal subclasse gato

        //Gato gato1 = new Gato();
        //gato1.Nome = "Maizena";
        //Console.WriteLine(gato1.Nome + " disse:");
        //gato1.emitirSom();
        //Gato gato2 = new Gato();
        //gato2.Nome = "Tom";
        //Console.WriteLine(gato2.Nome + " disse:");
        //gato1.emitirSom();

        //Porco porco1 = new Porco();
        //porco1.Nome = "Napoleão";
        //Console.WriteLine(porco1.Nome + " disse:");
        //porco1.emitirSom();

        //Galinha galinha1 = new Galinha();
        //galinha1.Nome = "Gertrudes";
        //Console.WriteLine(galinha1.Nome + " disse:");
        //galinha1.emitirSom();


        Console.WriteLine("===================================================");

        Console.WriteLine(" ");

        Cavaleiro cavaleiro1 = new Cavaleiro();
        cavaleiro1.Nome = "Leôncio";
        cavaleiro1.Categoria = "Cavaleiro";
        cavaleiro1.Nivel = 1;
        cavaleiro1.Forca = 125;
        cavaleiro1.Vida = 300;
        cavaleiro1.Inteligencia = 100;
        cavaleiro1.Agilidade = 75;

        cavaleiro1.Apresentar();

        Console.WriteLine(" ");

        Mago mago1 = new Mago();
        mago1.Nome = "Patolino";
        mago1.Categoria = "Mago";
        mago1.Nivel = 1;
        mago1.Forca = 150;
        mago1.Vida = 300;
        mago1.Inteligencia = 100;
        mago1.Agilidade = 50;

        mago1.Apresentar();

        Console.WriteLine(" ");

        mago1.Confronto(cavaleiro1);
        Console.WriteLine(" ");

        mago1.Apresentar();
    }
}