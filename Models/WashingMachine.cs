using HomeApplianceMaintenance.Models;

namespace HomeApplianceMaintenance.Models
{
    public class WashingMachine : Appliance
    {
        public double DrumSize { get; set; }

        public WashingMachine(string serialNumber, string brand, double drumSize)
            : base(serialNumber, brand)
        {
            DrumSize = drumSize;
        }

        public override void Diagnose()
        {
            Status = "Diagnosing";
        }

        public override void StartRepair()
        {
            Status = "Repairing";
        }

        public override double CalculateRepairCost()
        {
            return 50.0 + (DrumSize * 1.5);
        }
    }
}