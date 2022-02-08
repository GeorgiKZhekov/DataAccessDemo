CREATE PROCEDURE [dbo].[spPeople_Delete]
	@Id int
AS
begin
	set nocount on;

	delete from dbo.People
	where Id = @Id
end
