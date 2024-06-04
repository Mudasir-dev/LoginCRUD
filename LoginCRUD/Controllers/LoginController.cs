using LoginCRUD.Models;

using System.Linq;
using System.Web.Mvc;

namespace LoginCRUD.Controllers
{
    public class LoginController : Controller
    {
        MyAcademyEntities1 db = new MyAcademyEntities1();
        public ActionResult Index()
        {

            if (Session["Userid"] != null)
            {
                return RedirectToAction("Index", "Courses");
            }

            return View();


        }

        [HttpPost]
        public ActionResult Index(user objuser)
        {
            var user = db.users.Where(model => model.username == objuser.username && model.password == objuser.password).FirstOrDefault();

            if (user != null)
            {
                Session["Userid"] = user.Id.ToString();
                Session["Username"] = user.username.ToString();
                TempData["LoginSuccess"] = "<script>alert('Login Successfully')</script>";

                return RedirectToAction("Index", "Courses");
            }
            else
            {
                ViewBag.ErrorMessage = "<script>alert('Username or Password Incorrect')</script>";
                return View();
            }




        }

        public ActionResult Signup(user u)
        {
            if (ModelState.IsValid)
            {

                db.users.Add(u);
                int a = db.SaveChanges();

                if (a > 0)
                {
                    ViewBag.InsertMessage = "<script>alert('Registered Successfully')</script>";

                    ModelState.Clear();

                    return RedirectToAction("Index");
                }

                else
                {
                    ViewBag.InsertMessage = "<script>alert('Registered Successfully')</script>";
                }

            }
            return View();
        }
    }
}