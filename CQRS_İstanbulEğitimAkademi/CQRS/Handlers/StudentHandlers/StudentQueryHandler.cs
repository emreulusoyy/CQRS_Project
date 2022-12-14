using CQRS_İstanbulEğitimAkademi.CQRS.Results.StudentResult;
using CQRS_İstanbulEğitimAkademi.DAL.Context;
using System.Collections.Generic;
using System.Linq;

namespace CQRS_İstanbulEğitimAkademi.CQRS.Handlers.StudentHandlers
{
    public class StudentQueryHandler
    {
        private readonly ProductContext _context;

        public StudentQueryHandler(ProductContext context)
        {
            _context = context;
        }
        public List<GetStudentQuerlyResult> Handle()
        {
            var values = _context.Students.Select(x =>
            new GetStudentQuerlyResult
            {
                StudentID = x.StudentID,
                Name = x.Name,
                Surname = x.Surname,
                City = x.City
            }).ToList();
            return values;
        }
    }
}
