namespace ManipulacaoDeString;

public class ManipulacaoDeString
{
    /*
     Crie um programa que receba o nome completo de uma pessoa ex: Natanael de Lima Oliveira
     * remova todos os espaços laterais 
     * remova todos os espaçoes entre os nomes
     * passe todas as letras para minusculo
     * passe todas as letras para maiusculo
     * adicione uma nova palavra ao nome
     * remova uma palavra do nome
     * pesquise uma palavra dentro do nome
     * informe a quantidade de letras no nome
    */

    public static void Main(string[] args)
    {
        //Recebendo o nome completo
        Console.WriteLine("Informe o seu nome completo: ");
        string nomeCompleto = Console.ReadLine();
        
        Console.Clear();
        
        //Removendo os espaços laterais
        Console.WriteLine(nomeCompleto.Trim());
        
        //Removendo os espaços entre os nomes
        Console.WriteLine(nomeCompleto.Replace(" ", ""));
        
        //passe todas as letras para minusculo
        Console.WriteLine(nomeCompleto.ToLower());
        
        //passe todas as letras para maiusculo
        Console.WriteLine(nomeCompleto.ToUpper());
        
        //adicione uma nova palavra ao nome
        Console.WriteLine(nomeCompleto.Insert(nomeCompleto.Length, "Natan"));
        
        //remova uma palavra do nome
        Console.WriteLine(nomeCompleto.Replace("Natanael", ""));
        
        //pesquise uma palavra dentro do nome
        Console.WriteLine(nomeCompleto.Contains("Natan"));
        
        //informe a quantidade de letras no nome
        Console.WriteLine(nomeCompleto.Replace(" ", "").Length);
    }
}