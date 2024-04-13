namespace _20_Static
{
    public class StopWatch
    {
        public static int NoOfInstances = 0;

        // Constructor
        public StopWatch()
        {
            StopWatch.NoOfInstances++;
        }
    }
}
