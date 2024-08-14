using FundamentosOO;
using System.Net.WebSockets;
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
        Aluno aluno1 = new Aluno();
        Aluno aluno2 = new Aluno();
        Aluno aluno3 = new Aluno();

        //Preencher os atributos do objeto
        aluno1.Nome = "Joaquim";
        aluno1.RM = "4795";
        aluno1.Email = "jotagesr@gmail.com";
        aluno1.Nascimento = new DateOnly(2007, 08, 10);

        aluno2.Nome = "Bruno Henrique Martins Alves";
        aluno2.RM = "6666";
        aluno2.Email = "bruno.contato2007@gmail.com";
        aluno2.Nascimento = new DateOnly(2007, 08, 28);

        aluno3.Nome = "João Rodolfo Fiamengui Costa";
        aluno3.RM = "1234";
        aluno3.Email = "jones@gmail.com";
        aluno3.Nascimento = new DateOnly(2008, 05, 16);


        //Imprimir na tela
        Console.WriteLine("Aluno 1");
        Console.WriteLine("Nome: " + aluno1.Nome);
        Console.WriteLine("RM: " + aluno1.RM);
        Console.WriteLine("Email: " + aluno1.Email);
        Console.WriteLine("Nascimento: " + aluno1.Nascimento);
        Console.WriteLine("===================================================");
        Console.WriteLine("Aluno 2");
        Console.WriteLine("Nome: " + aluno2.Nome);
        Console.WriteLine("RM: " + aluno2.RM);
        Console.WriteLine("Email: " + aluno2.Email);
        Console.WriteLine("Nascimento: " + aluno2.Nascimento);
        Console.WriteLine("===================================================");
        Console.WriteLine("Aluno 3");
        Console.WriteLine("Nome: " + aluno3.Nome);
        Console.WriteLine("RM: " + aluno3.RM);
        Console.WriteLine("Email: " + aluno3.Email);
        Console.WriteLine("Nascimento: " + aluno3.Nascimento);
        Console.WriteLine("===================================================");

        //Instanciar um objeto do tipo produto
        Produto p1 = new Produto();

        //Preencher os atributos do objeto
        p1.Codigo = 123456;
        p1.Nome = "Coca-Cola 2 Litros";
        p1.Preco = 12.99;
        p1.Estoque = 96;

        //Chamar o método PRodutos em Estoque
        p1.QuantidadeEstoque();

        p1.Estoque = 85;
        p1.QuantidadeEstoque();
        Console.WriteLine("===================================================");

        Console.WriteLine(" ");

        //Instanciar um objeto do tipo carro
        Carro carro1 = new Carro();

        //Preencher os atributos do objeto
        carro1.Marca = "Lamborghini";
        carro1.Modelo = "Miura";
        carro1.Velocidade = 80;

        //Acelerar ou desacelerar

        carro1.Acelerar();
        carro1.Desacelerar();
        carro1.Desacelerar();
        carro1.Desacelerar();
        carro1.Desacelerar();
        carro1.Desacelerar();
        carro1.Acelerar();
        carro1.Acelerar();
        carro1.Acelerar();
        carro1.Acelerar();
        carro1.Acelerar();
        carro1.Acelerar();
        carro1.Acelerar();
        carro1.Acelerar();
        carro1.Acelerar();
        carro1.Acelerar();
        carro1.Acelerar();
        carro1.Acelerar();
        carro1.Acelerar();
        carro1.Acelerar();



        Console.WriteLine("===================================================");

        Console.WriteLine(" ");
        //Instanciando um objeto Pessoa
        Pessoa pessoa1 = new Pessoa();

        //Preencher os atributos da pessoa
        pessoa1.Nome = "Joaquim";
        pessoa1.Idade = 17;

        //Envelhecer
        pessoa1.Envelhecer(5);
        Console.WriteLine("===================================================");

        Console.WriteLine(" ");
        Funcionario func1 = new Funcionario();
        func1.Nome = "Fábio";
        func1.Idade = 34;
        func1.Cargo = "Caixa";
        func1.Salario = 1320.00;
        func1.Apresentar();
    }
}