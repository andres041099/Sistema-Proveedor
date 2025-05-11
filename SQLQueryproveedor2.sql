alter proc ptblproveedor
(
 @ID	varchar	(100)
,@NombredelProducto	varchar	(50)
,@Vendedor	varchar	(50)
,@Telefono	varchar(50)
,@Email	varchar(100)
,@RNC	varchar(100)
,@imagen image
)as 
if not exists (select  id FROM tblproveedor2 where ID=@ID)
BEGIN
INSERT tblproveedor2
(ID,NombredelProducto,Vendedor,Telefono,Email,RNC, imagen )
values
(@ID,@NombredelProducto,@Vendedor,@Telefono,@Email,@RNC,@imagen )
END 