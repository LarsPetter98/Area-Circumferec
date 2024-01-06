namespace AreaAndCircumference
{
    class Program
    {
        static void Main()
        {
            bool showGreeting = true;

            while (true)
            {
               if(showGreeting) Console.WriteLine("Welcome to the calculator. Enter either circle, rectangel or square to start. Enter exit to exit the calculator");

                var input = Console.ReadLine();

                if (input == "exit") break;
                else if (input == "circle" || input == "rectangel" || input == "square")
                {
                    while (true)
                    {
                        if (input == "circle")
                        {
                            _ = new Circel();
                            showGreeting = true; break;
                        }
                        else if (input == "rectangel")
                        {
                            _ = new Rectangle();
                            showGreeting = true; break;

                        }
                        else if (input == "square")
                        {
                            _ = new Square();
                            showGreeting = true; break;
                        }
                        else Console.WriteLine("Please enter either circle, rectangle or square");
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Please enter either circle, rectangel or square. Enter exit to exit the calculator");
                    showGreeting = false;
                }
            }
        }    
    }
}