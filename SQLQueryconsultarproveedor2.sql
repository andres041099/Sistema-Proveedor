create proc pbuscarproveedor (@CODemple varchar (100))as
begin
select * from tblproveedor2
where NombredelProducto like'%'+@CODemple+'%'
end
