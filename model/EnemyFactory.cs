using System;

namespace EnemyFactoryDP{
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

            return new Enemy(name,attackDamage,weakness);
        }

    }

    public class Enemy
    {

        // Here we are using fields and no properties.
        private string name;
        private int attackDamage;
        private string weakness;

        // constructor
        public Enemy(string name, int attackDamage, string weakness)
        {
            this.name = name;
            this.attackDamage = attackDamage;
            this.weakness = weakness;
            Console.WriteLine($"Enemy {this.name} created. Weakness: {this.weakness} - AttackDamage: {this.attackDamage}");
        }

    }





}

