namespace LearnAsync
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Main method started");

            // Memanggil metode asinkron
            await PerformTaskAsync();

            Console.WriteLine("Main method completed");
        }

        static async Task PerformTaskAsync()
        {
            Console.WriteLine("Performing a long-running task...");
            await Task.Delay(2000); // Menunggu selama 2 detik (simulasi tugas asinkron)

            Console.WriteLine("Task completed");
        }
        
    }
}