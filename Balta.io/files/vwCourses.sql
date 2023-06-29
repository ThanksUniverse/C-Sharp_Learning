create or alter view vwCourses as
select top 100
     [Course].[Id],
     [Course].[Tag],
     [Course].[Title],
     [Course].[Url],
     [Course].[Summary],
     [Course].[CreateDate],
     [Category].[Title] as [Category],
     [Author].[Name] as [Author]
from
    [Course]
    inner join [Category] on [Course].[CategoryId] = [Category].[Id]
    inner join [Author] on [Course].[AuthorId] = [Author].[Id]
where 
    [Active] = 1