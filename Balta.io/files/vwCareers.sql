create or alter view vwCareers as
select 
    [Career].[Id],
    [Career].[Title],
    [Career].[Url],
    COUNT(([Career].[Id])) as Cursos
    -- Uma forma (Select COUNT([CareerId]) from [CareerItem] where [CareerId] = [Id]) as [Courses]
from
    [Career]
    inner join [CareerItem] on [CareerItem].[CareerId] = [Career].[Id]
group by
    [Career].[Id],
    [Career].[Title],
    [Career].[Url]

