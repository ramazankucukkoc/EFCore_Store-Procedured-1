USE [EFCoreProd]
GO
/****** Object:  StoredProcedure [dbo].[sp_get_product_full]    Script Date: 18.09.2023 22:10:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[sp_get_product_full]
as
begin
select p.Id,p.Name,c.Name 'CategoryName',p.Description,p.UnitPrice from Products p
join Category c on p.CategoryId=c.Id
end