using System;
using System.Text;

namespace EditorHtml
{
    public static class Editor
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            System.Console.WriteLine("MODO EDITOR (APERTE ESC PARA FINALIZAR");
            System.Console.WriteLine("--------------------------------------");
            Start();
        }

        public static void Start()
        {
            var file = new StringBuilder();

            do
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            }while(Console.ReadKey().Key != ConsoleKey.Escape);

            Viewer.Show(file.ToString());
            Save(file);
            Menu.Show();
        }

        public static void CreateFile(string text)
        {
           
            Console.Clear();
            System.Console.WriteLine("Qual caminho para salvar o arquivo?");
            var path = Console.ReadLine();

            using(var file = new StreamWriter(path))
            {
                 file.Write(text);
            }

            System.Console.WriteLine($"Arquivo {path} salvo com sucesso! Aperte enter para continuar...");
            Console.ReadLine();
        }

        public static void Save(StringBuilder file)
        {
            System.Console.WriteLine("Deseja salvar o arquivo? [S/N]");
            string Option = Console.ReadLine().Trim().ToUpper();
            switch(Option)
                {
                    case "S": CreateFile(file.ToString());break;
                    case "N": Menu.Show();break;
                    default: Save(file);break;
                   
                }
        
        }


    }
}