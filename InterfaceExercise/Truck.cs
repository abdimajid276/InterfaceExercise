namespace InterfaceExercise;

public class Truck : IVehicle , ICompany
{
    public bool HasTrunk { get; set; }
    public int TrunkSpace { get; set; }
    public bool HasTruckBed { get; set; }
    public int TruckBedspace { get; set; }
    public string Logo { get; set; }
    public string Headquarters { get; set; }
    public string Make { get; set; }
    public int Year { get; set; }
    public string Model { get; set; }
    public int WheelCount { get; set; }
}