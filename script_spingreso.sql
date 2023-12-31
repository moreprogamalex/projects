USE [dbventas]
GO
/****** Object:  StoredProcedure [dbo].[spmostrar_ingreso]    Script Date: 19/1/2022 16:35:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO












ALTER proc [dbo].[spmostrar_ingreso]
as
select top 50 i.idingreso,(t.nombre+ ''+t.apellidos) as Trabajador,i.fecha,i.tipo_comprobante,i.serie,
i.correlativo,i.estado,p.razon_social as [Proveedor],sum(d.stock_inicial*d.precio_compra) as [Total]
from detalle_ingreso d inner join ingreso i
on d.idingreso = i.idingreso
inner join proveedor p
on i.idproveedor = p.idproveedor
inner join trabajador t
on t.idtrabajador = i.idtrabajador
group by
i.idingreso,t.nombre+ ''+t.apellidos,i.fecha,i.tipo_comprobante,i.serie,
i.correlativo,i.estado,p.razon_social
order by i.idingreso desc
go

--Mostrar ingreso entre fechas
create proc buscar_ingresoxfecha
@txtbuscar varchar(20),
@txtbuscar02 varchar(20)
as
select i.idingreso,(t.nombre+ ''+t.apellidos) as Trabajador,i.fecha,i.tipo_comprobante,i.serie,
i.correlativo,i.estado,p.razon_social as [Proveedor],sum(d.stock_inicial*d.precio_compra) as [Total]
from detalle_ingreso d inner join ingreso i
on d.idingreso = i.idingreso
inner join proveedor p
on i.idproveedor = p.idproveedor
inner join trabajador t
on t.idtrabajador = i.idtrabajador
group by
i.idingreso,t.nombre+ ''+t.apellidos,i.fecha,i.tipo_comprobante,i.serie,
i.correlativo,i.estado,p.razon_social
having i.fecha>=@txtbuscar and i.fecha<=@txtbuscar02
go

--Insertar ingresos
alter proc spinsertar_ingreso
@idingreso int=null output,
@idtrabajador int,
@idproveedor int,
@fecha date,
@tipo_comprobante varchar(20),
@serie varchar(10),
@correlativo varchar(10),
@igv decimal(4,2),
@estado varchar(50)
as
insert into ingreso (idtrabajador,idproveedor,fecha,tipo_comprobante,serie,correlativo,igv,estado)
values(@idtrabajador,@idproveedor,@fecha,@tipo_comprobante,@serie,@correlativo,@igv,@estado)
set @idingreso = @@IDENTITY
go

--Anular ingreso
create proc spanular_ingreso
@idingreso int
as
update ingreso set estado = 'ANULADO'
where idingreso = @idingreso
go

--Insertar en el detalle ingreso
alter proc spinsertar_eldetalleingreso
@iddetalleingreso int output,
@idingreso int,
@idarticulo int,
@precio_compra money,
@precio_venta money,
@stock_inicial int,
@stock_actual int,
@fecha_produccion date,
@fecha_vencimiento date
as
insert into detalle_ingreso (idingreso,idarticulo,precio_compra,precio_venta,
stock_inicial,stock_actual,fecha_produccion,fecha_vencimiento)
values(@idingreso,@idarticulo,@precio_compra,@precio_venta,
@stock_inicial,@stock_actual,@fecha_produccion,@fecha_vencimiento)
go

--Mostrar detalle ingreso
alter proc spmostrar_detalleingreso
@txtbuscar int--OBSERVACION
as
select d.idarticulo ,a.nombre as [Articulo],d.precio_compra,d.precio_venta,(d.precio_compra*d.stock_inicial) as [subtotal],
d.stock_inicial,d.stock_actual,d.fecha_produccion,d.fecha_vencimiento
from detalle_ingreso d inner join articulo a
on d.idarticulo = a.idarticulo
where d.idingreso = @txtbuscar
go
