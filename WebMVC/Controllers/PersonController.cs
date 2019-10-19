using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using WebMVC.Models;
using WebMVC.Factories;
using System;
using GJJA.RegistraVoce.Domain;
using GJJA.RegistraVoce.Domain.Enums;
using GJJA.ResgistraVoce.DataAccess.Entity.Context;
using GJJA.Repository.Common.Interfaces;
using GJJA.RegistraVoce.Repository.Entity;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;

namespace WebMVC.Controllers
{
   
    public class PersonController : Controller
    {
        public ListPersonModel model;
        public PersonController()
        {
            model = new ListPersonModel();
            SetUp();
        }
         private static ServiceProvider _serviceProvider;


        public IActionResult Index()
        {
            LoadPeople();     
            model.EditPerson.Name = "Olá" ;  
            
            return View (model);     
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

        public IActionResult DeletePerson(Int32 personId)
        {
              ICrudRepository<Person, int> personRepository = _serviceProvider.GetService<ICrudRepository<Person, int>>();
              personRepository.DeleteById(personId);
              LoadPeople();
              return View("Index", model);

           // return View();
        }
        public IActionResult InsertPerson()
        {
            ICrudRepository<Person, int> personRepository = _serviceProvider.GetService<ICrudRepository<Person, int>>();
            personRepository.Insert(model.EditPerson);
            LoadPeople();
            return View("Index", model);
        }



        private void LoadPeople ()
        {
             
            ICrudRepository<Person, int> personRepository = _serviceProvider.GetService<ICrudRepository<Person, int>>();
            List<Person> people = personRepository.Select();
            model =  new ListPersonModel(people);              
           
           // personRepository.DeleteById(personId);
            
        }        

          private static void SetUp()
        {
           

            IServiceCollection services = new ServiceCollection();
            services.AddSingleton<RegistraVoceDbContext>((provider) =>
            {
                return new WebMVCDbContextFactory().CreateDbContext(new string[] { });
            });
            services.AddScoped<ICrudRepository<Person, int>, PersonRepository>();
            _serviceProvider = services.BuildServiceProvider();

        }

        public  IActionResult EditPerson(Int32 personId)
        {
            ICrudRepository<Person, int> personRepository = _serviceProvider.GetService<ICrudRepository<Person, int>>();
            Person p = personRepository.SelectById(personId);
            LoadPeople();
            model.EditPerson = p;
            return View("Index", model);
        }
    }
}