CREATE PROCEDURE [dbo].[spPeople_ReadOne]
	@Id int
AS
begin
	set nocount on;
	select [Id], [FirstName], [LastName], [DateOfBirth] from dbo.People
	where Id = @Id
end
