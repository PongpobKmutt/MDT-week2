class Program{

    public static void Main(string[] args) {

        Car myCar = new Car();
        myCar.brand= "toyota";
        myCar.model= "Altis";
        myCar.numberofdoors= 4;
        myCar.numberOfWheels= 4;

        Car secondCar = new Car();
        secondCar.brand= "Tesla";
        secondCar.model= "S";
        secondCar.numberofdoors= 2;
        secondCar.numberOfWheels= 4;

        PrintCarInformation(myCar);
        PrintCarInformation(secondCar);

    }
    static void PrintCarInformation(Car car){
        Console.WriteLine("******************************");
        Console.WriteLine("Brand: {0}", car.brand);
        Console.WriteLine("Model {0}", car.model);
        Console.WriteLine("Number of Doors {0}", car.numberofdoors);
        Console.WriteLine("Number of wheels {0}", car.numberOfWheels);
        Console.WriteLine(car.moveforward());
        Console.WriteLine(car.movebackward());
        Console.WriteLine(car.Turn());
        Console.WriteLine(car.stop());
        Console.WriteLine("******************************");

    }

}

public class Car {
        
        public string brand;
        public string model;
        public int numberofdoors;
        public int numberOfWheels;

        public string moveforward() {
            return "MoveForward";
        }
        public string movebackward() {
            return "Movebackward";
        }
        public string stop() {
            return "Stop";
        }
        public string Turn() {
            return "Turn";
        }





    }

