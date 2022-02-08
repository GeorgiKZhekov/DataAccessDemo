CREATE PROCEDURE [dbo].[spPeople_ReadBasedOnSearchTerm]
	@SearchTerm nvarchar(50)
AS
begin
	set nocount on;
	select [Id], [FirstName], [LastName], [DateOfBirth] from dbo.People
	where [FirstName] like '%' + @SearchTerm + '%' or [LastName] like '%' + @SearchTerm + '%'
end
