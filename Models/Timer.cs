namespace StopWatch.Models
{
    public class Timer
    {
        public void Start(int totalTimeInSeconds)
        {
            PreStart();

            int currentTime = 0;
            while (currentTime < totalTimeInSeconds)
            {
                currentTime++;
                Console.Clear();
                Console.WriteLine($"Tempo decorrido: {currentTime}s");
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Cronômetro finalizado!");
            Thread.Sleep(1500);
        }

        private void PreStart()
        {
            Console.Clear();
            Console.WriteLine("Preparando o cronômetro...");
            Thread.Sleep(1000);
            Console.WriteLine("Iniciando...");
            Thread.Sleep(1000);
        }
    }
}