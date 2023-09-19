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
exec st_insert_product 'Bisk�vi-2',130,2,'Bisk�vi g�zel',@newId output
select @newId
