namespace Eindopdracht_PG2_fitness.DTO
{
    public class TrainingsImpactDTO
    {


        public int CyclingSessionID { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Duration { get; set; }
        public int AvgWatt { get; set; }
        public int MaxWatt { get; set; }
        public int AvgCadence { get; set; }
        public int MaxCadence { get; set; }
        public string TrainingType { get; set; }
        public string Comment { get; set; }
        public int MemberID { get; set; }

        public string TrainingsImpact { get; set; }

        

    }
}
