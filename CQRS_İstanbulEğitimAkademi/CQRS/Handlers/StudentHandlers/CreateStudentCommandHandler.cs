using CQRS_İstanbulEğitimAkademi.CQRS.Commends.StudentCommends;
using CQRS_İstanbulEğitimAkademi.DAL.Context;
using CQRS_İstanbulEğitimAkademi.DAL.Entities;

namespace CQRS_İstanbulEğitimAkademi.CQRS.Handlers.StudentHandlers
{
    public class CreateStudentCommandHandler
    {
        private readonly ProductContext _context;

        public CreateStudentCommandHandler(ProductContext context)
        {
            _context = context;
        }

        public void Handle(CreateStudentCommand command)
        {
            _context.Students.Add(new Student   //yeni bir öğrenci ekliyorum. Öğrencinin adı soyadı ve departmanını eklicem sadece
            {
                Name = command.studentName,
                Surname = command.studentSurname,
                Department = command.studentDepartment
            });
            _context.SaveChanges();
        }
    }
}
