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

    public class Orientador
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Subjects { get; set; }

        public Orientador(string id, string name, string subjects)
        {
            this.Id = id;
            this.Name = name;
            this.Subjects = subjects;
        }
    }
}
