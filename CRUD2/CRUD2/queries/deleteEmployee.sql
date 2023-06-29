create or alter procedure [spDeleteEmployee](
	@Id int
)
as
begin transaction
delete
from [Employee]
where [Id] = @Id
commit