CREATE PROCEDURE sp_get_product_full
as
begin
select p.Id,p.Name,c.Name 'CategoryName',p.Description,p.UnitPrice from Products p
join Category c on p.CategoryId=c.Id
end

exec sp_get_product_full_Paremeters 1


Create PROCEDURE sp_get_product_full_Paremeters
@categoryId int
as begin
select p.Id,p.Name,p.UnitPrice,c.Name 'CategoryName',p.Description from Products p
join Category c on p.CategoryId=c.Id
where p.CategoryId=@categoryId 
end