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

    public class Projeto 
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public string References { get; set; }

        public string Description { get; set; }

        public Orientador Orientador { get; set; }

        public Universidade Universidade { get; set; }

        public Projeto(string id, string name, string type, string references, string description, Orientador orientador, Universidade universidade)
        {
            Id = id;
            Name = name;
            Type = type;
            References = references;
            Description = description;
            Orientador = orientador;
            Universidade = universidade;
        }
    }

    public class Team
    {
        public string Id { get; set; }

        public Aluno Aluno { get; set; }

        public Projeto Projeto { get; set; }

        public Team(string id, Aluno aluno, Projeto projeto)
        {
            Id = id;
            Aluno = aluno;
            Projeto = projeto;
        }
    }
}
