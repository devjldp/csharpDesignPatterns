namespace State
{
    public enum BowState{
        Reloading,
        Aiming,
        Shooting,
    }


    public class Goblin {
        public BowState currentState = BowState.Reloading;

        public void Attack(){
            switch(currentState){
                case BowState.Reloading:
                    Console.WriteLine("Goblin has knotched an arrow");
                    currentState = BowState.Aiming;
                    break;
                case BowState.Aiming:
                    Console.WriteLine("Goblin has aimed an enemy");
                    currentState = BowState.Shooting;
                    break;
                case BowState.Shooting:
                    Console.WriteLine("Goblin has released the arrow");
                    currentState = BowState.Reloading;
                    break;
            }
        }

        public void LoseSightOfTarget()
        {
            currentState = BowState.Aiming;
        }

        public void ChangeState(BowState newState)
        {
            currentState =  newState;
        }
    }
}