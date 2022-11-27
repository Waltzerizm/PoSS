namespace PoSS.DTOs
{
    #pragma warning disable CS1591
    public class ServiceFilterDto
    {
        public string? Name { get; set; }
        public int? minDurationMins { get; set; }
        public int? maxDurationMins { get; set; }
        public Boolean? isAvailable { get; set; }
    }
}