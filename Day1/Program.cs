// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var measurementService = new MeasurementService();
var measurements = measurementService.Get();
Console.WriteLine(Sonar.Increases(measurements));
var condensedMeasurements = measurements.MovingWindowSum(3);
Console.WriteLine(Sonar.Increases(condensedMeasurements));