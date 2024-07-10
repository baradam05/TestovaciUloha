create database TestDatabase;

use TestDatabase;

-- tabulka "Výrobek"
create table Product(
	id int primary key auto_increment,
    name varchar(100) not null,
    description varchar(250),
    price int not null,
    note varchar(250),
    createdAt datetime default NOW(),
    editedAt datetime
);

-- tabulka "Díl"
create table Part(
	id int primary key auto_increment,
    productId int not null,
    name varchar(100) not null,
    description varchar(250),
    price int not null,
    createdAt datetime default NOW(),
    editedAt datetime
);

-- propojení 1:N
alter table Part add foreign key (productId) references Product (id);

-- nastavení triggeru pro "Upraveno (editedAt)"
create trigger t_editedAt_Product
before update on Product
for each row
set new.editedAt = Now();

create trigger t_editedAt_Part
before update on Part
for each row
set new.editedAt = Now();