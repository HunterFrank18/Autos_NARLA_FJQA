use AutosNARLA;

-- . Registrar un cliente nuevo con su primera compra (Cliente + Venta)

BEGIN TRANSACTION;

BEGIN TRY
    -- 1. Insertar el nuevo cliente
    INSERT INTO Cliente (ClienteID, Nombre, Apellido,Correo, Telefono)
    VALUES (101, 'Juan', 'Pérez', 'juan.perez@mail.com', '55512345');

    -- 2. Insertar la venta del cliente
    INSERT INTO Venta (VentaID, AutoID, ClienteID, EmpleadoID, FechaVenta, PrecioFinal)
    VALUES (201, 5, 101, 3, GETDATE(), 50204);

    -- Confirmar transacción si todo salió bien
    COMMIT TRANSACTION;
    PRINT '✅ Cliente registrado y primera venta realizada correctamente.';
END TRY
BEGIN CATCH
    -- Revertir si algo falla
    ROLLBACK TRANSACTION;
    PRINT '❌ Error: Se deshizo la transacción.';
    PRINT ERROR_MESSAGE();
END CATCH;
