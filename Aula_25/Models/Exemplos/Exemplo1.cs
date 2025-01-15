using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_25.Models.Exemplos
{
    public class Exemplo1
    {
        public static void Exe1() {
            // File é uma classe estatic que contem metodos 
            // para manipulação de arquivos
            string inicioParh = @"C:\Users\thiag\OneDrive\Área de Trabalho\Projetos\c-sharp\Aula_25\public\teste1.txt";

            string finalFile = @"C:\Users\thiag\OneDrive\Área de Trabalho\Projetos\c-sharp\Aula_25\public\teste2.txt";

            try
            {
                FileInfo fileInfo = new(inicioParh); // Cria um objeto com referencia endereco criamos do arquivo
                fileInfo.CopyTo(finalFile); // Copia do arquivo de origem para o destino

                // Mostrar o que esta escrito no arquivo do inicioParh
                string[] line = File.ReadAllLines(inicioParh);
                // foreach (string item in line) // percorre todas as linhas
                // {
                //     System.Console.WriteLine(item);
                // }
                Console.WriteLine($"{string.Join("\n", line)}");
                
            }
            catch (IOException e) // Tratamento de erro especifico para manipular arquivo
            {
                System.Console.WriteLine("Ocorreu erro");
                System.Console.WriteLine(e.Message);
            }
        }

        public static void Exe2()
        {
            string inicioParh = @"C:\Users\thiag\OneDrive\Área de Trabalho\Projetos\c-sharp\Aula_25\public\teste1.txt";

            // Isso é uma conversa com o sistema operacional
            //  Não é gerenciado pelo clr
            FileStream? fs = null;// Essa é uma classe que permite leitura e escrita de arquivos, e é uma classe de baixo nivel

            StreamReader? sr = null; // Também classe de manipução de arquivo como FileStream mas é de alto nivel


            try
            {
                fs = new FileStream(inicioParh, FileMode.Open); // Abre o arquivo

                sr = new StreamReader(fs);
                string? line = sr.ReadLine();
                System.Console.WriteLine(line);


                while (line != null)
                {
                    line = sr.ReadLine();
                    System.Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {

                System.Console.WriteLine("Ocorreu erro");
                System.Console.WriteLine(e.Message);
            }
            finally
            {
                // Eu preciso fechar o arquivvo, pois o sistema 
                // operacional não faz isso automaticamente
                sr?.Close();
                fs?.Close();
            }
        }

        public static void Exe3()
        {
            string inicioParh = @"C:\Users\thiag\OneDrive\Área de Trabalho\Projetos\c-sharp\Aula_25\public\teste1.txt";

            try
            {
                using FileStream fs = new(inicioParh, FileMode.Open);
                using StreamReader sr = new(fs);
                System.Console.WriteLine(sr.ReadToEnd().ToUpper());
            }
            catch (IOException e)
            {
                System.Console.WriteLine("Ocorreu erro");
                System.Console.WriteLine(e.Message);
            }
        }
        public static void Exe4()
        {
            string inicioParh = @"C:\Users\thiag\OneDrive\Área de Trabalho\Projetos\c-sharp\Aula_25\public\teste1.txt";

            string finalParh = @"C:\Users\thiag\OneDrive\Área de Trabalho\Projetos\c-sharp\Aula_25\public\teste2.txt";

            try
            {
                string [] lines = File.ReadAllLines(inicioParh);

                using StreamWriter sw = File.AppendText(finalParh);
                // foreach (string item in lines)
                // {
                //     sw.WriteLine(item.ToUpper()); // Escreve a linha em maiusculo
                //                                   //  Quiser em todos minisculos 
                //                                   // sw.WriteLine(item.ToLower());
                //                                   //  Se quiser inverter a ordem
                //                                   // sw.WriteLine(item.Reverse().ToArray());
                // }
                sw.Write(string.Join("\n", lines));
            }
            catch (IOException e)
            {
                
                System.Console.WriteLine("Ocorreu erro");
                System.Console.WriteLine(e.Message);
            }
        }
        public static void Exe5()
        {
            string inicioParh = @"C:\Users\thiag\OneDrive\Área de Trabalho\Projetos\c-sharp\Aula_25\public\teste1.txt";
            System.Console.WriteLine("Diretory Separator Char" + Path.DirectorySeparatorChar);
            System.Console.WriteLine("Separador de caminho: " + Path.PathSeparator);
            System.Console.WriteLine("Retorna o diretorio do arquivo: " + Path.GetDirectoryName(inicioParh));
            System.Console.WriteLine("Retorna o nome do arquivo" + Path.GetFileName(inicioParh));
            System.Console.WriteLine("Retorna o nome do arquivo sem extenção" +
               Path.GetFileNameWithoutExtension(inicioParh));
            System.Console.WriteLine("Retorna somente extenção do arquivo" + Path.GetExtension(inicioParh));


        }
    }
}