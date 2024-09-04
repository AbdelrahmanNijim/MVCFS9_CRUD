using Microsoft.AspNetCore.Mvc;
using MVCFS9.Data;
using MVCFS9.Models;

namespace MVCFS9.Controllers
{
    public class studentsController : Controller
    {
      ApplicationDbContext context;
        public studentsController(ApplicationDbContext context) 
        {
          this.context = context;
        }
        public IActionResult Index()
        {
           var students = context.Students.ToList();
         
           return View(students);
        }

        public IActionResult Getd ()
        {
   
            return View();
        }

        public IActionResult Create()
        {
            return View();

        }
        public IActionResult Store(Student student)
        {
            context.Students.Add(student);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Edit(int id)
        {
            var student = context.Students.Find(id);

            return View(student);

        }
        public IActionResult Update(Student stu)
        {
            var student = context.Students.Find(stu.Id);
            student.Name = stu.Name;
            student.Email = stu.Email;
            if (stu.password is not null )
            {
                student.password = stu.password;
            }
            student.Phone = stu.Phone;
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(int id)
        {
            var student = context.Students.Find(id);
            context.Students.Remove(student);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }
    }
}
