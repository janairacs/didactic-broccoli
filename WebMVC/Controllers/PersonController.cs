using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using GJJA.RegistraVoce.Domain;
using GJJA.RegistraVoce.Domain.Enums;
using WebMVC.Models;
using System;

namespace WebMVC.Controllers
{
    public class PersonController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }



        public IActionResult Welcome()
        {
            var model = new PersonModel();
            model.Id = 1;
            model.Name = "Janaira";
            model.Gender = Gender.Male;
            model.DocumentNumber = "11223344";
            model.Identification = "22334455";
            model.BirthDate = new DateTime(1990, 01, 03);
            model.Address = "Minha Rua, Meu numero";
            model.Phone = "12981386001";
            model.MaritalStatus = MaritalStatus.Single;
            return View(model);


        }
    }
}