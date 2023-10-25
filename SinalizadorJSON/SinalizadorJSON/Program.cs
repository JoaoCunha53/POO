using System.Text.Json;

namespace SinalizadorJSON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> records = new List<Pessoa>();

            //add objetos à lista 
            records.Add(new Pessoa("José", 28));
            records.Add(new Pessoa("Maria", 30));

            //Serialização para JSON
            string json = JsonSerializer.Serialize(records);

            File.WriteAllText("data.json",json);

            //Desserialização de JSON
            string loadedJson = File.ReadAllText("data.json");
            var loadedRecords = JsonSerializer.Deserialize<List<Pessoa>>(loadedJson);

            foreach (var record in loadedRecords) 
            {
                Console.WriteLine($"Name:{record.Nome} - Age: {record.Idade} ");
            }



        }
    }
}