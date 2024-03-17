// See https://aka.ms/new-console-template for more information
public class HaloGeneric
{

    public void SapaUser<T>(T user)
    {
        Console.WriteLine("Halo user " + user);
    }
    
}

public class DataGeneric<T>
{
    public T data;

    public DataGeneric(T data)
    {
        this.data = data;
    }

    public void PrintData()
    {
        Console.WriteLine($"Data yang tersimpan adalah: {data}");
    }
}

class Program
{
    static void Main(string[] args)
    {

        HaloGeneric halo = new HaloGeneric();

        halo.SapaUser("Rizky Kusuma Nugraha");
        DataGeneric<string> dataString = new DataGeneric<string>("1302220013");
        dataString.PrintData();
     
    }
}

