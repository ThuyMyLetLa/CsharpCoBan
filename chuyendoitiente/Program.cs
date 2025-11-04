public class Program
{
    public static void Main(string[] args)
    {
        int usd = 23000000;
        Console.WriteLine("Nhap so usd can doi sang vnd: ");
        int vnd = Convert.ToInt32(Console.ReadLine());
        int tienvnd = vnd * usd;
        Console.WriteLine($"so tien chuyen doi la: {tienvnd} VND");
    }
}