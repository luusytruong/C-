namespace review_test
{
    abstract class Appliance{
        public abstract void TurnOn();
        public abstract void TurnOff();
    }
    class WashingMachine : Appliance{
        public override void TurnOn(){
            Console.WriteLine($"may giat da bat");
        }
        public override void TurnOff(){
            Console.WriteLine($"may giat da tat");
        }
    }
    class Refrigerator : Appliance{
        public override void TurnOn(){
            Console.WriteLine($"tu lanh da bat");
        }
        public override void TurnOff(){
            Console.WriteLine($"tu lanh da tat");
        }
    }
}