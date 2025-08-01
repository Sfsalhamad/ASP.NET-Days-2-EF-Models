public class DoctorServices
{
    public static int count { get; set; }

    public DoctorServices()
    {
        count++;
        Console.WriteLine($"DoctorServices instance created. Current count: {count}");
    }
}