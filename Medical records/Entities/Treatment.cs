namespace Medical_records.Entities
{
    public class Treatment
    {
        public int TreatmentId { get; set; }
        public int DiagnosisId { get; set; }
        public int DoctorId { get; set; }
        public string Description { get; set; }
        public DateTime TreatmentDate { get; set; }
        public decimal Cost { get; set; }
        public Diagnosis Diagnosis { get; set; }
        public Doctor Doctor { get; set; }
    }
}
