using System;

internal class Program
{
    static void Main(string[] args)
    {
        uint colsAmount = 3;
        uint pictureAmount = 52;
        uint fullRows;
        uint picturesHidden;

        fullRows = pictureAmount / colsAmount;
        picturesHidden = pictureAmount % colsAmount;
        Console.WriteLine($"Заполнено рядов - {fullRows}");
        Console.WriteLine($"Не показано картинок - {picturesHidden}");
    }
}
