namespace FitnessBL.DTO
{
    public class TrainingsImpactMonthlyDTO
    {
        public string Month { get; set; }

        public List<TrainingsImpactDTO> Sessions { get; set; }
    }
}
