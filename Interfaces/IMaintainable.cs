namespace HomeApplianceMaintenance.Interfaces
{
    public interface IMaintainable
    {
        void StartRepair();
        double CalculateRepairCost();
    }
}