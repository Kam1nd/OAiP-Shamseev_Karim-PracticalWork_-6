class GamingLaptop : Computer
{
    public string gpuModel { get; set; }
    public int batteryLifeGaming { get; set; }

    public override void DisplayPerformanceMetrics()
    {
        Console.WriteLine("GPU load: 88% | CPU boost: 4.9 GHz | RAM usage: 92% | Fan speed: 4500 RPM");
    }

    public override void OptimizeResources()
    {
        Console.WriteLine("Turbo mode activated: prioritizing GPU/CPU for gaming workload");
    }

    public new void ConnectPeripherals()
    {
        Console.WriteLine("Wireless peripherals paired: mechanical keyboard, RGB mouse, VR headset");
    }

    public new void ManageCoolingSystem()
    {
        Console.WriteLine("Vapor chamber cooling active: dual fans at 6200 RPM with liquid metal thermal paste");
    }
}
