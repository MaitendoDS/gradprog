namespace FitnessBL.DTO
{
    public class SessionDetailsDTO
    {
        public int SessionsCount { get; set; }
        public TimeSpan Tijdsduur { get; set; }
        public TimeSpan GemiddeldeTijdsduur { get; set; }

        public object KortsteSessie { get; set; }
        public object LangsteSessie { get; set; }

    }
}
