// See https://aka.ms/new-console-template for more information

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
        Console.Write("Input NIM: ");
        string nim = Console.ReadLine();
        Console.WriteLine();

        DataGeneric<string> dg = new DataGeneric<string>(nim);
        dg.PrintData();
    }
}
