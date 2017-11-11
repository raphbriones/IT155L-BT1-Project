create database RestovateDatabase;
use RestovateDatabase;

create table ItemDescript (ItemID int primary key, ProdName varchar(100) not null, ProdType varchar(50) not null, ProdDescript varchar(250) );

insert into ItemDescript values (1001, 'Grilled Pork', 'grill_pork', 'Lorem ipsum blah blah blah');
insert into ItemDescript values (1002, 'Grilled Chicken', 'grill_chicken', 'Lorem ipsum blah blah blah');
insert into ItemDescript values (1003, 'Breaded Pork Steak', 'breaded_porksteak', 'Lorem ipsum blah blah blah');
insert into ItemDescript values (1004, 'Breaded Fish Fillet', 'breaded_fishfillet', 'Lorem ipsum blah blah blah');
insert into ItemDescript values (1005, 'Breaded Pork', 'breaded_pork', 'Lorem ipsum blah blah blah');
insert into ItemDescript values (1006, 'Beef Misono', 'beef_misono', 'Lorem ipsum blah blah blah');
insert into ItemDescript values (1007, 'Pork Katsudon', 'pork_katsudon', 'Lorem ipsum blah blah blah');
insert into ItemDescript values (1008, 'Pork Tonkatsu', 'pork_tonkatsu', 'Lorem ipsum blah blah blah');
insert into ItemDescript values (1009, 'Chicken Teriyaki', 'chicken_teriyaki', 'Lorem ipsum blah blah blah');
insert into ItemDescript values (1010, 'Chicken Yakitori', 'chicken_yakitori', 'Lorem ipsum blah blah blah');
insert into ItemDescript values (1011, 'Kani Tempura', 'kani_tempura', 'Lorem ipsum blah blah blah');
insert into ItemDescript values (1012, 'Ebi Tempura', 'ebi_tempura', 'Lorem ipsum blah blah blah');
insert into ItemDescript values (1013, 'California Maki', 'california_maki', 'Lorem ipsum blah blah blah');

select * from ItemDescript;

drop table ItemDescript;

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
create table Account (AccountId int primary key Identity(1000,10000), FirstName varchar(100) not null, LastName varchar(100) not null, 
MobileNumber varchar(100) not null, Email varchar(100) not null, Password varchar(100) not null);

insert into Account values ('Hello','World','09980000000','email', 'pass');

select * from Account;

drop table Account;

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
create table Login (LoginID int primary key Identity (1000,10000), Email varchar(100) not null, Password varchar(100) not null);

insert into Login values ('email', 'pass');

select * from Login;

drop table Login;






