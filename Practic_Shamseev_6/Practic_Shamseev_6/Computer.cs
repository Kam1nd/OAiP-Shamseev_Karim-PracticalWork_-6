using System;

class Computer
{
    public string brand { get; set; }
    public string cpuModel { get; set; }
    public int ramCapacity { get; set; }
    public bool isPoweredOn { get; set; }

    public void BootSystem()
    {
        Console.WriteLine("System initialization sequence started. BIOS check in progress...");
    }

    public void RunDiagnostics()
    {
        Console.WriteLine("Hardware diagnostics completed. All components operational.");
    }

    public virtual void DisplayPerformanceMetrics()
    {
        Console.WriteLine("CPU load: 45% | RAM usage: 60% | Thermal throttling: inactive");
    }

    public virtual void OptimizeResources()
    {
        Console.WriteLine("Background processes optimized for desktop workload.");
    }

    public void ConnectPeripherals()
    {
        Console.WriteLine("Wired peripherals detected: keyboard, mouse, external monitorssss");
    }

    public void ManageCoolingSystem()
    {
        Console.WriteLine("Active cooling engaged: 3 case fans at 1200 RPM");
    }
}
