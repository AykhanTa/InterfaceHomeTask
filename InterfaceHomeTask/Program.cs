namespace InterfaceHomeTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Square square = new(5);
            //square.CalcArea();

            Rectangle rectangle = new(5, 10);
            //rectangle.CalcArea();

            Console.WriteLine("1.Square");
            Console.WriteLine("2.Rectangle");
            Console.WriteLine("0.Quit");

            

            while (true)
            {
            TakeCommand:
                bool result = int.TryParse(Console.ReadLine(), out int command);

                if (!result)
                {
                    Console.WriteLine("Duzgun formatda command daxil edin:");
                    goto TakeCommand;

                }
                if (command > 0 && command < 3)
                {
                    switch (command)
                    {
                        case 1:
                            square.CalcArea();
                            break;
                        case 2:
                            rectangle.CalcArea();
                            break;
                    }
                }
                else if (command == 0)
                {
                    break;
                }

            }
            
     
        }
    }
}