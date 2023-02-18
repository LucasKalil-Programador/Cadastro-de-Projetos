# Cadastro de projetos

[![NPM](https://img.shields.io/npm/l/react)](https://github.com/LucasKalil-Programador/Cadastro-de-Projetos/blob/89eb3fc72d175cd0338319038cbd638280c84d90/LICENCE)

# Sobre o projeto

Foi concebido inicialmente pela matéria de Banco de dados 1 com o intuito que nos aprofundássemos nos consertos de relacionamento entre entidades de uma banco de dados, ou seja esse projeto serviu para que estudássemos sobre comandos sql como create, update, insert, select, where, etc.

## Diagrama SQL criado para esse projeto

O banco de dados e composto de 4 tabelas principais e uma que é usada para relacionamento sendo elas Projeto, Universidade, Orientador, Aluno e Projeto_has_Aluno.

Projeto_has_Aluno é a tabela que serve para criar um relacionamento N-N entre Aluno e Projeto ou seja vários alunos possuem vários projetos.

Outros relacionamentos como Orientado para projeto e universidade para projeto sao mais simples.

![Diagrama do Banco de dados](https://user-images.githubusercontent.com/82661706/176945583-f76a2d0a-d66c-4ee7-baa5-47221ad0ca78.PNG)

## Design da aplicação

O layout do software foi feito usando o framework padram do .net o windowsforms com ela é possível criar janelas simples para interação com o usuário abaixo um protótipo da janela com o usuário.

![design da aplicação](https://user-images.githubusercontent.com/82661706/176910157-e16e6a75-8c50-4190-988e-453ccd1a14c8.PNG)

## Tecnologias adotadas

### Banco de dados

- MYSQL (Sistema de gerenciamento de banco de dados)
- MYSQL Workbench (criação de diagramas)

### Interação com o usuário

- C# (Linguagem)
- Windows Forms (Framework)

## Como executar o projeto

Antes de executar é necessário os seguintes pre-requisitos.

- [.NET 6.0](https://dotnet.microsoft.com/pt-br/download/dotnet/6.0)
- [MYSQL](https://www.mysql.com/)
- [Visual Studio](https://visualstudio.microsoft.com/pt-br/)

Execute o código no banco de dados mysql presente no projeto em [banco de dados SQL.txt](https://github.com/LucasKalil-Programador/Cadastro-de-Projetos/blob/89eb3fc72d175cd0338319038cbd638280c84d90/sql%20gerado%20banco%20de%20dados.txt).

Importe esse repositório para o Visual Studio depois ja sera possível executar o projeto normalmente sera necessário criar novos usuário pois a tabela nao ira ter nenhum objeto criado.

# Outras informações

Criador: Lucas Guimarães Kalil - desenvolvedor full stack

Linkedin: https://www.linkedin.com/in/lucas-kalil-436a6220a/<br>
Contato: lucas.prokalil2020@outlook.com
