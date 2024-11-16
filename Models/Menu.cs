namespace StopWatch.Models
{
    public class Menu
    {
        public void Display()
        {
            while (true)
            {
                ShowOptions();
                string input = Console.ReadLine()?.ToLower();

                if (input == "0")
                {
                    Console.WriteLine("Encerrando o programa...");
                    break;
                }

                var validator = new InputValidator();
                if (validator.TryParseInput(input, out int time, out char unit))
                {
                    int totalTimeInSeconds = validator.ConvertToSeconds(time, unit);
                    var timer = new Timer();
                    timer.Start(totalTimeInSeconds);
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Pressione qualquer tecla para tentar novamente.");
                    Console.ReadKey();
                }
            }
        }
        private void ShowOptions()
        {
            Console.Clear();
            Console.WriteLine("========================================");
            Console.WriteLine(" Bem-vindo ao StopWatch! ");
            Console.WriteLine("========================================");
            Console.WriteLine("Aqui estão as opções disponíveis:");
            Console.WriteLine(" S = Segundo (Exemplo: 10s = 10 segundos)");
            Console.WriteLine(" M = Minuto (Exemplo: 1m = 1 minuto)");
            Console.WriteLine(" 0 = Sair do programa");
            Console.WriteLine("========================================");
            Console.Write("Digite o tempo que deseja contar: ");
        }
    }
}
