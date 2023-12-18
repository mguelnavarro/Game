using System;

public class Cards
{
    public class Card
    {
        public string Name;
        public int ManaCost;

        public Card(string name, int manaCost)
        {
            Name = name;
            ManaCost = manaCost;
        }
    }

    public class CreatureCard : Card
    {
        public int Attack;
        public int Defense;

        public CreatureCard(string name, int manaCost, int attack, int defense)
            : base(name, manaCost)
        {
            Attack = attack;
            Defense = defense;
        }
    }

    public class SpellCard : Card
    {
        public string Effect;

        public SpellCard(string name, int manaCost, string effect)
            : base(name, manaCost)
        {
            Effect = effect;
        }
    }

    public class ArtifactCard : Card
    {
        public string Ability;

        public ArtifactCard(string name, int manaCost, string ability)
            : base(name, manaCost)
        {
            Ability = ability;
        }
    }
    public void CreateCards()
    {
        CreatureCard dragon = new CreatureCard("Dragon", 6, 5, 4);
        CreatureCard knight = new CreatureCard("Cavalheiro",);
        SpellCard lightning = new SpellCard();
        SpellCard fireball = new SpellCard();



    }
}
