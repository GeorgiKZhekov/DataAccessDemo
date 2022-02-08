CREATE PROCEDURE [dbo].[spPeople_Read]
	
AS
begin
	select Id, FirstName, LastName, DateOfBirth
	from dbo.People
end
