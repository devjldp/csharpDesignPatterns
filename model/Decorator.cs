
namespace Decortor
{
    public interface IBeverage
    {
        public double Cost();
        public void AddPreviousBeverage(IBeverage previousBeverage);
    }


    public class Coffee : IBeverage
    {
        IBeverage previousBeverage;
        public double Cost(){
            if (previousBeverage == null)
            {
                return 2;
            }
            return 2 + previousBeverage.Cost();
        }

        public void AddPreviousBeverage(IBeverage wrapBeverage){
            previousBeverage = wrapBeverage;
        }

    }

    public class SoyMilk : IBeverage
    {
        IBeverage previousBeverage;
        public double Cost(){
            if (previousBeverage == null)
            {
                return 5;
            }
            return 5 + previousBeverage.Cost();
        }

        public void AddPreviousBeverage(IBeverage wrapBeverage){
            previousBeverage = wrapBeverage;
        }
    }

        public class DailyMilk : IBeverage
    {
        IBeverage previousBeverage;
        public double Cost(){
            if (previousBeverage == null)
            {
                return 3;
            }
            return 3 + previousBeverage.Cost();
        }

        public void AddPreviousBeverage(IBeverage wrapBeverage){
            previousBeverage = wrapBeverage;
        }
    }


        public class Cream : IBeverage
    {
        IBeverage previousBeverage;
        public double Cost(){
            if (previousBeverage == null)
            {
                return 1.5;
            }
            return 1.5 + previousBeverage.Cost();
        }

        public void AddPreviousBeverage(IBeverage wrapBeverage){
            previousBeverage = wrapBeverage;
        }
    }

}