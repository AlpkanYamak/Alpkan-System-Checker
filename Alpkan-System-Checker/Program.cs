    using LibreHardwareMonitor.Hardware;
using System;

class Program
{
    static void Main()
    {
        Computer computer = new Computer
        {
                IsCpuEnabled = true,
                IsGpuEnabled = true,
                IsMotherboardEnabled = true, // Anakart sensörlerini açar
                IsMemoryEnabled = true       // RAM sensörlerini açar
        };

        computer.Open();

        Console.WriteLine("Donanim Izleyici Calisiyor... (Durdurmak icin Ctrl+C yapabilirsin)");
        Console.WriteLine("-------------------------------------------------------------");

        while (true)
        {
            foreach (IHardware hardware in computer.Hardware)
            {
                hardware.Update();
                foreach (ISensor sensor in hardware.Sensors)
                {
                    // Sadece sicaklik (Temperature) sensorlerini goster
                    if (sensor.SensorType == SensorType.Temperature)
                    {
                        Console.WriteLine($"{hardware.Name} - {sensor.Name}: {sensor.Value}°C");
                    }
                }
            }
            System.Threading.Thread.Sleep(2000); // 2 saniyede bir guncelleme yapar
        }
    }
}