using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Bem-vindo ao Jogo de Cartas!");

        bool startGame = true;
        MysticSynergyGame myGame = new MysticSynergyGame();

        while (startGame)
        {
            Console.WriteLine("\nEscolha uma opção:");
            Console.WriteLine("1. Iniciar Batalha");
            Console.WriteLine("2. Gerenciar Deck");
            Console.WriteLine("3. Sair do jogo");

            string choiceStart = Console.ReadLine();

            switch (choiceStart)
            {
                case "1":
                    myGame.Play();
                    break;
                case "2":
                    myGame.ManageDeck();
                    break;
                default:
                    startGame = false;
                    break;
            }
        }



        Console.WriteLine("Obrigado por jogar!");
    }
}