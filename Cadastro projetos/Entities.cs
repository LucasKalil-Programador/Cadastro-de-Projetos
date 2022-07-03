using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_projetos.Entities
{
    public class Aluno
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string RegisterNumber { get; set; }

        public string Semester { get; set; }

        public Aluno(string id, string name, string registerNumber, string semester)
        {
            this.Id = id;
            this.Name = name;
            this.RegisterNumber = registerNumber; 
            this.Semester = semester;   
        }
    }

    public class Universidade
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public Universidade(string id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
