create Database Navya

create table Student (

Id int,
Name varchar(20),
Email varchar(50),
Address varchar(100)
)

insert Student(id,Name,Email,Address) values(01,'Navya','navya@gmail.com','Sector-62 Noida')

insert Student(id,Name,Email,Address) values(02,'Abhishek','abhishek@gmail.com','Sector-32 Greater Noida')

insert student(id,Name,Email,Address) values(03,'Raheja','raheja@gmail.com','Sector-62 Noida')

SP_rename 'Student.Zipcode' , 'Pincode'

drop table Student

truncate table Student

select * from Student

Alter table Student 
add Phone int

Delete From Student where id = 01