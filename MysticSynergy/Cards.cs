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
        CreatureCard knight = new CreatureCard("Cavalheiro", 3, 2, 3);
        SpellCard cure = new SpellCard("Cura", 2, "Aumenta 2 pontos de vida do jogador");
        SpellCard fireball = new SpellCard("Bola de fogo", 3, "Causa 4 de dano a qualquer alvo");
        ArtifactCard bladeJustice = new ArtifactCard("Espada da Justiça",3, "A criatura equipada ganha +2 ATK");
        ArtifactCard shieldMana = new ArtifactCard("Escudo de mana", 2, "A criatura equipada ganha proteção contra feitiços");


    }
