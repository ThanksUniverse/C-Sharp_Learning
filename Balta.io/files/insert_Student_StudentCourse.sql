select * from [Course] order by CreateDate desc
select * from [Student]
select * from [StudentCourse]

insert into 
    [Student]
values (
    '21930e45-fac9-4116-8604-b5e811e10c1b',
    'Pedro Bertoluchi',
    'thanksuniverse333@outlook.com',
    '12345678901',
    '12345678',
    NULL,
    GetDate()
)

insert into
    [StudentCourse]
values(
    '08317b43-0ff7-41e1-9d9e-736e5980f0d2',
    '21930e45-fac9-4116-8604-b5e811e10c1b',
    50,
    0,
    '2020-01-13 12:35:54',
    GETDATE()
)