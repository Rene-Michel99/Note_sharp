[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
<h1>Note_sharp</h1>
<h2>Criando o banco de dados MySql</h2>
create database notesdb;<br>
use notesdb;

<h2>Criando a tabela de notas</h2>
create table notes(<br>
	id int primary key,<br>
	title char(255),<br>
	text_ text,<br>
	date_ datetime<br>
);

<h2>Criando uma nota</h2>
<img src='creating_note.gif' alt='Criando nota' width='500' height='350'>

<h2>Acessando outras notas</h2>
<img src='switching.gif' width='500' height='350'>

<h2>Editando os textos</h2>
<img src='editing.gif' width='500' height='350'>

<h2>Apagando uma nota</h2>
<img src='erasing.gif' width='500' height='350'>
