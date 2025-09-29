use AutosNARLA

--Registrar un empleado con una venta (Empleado + Venta)

BEGIN TRANSACTION;

BEGIN TRY
    -- 1. Insertar el nuevo empleado
    INSERT INTO Empleado (EmpleadoID, Nombre, Cargo)  -- Se debe de cambiar el nombre completo del empleado y el ID de este tanto en este campo como en Venta							
    VALUES (81, 'Carlos Gómez', 'Vendedor');          -- Es decir el valor de EmpleadoID de la tabla Empleado es 81 y para que funcione se debe cambiar
	                                                  --  El ID del empleado en la insercion para la tabla Venta Venta

    -- 2. Insertar la venta realizada por el empleado
    INSERT INTO Venta (VentaID, AutoID, ClienteID, EmpleadoID, FechaVenta, PrecioFinal)
    VALUES (401, 6, 12, 81, GETDATE(), 60104);

    -- Confirmar transacción si todo salió bien
    COMMIT TRANSACTION;
    PRINT '✅ Empleado registrado y venta asociada realizada correctamente.';
END TRY
BEGIN CATCH
    -- Revertir si algo falla
    ROLLBACK TRANSACTION;
    PRINT '❌ Error: Se deshizo la transacción.';
    PRINT ERROR_MESSAGE();
END CATCH;
