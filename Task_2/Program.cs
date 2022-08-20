using static System.Console;
class Program
{
    /// <summary>
    /// разделение строки на слова с помощью встроенной библиотеки и функции string.Split()
    /// </summary>
    /// <param name="Text"></param>
    /// <returns></returns>
    static string[] Split(string Text)
    {
        return Text.Split(new char[] { ' ' });

    }
    /// <summary>
    /// размещение слов в обратном порядке
    /// </summary>
    /// <param name="Phrase"></param>
    static void ReversPhrase(string Phrase)
    {
        var splitedPhrase=Split(Phrase);
        //foreach (var word in splitedPhrase)
        //    WriteLine(word);
        string reversPhrase="";
        for (int i = splitedPhrase.Length-1; i >=0; i--)
        {
            reversPhrase += splitedPhrase[i]+" ";
        }
        Write($"{reversPhrase}");
    }
    /// <summary>
    /// основная функция
    /// </summary>
    static void Main()
    {
        string Text = ReadLine();
        ReversPhrase(Text);
    }
}