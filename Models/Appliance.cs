using System;
using HomeApplianceMaintenance.Interfaces;

namespace HomeApplianceMaintenance.Models
{
    public delegate void StatusChangedHandler(string serialNumber, string newStatus);

    public abstract class Appliance : IMaintainable
    {
        private string _brand;
        private string _status;
        private static int _totalDevices = 0;

        public string SerialNumber { get; private set; }

        public string Brand
        {
            get { return _brand; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Brand cannot be empty.");
                _brand = value;
            }
        }

        public string Status
        {
            get { return _status; }
            set
            {
                if (_status != value)
                {
                    _status = value;
                    if (OnStatusChanged != null)
                    {
                        OnStatusChanged(this.SerialNumber, this.Status);
                    }
                }
            }
        }

        public event StatusChangedHandler OnStatusChanged;

        protected Appliance(string serialNumber, string brand)
        {
            if (string.IsNullOrWhiteSpace(serialNumber))
                throw new ArgumentException("Serial number is required.");

            SerialNumber = serialNumber;
            Brand = brand;
            Status = "Received";
            _totalDevices++;
        }

        public static int TotalDevices { get { return _totalDevices; } }

        public abstract void Diagnose();
        public abstract void StartRepair();
        public abstract double CalculateRepairCost();
    }
}