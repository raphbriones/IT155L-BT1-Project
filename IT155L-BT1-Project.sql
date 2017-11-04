create database RestovateDatabase;
use RestovateDatabase;

create table ItemDescript (ItemID int primary key, ProdName varchar(100) not null, ProdType varchar(50) not null, ProdDescript varchar(250) );

insert into ItemDescript values (1001, 'Grilled Pork', 'grill_pork', 'Lorem ipsum blah blah blah');
insert into ItemDescript values (1002, 'Grilled Chicken', 'grill_chicken', 'Lorem ipsum blah blah blah');
insert into ItemDescript values (1003, 'Breaded Pork Steak', 'breaded_porksteak', 'Lorem ipsum blah blah blah');
insert into ItemDescript values (1004, 'Breaded Fish Fillet', 'breaded_fishfillet', 'Lorem ipsum blah blah blah');
insert into ItemDescript values (1005, 'Breaded Pork', 'breaded_pork', 'Lorem ipsum blah blah blah');

select * from ItemDescript;