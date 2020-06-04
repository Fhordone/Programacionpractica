create table t_contacto (
    id serial primary key,
    FirstName VARCHAR(100),
    LastName VARCHAR(100),
    Agree BOOLEAN,
    Gender VARCHAR(10),
    Country VARCHAR(50),
    Email VARCHAR(100)
);

insert into t_contacto(FirstName,LastName,Agree,Gender,Country,Email)
values('Katia', 'Garcia',true, 'F','PE','kgarcia@usmp.pe');

insert into t_contacto(FirstName,LastName,Agree,Gender,Country,Email)
values('Alvaro', 'Neira',true, 'M','PE','aneira@usmp.pe');

insert into t_contacto(FirstName,LastName,Agree,Gender,Country,Email)
values('Agustin', 'Mego',false, 'M','CO','amego@usmp.pe');

insert into t_contacto(FirstName,LastName,Agree,Gender,Country,Email)
values('Test1', 'Test1',false, 'M','CO','test1@usmp.pe');

insert into t_contacto(FirstName,LastName,Agree,Gender,Country,Email)
values('Test2', 'Test2',false, 'M','CO','test2@usmp.pe');

insert into t_contacto(FirstName,LastName,Agree,Gender,Country,Email)
values('Test3', 'Test3',false, 'M','CO','test3@usmp.pe');

insert into t_contacto(FirstName,LastName,Agree,Gender,Country,Email)
values('Test4', 'Test4',false, 'M','CO','test4@usmp.pe');


insert into t_contacto(FirstName,LastName,Agree,Gender,Country,Email)
values('Test5', 'Test5',false, 'M','CO','test5@usmp.pe');

insert into t_contacto(FirstName,LastName,Agree,Gender,Country,Email)
values('Test6', 'Test6',false, 'M','CO','test6@usmp.pe');

insert into t_contacto(FirstName,LastName,Agree,Gender,Country,Email)
values('Test7', 'Test7',false, 'M','CL','test7@usmp.pe');

insert into t_contacto(FirstName,LastName,Agree,Gender,Country,Email)
values('Test8', 'Test8',false, 'M','CL','test8@usmp.pe');


select * from t_contacto
where country='PE';

select * from t_contacto order by LastName desc, FirstName;

update t_contacto set Agree =false where lastName='Garcia';



SELECT t."id", t."agree", t."country", t."email", t."firstname", t."gender", t."lastname"  
      FROM t_contacto AS t