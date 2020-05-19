namespace VolumeWebService.VolumeCalculator
{
    public class VolumeResult
    {
        public VolumeResult()
        {
        }

        public int id { get; set; }
        public string type { get; set; }
        public double Height { get; set; }
        public double Radius { get; set; }
        public double Volume { get; set; }
    }
}