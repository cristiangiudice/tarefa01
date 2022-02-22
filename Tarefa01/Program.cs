using System;
using System.Threading.Tasks;
using Tarefa01.Soap;

namespace Tarefa01
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            SOAPDemoSoapClient soapClient = new SOAPDemoSoapClient();

            var response = await soapClient.AddIntegerAsync(15,25);

            Console.WriteLine(response);

            var person = await soapClient.FindPersonAsync("1");

            Console.WriteLine(person.Name);

            var divide = await soapClient.DivideIntegerAsync(100,10);

            Console.WriteLine(divide);

        }
    }
}
