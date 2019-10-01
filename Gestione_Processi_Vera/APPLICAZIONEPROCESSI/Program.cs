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
            Process.Start(@"C:\Users\studenti\Source\Repos\GESTIONE_PROCESSI_Vera\Gestione_Processi_Vera\APPLICAZIONEPROCESSI\FileDiTesto.txt");
        }
    }
}
