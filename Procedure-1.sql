Create procedure sp_get_proudtcs
as begin
select * from Products
end

exec  sp_get_proudtcs

Insert Into Products(UnitPrice,CategoryId,Description,Name) Values(56,2,'Ürün güzeldir.','Çikolatalý Bisküvi')

Insert Into Category (Name,Description) Values('Yiyecekler','Yiyecekler kategorisi müthiþtir.')

select * from Products