using System;

internal class Program
{
    static void Main(string[] args)
    {
        uint colsAmount = 3;
        uint picturesAmount = 52;
        uint filledPicturesRows;
        uint picturesHidden;

        filledPicturesRows = picturesAmount / colsAmount;
        picturesHidden = picturesAmount % colsAmount;
        Console.WriteLine($"Заполнено рядов - {filledPicturesRows}");
        Console.WriteLine($"Не показано картинок - {picturesHidden}");
    }
}
