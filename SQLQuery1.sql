alter PROCEDURE sp_get_product_full_parameters
@categoryId int
as 
begin 
select p.Id,p.Name,p.UnitPrice,c.Name 'CategoryName',p.Description ,c.Id 'CategoryId' from Category c
join Products p on p.CategoryId=c.Id
where p.CategoryId =@categoryId
end
exec sp_get_product_full_parameters 1