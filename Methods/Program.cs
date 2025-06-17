namespace Methods
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int number;
            bool result = int.TryParse("ABC",out number);
            if(result) 
            Console.WriteLine(number);
            else
                Console.WriteLine("Failed");
        
        }


        static void useParams()
        {
            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2, 3));
        }

            static void UsePoints()
            {
                try
                {
                    Point point = new Point(10, 20);
                    point.Move(null);
                    Console.WriteLine("Point is set to ({0}), ({1})", point.x, point.y);

                    point.Move(100, 200);
                    Console.WriteLine("Point is set to ({0}), ({1})", point.x, point.y);
                }
                catch (Exception)
                {

                    Console.WriteLine("An unexpected error occured");
                }
            }
    }
}
