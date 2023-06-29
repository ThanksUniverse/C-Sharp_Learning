create or alter procedure [spInsertEmployee](
	@Name nvarchar(50),
	@Email nvarchar(255),
	@Phone nvarchar(11),
	@Gender nvarchar(10),
	@City nvarchar(50),
	@DepartmentId int
)
as
begin transaction
insert into [Employee]
values(@Name, @Email, @Phone, @Gender, @City, @DepartmentId)
commit