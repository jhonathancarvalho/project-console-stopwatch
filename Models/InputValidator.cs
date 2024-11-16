namespace StopWatch.Models
{
    public class InputValidator
    {
        public bool TryParseInput(string input, out int time, out char unit)
        {
            time = 0;
            unit = ' ';

            if (string.IsNullOrWhiteSpace(input) || input.Length < 2)
                return false;

            unit = input[^1];
            string timePart = input.Substring(0, input.Length - 1);

            return int.TryParse(timePart, out time) && (unit == 's' || unit == 'm');
        }

        public int ConvertToSeconds(int time, char unit)
        {
            return unit == 'm' ? time * 60 : time;
        }
    }
}
