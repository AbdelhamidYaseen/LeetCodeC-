namespace LeetCodeCSharp
{
    internal class Program
    {
        static void Wait() 
        {
            Console.WriteLine("=========================");
            Console.WriteLine("Press -ENTER- To Continue");
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            string selected;
            bool flick = true;
            do
            {
                Console.Clear();
                Console.WriteLine("======================================================");
                Console.WriteLine("Please select a excercise");
                Console.WriteLine("======================================================");
                Console.WriteLine(
                    "01| Exercise 1: \n" +
                    "02| Exercise 2: \n" +
                    "03| Exercise 3: \n" +
                    "04| Exercise 4: \n" +
                    "05| Exercise 5: \n" +
                    "06| Exercise 6: \n" +
                    "07| Exercise 7: \n" +
                    "08| Exercise 8: \n" +
                    "09| Exercise 9: \n" +
                    "10| Exercise 10: \n" +
                    "11| Exercise 11: \n" +

                    "END| END-PROGRAM"
                    );
                Console.WriteLine("======================================================");
                selected = Console.ReadLine();
                Console.WriteLine("======================================================");
                if (selected == "01")       { Console.Clear(); Exercises.Exc1(); Wait(); }
                else if (selected == "02")  { Console.Clear(); }
                else if (selected == "03")  { Console.Clear(); }
                else if (selected == "04")  { Console.Clear(); }
                else if (selected == "05")  { Console.Clear(); }
                else if (selected == "06")  { Console.Clear(); }
                else if (selected == "07")  { Console.Clear(); }
                else if (selected == "08")  { Console.Clear(); }
                else if (selected == "09")  { Console.Clear(); }
                else if (selected == "10")  { Console.Clear(); }
                else if (selected == "11")  { Console.Clear(); }
                else if (selected == "12")  { Console.Clear(); }
                else if (selected == "13")  { Console.Clear(); }
                else if (selected == "14")  { Console.Clear(); }
                else if (selected == "15")  { Console.Clear(); }
                else if (selected == "16")  { Console.Clear(); }
                else if (selected == "17")  { Console.Clear(); }
                else if (selected == "18")  { Console.Clear(); }
                else if (selected == "19")  { Console.Clear(); }
                else if (selected == "20")  { Console.Clear(); }
                else if (selected == "21")  { Console.Clear(); }
                else if (selected == "22")  { Console.Clear(); }
                else if (selected == "23")  { Console.Clear(); }
                else if (selected == "24")  { Console.Clear(); }
                else if (selected == "25")  { Console.Clear(); }

                else if (selected == "END") { Console.Clear(); flick = false; }
                else { Console.WriteLine("Please select a correct input"); }
            }
            while (flick);
        }
    }
}