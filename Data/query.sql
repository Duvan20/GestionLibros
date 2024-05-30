create table Authors(
	Id int primary key auto_increment,
    Name Varchar(125),
    LastName varchar(45),
    Email varchar(125),
    Nationality varchar(125),
    Status ENUM("Eliminado","Activo")
);


DROP TABLE `Authors`;
alter table Books Add COLUMN Authorid; 

create table Editorials(
	Id int primary key auto_increment,
    Name varchar(125),
    Address varchar(125),
    Phone varchar(35),
    Email varchar(125),
    Status ENUM("Eliminado","Activo")
);


DROp Table `Editorials`;

create table Books(
	Id integer auto_increment primary key,
    Title Varchar(225),
    Pages integer(10),
    Language varchar(125),
    PublicationDate date,
    Description VARCHAR(500),
    Status ENUM("Eliminado","Activo"),
    Authorid int,
    Editorialid int
);

ALTER TABLE `Books` ADD FOREIGN KEY (Authorid) REFERENCES Authors(Id);
ALTER TABLE `Books` ADD FOREIGN KEY (Editorialid) REFERENCES Editorials(Id);


DROP Table `Books`;


drop table `Books`;

CREATE TABLE Poll_Authors(
    Id INTEGER AUTO_INCREMENT PRIMARY KEY,
    Type_Objeto VARCHAR(255),
    Status varchar(25),
    Name Varchar(125),
    LastName varchar(45),
    Email varchar(125),
    Nationality varchar(125)
);


INSERT into Authors(Name,LastName,Email,Nationality,Status)VALUES("John","Johnalx","jonny@gmail.com","Colombia","Eliminado");

INSERT into Editorials(Name,Address,Phone,Email,Status)VALUES("Dina","tamariando","3154514214","dina@gmail.com","Activo");


INSERT INTO Books(Title,Pages,Language,PublicationDate,Description,Status,Authorid,Editorialid) VALUES("Dina y codigo Aventuras de amor",100,"spanish","2020-09-12","gjsdfjsd","Activo",1,1);