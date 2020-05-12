drop database liga2;

create database liga2;

use liga2;

create table general(
Club char(15) primary key not null,
PJ int,G int,E int,P int,GF int,GC int,DG int,PTS int,Ultimos varchar(5));

create table GF(
Club char(15) primary key not null,
A1 int, A2 int, A3 int,A4 int,A5 int,A6 int,A7 int,A8 int,A9 int,A10 int,A11 int,A12 int,A13 int);
/*C1 int, C2 int, C3 int,C4 int,C5 int,C6 int,C7 int,C8 int,C9 int,C10 int,C11 int,C12 int,C13 int);*/

create table GC(
Club char(15) primary key not null,
A1 int, A2 int, A3 int,A4 int,A5 int,A6 int,A7 int,A8 int,A9 int,A10 int,A11 int,A12 int,A13 int);
/*C1 int, C2 int, C3 int,C4 int,C5 int,C6 int,C7 int,C8 int,C9 int,C10 int,C11 int,C12 int,C13 int);*/

create table Gana(
Club char(15) primary key not null,
A1 int, A2 int, A3 int,A4 int,A5 int,A6 int,A7 int,A8 int,A9 int,A10 int,A11 int,A12 int,A13 int);
/*C1 int, C2 int, C3 int,C4 int,C5 int,C6 int,C7 int,C8 int,C9 int,C10 int,C11 int,C12 int,C13 int);*/

create table Empate(
Club char(15) primary key not null,
A1 int, A2 int, A3 int,A4 int,A5 int,A6 int,A7 int,A8 int,A9 int,A10 int,A11 int,A12 int,A13 int);
/*C1 int, C2 int, C3 int,C4 int,C5 int,C6 int,C7 int,C8 int,C9 int,C10 int,C11 int,C12 int,C13 int);*/

create table Pierde(
Club char(15) primary key not null,
A1 int, A2 int, A3 int,A4 int,A5 int,A6 int,A7 int,A8 int,A9 int,A10 int,A11 int,A12 int,A13 int);
/*C1 int, C2 int, C3 int,C4 int,C5 int,C6 int,C7 int,C8 int,C9 int,C10 int,C11 int,C12 int,C13 int);*/

create table Partidos(
Club char(15) primary key not null,
A1 varchar(1), A2 varchar(1), A3 varchar(1),A4 varchar(1),A5 varchar(1),A6 varchar(1),A7 varchar(1),A8 varchar(1),A9 varchar(1),A10 varchar(1),A11 varchar(1),A12 varchar(1),A13 varchar(1));
/*C1 varchar(1), C2 varchar(1), C3 varchar(1),C4 varchar(1),C5 varchar(1),C6 varchar(1),C7 varchar(1),C8 varchar(1),C9 varchar(1),C10 varchar(1),C11 varchar(1),C12 varchar(1),C13 varchar(1));*/

create table TablaJ(
Torneo char(15) primary key not null,
A1 int, A2 int, A3 int, A4 int, A5 int, A6 int, A7 int, A8 int, A9 int, A10 int, A11 int, A12 int, A13 int);
/*C1 int, C2 int, C3 int, C4 int, C5 int, C6 int, C7 int, C8 int, C9 int, C10 int, C11 int, C12 int, C13 int);*/

/*Base*/
insert into general(Club, PJ, G, E ,P, GF, GC, DG, PTS, Ultimos) values
('Alebrijes', 		0, 0, 0, 0, 0, 0, 0, 0, ''),
('Atlante', 		0, 0, 0, 0, 0, 0, 0, 0, ''),
('Cafetaleros',		0, 0, 0, 0, 0, 0, 0, 0, ''),
('Cimarrones',		0, 0, 0, 0, 0, 0, 0, 0, ''),
('Zacatepec',		0, 0, 0, 0, 0, 0, 0, 0, ''),
('Celaya', 			0, 0, 0, 0, 0, 0, 0, 0, ''),
('Correcaminos',	0, 0, 0, 0, 0, 0, 0, 0, ''),
('Dorados', 		0, 0, 0, 0, 0, 0, 0, 0, ''),
('Loros Colima',	0, 0, 0, 0, 0, 0, 0, 0, ''),
('Mineros',			0, 0, 0, 0, 0, 0, 0, 0, ''),
('Tampico Madero', 	0, 0, 0, 0, 0, 0, 0, 0, ''),
('Potros UAEM', 	0, 0, 0, 0, 0, 0, 0, 0, ''),
('Leones Negros', 	0, 0, 0, 0, 0, 0, 0, 0, ''),
('Venados', 		0, 0, 0, 0, 0, 0, 0, 0, '');

/*Jornada Jugada Cambiar A por C cuando sea clausura*/
insert into TablaJ (Torneo, A1 , A2 , A3 , A4 , A5 , A6 , A7 , A8 , A9 , A10 , A11 , A12 , A13 /*C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13*/) values
('Apertura', 	0,0,0,0,0,0,0,0,0,0,0,0,0),
('Clausura', 	0,0,0,0,0,0,0,0,0,0,0,0,0);

/*Goles a Favor*/
insert into GF(Club, A1,A2,A3,A4,A5,A6,A7,A8,A9,A10,A11,A12,A13)/*C1,C2,C3,C4,C5,C6,C7,C8,C9,C10,C11,C12,C13)*/ values
('Alebrijes', 		NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
('Atlante', 		NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
('Cafetaleros',		NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
('Cimarrones',		NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
('Zacatepec',		NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
('Celaya', 			NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
('Correcaminos',	NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
('Dorados', 		NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
('Loros Colima',	NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
('Mineros',			NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
('Tampico Madero', 	NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
('Potros UAEM', 	NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
('Leones Negros', 	NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
('Venados', 		NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL);

/*Goles en Contra*/
insert into GC(Club, A1,A2,A3,A4,A5,A6,A7,A8,A9,A10,A11,A12,A13)/*C1,C2,C3,C4,C5,C6,C7,C8,C9,C10,C11,C12,C13)*/ values
('Alebrijes', 		NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
('Atlante', 		NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
('Cafetaleros',		NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
('Cimarrones',		NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
('Zacatepec',		NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
('Celaya', 			NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
('Correcaminos',	NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
('Dorados', 		NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
('Loros Colima',	NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
('Mineros',			NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
('Tampico Madero', 	NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
('Potros UAEM', 	NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
('Leones Negros', 	NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
('Venados', 		NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL);

/*Ganados*/
insert into Gana(Club, A1,A2,A3,A4,A5,A6,A7,A8,A9,A10,A11,A12,A13)/*C1,C2,C3,C4,C5,C6,C7,C8,C9,C10,C11,C12,C13)*/ values
('Alebrijes', 		NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
('Atlante', 		NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
('Cafetaleros',		NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
('Cimarrones',		NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
('Zacatepec',		NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
('Celaya', 			NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
('Correcaminos',	NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
('Dorados', 		NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
('Loros Colima',	NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
('Mineros',			NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
('Tampico Madero', 	NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
('Potros UAEM', 	NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
('Leones Negros', 	NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
('Venados', 		NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL);

/*Empatados*/
insert into Empate(Club, A1,A2,A3,A4,A5,A6,A7,A8,A9,A10,A11,A12,A13)/*C1,C2,C3,C4,C5,C6,C7,C8,C9,C10,C11,C12,C13)*/ values
('Alebrijes', 		NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
('Atlante', 		NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
('Cafetaleros',		NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
('Cimarrones',		NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
('Zacatepec',		NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
('Celaya', 			NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
('Correcaminos',	NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
('Dorados', 		NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
('Loros Colima',	NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
('Mineros',			NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
('Tampico Madero', 	NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
('Potros UAEM', 	NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
('Leones Negros', 	NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
('Venados', 		NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL);

/*Perdidos*/
insert into Pierde(Club, A1,A2,A3,A4,A5,A6,A7,A8,A9,A10,A11,A12,A13)/*C1,C2,C3,C4,C5,C6,C7,C8,C9,C10,C11,C12,C13)*/ values
('Alebrijes', 		NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
('Atlante', 		NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
('Cafetaleros',		NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
('Cimarrones',		NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
('Zacatepec',		NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
('Celaya', 			NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
('Correcaminos',	NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
('Dorados', 		NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
('Loros Colima',	NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
('Mineros',			NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
('Tampico Madero', 	NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
('Potros UAEM', 	NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
('Leones Negros', 	NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
('Venados', 		NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL);

/*Partidos*/
insert into Partidos(Club, A1,A2,A3,A4,A5,A6,A7,A8,A9,A10,A11,A12,A13)/*C1,C2,C3,C4,C5,C6,C7,C8,C9,C10,C11,C12,C13)*/ values
('Alebrijes', 		'0','0','0','0','0','0','0','0','0','0','0','0','0'),
('Atlante', 		'0','0','0','0','0','0','0','0','0','0','0','0','0'),
('Cafetaleros',		'0','0','0','0','0','0','0','0','0','0','0','0','0'),
('Cimarrones',		'0','0','0','0','0','0','0','0','0','0','0','0','0'),
('Zacatepec',		'0','0','0','0','0','0','0','0','0','0','0','0','0'),
('Celaya', 			'0','0','0','0','0','0','0','0','0','0','0','0','0'),
('Correcaminos',	'0','0','0','0','0','0','0','0','0','0','0','0','0'),
('Dorados', 		'0','0','0','0','0','0','0','0','0','0','0','0','0'),
('Loros Colima',	'0','0','0','0','0','0','0','0','0','0','0','0','0'),
('Mineros',			'0','0','0','0','0','0','0','0','0','0','0','0','0'),
('Tampico Madero', 	'0','0','0','0','0','0','0','0','0','0','0','0','0'),
('Potros UAEM', 	'0','0','0','0','0','0','0','0','0','0','0','0','0'),
('Leones Negros', 	'0','0','0','0','0','0','0','0','0','0','0','0','0'),
('Venados', 		'0','0','0','0','0','0','0','0','0','0','0','0','0');

/*Simulacion Tabla*/
drop table if exists tmpGeneral;
create table tmpGeneral like general;
insert into tmpGeneral select *from general;

/*Simulacion GF*/
drop table if exists tmpGF;
create table tmpGF like GF;
insert into tmpGF select *from GF;

/*Simulacion GC*/
drop table if exists tmpGC;
create table tmpGC like GC;
insert into tmpGC select *from GC;

/*Simulacion Gana*/
drop table if exists tmpGana;
create table tmpGana like Gana;
insert into tmpGana select *from Gana;

/*Simulacion Empata*/
drop table if exists tmpEmpate;
create table tmpEmpate like Empate;
insert into tmpEmpate select *from Empate;

/*Simulacion Pierde*/
drop table if exists tmpPierde;
create table tmpPierde like Pierde;
insert into tmpPierde select *from Pierde;

/*Simulacion Partidos*/
drop table if exists tmpPartidos;
create table tmpPartidos like Partidos;
insert into tmpPartidos select *from Partidos;
