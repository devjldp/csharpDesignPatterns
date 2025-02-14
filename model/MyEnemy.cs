using System;
/*
namespace EnemyFactoryDPI{
    public enum EnvironmentType
    {
        Forest,
        Mountain,
        Ocean,
    }

    // Factory pattern
    // Give an input and the factory returns an object
    public class EnemyFactory{

        // Function to create an enemy using the environment and its level
        public Enemy FromEnvironmentAndLevel(EnvironmentType environmentType, int playerLevel)
        {
            
            string name = "";
            string weakness = "";
            switch (environmentType)
            {
                case EnvironmentType.Forest:
                    name = "Gnome";
                    weakness = "Fire";
                    break;
                case EnvironmentType.Mountain:
                    name = "Goat";
                    weakness = "Fire";
                    break;
                case EnvironmentType.Ocean:
                    name = "Gnome";
                    weakness = "Spear";
                    break;
            }

            int attackDamage = 0;
            
            if (playerLevel > 5)
            {
                attackDamage = 5;
            }
            
            if(playerLevel > 10)
            {
                attackDamage = 7;
            }


            /*
            Another way to do the same before.
            if(playerLevel > 10)
            {
                attackDamage = 7;
            }
            else if(playerLevel > 5)
            {
                attackDamage = 5;
            }
              


            */
/*
            return new Enemy(name,attackDamage,weakness);
        }

    }

    public abstract class Enemy
    {

        // Here we are using fields and no properties.
        private string Name {get; set;}
        private int AttackDamage {get; set;}
        private string Weakness {get; set;}

        // constructor
        public Enemy(string name, int attackDamage, string weakness)
        {
            Name = name;
            AttackDamage = attackDamage;
            Weakness = weakness;
            Console.WriteLine($"Enemy {this.name} created. Weakness: {this.weakness} - AttackDamage: {this.attackDamage}");
        }

        public int Attcak(){
            return AttackDamage;
        }
    }

    public class Bandit : Enemy
    {
        public Bandit() :base("Bandit", 15, "Low Magic Resistance" ){}    
    }





}

*/