create database Abhishek

select * from EMP_CHE
union all
select * from EMP_HYD

create table EMP_CHE
(
id int identity(3,2),
ename varchar(20),
sal Varchar(30)
)

drop table EMP_CHE

set Identity_insert EMP_CHE on

insert EMP_CHE(id,ename,sal) values(5,'Anamika','7000')