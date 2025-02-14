using Composite;
using Decortor;
using EnemyFactoryDP;
using Strategy;

namespace DP
{
    public class Program
    {
        public static void Main(string[] args)
        {

            // ============= Factory Design Pattern ========================
            EnemyFactory enemyFactory = new EnemyFactory();

            Enemy test = enemyFactory.FromEnvironmentAndLevel(EnvironmentType.Mountain, 23);

            // More example to create cars

            //  ====== Composite Design Pattern =========

            // Creating the task breakfast 
            TaskComposite makeBreakfast = new TaskComposite("Make a breakfast");

            // Creating small tasks for "Breakfast Task"
            TaskLeaf makecoffee = new TaskLeaf("Making a nice coffee");
            TaskLeaf makeToast =  new TaskLeaf("Making a toast with butter");

            // Adding new tasks to the  "breakfast Task"  
            makeBreakfast.AddTask(makecoffee);
            makeBreakfast.AddTask(makeToast);
            
            // Creating a new Task  
            TaskComposite hygiene =  new TaskComposite("Morning hygiene");

            // Creating small tasks for "hygiene task"
            TaskLeaf brushteeth= new TaskLeaf("Brushing teeth");
            TaskLeaf washFace =  new TaskLeaf("Washing Face");

            // Adding task to "Hygiene task"
            hygiene.AddTask(brushteeth);
            hygiene.AddTask(washFace);;


            // Creating the morning routine. This taks involve hygiene and makeBreakfast
            TaskComposite morningRoutine = new TaskComposite("My morning routine");

            // add tasks
            morningRoutine.AddTask(hygiene);
            morningRoutine.AddTask(makeBreakfast);


            morningRoutine.Do();


           // ===== Strategy Design Pattern ========

           // Creating a pond duck
           
            PondDuck duck1 = new PondDuck();
            duck1.PerfomrQuacks();
            duck1.PerformSwim();
            duck1.PerformFly();

           // Creating a river duck

            RiverDuck duck2 = new RiverDuck();
            duck2.PerfomrQuacks();
            duck2.PerformSwim();
            duck2.PerformFly();


           // Creating a rubber duck
            RubberDuck duck3 = new RubberDuck();
            duck3.PerfomrQuacks();
            duck3.PerformSwim();
            duck3.PerformFly();




            // Decorator

            Coffee coffee = new Coffee();
            Console.WriteLine($"Cost of coffee: {coffee.Cost()}");

            DailyMilk dailyMilk = new DailyMilk();

            dailyMilk.AddPreviousBeverage(coffee);
            Console.WriteLine($"Cost of Latte: {dailyMilk.Cost()}");

            SoyMilk soyMilk = new SoyMilk();
            soyMilk.AddPreviousBeverage(coffee);
            Console.WriteLine($"Cost of coffe with soy milk: {soyMilk.Cost()}");

            Cream cream = new Cream();
            cream.AddPreviousBeverage(dailyMilk);
            Console.WriteLine($"Cost of latte with cream: {cream.Cost()}");






        }
    }
}