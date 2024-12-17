namespace Eindopdracht_PG2_fitness.DTO
{
    public class TrainingsImpactMonthlyDTO
    {
        public string Month { get; set; }

        public List<TrainingsImpactDTO> Sessions { get; set; }
    }
}
