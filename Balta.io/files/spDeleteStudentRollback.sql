create or alter procedure spDeleteStudentRollback(
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
rollback