namespace HomeApplianceMaintenance.Models
{
    public class AirConditioner : Appliance
    {
        public int BTU { get; set; }

        public AirConditioner(string serialNumber, string brand, int btu)
            : base(serialNumber, brand)
        {
            BTU = btu;
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
            return 60.0 + (BTU / 1000.0 * 10);
        }
    }
}