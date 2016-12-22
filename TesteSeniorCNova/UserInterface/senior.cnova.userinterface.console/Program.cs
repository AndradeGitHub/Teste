using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using senior.cnova.application;
using senior.cnova.domain.model;

namespace senior.cnova.userinterface.console
{
    class Program
    {                
        static void Main(string[] args)
        {
            AmigoFacade amigoFacade = new AmigoFacade();
                    
            try
            {
                Console.WriteLine("Informe a sua localidade atual.");
                Console.WriteLine("Qual a sua Latitude?:");
                string latitudeDig = Console.ReadLine();
                Console.WriteLine("Qual a sua Longitude?:");
                string longitudeDig = Console.ReadLine();

                for (int i = 0; i < 100; i++)
                {
                    double num = 0;
                    bool isLatNum = Double.TryParse(latitudeDig, out num);
                    bool isLongNum = Double.TryParse(longitudeDig, out num);

                    if (isLatNum && isLongNum) break;

                    if (!isLatNum)
                    {
                        Console.WriteLine("Latitude inválida. Informe corretamente a sua Latitude?:");
                        latitudeDig = Console.ReadLine();
                    }

                    if (!isLongNum)
                    {
                        Console.WriteLine("Longitude inválida. Informe corretamente a sua Longitude?:");
                        longitudeDig = Console.ReadLine();
                    }
                }

                Console.WriteLine(string.Empty);
                Console.WriteLine("# INICIO DO PROCESSAMENTO");                
                Console.WriteLine("******************************************************************************");                
                Console.WriteLine("******************************************************************************");

                Console.WriteLine(string.Empty);
                Console.WriteLine("# INÍCIO - BUSCANDO AMIGOS PRÓXIMOS");                                
                var lstAmigo = amigoFacade.RetornaAmigoProximos(Convert.ToDouble(latitudeDig.Replace(".",",")), Convert.ToDouble(longitudeDig.Replace(".", ",")));                

                Console.WriteLine(string.Empty);
                Console.WriteLine("Os 3 amigos mais próximos são:");
                Console.WriteLine(string.Empty);

                foreach (Amigo amigo in lstAmigo)
                {
                    Console.WriteLine(string.Concat("NOME: ", amigo.Nome));
                    Console.WriteLine(string.Concat("CIDADE: ", amigo.Cidade));
                    Console.WriteLine(string.Concat("ESTADO: ", amigo.Estado));
                    Console.WriteLine(string.Concat("LATITUDE: ", amigo.Latitude));
                    Console.WriteLine(string.Concat("LONGITUDE: ", amigo.Longitude));                    
                    Console.WriteLine(string.Concat("DISTANCIA: ", amigo.Distancia.ToString("N2"), (amigo.Distancia.ToString().Substring(0, 1) == "0" ? " m" : " km")));
                    
                    Console.WriteLine(string.Empty);
                }

                Console.WriteLine("# FIM - BUSCANDO AMIGOS PRÓXIMOS");
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Empty);
                Console.WriteLine(string.Concat("# ERRO - ", ex));
            }
            finally
            {
                Console.WriteLine(string.Empty);
                Console.WriteLine("******************************************************************************");
                Console.WriteLine("******************************************************************************");
                Console.WriteLine("# FIM DO PROCESSAMENTO");
                Console.Read();
            }
        }
    }
}
