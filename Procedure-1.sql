Create procedure sp_get_proudtcs
as begin
select * from Products
end

exec  sp_get_proudtcs

Insert Into Products(UnitPrice,CategoryId,Description,Name) Values(56,2,'�r�n g�zeldir.','�ikolatal� Bisk�vi')

Insert Into Category (Name,Description) Values('Yiyecekler','Yiyecekler kategorisi m�thi�tir.')

select * from Products