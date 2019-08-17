using UI = System.Console;
using GJJA.RegistraVoce.DataAcess.DAOs;
using GJJA.RegistraVoce.Domain;
using System;
using System.Collections.Generic;

namespace GJJA.RegistraVoce.App.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            UI.WriteLine($"*** Bem-Vindo! ***{Environment.NewLine}");  // OU   UI.WriteLine("*** Bem-Vindo! ***\n");   
            UI.WriteLine($"O que você deseja fazer? {Environment.NewLine}");
            UI.WriteLine("1. Listar pessoas");
            UI.WriteLine("0. Sair");
            int opcao = Convert.ToInt32(UI.ReadLine());
            switch (opcao)
            {
                case 0:
                    UI.WriteLine("Tchau ;)");
                    break;
                case 1:
                    ShowPeople();
                    break;
                default:
                    UI.WriteLine("Opção inválida!");
                    break;
            }
        }

        private static void ShowPeople()
        {
            PersonDAO personDAO = new PersonDAO();
            List<Person> people = personDAO.Select();
            if (people.Count == 0)
            {
                UI.WriteLine("não existem pessoas cadastradas");
            }
            else
            {
                //varrer 
                people.ForEach(person =>
                {
                    UI.WriteLine($"[{person.Id}] {person.Name}");
                });
            }
        }
    }
}
