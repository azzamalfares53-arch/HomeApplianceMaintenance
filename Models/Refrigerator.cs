namespace HomeApplianceMaintenance.Models
{
    public class Refrigerator : Appliance
    {
        public bool HasFreezer { get; set; }

        public Refrigerator(string serialNumber, string brand, bool hasFreezer)
            : base(serialNumber, brand)
        {
            HasFreezer = hasFreezer;
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
            return HasFreezer ? 120.0 : 80.0;
        }
    }
}