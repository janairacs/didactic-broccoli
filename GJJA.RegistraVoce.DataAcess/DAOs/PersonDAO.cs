using System.Collections.Generic;
using GJJA.RegistraVoce.Domain;
using GJJA.RegistraVoce.DataAcess.Utils;
using System.Data.Common;
using System;
using GJJA.RegistraVoce.Domain.Enums;
using System.Data;

namespace GJJA.RegistraVoce.DataAcess.DAOs
{
    public class PersonDAO
    {
        // METODO DE SELECT

        // try finally 

        public List<Person> Select()
        {
            // Aplicando o  acoplamento   principio de liskov
            // DbUtils dbUtils = new DbUtils();

            List<Person> people = new List<Person>();
            DbConnection conn = null;
            try
            {
                conn = DbUtils.CreateConnection();
                DbCommand command = conn.CreateCommand();  //CRIO COMANDO 
                command.CommandText = "SELECT * FROM pes_pessoas";
                command.CommandType = System.Data.CommandType.Text;
                DbDataReader reader = command.ExecuteReader(); //LEIO RESULTADO DE COMANDO
                while (reader.Read())
                {
                    people.Add(new Person
                    {
                        Id = Convert.ToInt32(reader["pes_id"]),
                        Name = reader["pes_nome"].ToString(),
                        Gender = (Gender)Convert.ToInt32(reader["pes_sexo"]),
                        DocumentNumber = reader["pes_cpf"].ToString(),
                        Identification = reader["pes_rg"].ToString(),
                        BirthDate = Convert.ToDateTime(reader["pes_data_nascimento"]),
                        MaritalStatus = (MaritalStatus)Convert.ToInt32(reader["pes_estado_civil"]),
                        Address = reader["pes_endereco"].ToString(),
                        Phone = reader["pes_telefone"].ToString(),

                    });
                }
                return people;
            }

            finally
            {
                DbUtils.CloseConnection(conn);
            
            }
        }
    }

}