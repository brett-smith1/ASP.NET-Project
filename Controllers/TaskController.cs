using Microsoft.AspNetCore.Mvc;
using ASP.NET_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ASP.NET_Project.Controllers
{
    public class TaskController : Controller
    {

        public IActionResult Index()
        {
            return Content("No task selected");
        }

        public IActionResult Show(int id)
        {
            //create instance of the model
            Task task1 = new Task();
            if (id == 1)
            {
                task1.TaskName = "CSC395 Project";
                task1._Category = Task.Category.Work;
                task1.Priority = Task.PriorityLevel.Routine;
                task1.DueDate = DateTime.Now+TimeSpan.FromDays(14);
            }
            else
            {
                ViewBag.Task = "No Task Specified";
                ViewBag.Response = "Please add an id to the URL, or...";
            }

            return View(task1);

        }

        public IActionResult AddTask()
        {
            Task newTask = new Task();
            //WILL ADD CODE TO ADD TASK TO DATABASE ONCE I LEARN

            return View();
        }
    }
}
