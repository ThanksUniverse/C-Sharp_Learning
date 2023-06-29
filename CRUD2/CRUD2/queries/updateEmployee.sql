create or alter procedure [spUpdateEmployee](
	@Id int,
	@Name nvarchar(50),
	@Email nvarchar(255),
	@Phone nvarchar(11),
	@Gender nvarchar(10),
	@City nvarchar(50),
	@DepartmentId int
)
as
begin transaction
update [Employee]
set [Name] = @Name, [Email] = @Email, [Phone] = @Phone, [Gender] = @Gender, [City] = @City, [DepartmentId] = @DepartmentId
commit