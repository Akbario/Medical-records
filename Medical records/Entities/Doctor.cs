namespace Medical_records.Entities
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        public string Name { get; set; }
        public string Specialty { get; set; }
        public List<Diagnosis> Diagnoses { get; set; }
        public List<Treatment> Treatments { get; set; }
    }
}
