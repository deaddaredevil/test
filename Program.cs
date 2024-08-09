namespace test
{
    class Program
    {
        static void Main()
        {
            Random randomNumber = new Random();
            int specifiedNumber = randomNumber.Next(0, 100);
            int initialNumber = 2;
            int degreeMultiplier = 2;
            int targetMultiplier = 1;
            int targetNumber = 1;

            while (targetNumber <= specifiedNumber)
            {
                targetMultiplier++;
                targetNumber *= degreeMultiplier;
            }

            Console.WriteLine("искомое число в степени " + (targetNumber) + " это " + (initialNumber) + " в степени " + targetMultiplier + ".");
            Console.WriteLine("заданное число " + specifiedNumber + ".");
        }
    }
}
