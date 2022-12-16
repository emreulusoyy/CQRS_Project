using CQRS_İstanbulEğitimAkademi.CQRS.Commends.StudentCommands;
using CQRS_İstanbulEğitimAkademi.DAL.Context;

namespace CQRS_İstanbulEğitimAkademi.CQRS.Handlers.StudentHandlers
{
    public class UpdateStudentCommandHandler
    {
        private readonly ProductContext _context;

        public UpdateStudentCommandHandler(ProductContext context)
        {
            _context = context;
        }

        public void Handle(UpdateStudentCommand command)
        {
            var values = _context.Students.Find(command.StudentID);
            values.Name = command.Name;
            values.Surname = command.Surname;
            values.LessonAverage = command.LessonAverage;
            values.City = command.City;
            _context.SaveChanges();
        }
    }
}
