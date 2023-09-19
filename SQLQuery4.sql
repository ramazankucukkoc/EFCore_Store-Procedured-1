create procedure st_insert_product
@name nvarchar(50),
@unitPrice decimal(18,2),
@categoryId int,
@description nvarchar(50),
@newId int output
as 
begin
insert into Products(Name,UnitPrice,CategoryId,Description)values(@name,@unitPrice,@categoryId,@description)
set @newId=SCOPE_IDENTITY();
return @newId
end
declare @newId int;
exec st_insert_product 'Bisküvi-2',130,2,'Bisküvi güzel',@newId output
select @newId
