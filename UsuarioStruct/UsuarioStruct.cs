namespace UsuarioStruct;

public class UsuarioStruct
{
    //Faça um programa que crie uma struct
    public static void Main(string[] args)
    {
        var usuario1 = new Usuario(1, "Natan", "Lima", 22);
    }

    struct Usuario
    {
        public Usuario(int id, string name, string lastName, int idade)
        {
            Id = id;
            Name = name;
            LastName = lastName;
            Idade = idade;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Idade { get; set; }
    }
}