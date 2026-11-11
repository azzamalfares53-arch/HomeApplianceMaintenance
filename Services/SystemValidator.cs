namespace HomeApplianceMaintenance.Services
{
    public static class SystemValidator
    {
        public static bool IsValidSerialNumber(string serial)
        {
            return !string.IsNullOrWhiteSpace(serial) && serial.Length >= 5;
        }
    }
}