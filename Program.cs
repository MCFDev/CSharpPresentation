//school presentation
using static System.Console;
using Figgle;
using System.Drawing;


namespace helllooo
{
    class sex
    {
        static void Main(string[] args)
        {
                    //setting up figgle and console settngs
            using var fontStream = System.IO.File.OpenRead("cosmike.flf");
            var font = FiggleFontParser.Parse(fontStream);
            Console.Title = "Aula de ICORI CEF 2 - 1ºA";
            var text = font.Render("Bom Dia");
            Console.WriteLine(text, ColorTranslator.FromHtml("#8AFFEF"));
        }
    }
}
