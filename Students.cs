namespace Cap10_12
{
    public class Students
    {
        public string? nameStudent { get; set; }
        public int idStudent { get; set; }
        public string? race { get; set; }
        public Students(string nameStudent, int idStudent, string race)
        {
            this.nameStudent = nameStudent;
            this.idStudent = idStudent;
            this.race = race;
        }
    }
}