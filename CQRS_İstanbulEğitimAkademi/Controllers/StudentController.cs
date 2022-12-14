using CQRS_İstanbulEğitimAkademi.CQRS.Commends.StudentCommends;
using CQRS_İstanbulEğitimAkademi.CQRS.Handlers.StudentHandlers;
using Microsoft.AspNetCore.Mvc;

namespace CQRS_İstanbulEğitimAkademi.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentQueryHandler _studentQueryHandler;
        private readonly CreateStudentCommandHandler _createStudentCommandHandler;
        private readonly GetStudentByIDQueryHandler _getStudentByIDQueryHandler;
        private readonly RemoveStudentCommandHandler _removeStudentCommandHandler;

        public StudentController(StudentQueryHandler studentQueryHandler, CreateStudentCommandHandler createStudentCommandHandler, GetStudentByIDQueryHandler getStudentByIDQueryHandler, RemoveStudentCommandHandler removeStudentCommandHandler)
        {
            _studentQueryHandler = studentQueryHandler;
            _createStudentCommandHandler = createStudentCommandHandler;
            _getStudentByIDQueryHandler = getStudentByIDQueryHandler;
            _removeStudentCommandHandler = removeStudentCommandHandler;
        }

        public IActionResult Index()
        {
            var values = _studentQueryHandler.Handle();
            return View(values);
        }

        
        [HttpGet] 
        public IActionResult AddStudent() 
        {
            return View(); 
        }

        [HttpPost] 
        public IActionResult AddStudent(CreateStudentCommand command) 
        { 
            _createStudentCommandHandler.Handle(command); 
            return RedirectToAction("Index"); 
        }

        public IActionResult GetStudent(int id)
        {
            var values = _getStudentByIDQueryHandler.Handle(id);
            return View(values);
        }

        public IActionResult RemoveStudent(int id) 
        { 
            _removeStudentCommandHandler.Handle(id);
            return RedirectToAction("Index");
        }



    }
}
