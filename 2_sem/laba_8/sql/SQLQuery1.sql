create database AIR;
use AIR;
drop table Airplane
drop table Ekipash
drop table Airport

use AIR;
create table Airplane(
id int primary key,
[type] varchar(20),
model varchar(20),
freePlace int,
dataCreate varchar(40),
maxWeight int,
dateLastOsm varchar(40),
img varchar(100)
)
create table Ekipash(
	FIO varchar(30) primary key,
	workr_as varchar(15),
	Age int,
	YearOfWork int
)

create table Airport(
	id int primary key,
	airplane int foreign key references Airplane (id),
	peopleWork varchar(30) foreign key references Ekipash (FIO)
)

insert Airplane(id,type,model,freePlace,dataCreate,maxWeight,dateLastOsm,img)
values(0,'скоростной','v-444',98,'12-12-2003',2500,'01-04-2023','D:\ООП\2_sem\laba_8\sql\budda_kotokuin.jpg'),
(1,'грузовой','c-149',78,'02-01-2023',3500,'08-04-2023','D:\ООП\2_sem\laba_8\sql\castle_nagoua.jpg'),
(2,'истребитель','ро-994',4,'12-12-2003',500,'26-11-2016','D:\ООП\2_sem\laba_8\sql\geysha-v-kioto.jpg')


insert Ekipash(FIO,workr_as,Age,YearOfWork)
values('Kuprin A.A.','pilot', 29,5),
('Zumber L.A.','styord', 39,19),
('Malinov K.B.','secondPilot', 49,19),
('Jurkov S.N.','styord', 25,5)

insert Airport(id,airplane,peopleWork)
values(0,0,'Kuprin A.A.'),
(1,0,'Zumber L.A.'),
(2,1,'Kuprin A.A.'),
(3,2,'Malinov K.B.'),
(4,1,'Jurkov S.N.'),
(5,2,'Malinov K.B.'),
(6,2,'Jurkov S.N.')


select * from Airplane
order by Airplane.type;

Use AIR;
update Airplane
set img = 'sql\budda_kotokuin.jpg'