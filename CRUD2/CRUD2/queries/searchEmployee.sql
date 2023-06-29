create or alter procedure [spSearchEmployee](
	@Id int = 0,
	@Name nvarchar(50) = null,
	@Email nvarchar(100) = null
)
as
begin transaction
select *
from [Employee]
where [Id] = @Id or [Name] like '%' + @Name + '%' or [Email] like '%' + @Email + '%'
commit