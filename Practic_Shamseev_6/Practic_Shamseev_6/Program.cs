using System;
class Program
{
    static void Main(string[] args)
    {
        GamingLaptop myLaptop = new GamingLaptop
        {
            brand = "HP",
            cpuModel = "Intel Core i5 - 12400",
            ramCapacity = 32,
            isPoweredOn = true,
            gpuModel = "NVIDIA GeForce RTX 4070",
            batteryLifeGaming = 90
        };

        Console.WriteLine("Calling methods via myLaptop object:");
        myLaptop.BootSystem();
        myLaptop.RunDiagnostics();
        myLaptop.DisplayPerformanceMetrics();
        myLaptop.OptimizeResources();
        myLaptop.ConnectPeripherals();
        myLaptop.ManageCoolingSystem();

        Console.WriteLine();

        Console.WriteLine("Calling methods via myComputer object:");

        Computer myComputer = myLaptop;
        myComputer.BootSystem();
        myComputer.RunDiagnostics();
        myComputer.DisplayPerformanceMetrics();
        myComputer.OptimizeResources();
        myComputer.ConnectPeripherals();
        myComputer.ManageCoolingSystem();
    }
}
