using System;
using HomeApplianceMaintenance.Models;
using HomeApplianceMaintenance.Services;

namespace HomeApplianceMaintenance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Home Appliance Maintenance System ===");

            string testSerial = "WM-12345";
            if (!SystemValidator.IsValidSerialNumber(testSerial))
            {
                Console.WriteLine("Invalid Serial Number!");
                return;
            }

            Appliance washer = new WashingMachine(testSerial, "LG", 8.5);
            Appliance fridge = new Refrigerator("REF-98765", "Samsung", true);
            Appliance ac = new AirConditioner("AC-55555", "Gree", 18000);

            MaintenanceCenter center = new MaintenanceCenter();
            center.AddDevice(washer);
            center.AddDevice(fridge);
            center.AddDevice(ac);

            center.ProcessAllDevices();

            Console.WriteLine("\nTotal Devices Registered in System: " + Appliance.TotalDevices);

            Console.ReadLine();
        }
    }
}