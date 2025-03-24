using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace pooBiblioteca.contentContext
{
    public static class AcervoBiblioteca
    {

        
        
        
        
        private static JsonSerializerOptions _options = new JsonSerializerOptions
        {
            WriteIndented = true,
            Converters = { new JsonStringEnumConverter(JsonNamingPolicy.CamelCase) }
        };
        private static string GetProjectDirectory()
        {
            DirectoryInfo dir = new DirectoryInfo(AppContext.BaseDirectory);
            return dir.Parent.Parent.Parent.FullName;
        }
        
        private static string filePath = Path.Combine(GetProjectDirectory(), "acervo.json");
        
        //Salva o acervo em um arquivo JSON, serializando com informações de tipo
        public static void SalvarAcervo(List<ItemBiblioteca> items)
        {
            try
            {
                string json = JsonSerializer.Serialize(items, _options);

                // Garante que o diretório onde o arquivo será salvo exista
                string directory = Path.GetDirectoryName(filePath);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                File.WriteAllText(filePath, json);
                Console.WriteLine($"Acervo salvo com sucesso em: {filePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao salvar o acervo: " + ex.Message);
            }
        }
        //listar os itens do arcevo
        public static List<ItemBiblioteca> ListarAcervo()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<List<ItemBiblioteca>>(json, _options);
                
            }
            else
            {
                return new List<ItemBiblioteca>();
            }
        }
    }
}