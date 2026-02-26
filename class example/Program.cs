namespace class_example {
    internal class Program {
        static void Main(string[] args) {
            Player playerJohn = new Player("John", 20);
            Player playerAlice = new Player("Alice", 25);
            playerJohn.SayHello();
            playerAlice.SayHello();
            Console.ReadKey();
        }

        private class Player {
            private string name = "-";
           
            internal Player(string name, int age) {
                this.name = name;
                Console.WriteLine($"Player created with name: {name}, age: {age}");
            }

            internal void SayHello() {
                Console.WriteLine($"Hello, Player {name}!");
            }        
        }
    }
}
