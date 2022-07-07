using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando Projeto 5 - Caracteres e Textos");

        char letra = 'a';
        Console.WriteLine(letra);

         letra =(char) 65;
        Console.WriteLine(letra);

        letra = (char)(65 + 1);
        letra = (char)(65 + 10);
        Console.WriteLine(letra);

        string primeiraFrase = "Alura - curso de tecnologia";
        Console.WriteLine(primeiraFrase + 2022);

        string vazia = "";
        Console.WriteLine(vazia); // string aceita vazia no vs22


        letra = ' '; // no char precisamos de pelo memos um espaço para não dar erro

        string cursos = @"Curso disponiveis:
-Go 
-c# 
-Python 
-Java ";
        Console.WriteLine(cursos);

        string palavra = "Breve vira";
        palavra = palavra + " breve Jesus voltara"; // concatenando string com string
        Console.WriteLine(palavra);


        string palavras = "estamos em ";
        palavras = palavras + 2022;
        Console.WriteLine(palavras);// concatenando string mais numeros

        string saudacao = "Olá, meu nome é ";
        string nome = " Vagner ";
        string continuacao = " e minha idade é ";
        int idade = 39;
        Console.WriteLine(saudacao + nome + continuacao + idade);


        Console.WriteLine("pressione enter para sair....");
        Console.ReadLine();
    }
}
