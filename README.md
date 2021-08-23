# Meus Produtos

O objetivo deste projeto é resolver um Desafio para estágio em desenvolvedor .NET. 

O projeto consiste em uma api web capaz de cadastrar e listar clientes e produtos em um banco de dados, seguindo as seguintes regras:

O cadastro de clientes deve conter os campos:
* nome 
* email
* senha

O cadastro de produtos deve conter os campos:
* nome 
* valor
* status

## Tecnologias usadas
* [Asp.Net Core 5](https://docs.microsoft.com/pt-br/aspnet/core/introduction-to-aspnet-core?view=aspnetcore-5.0)
* [SQLite3](https://www.sqlite.org/index.html)

## Ferramentas usadas
* [Visual Studio Code](https://code.visualstudio.com/): Geração do código
* [Postman](https://www.postman.com/): Realização de testes para verificar o funcionamento correto da api.

## Como rodar o Projeto
Dentro da pasta do projeto digite: `dotnet run`, depois abra o seu navegador em algum dos endereços abaixo:
* https://localhost:5001/api/Clients: Acesso a lista de clientes;
* https://localhost:5001/api/Products: Acesso a lista de produtos.

## Desafios e Problemas
O primeiro desafio foi me adaptar a linguagem, uma vez que, só havia usado uma vez muito brevemente em um curso introdutório de C#. Nem tinha mais baixado o **.Net** no meu computador. 

Por isso a primeira coisa que fiz foi baixa-lo. O que também, foi um desafio já que uso o **Ubuntu 20.04** e o .Net foi feito pela **Microsoft**, e portanto era melhor utilizado no **Windows**. Primeiro tentei baixar pelo [snap](https://snapcraft.io/). Mas ele só executava como **sudo** e o **Visual Studio Code** não reconhecia. Depois achei um [tutorial da própria Microsoft de como instalar](https://docs.microsoft.com/pt-br/dotnet/core/install/linux?WT.mc_id=dotnet-35129-website).

Depois resolvi aprender como fazer uma api web e para isso usei outro [tutorial da Microsoft](https://docs.microsoft.com/pt-br/aspnet/core/tutorials/first-web-api?view=aspnetcore-5.0&tabs=visual-studio-code), que me ajudou bastante a aprender como dar os primeiros passos com a api.

Porém o tutorial não ensinava como usar o banco de dados e portanto tive que procurar vídeos e outros tutoriais para conseguir conectar o SQLite a api. 

Tendo tudo configurado e funcionando resolvi começar a fazer as tarefas bonus. Os métodos **Put** e **Delete** já vieram implementados ao criar os métodos **Get** e **Post**
Para fazer validações nos cadastros usei a biblioteca [System.ComponentModel.DataAnnotations](https://docs.microsoft.com/pt-br/dotnet/api/system.componentmodel.dataannotations?view=net-5.0). Já para criptografar a senha usei a biblioteca [BcryptNet](https://github.com/BcryptNet/bcrypt.net).

Porém não consegui tornar o email único para cada cliente, nem implementar o retorno de um JWT no login.