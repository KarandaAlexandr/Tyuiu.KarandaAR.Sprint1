using tyuiu.cources.programming.interfaces.Sprint1;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.KarandaAR.Sprint1.Task6.V3.Lib
{
    public class DataService : ISprint1Task6V3
    {
        public string LastLetterWord(string value)
        {
            string[] words = value.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            // Собираем последние буквы каждого слова
            string lastLetters = "";
            foreach (string word in words)
            {
                lastLetters += word[word.Length - 1];  // Берём последнюю букву каждого слова
            }

            return lastLetters;
        }
    }
}
