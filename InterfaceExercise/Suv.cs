namespace InterfaceExercise;

public class Suv : IVehicle , ICompany
{
    public int NumberOfSeats { get; set; }
    public bool HasTrunk { get; set; }
    public string Logo { get; set; }
    public string Headquarters { get; set; }
    public string Make { get; set; }
    public int Year { get; set; }
    public string Model { get; set; }
    public int WheelCount { get; set; }
}