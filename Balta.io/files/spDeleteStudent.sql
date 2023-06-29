create or alter procedure spDeleteStudent(
    @StudentId UNIQUEIDENTIFIER
)
as
begin TRANSACTION
delete from
    [StudentCourse]
where 
    [StudentId] = @StudentId


delete from
    [Student]
where
    [Id] = @StudentId
commit