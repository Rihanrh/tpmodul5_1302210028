// See https://aka.ms/new-console-template for more information

public class HaloGeneric
{
    public void SapaUser<U>(U username)
    {
        Console.WriteLine("Halo user " + username);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        HaloGeneric halo = new HaloGeneric();
        Console.Write("Input nama user: ");
        string input = Console.ReadLine();
        Console.WriteLine();
        halo.SapaUser(input);
    }
}
