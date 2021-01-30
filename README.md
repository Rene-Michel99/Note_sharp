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
<img src='creating_note.gif' alt='Criando nota' width='250' height='150'>
