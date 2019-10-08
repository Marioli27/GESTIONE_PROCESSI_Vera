using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPLICAZIONEPROCESSI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Esercitazione sulla gestione dei progetti");
            Process.Start("Notepad.exe");
            Process.Start("Notepad.exe",@"C:\Users\studenti\Source\Repos\GESTIONE_PROCESSI_Vera\Gestione_Processi_Vera\APPLICAZIONEPROCESSI\FileDiTesto.txt");
            Process.Start("Chrome.exe",@"www.snake.it");
            var app = new Process();
            app.StartInfo.FileName = @"Notepad.exe";
            app.StartInfo.Arguments = @"C:\Users\studenti\Source\Repos\GESTIONE_PROCESSI_Vera\Gestione_Processi_Vera\APPLICAZIONEPROCESSI\FileDiTesto.txt";
            app.Start();
            app.PriorityClass = ProcessPriorityClass.RealTime;
            app.WaitForExit();
            Console.WriteLine("Programma terminato");
            Console.ReadLine();
        }
    }
}
