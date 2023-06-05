using Microsoft.AspNetCore.Mvc;
using WebApplication2.DataRepositoryies;
using WebApplication2.Model;
using WebApplication2.ViewModel;

namespace WebApplication2.HomeController
{
    public class HomeController:Controller
    {
        private readonly IStudentRepository _studentRepository;
        //使用构造函数注入的方式注入IStudetnRepository
        public HomeController(IStudentRepository studentRepository)
        {
            _studentRepository = new MockStudnetRepository();
        }
        public  ViewResult Index()
        {
            //查询所有的学生信息
            var model = _studentRepository.GetAllStudents();
            return View(model);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public RedirectToActionResult Create(Student student)
        {
            Student newstudent = _studentRepository.Add(student);
            return RedirectToAction("Details", new {id=newstudent.Id});
        }
        public ViewResult Details(int id)
        {
            //实例化HomeDetailsViewModel并存储Student详细信息和PageTitle
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel() {
                Student = _studentRepository.GetStudent(id),
                PageTitle="学生详情"
            };
            return View(homeDetailsViewModel);
        }
    }
}
