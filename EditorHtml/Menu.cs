using System;

namespace EditorHtml
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

            DrawScreen();
            WriteOptions();

            var option = short.Parse(Console.ReadLine());

            HandleMenuOption(option);
        }

        public static void DrawScreen()
        {
            lines();

            row();

            lines();
        }

        public static void lines()
        {
            System.Console.Write("+");
            for(int i = 0; i <= 30; i++)
               System.Console.Write("-"); 
            
             System.Console.Write("+");
             System.Console.Write("\n");
        }

        public static void row()

        {
           for(int line = 0; line <= 15; line++)
              {
                System.Console.Write("|");

                 for(int j = 0; j <= 30; j++)
                      System.Console.Write(" "); 
                
                System.Console.Write("|");

                System.Console.Write("\n");
              } 
        }

        public static void WriteOptions()
        {
            Console.SetCursorPosition(3,1);
            System.Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3,2);
            System.Console.WriteLine("============");
            Console.SetCursorPosition(3,3);
            System.Console.WriteLine("Selecione uma opção abaixo");
            Console.SetCursorPosition(3,5);
            System.Console.WriteLine("1 - Novo arquivo");
            Console.SetCursorPosition(3,6);
            System.Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(3,7);
            System.Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3,8);
            System.Console.Write("Opção: ");
        }

        public static void HandleMenuOption(short option)
        {
            switch(option)
            {
                case 1: Editor.Show();break;
                case 2: Viewer.OpenFile();break;
                case 0: 
                    {
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                    }
                default: Show();break;
            }

        }


    }
}