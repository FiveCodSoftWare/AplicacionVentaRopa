
xp_create_subdir 'D:\ProyectoVentas\VentasRopa'
go

xp_create_subdir 'C:\Proyecto2018Ventas\Dasarrollo'
go


--Creacion de base Datos con archivos y grupos 
--La base datos a sido creada en el disco local D.
Create database SistemaVentaRopaTrujillo
  on primary
   (name='SistemaVentasRopa01', FileName='D:\ProyectoVentas\VentasRopa\VentasRopa01.mdf',Maxsize=2GB, size=20MB,filegrowth=10MB),
   (name='SistemaVentasRopa02', FileName='D:\ProyectoVentas\VentasRopa\VentasRopa02.ndf',Maxsize=2GB, size=20MB,filegrowth=10MB),
   FileGroup Ventas
	(name = 'VentasRopa03', filename = 'D:\ProyectoVentas\VentasRopa\VentasRopa03.ndf',Maxsize=1GB, size=20MB,filegrowth=10MB),
	(name = 'VentasRopa04', filename = 'D:\ProyectoVentas\VentasRopa\VentasRopa04.ndf',Maxsize=1GB, size=20MB,filegrowth=10MB),
	FileGroup Finanzas
	(name='FinanzasRopa05', filename = 'C:\Proyecto2018Ventas\Dasarrollo\FinanzasRopa05.ndf',Maxsize=1GB, size=20MB,filegrowth=10MB),
	(Name='FinanzasRopa06', filename = 'C:\Proyecto2018Ventas\Dasarrollo\FinanzasRopa06.ndf',MaxSize = 1GB,Size=40MB,Filegrowth = 20MB),
	FileGroup Costos
	(name='CostosRopa07', filename = 'C:\Proyecto2018Ventas\Dasarrollo\CostosRopa07.ndf',Maxsize=1GB, size=20MB,filegrowth=10MB),
	(Name='CostosRopa08', filename = 'C:\Proyecto2018Ventas\Dasarrollo\CostosRopa08.ndf',MaxSize=1GB,Size=40MB,Filegrowth = 20MB),
	FileGroup Comercial
	(name='ComercialRopa09', filename = 'D:\ProyectoVentas\VentasRopa\ComercialRopa09.ndf',Maxsize=1GB, size=20MB,filegrowth=10MB),
	(Name='ComercialRopa10', filename = 'D:\ProyectoVentas\VentasRopa\ComercialRopa10.ndf',MaxSize=1GB,Size=20MB,Filegrowth = 10MB)
	LOG on
	(name= 'SistemaVentaRopa11', filename ='C:\Proyecto2018Ventas\Dasarrollo\SistemaVentaRopa11.ldf',size=30MB)

Go


use SistemaVentaRopaTrujillo
go



if not exists (select * from sys.schemas where name = 'Personal')
Begin
Execute('Create schema Personal')
End
go

--Creacion del Esquema Reportes

if not exists (select * from sys.schemas where name = 'Reportes')
Begin
Execute('Create schema Reportes')
End
go

--Creacion del Esquema TiendaVentas

if not exists (select * from sys.schemas where name = 'TiendaVentas')
Begin
Execute('Create schema TiendaVentas')
End
go

--------------Visualisar un Esquema--------------
-------------------------------------------------

select * from sys.schemas
go

------------------------------------Creacion de Tipo de Datos Definidos por el Usuario 
Create type Codigo10 from nchar(10) not null
Create type TextoObligatorio50 from nvarchar(50) not null
Create type TextoObigatorio100 from nvarchar(100) not null
Create type CodigoObligatorio15 from nchar(15) not null
Create type Texto100 from nvarchar(100) 
Create type Valores92 from Numeric(9,2) 
Create type Fecha from Date
go

-- Tabla particionada para las tabla Categoria
Create partition function FuncionParticionCategoria (nchar(10))
	as range Right for values ('E','J','M','R')
go


Create partition scheme EsquemaParticionCategoria
	as partition FuncionParticionCategoria
	to (Ventas, Finanzas,  Costos, [Primary] , [Primary])
go

--------------------------------Creacion de la tabla Categoria-------------------
---------------------------------------------------------------------------------

Create table TiendaVentas.Categoria(
		CategoriaCodigo Codigo10,---Datos definidos por el usuario
		CategoriaNombre TextoObligatorio50,--Datos definidos por el usuario
		CategoriaDescripcion TextoObigatorio100,--Datos definidos por el usuario
		CategoriaEstado nchar(1) Constraint CategoriaEsatdoDF default 'A',
				constraint CategoriaPK Primary key(CategoriaCodigo)
) on EsquemaParticionCategoria(CategoriaCodigo)
go




insert into TiendaVentas.Categoria(CategoriaCodigo, CategoriaNombre, CategoriaDescripcion, CategoriaEstado) values
								('CA-00000'  	,'Zapatos',	'zapatos rojos','A'),
								('CA-00001'  ,	'Zapatillas',	'Zapatillas negras','A'),
								('CA-00002'  ,	'Zandallas',	'zanadallas marrones','A')
								go


-----------------Indice particionado por Nombre y Descripcion

Create index CategoriaIDXParticionado on TiendaVentas.Categoria (CategoriaCodigo)
include (CategoriaNombre,CategoriaDescripcion)
on EsquemaParticionCategoria (CategoriaCodigo)
go


select * from TiendaVentas.Categoria
go
---------------------------------Ver la Estructura de la Tabla --------------------
-----------------------------------------------------------------------------------

sp_help[TiendaVentas.Categoria]
go

------------------------------------------------------------------------------------------------------------------------
-----Particion para la Tabla MarcaProducto

Create partition function FuncionParticionMarcaProducto (nchar(10))
	as range Right for values ('E','J','M','R')
go


Create partition scheme EsquemaParticionMarcaProducto
	as partition FuncionParticionMarcaProducto
	to (Ventas, Finanzas,  Costos,Comercial, [Primary])
go


--------------------------------Creacion de la tabla TipoProducto-------------------
------------------------------------------------------------------------------------

Create table TiendaVentas.MarcaProducto(
	MarcaProductoCodigo Codigo10,----Dato definido por el usuario
	MarcaProductoNombre nvarchar(50) ,
	MarcaProductoDescripcion nvarchar(150),
	MarcaProductoEstado nchar(1) Constraint MarcaProductoCodigoEstadoDF default 'A',
				Constraint MarcaProductoPK Primary key(MarcaProductoCodigo)
) on  EsquemaParticionMarcaProducto(MarcaProductoCodigo)
go


------------------------
insert into TiendaVentas.MarcaProducto (MarcaProductoCodigo, MarcaProductoNombre, MarcaProductoDescripcion, MarcaProductoEstado)
										values('MA-00000'  	,'Nike','	marca exportada desde lima','A')
									   
go



-----------------Indice particionado por Nombre y Descripcion

Create index MarcaProductoIDXParticionado on TiendaVentas.MarcaProducto(MarcaProductoCodigo)
include (MarcaProductoNombre,MarcaProductoDescripcion)
on EsquemaParticionMarcaProducto (MarcaProductoCodigo)
go



--------------------------------Creacion de la tabla Productos-------------------
------------------------------------------------------------------------------------


-----Particion para la Tabla Producto
Create partition function FuncionParticionProducto (nchar(10))
	as range Right for values ('E','J','M','R')
go


Create partition scheme EsquemaParticionProducto
	as partition FuncionParticionProducto
	to (Ventas, Finanzas,  Costos, Comercial , Costos)
go


Create table TiendaVentas.Producto(
		ProductoCodigo Codigo10,--Dato definido por el usuario
		ProductoCodigoBarras nvarchar(150),
		ProductoNombre TextoObligatorio50,--Dato definido por el usuario
		ProductoDescripcion nvarchar(150) ,
		ProductoImagen Image Constraint ProductoImagenDF Default 'Sin Imagen',
		ProductoStock Int,  
		ProductoPrecioCompra Numeric(9,2),
		ProductoPrecioVenta Numeric(9,2),
		CategoriaCodigo Codigo10,--Dato definido por el usuario
		MarcaProductoCodigo Codigo10,--Dato definido por el usuario
		ProductoEstado nchar(1) Constraint ProductoEstadoDF default 'A',
constraint CategoriaFK foreign key(CategoriaCodigo) references TiendaVentas.Categoria(CategoriaCodigo),
constraint MarcaProductoFK foreign key(MarcaProductoCodigo) references  TiendaVentas.MarcaProducto(MarcaProductoCodigo),
Constraint ProductoPK primary key(ProductoCodigo)
)on EsquemaParticionProducto(ProductoCodigo)
go


--alter table TiendaVentas.Producto alter column  ProductoStock Int


-----------------Indice particionado por Nombre y Descripcion

Create index ProductoIDXParticionado on TiendaVentas.Producto(ProductoCodigo)
include (ProductoNombre,ProductoDescripcion)
on EsquemaParticionProducto (ProductoCodigo)
go



----------------Visualizar la tabla productos
select * from TiendaVentas.Producto
go
----------------------------------------------


---------------------------Creacion de la Tabla Cliente---------------------------------
----------------------------------------------------------------------------------------
Create table Personal.Cliente(
			ClienteCodigo Codigo10, 
			ClientePaterno TextoObigatorio100,
			ClienteMaterno TextoObigatorio100,
			ClienteNombre TextoObigatorio100,
			ClienteGenero nchar(1),
			ClienteFechaNacimiento Fecha,
			ClienteTipoDocumento nvarchar(20),
			ClienteNumeroDocumento nchar(15),
			ClienteDireccion nvarchar(100) Constraint ClienteDireccionDF Default 'No especificada',
			ClienteTelefono nchar(9) Constraint ClienteTelefonoDF Default 'Sin Telefono',
			ClienteEmail nvarchar(100) Constraint ClienteEmailDF Default 'No especificada',
			ClienteEstado nchar(1) Constraint ClienteEstadDF Default 'A',
			constraint ClienteGeneroCK check (ClienteGenero = 'M' or 
			ClienteGenero = 'F'),
			Constraint ClientePK primary key (ClienteCodigo)
)on [Primary]
go

----------------------------Creacion de la tabla Trabajador-----------------------
-----------------------------------------------------------------------------------

Create table Personal.Trabajador(
TrabajadorCodigo nchar(10),
TrabajadorPaterno nvarchar(100),
TrabajadorMaterno nvarchar(100),
TrabajadorNombre nvarchar(100),
TrabajadorGenero nchar(1) ,
TrabajadorFechaNacimiento Date ,
TrabajadorNumeroDocumento nchar(8),
TrabajadorDireccion nvarchar(150)Constraint TrabajadorDireccionDF Default 'No especificada',
TrabajadorTelefono nchar(9) Constraint TrabajadorTelefonoDF Default 'Sin Numero',
TrabajadorEmail nvarchar(100) Constraint TrabajadorEmailDF Default 'No especificada',
TrabajadorFechaRegistrado fecha,
TrabajadorEstado nchar(1) constraint TrabajadorEstadoDF Default 'A',
constraint TrabajadorGeneroCK check (TrabajadorGenero = 'M' or 
		TrabajadorGenero = 'F'),
Constraint TrabajadorPK Primary key (TrabajadorCodigo)
) on [Primary]
go
insert into Personal.Trabajador(TrabajadorCodigo, TrabajadorPaterno, TrabajadorMaterno, TrabajadorNombre, TrabajadorGenero, TrabajadorFechaNacimiento, TrabajadorNumeroDocumento, TrabajadorDireccion, TrabajadorTelefono, TrabajadorEmail, TrabajadorFechaRegistrado, TrabajadorEstado)
values ('TR-00000'  	,'PRUEBA',	'PR',	'test',	'M',	'2018-07-15',	'12345678',	'av. paujiles' 	,'123456789'	,'fgggg@gmail.com',	'2018-06-10',	'A')

---------------------------Creacion de la Tabla Usuario---------------------------------
----------------------------------------------------------------------------------------

Create table Personal.Usuario(
			UsuarioCodigo nchar(10), 
			TrabajadorCodigo nchar(10),
			UsuarioUserNombre nvarchar(20),
			UsuarioUsuario nvarchar(20),
			UsuarioContraseña nvarchar(20),
			UsuarioEstado nchar(1) constraint UsuarioEstadoDF Default 'A',
			constraint UsuarioPk Primary Key (UsuarioCodigo),
			constraint TrabajadorFK Foreign Key (TrabajadorCodigo) references Personal.Trabajador(TrabajadorCodigo), 
			constraint UsuarioUserNombreUQ Unique (UsuarioUserNombre)
		)
go 

insert into Personal.Usuario(UsuarioCodigo, TrabajadorCodigo, UsuarioUserNombre, UsuarioUsuario,UsuarioContraseña, UsuarioEstado)
values('US-00000','TR-00000', 'Administrador','test','1236','A')
go


--insert into Personal.Usuario(UsuarioCodigo, TrabajadorCodigo, UsuarioUserNombre, UsuarioContraseña, UsuarioUsuario, UsuarioEstado)
--     VALUES()
--GO






-------------
--Alter table Personal.Usuario add UsuarioUsuario nvarchar(20)
--Alter table Personal.Usuario add UsuarioEstado nchar(1) constraint UsuarioEstadoDF Default 'A'

---------------------------Ver la tabla usuarios

select * from Personal.Usuario
go
--------------------------------------------------------------------------------------------

-------------------Creacion de la Tabla Ventas------------------------------------
---------------------------------------------------------------------------------

Create table TiendaVentas.Venta(
			VentaCodigo nchar(10), 
			ClienteCodigo Codigo10, 
			VentaFecha Fecha,
			UsuarioCodigo nchar(10), 
			VentaTipoComprobante nvarchar(100),
			VentaNumeroComprobante nvarchar(50),
			constraint VentaPK Primary Key (VentaCodigo),
			constraint ClienteCodigoFK Foreign Key  (ClienteCodigo) references Personal.Cliente(ClienteCodigo),
			constraint UsuarioFK Foreign Key  (UsuarioCodigo)references Personal.Usuario(UsuarioCodigo) 
		)
go 

--alter table TiendaVentas.Venta add VentaTipoComprobante nvarchar(100)

--alter table TiendaVentas.Venta alter column  VentaNumeroComprobante nvarchar(50)

--Ver los datos de la tabla Ventas

select * from TiendaVentas.Venta

-------------------------------------------------
----------------------------Creacion de la Tabla DetalleVenta------------------------------------
-------------------------------------------------------------------------------------------


Create table TiendaVentas.DetalleVenta
		(   DetalleVentaCodigo nchar(10),
			VentaCodigo nchar(10),
			ProductoCodigo Codigo10, 
			DetalleVentaPrecio Numeric(9,2),
			DetalleVentaCantidad Int,
			DetalleVentaEstado nchar(1) constraint DetalleVentaEstadoDF Default 'A'
			constraint DetalleVentaPK Primary Key (DetalleVentaCodigo),
			constraint VentaFK Foreign Key (VentaCodigo)	references TiendaVentas.Venta(VentaCodigo),
			constraint ProductoFK Foreign Key(ProductoCodigo)references TiendaVentas.Producto(ProductoCodigo)		
		)on Ventas	
go 

--alter table TiendaVentas.DetalleVenta alter column  DetalleVentaCantidad Int


--alter table TiendaVentas.DetalleVenta add DetalleVentaEstado nchar(1) constraint DetalleVentaEstadoDF Default 'A'


--------------------------------------------------------Creacion de Indices para La optimizacion de Busquedas
------------------Indice para Busqueda por Nombre de la categoria

if not exists (Select * from sys.indexes where name = 'NombreCategoriaIDXa')
Begin
create index NombreCategoriaIDXa on TiendaVentas.Categoria(CategoriaNombre asc)
End
go



--------------------Indice para la busqueda de Nombre de producto
if not exists (Select * from sys.indexes where name = 'NombreProdcutoIDXa')
Begin
create index NombreProdcutoIDXa on TiendaVentas.Producto(ProductoNombre asc)
End
go

--------------------Indice para la busqueda de Marca Producto

if not exists (Select * from sys.indexes where name = 'MarcaProductoIDXa')
Begin
create index MarcaProductoIDXa on TiendaVentas.MarcaProducto(MarcaProductoNombre asc)
End
go

--------------------Indice para la busqueda de Cliente

if not exists (Select * from sys.indexes where name = 'ClienteNombreIDXa')
Begin
create index ClienteNombreIDXa on Personal.Cliente(ClienteNombre asc)
End
go


--------------------Indice para la busqueda de un Trabajador
if not exists (Select * from sys.indexes where name = 'TrabajadorNombreIDXa')
Begin
create index TrabajadorNombreIDXa on Personal.Trabajador(TrabajadorNombre asc)
End
go




--------------------------------- PROCEDIMIENTOS ALMACENADOS--------------------------------------
--------------------------------------------------------------------------------------------------

-----------TABLA CATEGORIA-----------------
-------------------------------------------

Create Procedure spMostrarCategoria
as
Select c.CategoriaCodigo as 'Código', c.CategoriaNombre as 'Nombre', c.CategoriaDescripcion as 'Descripción',
		c.CategoriaEstado as 'Estado' from TiendaVentas.Categoria as c where c.CategoriaEstado='A'
order by CategoriaCodigo asc
go

-------------Procedimiento Almacenado para Insertar Categoria


Create Procedure spInsertarCategoria
@CategoriaCodigo Codigo10, 
@CategoriaNombre TextoObligatorio50,
@CategoriaDescripcion TextoObigatorio100,
@CategoriaEstado nchar(1)
as 
Insert into TiendaVentas.Categoria (CategoriaCodigo,CategoriaNombre,CategoriaDescripcion,CategoriaEstado)
values (@CategoriaCodigo,@CategoriaNombre,@CategoriaDescripcion,@CategoriaEstado) 
go


-------------Procedimiento Almacenado para  Modificar Categoria

Create Procedure spModificarCategoria
@CategoriaCodigo Codigo10, 
@CategoriaNombre TextoObligatorio50,
@CategoriaDescripcion TextoObigatorio100,
@CategoriaEstado nchar(1)
as 
update TiendaVentas.Categoria set CategoriaNombre=@CategoriaNombre, CategoriaDescripcion=@CategoriaDescripcion, CategoriaEstado=@CategoriaEstado where CategoriaCodigo=@CategoriaCodigo
go


-------------Procedimiento Almacenado para  Eliminar Categoria
Create procedure spEliminarCategoria
@CategoriaCodigo Codigo10
as 
update  TiendaVentas.Categoria set CategoriaEstado='I' where CategoriaCodigo=@CategoriaCodigo
go


/*Create procedure ultimoCodigo
as
select top 1 CategoriaCodigo from TiendaVentas.Categoria order by CategoriaCodigo desc 
go
*/

------------------------Procedimientos almacenados para Marca Producto

-----------------Mostrar
Create procedure spMostrarMarcaProducto
as 
select tp.MarcaProductoCodigo as 'Código', tp.MarcaProductoNombre as 'Nombre', tp.MarcaProductoDescripcion as 'Descripcion', tp.MarcaProductoEstado as 'Estado' from TiendaVentas.MarcaProducto as tp where tp.MarcaProductoEstado='A'
order by tp.MarcaProductoCodigo asc
go


------------------------Insertar 

Create Procedure spInsertarMarcaProducto
@MarcaProductoCodigo Codigo10,
@MarcaProductoNombre nvarchar(50) ,
@MarcaProductoDescripcion nvarchar(150),
@MarcaProductoEstado nchar(1) 

as 
Insert into TiendaVentas.MarcaProducto(MarcaProductoCodigo,MarcaProductoNombre,MarcaProductoDescripcion,MarcaProductoEstado)
values (@MarcaProductoCodigo,@MarcaProductoNombre,@MarcaProductoDescripcion,@MarcaProductoEstado)
go



----------------Modificar


Create Procedure spModificarMarcaProducto
@MarcaProductoCodigo Codigo10,
@MarcaProductoNombre nvarchar(50) ,
@MarcaProductoDescripcion nvarchar(150),
@MarcaProductoEstado nchar(1) 
as 
update TiendaVentas.MarcaProducto set MarcaProductoNombre=@MarcaProductoNombre, MarcaProductoDescripcion=@MarcaProductoDescripcion, MarcaProductoEstado=@MarcaProductoEstado where MarcaProductoCodigo=@MarcaProductoCodigo
go


------------------Eliminar 

Create procedure spEliminarMarcaProducto
@MarcaProductoCodigo Codigo10
as 
update  TiendaVentas.MarcaProducto set MarcaProductoEstado='I' where MarcaProductoCodigo=@MarcaProductoCodigo
go

-------------Procedimientos almacenados para Producto


Create procedure spMostrarProducto
as 
Select pro.ProductoCodigo as 'Codigo',pro.ProductoCodigoBarras as 'Codigo Barras',pro.ProductoNombre as 'Nombre',pro.ProductoDescripcion as 'Descripcion',
 pro.ProductoImagen as 'Imagen',pro.ProductoStock as 'Stock',pro.ProductoPrecioCompra as 'Precio Compra',pro.ProductoPrecioVenta as 'Precio Venta',
	pro.CategoriaCodigo,ca.CategoriaNombre as 'Nombre_Categoria',pro.MarcaProductoCodigo, m.MarcaProductoNombre as 'Nombre Marca',pro.ProductoEstado as 'Estado'
	from TiendaVentas.Producto  As pro INNER JOIN
                         TiendaVentas.Categoria As ca ON pro.CategoriaCodigo = ca.CategoriaCodigo INNER JOIN
                         TiendaVentas.MarcaProducto As m ON pro.MarcaProductoCodigo = m.MarcaProductoCodigo where pro.ProductoEstado='A' order by pro.ProductoCodigo asc
go


Create procedure spInsertarProducto
	@ProductoCodigo Codigo10,
	@ProductoCodigoBarras nvarchar(150),
	@ProductoNombre TextoObligatorio50,
	@ProductoDescripcion nvarchar(150) ,
	@ProductoImagen Image ,
	@ProductoStock Int,  
	@ProductoPrecioCompra Numeric(9,2),
	@ProductoPrecioVenta Numeric(9,2),
	@CategoriaCodigo Codigo10,
	@MarcaProductoCodigo Codigo10,
	@ProductoEstado nchar(1) 
	as
insert into TiendaVentas.Producto(ProductoCodigo,ProductoCodigoBarras,ProductoNombre,ProductoDescripcion,ProductoImagen,ProductoStock,ProductoPrecioCompra,ProductoPrecioVenta,CategoriaCodigo,MarcaProductoCodigo,ProductoEstado) 
values (@ProductoCodigo,@ProductoCodigoBarras,@ProductoNombre,@ProductoDescripcion,@ProductoImagen,@ProductoStock,@ProductoPrecioCompra,@ProductoPrecioVenta,@CategoriaCodigo,@MarcaProductoCodigo,@ProductoEstado)
go


------------- Editar Producto
Create procedure spEditarProducto
	@ProductoCodigo Codigo10,
	@ProductoCodigoBarras nvarchar(150),
	@ProductoNombre TextoObligatorio50,
	@ProductoDescripcion nvarchar(150) ,
	@ProductoImagen Image ,
	@ProductoStock Int,
	@ProductoPrecioCompra Numeric(9,2),
	@ProductoPrecioVenta Numeric(9,2),
	@CategoriaCodigo Codigo10,
	@MarcaProductoCodigo Codigo10,
	@ProductoEstado nchar(1) 
as
update TiendaVentas.Producto set ProductoCodigoBarras=@ProductoCodigoBarras, ProductoNombre=@ProductoNombre,ProductoDescripcion=@ProductoDescripcion,ProductoImagen=@ProductoImagen,
ProductoStock=@ProductoStock,ProductoPrecioCompra=@ProductoPrecioCompra,ProductoPrecioVenta=@ProductoPrecioVenta,CategoriaCodigo=@CategoriaCodigo,MarcaProductoCodigo=@MarcaProductoCodigo, ProductoEstado=@ProductoEstado where ProductoCodigo=@ProductoCodigo
go


----------------Eliminar Producto

Create procedure spEliminarProducto
@ProductoCodigo Codigo10
as
update  TiendaVentas.Producto set ProductoEstado='I' where ProductoCodigo= @ProductoCodigo
go

-------------------------------------------------------------------------------
----- Procedimientos para la Tabla Clientes 
-------------------------------------------------------------------------------

Create procedure spClientesMostrar
as
Select C.ClienteCodigo as 'Codigo', C.ClientePaterno as 'A. Paterno', C.ClienteMaterno as 'A. Materno' 
,C.ClienteNombre as 'Nombre',C.ClienteGenero as 'Generó',C.ClienteFechaNacimiento as 'Fecha Nacimiento',C.ClienteTipoDocumento 'Tipo Documento',
C.ClienteNumeroDocumento as 'NDocumento',C.ClienteDireccion as 'Dirección', C.ClienteTelefono as 'Telefono',C.ClienteEmail as 'Email', C.ClienteEstado as 'Estado'
 from Personal.Cliente as C where C.ClienteEstado='A' order by C.ClienteCodigo asc
go

---------------Procedimiento para Insertar Cliente 

Create procedure spInsertarCliente 
@ClienteCodigo Codigo10,
@ClientePaterno TextoObigatorio100,
@ClienteMaterno TextoObigatorio100,
@ClienteNombre TextoObigatorio100,
@ClienteGenero nchar(1),
@ClienteFechaNacimiento Fecha,
@ClienteTipoDocumento nvarchar(20),
@ClienteNumeroDocumento nchar(15),
@ClienteDireccion nvarchar(50),
@ClienteTelefono nchar(9),
@ClienteEmail nvarchar(100),
@ClienteEstado nchar(1)
as
insert into Personal.Cliente(ClienteCodigo, ClientePaterno, ClienteMaterno, ClienteNombre,
 ClienteGenero, ClienteFechaNacimiento, ClienteTipoDocumento, ClienteNumeroDocumento,
  ClienteDireccion, ClienteTelefono, ClienteEmail, ClienteEstado)
values(@ClienteCodigo,@ClientePaterno,@ClienteMaterno,@ClienteNombre,@ClienteGenero,@ClienteFechaNacimiento,@ClienteTipoDocumento,@ClienteNumeroDocumento,@ClienteDireccion,@ClienteTelefono,@ClienteEmail,@ClienteEstado)
go

------------Procedimiento para Editar Cliente 

Create procedure spEditarCliente
@ClienteCodigo Codigo10,
@ClientePaterno TextoObigatorio100,
@ClienteMaterno TextoObigatorio100,
@ClienteNombre TextoObigatorio100,
@ClienteGenero nchar(1),
@ClienteFechaNacimiento Fecha,
@ClienteTipoDocumento nvarchar(20),
@ClienteNumeroDocumento nchar(15),
@ClienteDireccion nvarchar(50),
@ClienteTelefono nchar(9),
@ClienteEmail nvarchar(100),
@ClienteEstado nchar(1)
as 
update Personal.Cliente set ClientePaterno=@ClientePaterno,ClienteMaterno=@ClienteMaterno,ClienteNombre=@ClienteNombre
,ClienteGenero=@ClienteGenero,ClienteFechaNacimiento=@ClienteFechaNacimiento,ClienteTipoDocumento=@ClienteTipoDocumento,ClienteNumeroDocumento=@ClienteNumeroDocumento
,ClienteDireccion=@ClienteDireccion,ClienteTelefono=@ClienteTelefono,ClienteEmail=@ClienteEmail,ClienteEstado=@ClienteEstado where ClienteCodigo=@ClienteCodigo
go


------------Procedimiento para Eliminar Cliente 


Create procedure spEliminarCliente
@ClienteCodigo Codigo10
as
update Personal.Cliente set ClienteEstado='I' where ClienteCodigo=@ClienteCodigo
go

--------------------------------------------------------
-------------Procedimientos para la Tabla Trabajador
--------------------------------------------------------

-----------------Procedimento para mostrar Trbajador 
---------------------------------------------------------


Create procedure spMostrarTrabajador
as 
Select T.TrabajadorCodigo as 'Codigo', T.TrabajadorPaterno as 'A. Paterno', T.TrabajadorMaterno as 'A. Materno'
,T.TrabajadorNombre as 'Nombre', T.TrabajadorGenero as 'Genero',T.TrabajadorFechaNacimiento as 'Fecha Nacimiento',
T.TrabajadorNumeroDocumento as 'NDocumento',T.TrabajadorDireccion as 'Direccion', T.TrabajadorTelefono as 'Telefono',
T.TrabajadorEmail as 'Email',T.TrabajadorFechaRegistrado as 'Fecha Registro', T.TrabajadorEstado as 'Estado'
from Personal.Trabajador as T where T.TrabajadorEstado='A' order by T.TrabajadorCodigo
go


----------- Procedimiento para insertar Trabajador
---------------------------------------------------------
Create procedure spInsertarTrabajador
@TrabajadorCodigo nchar(10),
@TrabajadorPaterno nvarchar(100),
@TrabajadorMaterno nvarchar(100),
@TrabajadorNombre nvarchar(100),
@TrabajadorGenero nchar(1) ,
@TrabajadorFechaNacimiento Date ,
@TrabajadorNumeroDocumento nchar(8),
@TrabajadorDireccion nvarchar(150),
@TrabajadorTelefono nchar(9),
@TrabajadorEmail nvarchar(100),
@TrabajadorFechaRegistrado fecha,
@TrabajadorEstado nchar(10)
as 
Insert into Personal.Trabajador(TrabajadorCodigo, 
TrabajadorPaterno, TrabajadorMaterno, TrabajadorNombre, 
TrabajadorGenero, TrabajadorFechaNacimiento, TrabajadorNumeroDocumento, 
TrabajadorDireccion, TrabajadorTelefono, TrabajadorEmail,TrabajadorFechaRegistrado, TrabajadorEstado) 
values(@TrabajadorCodigo,@TrabajadorPaterno,@TrabajadorMaterno,@TrabajadorNombre,@TrabajadorGenero,@TrabajadorFechaNacimiento,
@TrabajadorNumeroDocumento,@TrabajadorDireccion,@TrabajadorTelefono,@TrabajadorEmail,@TrabajadorFechaRegistrado,@TrabajadorEstado)
go

-----------------Procedimeitno para editar un trabajador

Create procedure spEditarTrabajador
@TrabajadorCodigo nchar(10),
@TrabajadorPaterno nvarchar(100),
@TrabajadorMaterno nvarchar(100),
@TrabajadorNombre nvarchar(100),
@TrabajadorGenero nchar(1) ,
@TrabajadorFechaNacimiento Date,
@TrabajadorNumeroDocumento nchar(8),
@TrabajadorDireccion nvarchar(150),
@TrabajadorTelefono nchar(9),
@TrabajadorEmail nvarchar(100),
@TrabajadorFechaRegistrado fecha,
@TrabajadorEstado nchar(10)
as
update Personal.Trabajador set TrabajadorPaterno=@TrabajadorPaterno,TrabajadorMaterno=@TrabajadorMaterno, TrabajadorNombre=@TrabajadorNombre,
TrabajadorGenero=@TrabajadorGenero,TrabajadorFechaNacimiento=@TrabajadorFechaNacimiento,TrabajadorNumeroDocumento=@TrabajadorNumeroDocumento,
TrabajadorDireccion=@TrabajadorDireccion,TrabajadorTelefono=@TrabajadorTelefono,TrabajadorEmail=@TrabajadorEmail,TrabajadorFechaRegistrado=@TrabajadorFechaRegistrado
,TrabajadorEstado=@TrabajadorEstado
where TrabajadorCodigo=@TrabajadorCodigo
go


--------------Procedimiento almacenado para eliminar un Trabajador

Create procedure spEliminarTrabajador
@TrabajadorCodigo nchar(10)
as
update Personal.Trabajador set TrabajadorEstado='I' where TrabajadorCodigo=@TrabajadorCodigo
go

------------------- Procedimientos para Usuario
Create procedure spMostrarUsuario
as
select u.UsuarioCodigo as 'Codigo', u.TrabajadorCodigo as 'Codigo Trabajador', 
u.UsuarioUsuario as 'Nombre',u.UsuarioUserNombre 'Acceso', u.UsuarioContraseña as 'Contraseña',u.UsuarioEstado as 'Estado'
from Personal.Usuario as u inner join Personal.Trabajador as t on u.TrabajadorCodigo=t.TrabajadorCodigo where u.UsuarioEstado='A' order by u.UsuarioCodigo asc
go

Create procedure spUsuarioInsertar
			@UsuarioCodigo nchar(10), 
			@TrabajadorCodigo nchar(10),	
			@UsuarioUserNombre nvarchar(20),
			@UsuarioUsuario nvarchar(20),
			@UsuarioContraseña nvarchar(20),
			@UsuarioEstado nchar(1)	
as
	insert  into Personal.Usuario(UsuarioCodigo,TrabajadorCodigo,UsuarioUserNombre,UsuarioUsuario, UsuarioContraseña,UsuarioEstado)
	VALUES (@UsuarioCodigo, @TrabajadorCodigo,@UsuarioUserNombre,@UsuarioUsuario, @UsuarioContraseña,@UsuarioEstado)
go


------------------Procedimiento para ediatr un Usuario

Create procedure spUsuarioEditar
			@UsuarioCodigo nchar(10), 
			@TrabajadorCodigo nchar(10),	
			@UsuarioUserNombre nvarchar(20),
			@UsuarioUsuario nvarchar(20),
			@UsuarioContraseña nvarchar(20),
			@UsuarioEstado nchar(1)	
			as 
			update Personal.Usuario set TrabajadorCodigo=@TrabajadorCodigo,UsuarioUserNombre=@UsuarioUserNombre,UsuarioUsuario=@UsuarioUsuario,UsuarioContraseña=@UsuarioContraseña
			,UsuarioEstado=@UsuarioEstado where UsuarioCodigo=@UsuarioCodigo

go


Create procedure spUsuarioEliminar
@UsuarioCodigo nchar(10)
as
update Personal.Usuario set UsuarioEstado='I' where UsuarioCodigo=@UsuarioCodigo
go





--------------------------Procedimientos para La tabla Ventas
--------------------Procedimiento para mostrar Venta



Create procedure spMostrarVenta
as
Select V.VentaCodigo as 'Codigo',
	Cli.ClienteCodigo as 'N° Cliente',Cli.ClienteNombre as 'Nombre',Cli.ClienteNumeroDocumento as 'NDocumento',V.VentaFecha as 'Fecha Venta',V.VentaTipoComprobante as 'Tipo Comprobante',V.VentaNumeroComprobante as 'N° Comprobante',
	U.UsuarioCodigo as 'N° Usuario', U.UsuarioUserNombre as 'Usuario'
 from TiendaVentas.Venta as V inner join   Personal.Cliente as Cli on V.ClienteCodigo=Cli.ClienteCodigo  inner join Personal.Usuario as U on V.UsuarioCodigo=U.UsuarioCodigo
 order by V.VentaCodigo  desc 
go

--------------------Procedimiento para Insertar Venta 


Create Procedure spInsertarVenta
	@VentaCodigo nchar(10),
	@ClienteCodigo Codigo10,
	@VentaFecha Date,
	@VentaTipoComprobante nvarchar(100),
	@VentaNumeroComprobante nvarchar(50),
	@UsuarioCodigo nchar(10)
as
Insert into TiendaVentas.Venta(VentaCodigo, ClienteCodigo, VentaFecha,UsuarioCodigo,VentaNumeroComprobante,VentaTipoComprobante)
                        values(@VentaCodigo,@ClienteCodigo,@VentaFecha,@UsuarioCodigo,@VentaNumeroComprobante,@VentaTipoComprobante)
go

--------------------Procedimiento para Editar Venta 

Create procedure spEditarVenta
	@VentaCodigo nchar(10),
	@ClienteCodigo Codigo10,
	@VentaFecha Date,
	@VentaTipoComprobante nvarchar(100),
	@VentaNumeroComprobante nchar(20),
	@UsuarioCodigo nchar(10)
as
update TiendaVentas.Venta set  ClienteCodigo=@ClienteCodigo,VentaFecha=@VentaFecha,VentaNumeroComprobante=@VentaNumeroComprobante,VentaTipoComprobante=@VentaTipoComprobante,UsuarioCodigo=@UsuarioCodigo
where VentaCodigo=@VentaCodigo
go

-----------------Insertar un Detalle en la Venta

Create procedure spInsertarDetalleVenta
			@DetalleVentaCodigo nchar(10),
			@VentaCodigo nchar(10),
			@ProductoCodigo Codigo10, 
			@DetalleVentaPrecio Numeric(9,2),
			@DetalleVentaCantidad Int
as
Insert into TiendaVentas.DetalleVenta(DetalleVentaCodigo,VentaCodigo, ProductoCodigo, DetalleVentaPrecio, DetalleVentaCantidad)values
(@DetalleVentaCodigo,@VentaCodigo,@ProductoCodigo,@DetalleVentaPrecio,@DetalleVentaCantidad)
go


-----------------Eliminar un Detalle en la Venta


Create procedure spEliminarDetalleVenta
@DetalleVentaCodigo nchar(10)
as
delete TiendaVentas.DetalleVenta where  DetalleVentaCodigo=@DetalleVentaCodigo
go


-----------------Mostar  un Detalle en la Venta

Create procedure spMostrarDeatlleVenta
as 
select de.DetalleVentaCodigo as 'Codigo Detalle',de.VentaCodigo as 'Codigo',de.ProductoCodigo as 'Codigo Producto',p.ProductoNombre
as 'Nombre',de.DetalleVentaPrecio as 'Precio',de.DetalleVentaCantidad as 'Cantidad' from TiendaVentas.DetalleVenta as de inner join 
TiendaVentas.Producto as p on de.ProductoCodigo=p.ProductoCodigo
 order by de.DetalleVentaCodigo desc
go



---------------------Aumentar Producto 

Create procedure spAumentarStockProducto
@ProductoCodigo Codigo10,
@ProductoCantidad Int
as 
update TiendaVentas.Producto set ProductoStock =ProductoStock+@ProductoCantidad where ProductoCodigo=@ProductoCodigo 
go


---------------------Disminuir Stock Producto

Create procedure spDisminuirStockProducto
@ProductoCodigo Codigo10,
@ProductoCantidad Int
as 
update TiendaVentas.Producto set ProductoStock =ProductoStock-@ProductoCantidad where ProductoCodigo=@ProductoCodigo
go



----- Procedimiento almacenado para ingresar al sistema
Create procedure spAccederSistemaLogin
@UsuarioNombre nvarchar(30),
@UsuarioPassword nvarchar(40)
as
select U.UsuarioCodigo,U.UsuarioUsuario,U.UsuarioUserNombre from Personal.Usuario 
as U where U.UsuarioUsuario=@UsuarioNombre and U.UsuarioContraseña=@UsuarioPassword and U.UsuarioEstado='A'
go


-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

---De aca en adelante se va a crear los procedimiento para los reportes 
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------
--En esta parte no se usa el Alias por que genera comflicto con la Clase CLS en Visual Studio


Create procedure spGenerarComprobanteVenta(
@VentaCodigo nchar(10)
)
as
select V.VentaCodigo,C.ClienteNombre,C.ClientePaterno,C.ClienteNumeroDocumento,V.VentaFecha,
V.VentaNumeroComprobante, V.VentaTipoComprobante,
P.ProductoNombre,sum(D.DetalleVentaCantidad) as cantidad,
D.DetalleVentaPrecio, sum(D.DetalleVentaCantidad*D.DetalleVentaPrecio) as Total,U.UsuarioCodigo,U.UsuarioUserNombre
from TiendaVentas.Venta as V inner join TiendaVentas.DetalleVenta as D on V.VentaCodigo=D.VentaCodigo inner join TiendaVentas.Producto as P on D.ProductoCodigo=P.ProductoCodigo inner join Personal.Cliente as C on V.ClienteCodigo=C.ClienteCodigo 
inner join Personal.Usuario as U on V.UsuarioCodigo=U.UsuarioCodigo 
where V.VentaCodigo=@VentaCodigo
group by V.VentaCodigo,C.ClienteNombre,C.ClientePaterno,C.ClienteNumeroDocumento,V.VentaFecha,
V.VentaNumeroComprobante, V.VentaTipoComprobante,
P.ProductoNombre,
D.DetalleVentaPrecio ,
U.UsuarioCodigo,U.UsuarioUserNombre
go

----------------------------------------------------------------------------------------------
Create procedure spGenerarListaCliente
@ClienteCodigo nchar(10)
as
Select C.ClienteCodigo,C.ClienteNombre+'  '+C.ClientePaterno+'  '+C.ClienteMaterno as cliente
,C.ClienteGenero,C.ClienteFechaNacimiento,C.ClienteTipoDocumento,
C.ClienteNumeroDocumento,C.ClienteDireccion, C.ClienteTelefono,C.ClienteEmail
 from Personal.Cliente as C where C.ClienteEstado='A' and C.ClienteCodigo=@ClienteCodigo order by C.ClienteCodigo asc
 go

 -------------------------------------------------------------------------
 Create procedure spGenerarListaCategorias
 @CategoriaCodigo nchar(10)
  as
 Select c.CategoriaCodigo, c.CategoriaNombre, c.CategoriaDescripcion
		 from TiendaVentas.Categoria as c where c.CategoriaEstado='A' and c.CategoriaCodigo=@CategoriaCodigo
order by CategoriaCodigo asc
 go


 ------------------------------------------------------------
 Create procedure spGenerarListaMarcas
 @MarcaProductoCodigo nchar(10)
 as

select tp.MarcaProductoCodigo , tp.MarcaProductoNombre, tp.MarcaProductoDescripcion from TiendaVentas.MarcaProducto 
as tp where tp.MarcaProductoEstado='A' and tp.MarcaProductoCodigo=@MarcaProductoCodigo
order by tp.MarcaProductoCodigo asc

 go


 ----------------------------------------------------------
 Create procedure spGenerarListaProductos
 @ProductoCodigo nchar(10)
 as

 Select pro.ProductoCodigo,pro.ProductoCodigoBarras,pro.ProductoNombre,pro.ProductoDescripcion,
 pro.ProductoImagen,pro.ProductoStock,pro.ProductoPrecioCompra,pro.ProductoPrecioVenta,
	pro.CategoriaCodigo,ca.CategoriaNombre,pro.MarcaProductoCodigo, m.MarcaProductoNombre
	from TiendaVentas.Producto  As pro INNER JOIN
                         TiendaVentas.Categoria As ca ON pro.CategoriaCodigo = ca.CategoriaCodigo INNER JOIN
                         TiendaVentas.MarcaProducto As m ON pro.MarcaProductoCodigo = m.MarcaProductoCodigo where pro.ProductoEstado='A' and pro.CategoriaCodigo=@ProductoCodigo  order by pro.ProductoCodigo

 go
 



 ---------------------------------------------------------------------------
 --Sin paramentros
 ---------------------------------------------------------------------------

 Create procedure spVisualizarListaCliente
as
Select C.ClienteCodigo,C.ClienteNombre+'  '+C.ClientePaterno+'  '+C.ClienteMaterno as cliente
,C.ClienteGenero,C.ClienteFechaNacimiento,C.ClienteTipoDocumento,
C.ClienteNumeroDocumento,C.ClienteDireccion, C.ClienteTelefono,C.ClienteEmail
 from Personal.Cliente as C where C.ClienteEstado='A' order by C.ClienteCodigo asc
 go


 -------------------------------------------------------------------------
 Create procedure spVisualizarListaCategorias
  as
 Select c.CategoriaCodigo, c.CategoriaNombre, c.CategoriaDescripcion
		 from TiendaVentas.Categoria as c where c.CategoriaEstado='A'
order by CategoriaCodigo asc
 go


 ------------------------------------------------------------
 Create procedure spVisualizarListaMarcas
 as

select tp.MarcaProductoCodigo , tp.MarcaProductoNombre, tp.MarcaProductoDescripcion from TiendaVentas.MarcaProducto 
as tp where tp.MarcaProductoEstado='A'
order by tp.MarcaProductoCodigo asc

 go


 ----------------------------------------------------------
 Create procedure spVisualizarListaProductos
 as

 Select pro.ProductoCodigo,pro.ProductoCodigoBarras,pro.ProductoNombre,pro.ProductoDescripcion,
 pro.ProductoImagen,pro.ProductoStock,pro.ProductoPrecioCompra,pro.ProductoPrecioVenta,
	pro.CategoriaCodigo,ca.CategoriaNombre,pro.MarcaProductoCodigo, m.MarcaProductoNombre
	from TiendaVentas.Producto  As pro INNER JOIN
                         TiendaVentas.Categoria As ca ON pro.CategoriaCodigo = ca.CategoriaCodigo INNER JOIN
                         TiendaVentas.MarcaProducto As m ON pro.MarcaProductoCodigo = m.MarcaProductoCodigo where pro.ProductoEstado='A'  order by pro.ProductoCodigo

 go



 -------------------------------------------------------------------------

 create procedure spVisualizarListaTrabajadores
 as
select TrabajadorCodigo, TrabajadorPaterno, TrabajadorMaterno,
TrabajadorNombre, TrabajadorGenero, TrabajadorFechaNacimiento, TrabajadorNumeroDocumento, TrabajadorDireccion, TrabajadorTelefono, TrabajadorEmail, 
TrabajadorFechaRegistrado from Personal.Trabajador
where TrabajadorEstado='A'
order by TrabajadorCodigo asc
go


