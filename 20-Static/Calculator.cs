namespace _20_Static
{
    public static class Calculator
    {
        private static int _resultStorage = 0;

        public static string Type = "Arithmetic";

        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public static void Store(int resultado)
        {
            _resultStorage = resultado;
        }
    }
}
