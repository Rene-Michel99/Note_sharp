<h2>Criando o banco de dados MySql</h2>
create database notesdb;
use notesdb;

<h2>Criando a tabela de notas</h2>
create table notes(
	id int primary key,
	title char(255),
	text_ text,
	date_ datetime
);
