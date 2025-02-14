// bejaviour interfaces


namespace Strategy{

    // Swim Behaviour
    public interface ISwimBehaviour
    {
        public void Swim();
    }

    public class StraightLineSwimming :ISwimBehaviour
    {
        public void Swim()
        {
            Console.WriteLine("This duck has swam in a straight line");
        }
    }

    public class CircleSwimming :ISwimBehaviour
    {
        public void Swim()
        {
            Console.WriteLine("This duck has swam in a circle");
        }
    }


    // Quack Behaviour
    public interface IQuackBehaviour
    {
        public void Quack();
    }

    public class LoudQuack : IQuackBehaviour
    {
        public void Quack(){
            Console.WriteLine("Quack Quack");
        }
    }
   
    public class QuietQuack : IQuackBehaviour
    {
        public void Quack(){
            Console.WriteLine("quack quack");
        }
    }

    public class Squeak : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("Squeak");
        }
    }

    public class MuteQuack : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("<< Silence >>");
        }
    }


    // Fly Behaviour

    public interface IFlyBehaviour
    {
        public void Fly();
    }    

    public class FlyWithWings : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I am flying");
        }
    }

    public class FlyNoWay : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly");
        }
    }


    // Class Duck
    public class Duck
    {
        IQuackBehaviour quackCapability;
        ISwimBehaviour swimCapability;
        IFlyBehaviour flyCapability;

        public Duck(IQuackBehaviour quackBehaviour, ISwimBehaviour swimBehaviour, IFlyBehaviour flyBehaviour){ 
            this.quackCapability = quackBehaviour;
            this.swimCapability = swimBehaviour;
            this.flyCapability = flyBehaviour;
        }

        public void PerfomrQuacks()
        {
            quackCapability.Quack();
        }

        public void PerformSwim()
        {
            swimCapability.Swim();
        }

        public void PerformFly()
        {
            flyCapability.Fly();
        }

    }

    // Implement different ducks classes

    public class PondDuck : Duck
    {
        public PondDuck() : base(new LoudQuack(), new CircleSwimming(), new FlyWithWings())
        { }
    }

    public class RiverDuck : Duck
    {
        public RiverDuck() : base(new QuietQuack(), new StraightLineSwimming(), new FlyWithWings())
        { }
    }

    public class RubberDuck : Duck{
        public RubberDuck() : base(new Squeak(), new CircleSwimming(), new FlyNoWay())
        { }
    }
   
}