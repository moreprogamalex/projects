--Procedimientos Almacenados
alter proc spmostrar_venta
as
select top 100 v.Idventa,(c.Nombres +' '+ c.Apellidos) as Cliente,(t.Nombres +' '+ t.Apellidos) as Trabajador,
v.Fecha,v.TipoComprobante,sum((dv.Cantidad*dv.PrecioVenta)-dv.Descuento) as Total
from Detalle_Venta dv inner join Venta v 
on dv.Idventa = v.Idventa
inner join Cliente c
on c.Idcliente = v.Idcliente
inner join Empleado t
on t.IdEmpleado = v.IdEmpleado
group by  v.Idventa,(c.Nombres +' '+ c.Apellidos),(t.Nombres +' '+ t.Apellidos),
v.Fecha,v.TipoComprobante
order by v.Idventa asc
go

create proc spbuscarventa_xfecha
@txt01 varchar(50),
@txt02 varchar(50)
as
select v.Idventa,(c.Nombres +' '+ c.Apellidos) as Cliente,(t.Nombres +' '+ t.Apellidos) as Trabajador,
v.Fecha,v.TipoComprobante,sum((dv.Cantidad*dv.PrecioVenta)-dv.Descuento) as Total
from Detalle_Venta dv inner join Venta v 
on dv.Idventa = v.Idventa
inner join Cliente c
on c.Idcliente = v.Idcliente
inner join Empleado t
on t.IdEmpleado = v.IdEmpleado
group by  v.Idventa,(c.Nombres +' '+ c.Apellidos),(t.Nombres +' '+ t.Apellidos),
v.Fecha,v.TipoComprobante
having v.Fecha>=@txt01 and v.Fecha<=@txt02
go


alter proc spinsertar_venta
@idventa int = null output,
@idcliente int,
@idtrabajador int,
@fecha date,
@tipo_comprobante varchar(20)
as
insert into Venta(Idcliente,IdEmpleado,Fecha,TipoComprobante)
values(@idcliente,@idtrabajador,@fecha,@tipo_comprobante)
set @idventa = @@IDENTITY
go

create proc speliminar_venta
@idventa int
as
delete from Venta
where Idventa = @idventa
go


create proc spinsetar_detalleventa
@iddetalle_venta int = null output,
@iddetalle_compra int,
@idventa int,
@cantidad int,
@precio_venta money,
@descuento money
as
insert into Detalle_Venta(Iddetallecompra,Cantidad,PrecioVenta,Descuento,Idventa)
values(@iddetalle_compra,@cantidad,@precio_venta,@descuento,@idventa)
set @iddetalle_venta = @@IDENTITY
go


--Disparador para restablecer el stock actual de detalle_venta
--Cuando se elimine una venta
create trigger restablecer_stock
on[detalle_venta]
for delete
as
update di set di.StockActual=di.StockActual+dv.Cantidad
from Detalle_Compra as di inner join deleted as dv
on di.Iddetallecompra = dv.Iddetallecompra
go


create proc spdisminuir_stockactual
@iddetalle_ingreso int,
@cantidad int
as
update Detalle_Compra set StockActual = StockActual-@cantidad
where Iddetallecompra=@iddetalle_ingreso
go


create proc spmostrar_detalleventa
@txtbuscar int
as
select dv.Iddetallecompra,a.Nombre as Articulo,dv.Cantidad,dv.PrecioVenta,dv.Descuento,
((dv.Cantidad*dv.PrecioVenta)-dv.Descuento) as Subtotal
from Detalle_Venta dv inner join Detalle_Compra di
on dv.Iddetallecompra = di.Iddetallecompra
inner join articulo a
on di.Idarticulo = a.Idarticulo
where dv.Idventa = @txtbuscar
go


create proc spbuscararticulo_ventaxnombre
@txtarticulo varchar(200)
as
select di.Iddetallecompra,a.Nombre as Articulo,c.Nombre as Categoria,
di.PrecioCompra,di.PrecioVenta,di.StockActual,di.FechaVencimiento
from Articulo a inner join Categoria c
on a.idcategoria = c.idcategoria
inner join Detalle_Compra di
on a.Idarticulo = di.Idarticulo
inner join Compra i
on i.Idcompra = di.Idcompra
where a.Nombre like @txtarticulo + '%'
and di.StockActual>0
and i.Estado <> 'ANULADO'
GO


alter proc spMostrararticulo_vistaventa
as
select di.Iddetallecompra,a.Nombre as Articulo,c.Nombre as Categoria,
di.PrecioCompra,di.PrecioVenta,di.StockActual,di.FechaVencimiento
from Articulo a inner join Categoria c
on a.idcategoria = c.idcategoria
inner join Detalle_Compra di
on a.Idarticulo = di.Idarticulo
inner join Compra i
on i.Idcompra = di.Idcompra
where  i.Estado <> 'ANULADO'
GO

