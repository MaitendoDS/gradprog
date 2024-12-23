namespace REST.DTO
{
    public class ReeksDTO
    {

        public int Nummer { get; set; }
        public string Naam { get; set; }
        public string Url { get; set; }
        public List<StripReeksDTO> StripReeksDTO { get; set; }
    }
}
