//Alunos: Cauê Souza de Lima e Kauan Luciano Correia Alencar


using System;


class Program
{
public static void Main(string[] args)
{


string nome1, nome2;
string[] cartas = {"copas", "espadas", "ouros"};




    int pontuacao1 = 10;
    int pontuacao2 = 10;


    Console.WriteLine("Bem-vindo jogo de cartas");
    Console.WriteLine("Gosta de jogar com alguém? (1-Sim 2-Não)");
    int resp= int.Parse(Console.ReadLine());


    switch (resp)
    {
       
    case 1:
   
    Console.WriteLine("Nome do jogador 1:");
    nome1 = Console.ReadLine();
    Console.WriteLine("Nome do jogador 2:");
    nome2 = Console.ReadLine();


    Console.WriteLine("Jogador 1: " + nome1 + "\n");
    Console.WriteLine("Pontuação: " + pontuacao1+ "\n");


    Console.WriteLine("Jogador 2: " + nome2 + "\n");
    Console.WriteLine("Pontuação: " + pontuacao2 + "\n");


    do
    {
        Console.WriteLine("Vez do " + nome1 + ", aperte qualquer tecla para continuar.");
        Console.ReadLine();


        Random random = new Random();
        string carta1 = cartas[random.Next(0, 3)];
        string carta2 = cartas[random.Next(0, 3)];
        string carta3 = cartas[random.Next(0, 3)];


        Console.WriteLine(carta1);
        Console.WriteLine(carta2);
        Console.WriteLine(carta3);


        if (carta1 == carta2 && carta2 == carta3)
        {
            Console.WriteLine(nome1 + " não perdeu ponto" + "\n");
            Console.WriteLine("Pontuação: " + pontuacao1);
        }
        else
        {
            pontuacao1--;


            Console.WriteLine(nome1 + " perdeu pontos" + "\n");
            Console.WriteLine("Pontuação: " + pontuacao1);
        }


        Console.WriteLine("Vez do " + nome2 + ", aperte qualquer tecla para continuar.");
        Console.ReadLine();


        Random random2 = new Random();
        string carta5 = cartas[random.Next(0, 3)];
        string carta6 = cartas[random.Next(0, 3)];
        string carta7 = cartas[random.Next(0, 3)];


        Console.WriteLine(carta5);
        Console.WriteLine(carta6);
        Console.WriteLine(carta7);


        if (carta5 == carta6 && carta6 == carta7)
        {
            Console.WriteLine("Pontuação: " + pontuacao2);
            Console.WriteLine(nome2 + " não perdeu ponto" + "\n");
           
        }
        else
        {
            pontuacao2--;


            Console.WriteLine("Pontuação: " + pontuacao2);
            Console.WriteLine(nome2 + " perdeu pontos" + "\n");
           
        }


    } while (pontuacao1 > 0 && pontuacao2 > 0);


    if (pontuacao1 == 0)
    {
        Console.WriteLine(nome2 + " ganhou o jogo!");
    }
    else if (pontuacao2 == 0)
    {
        Console.WriteLine(nome1 + " ganhou o jogo!");
    }


    break;


    case 2:
   
    Console.WriteLine("Nome do jogador 1:");
    nome1 = Console.ReadLine();




    Console.WriteLine("Jogador 1: " + nome1 + "\n");
    Console.WriteLine("Pontuação: " + pontuacao1+ "\n");


    Console.WriteLine("Jogador 2: Máquina" + "\n");
    Console.WriteLine("Pontuação: " + pontuacao2 + "\n");


    do
    {
        Console.WriteLine("Vez do " + nome1 + ", aperte qualquer tecla para continuar.");
        Console.ReadLine();


        Random random = new Random();
        string carta1 = cartas[random.Next(0, 3)];
        string carta2 = cartas[random.Next(0, 3)];
        string carta3 = cartas[random.Next(0, 3)];


        Console.WriteLine(carta1);
        Console.WriteLine(carta2);
        Console.WriteLine(carta3);


        if (carta1 == carta2 && carta2 == carta3)
        {
            Console.WriteLine(nome1 + " não perdeu ponto" + "\n");
            Console.WriteLine("Pontuação: " + pontuacao1);
        }
        else
        {
            pontuacao1--;


            Console.WriteLine(nome1 + " perdeu pontos" + "\n");
            Console.WriteLine("Pontuação: " + pontuacao1);
        }


        Console.WriteLine("Vez da máquina, aperte qualquer tecla para continuar.");
        Console.ReadLine();


        Random random2 = new Random();
        string carta5 = cartas[random.Next(0, 3)];
        string carta6 = cartas[random.Next(0, 3)];
        string carta7 = cartas[random.Next(0, 3)];


        Console.WriteLine(carta5);
        Console.WriteLine(carta6);
        Console.WriteLine(carta7);


        if (carta5 == carta6 && carta6 == carta7)
        {
            Console.WriteLine("Pontuação: " + pontuacao2);
            Console.WriteLine("A máquina  não perdeu ponto" + "\n");
           
        }
        else
        {
            pontuacao2--;


            Console.WriteLine("Pontuação: " + pontuacao2);
            Console.WriteLine("A máquina perdeu pontos" + "\n");
           
        }


    } while (pontuacao1 > 0 && pontuacao2 > 0);


    if (pontuacao1 == 0)
    {
        Console.WriteLine("A máquina ganhou o jogo!");
    }
    else if (pontuacao2 == 0)
    {
        Console.WriteLine(nome1 + " ganhou o jogo!");
    }




    break;




    }
   
}
}
