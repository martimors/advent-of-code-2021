public class MeasurementService : IMeasurementService
{
    public List<int> Get()
    {
        var measurements = File.ReadLines(@"./measurement.txt").Select(line => int.Parse(line)).ToList();
        return measurements;
    }
}