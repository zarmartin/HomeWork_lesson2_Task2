namespace Task2
{
    class Program
    {
        static public void Main()
        {
            int i = 1, n = -20, summ;
            
            do
            {
                summ = i * n;
                Console.WriteLine(Environment.NewLine+ summ);
                i++;
            }
            while (i <= 5);
          
        }
    }   

}