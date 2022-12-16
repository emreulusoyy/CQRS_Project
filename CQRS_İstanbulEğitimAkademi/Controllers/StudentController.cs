using CQRS_İstanbulEğitimAkademi.CQRS.Commends.StudentCommands;
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
        private readonly UpdateStudentCommandHandler _updateStudentCommandHandler;

        public StudentController(StudentQueryHandler studentQueryHandler, CreateStudentCommandHandler createStudentCommandHandler, GetStudentByIDQueryHandler getStudentByIDQueryHandler, RemoveStudentCommandHandler removeStudentCommandHandler, UpdateStudentCommandHandler updateStudentCommandHandler)
        {
            _studentQueryHandler = studentQueryHandler;
            _createStudentCommandHandler = createStudentCommandHandler;
            _getStudentByIDQueryHandler = getStudentByIDQueryHandler;
            _removeStudentCommandHandler = removeStudentCommandHandler;
            _updateStudentCommandHandler = updateStudentCommandHandler;
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
        [HttpGet]
        public IActionResult GetStudent(int id)
        {
            var values = _getStudentByIDQueryHandler.Handle(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult GetStudent(UpdateStudentCommand command)
        {
            _updateStudentCommandHandler.Handle(command);
            return RedirectToAction("Index");   
        }


        public IActionResult RemoveStudent(int id) 
        { 
            _removeStudentCommandHandler.Handle(id);
            return RedirectToAction("Index");
        }



    }
}
