namespace WBWalks.Models.Domain
{
    public class Region
    {
        /*
         A GUID is a 128-bit integer (16 bytes) that can be 
        used across all computers and networks 
        wherever a unique identifier is required.
         */
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public double Area { get; set; }
        public double List { get; set; }
        public double Long { get; set; }
        public long population { get; set; }

    }
}
