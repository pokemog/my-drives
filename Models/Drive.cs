namespace MyDrives.Models
{
    public class Drive
    {
        public string DriveName { get; set; }
        public string VolumeLabel { get; set; }
        private long totalFreeSpace;
        public long TotalFreeSpace
        {
            get { return totalFreeSpace; }
            set { totalFreeSpace = value; }
        }
        
    }
}