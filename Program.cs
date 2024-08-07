namespace test
{
    class Program
    {
        static void Main()
        {
            Random rand = new Random();
            int specifiedNumber = rand.Next(0, 100);
            int initialNumber = 2, degreeMultiplier = 2;
            int targetMultiplier = 1;
            int targetNumber = initialNumber * targetMultiplier;

            while (targetNumber <= specifiedNumber)
            {
                targetMultiplier++;
                targetNumber *= degreeMultiplier;
            }

            Console.WriteLine("искомое число в степени " + (targetNumber) + " это 2 в степени " + targetMultiplier + ".");
            Console.WriteLine("заданное число " + specifiedNumber + ".");
        }
    }
}
