--1 Mostrar todos los vehículos que se encuentran en stock:
use AutosNARLA

SELECT *
FROM Auto
WHERE Stock > 0;

--2 Obtener info detallada de un vehiculo
SELECT a.*, f.URLFoto
FROM Auto a
LEFT JOIN FotosAuto f ON a.AutoID = f.AutoID
WHERE a.AutoID = 45;  -- reemplaza 15 por el código que quieras

--3 Ingresar nuevos vehiculos para ventas
insert into Auto (AutoID, Codigo, Marca, Modelo, AñoFabricacion, AñoProduccion, Cilindraje, TipoVehiculo, PrecioCompra, PrecioVenta, DescuentoAplicado, CategoriaID, ProveedorID, Stock) 
values (1, 'AUT-51', 'Chevrolet', 'Suburban 2500', 2015, 2015, 2800, 'Challenger', 19641.18, 20786, 0.1, 7, 46, 2);

--4 Mostrar inventario ordenado por Modelo, Marca o Año:

	--Por Modelo
SELECT *
FROM Auto
WHERE Stock > 0
ORDER BY Modelo;

   --Por Marca
SELECT *
FROM Auto
WHERE Stock > 0
ORDER BY Marca;

	--Por Año
SELECT *
FROM Auto
WHERE Stock > 0
ORDER BY AñoFabricacion;


--5 Filtro de busqueda por Modelo y Año
SELECT *
FROM Auto
WHERE Stock > 0
  AND Modelo = 'Avenger'   -- reemplaza por el modelo deseado
  AND AñoFabricacion = 2011;          -- reemplaza por el año deseado

  --6 Filtro por rango de precio y categoria
  SELECT *
FROM Auto
WHERE Stock > 0
  AND PrecioVenta BETWEEN 20000 AND 30000
  AND CategoriaID = 2;   -- reemplaza por la categoría deseada

 --7 Registrar venta y dar de baja de inventario
 -- Registrar venta
INSERT INTO Venta (VentaID, AutoID, ClienteID, EmpleadoID, FechaVenta, PrecioFinal)
VALUES (5, 15, 3, 1, GETDATE(), 25000);

-- Actualizar inventario
UPDATE Auto
SET Stock = Stock - 1
WHERE AutoID = 15;


--8 Aplicar un % de descuento (máx 10%) sobre un monto dado:

-- Ejemplo: descuento 8% en AutoID 15
UPDATE Auto
SET PrecioVenta = PrecioVenta * 0.92  -- 8% de descuento
WHERE AutoID = 15;

select * from Auto where AutoID = 15;

--9 Vehiculo mas antiguo
SELECT TOP 1 *
FROM Auto
WHERE Stock > 0
ORDER BY AñoFabricacion ASC;

--10 Vehiculo de mayor cilindraje en stock
SELECT TOP 1 *
FROM Auto
WHERE Stock > 0
ORDER BY Cilindraje DESC;

--11 Vehiculo con precio mas bajo
SELECT TOP 1 *
FROM Auto
WHERE Stock > 0
ORDER BY PrecioVenta ASC;



