--create or alter view StudentCourses as
create or alter procedure [spStudentProgress] (
    @StudentId uniqueidentifier
)
as
select 
    [Student].[Name],
    [Course].[Title],
    [StudentCourse].[Progress],
    [StudentCourse].[LastUpdateDate]
from
    [StudentCourse]
    inner join [Student] on [StudentCourse].[StudentId] = [Student].[Id]
    inner join [Course] on [StudentCourse].[CourseId] = [Course].[Id]
where
    [StudentCourse].[StudentId] = @StudentId
    AND [StudentCourse].[Progress] < 100
    AND [StudentCourse].[Progress] > 0
order by
    [StudentCourse].[LastUpdateDate]