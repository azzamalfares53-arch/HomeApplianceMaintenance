using System;
using System.Collections.Generic;
using HomeApplianceMaintenance.Models;

namespace HomeApplianceMaintenance.Services
{
    public class MaintenanceCenter
    {
        private List<Appliance> _devices;

        public MaintenanceCenter()
        {
            _devices = new List<Appliance>();
        }

        public void AddDevice(Appliance device)
        {
            if (device == null) throw new ArgumentNullException("device");
            _devices.Add(device);
            device.OnStatusChanged += Device_OnStatusChanged;
        }

        private void Device_OnStatusChanged(string serialNumber, string newStatus)
        {
            Console.WriteLine("[NOTIFICATION] Device " + serialNumber + " status changed to: " + newStatus);
        }

        public void ProcessAllDevices()
        {
            foreach (var device in _devices)
            {
                Console.WriteLine("\nProcessing Device: " + device.SerialNumber + " (" + device.Brand + ")");
                device.Diagnose();
                device.StartRepair();
                device.Status = "Completed";
                Console.WriteLine("Repair Cost: $" + device.CalculateRepairCost());
            }
        }
    }
}