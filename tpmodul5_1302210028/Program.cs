// See https://aka.ms/new-console-template for more information
public class HaloGeneric
{
    public void SapaUser<U>(U username)
    {
        Console.WriteLine("Halo user " + username);
    }
}

public class DataGeneric<T>
{
    private T data { get; set; }
    public DataGeneric(T data)
    {
        this.data = data;
    }
    public void PrintData()
    {
        Console.WriteLine("Data yang tesimpan adalah: " + data);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        //HaloGeneric
        HaloGeneric halo = new HaloGeneric();
        Console.Write("Input nama user: ");
        string input = Console.ReadLine();
        Console.WriteLine();
        halo.SapaUser(input);

        //DataGeneric
        Console.Write("Input NIM: ");
        string nim = Console.ReadLine();
        Console.WriteLine();

        DataGeneric<string> dg = new DataGeneric<string>(nim);
        dg.PrintData();
    }
}
