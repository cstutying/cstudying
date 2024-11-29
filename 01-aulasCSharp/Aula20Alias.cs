// ALIAS É UM APELIDO QUE TODO TIPO NO .NET TEM
// POR EXEMPLO
// SYSTEM.STRING TEM O ALIAS STRING
// VIMOS ANTERIORMENTE OS ALIAS
// Como o C# é case Sensitive, tanto faz escrevermos um ou outro. 
// Porem, o recomendado é sempre o usa o ALIAS, com alias escrevemos menos.
namespace Cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 25; // ALIAS
            int32 idade = 25; // TIPO
        }
    }
}