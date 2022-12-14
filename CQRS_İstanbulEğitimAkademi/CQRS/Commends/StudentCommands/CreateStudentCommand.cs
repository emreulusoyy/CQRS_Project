namespace CQRS_İstanbulEğitimAkademi.CQRS.Commends.StudentCommends
{
    public class CreateStudentCommand
    {
        public string studentName { get; set; }
        public string studentSurname { get; set; }
        public string studentDepartment { get; set; }
    }
}
