using System;


public class door{

    public class DogDoor {

        private bool open;
    
        public DogDoor() {

            this.open = false;

        }

        public void Open() {

            Console.WriteLine("The dog door is open.");
            this.open = true;

        }

        public void Close() {

            Console.WriteLine("The dog door is close");
            this.open = false;

        }

        public bool IsOpen() {
            return this.open;

        }
}
    public class Program {

    public static void Main(string[] args) {

            DogDoor door = new DogDoor();
            door.Open();
            door.Close();
            Console.WriteLine("Door is open? : {0}" , door.IsOpen());

         }

    }
}



