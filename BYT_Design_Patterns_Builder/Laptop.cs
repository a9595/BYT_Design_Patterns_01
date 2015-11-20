namespace BYT_Design_Patterns_Builder
{
    internal class Laptop
    {
        public string MonitorResolution { get; set; }
        public string Processor { get; set; }
        public string Memory { get; set; }
        public string Hdd { get; set; }

        public override string ToString()
        {
            return "Laptop: " + MonitorResolution + " " + Processor + " " + " " + Memory + " " + Hdd;
        }
    }
}