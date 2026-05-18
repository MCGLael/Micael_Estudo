using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CursoCS.Api
{
    public static class ExtesaoString{
    public static string ParseHome(this string path)
        {
            string home = (Environment.OSVersion.Platform == PlatformID.Unix || Environment.OSVersion.Platform == PlatformID.MacOSX)//Verifica qual o Sistema Operacional
                ? Environment.GetEnvironmentVariable("HOME") : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");// "?" = "Se" for Linux ou MACOS substitui ~ por HOME, se for Windows então por %HOMEDRIVE%HOMEPATH%
            return path.Replace("~", home);
        }
}
    class PrimeiroArquivo
    {
        public static void Executar()
        {
            var path = @"~/primeiro_arquivo.txt".ParseHome(); //Vai tentar criar um arquivo

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Esse é");
                    sw.WriteLine("Meu");
                    sw.WriteLine("Primeiro arquivo");
                    sw.WriteLine(@"\o/");
                }
            }
        }
    }
}
