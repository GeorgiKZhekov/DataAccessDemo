CREATE PROCEDURE [dbo].[spPeople_Create]
	@FirstName NVARCHAR(50),
	@LastName NVARCHAR(50),
	@DateOfBirth DATETIME2(7)
AS
begin
	--Does not return the how many rows were affected. Saves the load for the network
	set nocount on;

	insert into dbo.People(FirstName, LastName, DateOfBirth)
	values(@FirstName, @LastName, @DateOfBirth)
end