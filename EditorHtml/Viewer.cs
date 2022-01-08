using System;
using System.Text.RegularExpressions;

namespace EditorHtml
{
    public class Viewer
    {
        public static void Show(string text)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            System.Console.WriteLine("MODO VISUALIZAÇÃO Aperte ESC PARA FINALIZAR");
            System.Console.WriteLine("-------------------------------------------");
            Replace(text);
            System.Console.WriteLine("-------------------------------------------");
        }

        public static void Replace(string text)
        {

            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
            var words = text.Split(' ');

            for(var i = 0; i< words.Length; i++)
            {
                if(strong.IsMatch(words[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(words[i].Substring(
                        words[i].IndexOf('>') + 1,
                        ((words[i].LastIndexOf('<') - 1) - words[i].IndexOf('>'))
                    )
                    );
                    Console.Write(" ");

                }else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(words[i]);
                    Console.Write(" ");
                }
            }
        }
        public static void OpenFile()
        {
            Console.Clear();
            System.Console.WriteLine("Qual caminho do arquivo?");
            string path = Console.ReadLine();

            using(var file = new StreamReader(path))
            {
                string text = file.ReadToEnd();
                System.Console.WriteLine(text);
            }

            System.Console.WriteLine("Aperte qualquer tecla para voltar para o menu");
            Console.ReadLine();
            Menu.Show();  
        }

    }
}