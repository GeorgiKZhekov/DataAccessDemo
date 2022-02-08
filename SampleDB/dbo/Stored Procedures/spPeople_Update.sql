CREATE PROCEDURE [dbo].[spPeople_Update]
	@Id int,
	@FirstName nvarchar(50),
	@LastName nvarchar(50),
	@DateOfBirth datetime2(7)
AS
begin
	set nocount on;
	update dbo.People
	set FirstName = @FirstName,
		LastName = @LastName,
		DateOfBirth = @DateOfBirth
	where Id = @Id
end
