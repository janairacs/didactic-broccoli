using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using GJJA.RegistraVoce.Domain;
using GJJA.RegistraVoce.Domain.Enums;

namespace WebMVC.Models
{
    public class ListPersonModel
    
    {
        public List<Person> Lista{get;set;}

        public Person EditPerson {get;set;}
        public ListPersonModel()
        {
            EditPerson = new Person();
            Lista = new List<Person>();
        }
        public ListPersonModel(List<Person>lista)
        {
            EditPerson = new Person();
            Lista = new List<Person> ();
            foreach (Person person in lista)
            {
                Lista.Add(person);
            }
           
        }


    }


}