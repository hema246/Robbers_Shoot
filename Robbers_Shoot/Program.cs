namespace Robbers_shoot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number of Robbers:");
            int Total_Rob = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the robber with whom Sam will start shooting");
            int Rob_num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the gap between the robbers");
            int Gap = Convert.ToInt32(Console.ReadLine());

            int[] robbers = new int[Total_Rob];
            int CurrentIndex = Rob_num - 1;
            int ShotsCompleted = 0;

            for (int i = 0; i < Total_Rob; i++)
            {
                robbers[i] = i + 1;
            }

            while (Total_Rob != 0)
            {
                if (CurrentIndex >= Total_Rob)
                {
                    CurrentIndex = CurrentIndex % Total_Rob;
                }
                Console.WriteLine($"Target = {robbers[CurrentIndex]} , {++ShotsCompleted} shots completed");

                for (int i = CurrentIndex; i < Total_Rob - 1; i++)
                {
                    robbers[i] = robbers[i + 1];
                }

                Total_Rob--;
                CurrentIndex = CurrentIndex + Gap;
            }
            Console.WriteLine(ShotsCompleted + " shots taken");
        }

    }
}