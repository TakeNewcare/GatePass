create table appUser(
appuser_pk int identity(1,1) primary key,
username varchar(250) not null,
upass varchar(250) not null,
urole varchar(50) not null,
uenabled tinyint default 1 not null

)

insert into appUser(username, upass, urole) values ('admin', 'pass', 'ADMIN')

create table employee(
employee_pk int identity(1,1) primary key,
ename varchar(250),
hiredate datetime,
contact bigint,
gender varchar(50),
eaddress varchar(350),
city varchar(50),
estate varchar(50),
appuser_fk int not null,
eid varchar(50)
foreign key(appuser_fk) references appUser(appuser_pk)
)


create table visitors(
visitors_pk int identity(1,1) primary key,
vname varchar(250),
contact bigint,
gender varchar(50),
vaddress varchar(350),
uniqueID varchar(50),
visitorID varchar(50)
)




create table pass(
pass_pk int identity(1,1) primary key,
passID varchar(50),
validFrom date,
validTo date,
visitors_fk int not null,
foreign key(visitors_fk) references visitors(visitors_pk)
)

