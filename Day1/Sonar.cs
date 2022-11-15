public class Sonar
{
    public static int Increases(List<int> measurements)
    {
        var previousMeasurement = measurements[0];
        var nIncreases = 0;
        foreach (var measurement in measurements)
        {
            if (measurement > previousMeasurement)
            {
                nIncreases++;
            }
            previousMeasurement = measurement;
        }
        return nIncreases;
    }


}