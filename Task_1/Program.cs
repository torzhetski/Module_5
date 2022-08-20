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
        return Text.Split( ' ' );

    }
    /// <summary>
    /// разделение строки на слова без использования библиотек и функции string.Split()
    /// </summary>
    /// <param name="Text"></param>
    /// <returns></returns>
    static string[] SplitingWitoutSplitMethod(string Text)
    {
        int key = 1;
        foreach (char e in Text)
            if (e == ' ') key++;
        string[] text= new string[key];
        key = 0;
        for(int i = 0; i < Text.Length;i++)
        {
            if (Text[i] == ' ') key++;
            else text[key] += Convert.ToString(Text[i]);
        }
        return text;
    }
    /// <summary>
    /// вывод на экран по содному слову
    /// </summary>
    /// <param name="Text"></param>
    static void Print(string[] Text)
    {
        foreach (var e in Text)
            WriteLine(e);
    }
    /// <summary>
    /// основная функция
    /// </summary>
    static void Main()
    {
        string text = ReadLine();
        var splitedText = Split(text);
        Print(splitedText);
        ReadKey(); WriteLine();
        splitedText = SplitingWitoutSplitMethod(text);
        Print(splitedText);
    }
}