using System;
public class MysticSynergyGame
{
    private Deck deck = new Deck();

    public void ManageDeck()
    {
        bool managingDeck = true;
        while (managingDeck)
        {
            Console.WriteLine("\nGerenciamento de Deck:");
            Console.WriteLine("1. Adicionar carta ao deck");
            Console.WriteLine("2. Remover carta do deck");
            Console.WriteLine("3. Visualizar deck");
            Console.WriteLine("4. Voltar");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    AddCardToDeck();
                    break;
                case "2":
                    RemoveCardFromDeck();
                    break;
                case "3":
                    deck.Display();
                    break;
                case "4":
                    managingDeck = false;
                    break;
            }
        }
    }

    private void AddCardToDeck()
    {
        // Implementar lógica para adicionar uma carta ao deck
        // Exemplo: Solicitar ao usuário o nome da carta e adicioná-la ao deck
    }

    private void RemoveCardFromDeck()
    {
        // Implementar lógica para remover uma carta do deck
        // Exemplo: Solicitar ao usuário o nome da carta e removê-la do deck
    }

    // Outros métodos...
    
}