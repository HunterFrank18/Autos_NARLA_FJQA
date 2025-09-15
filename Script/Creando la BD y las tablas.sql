CREATE DATABASE AutosNARLA;
GO

USE AutosNARLA;
GO

CREATE TABLE CategoriaVehiculo (
    CategoriaID INT PRIMARY KEY,
    Nombre NVARCHAR(50) NOT NULL,
    Descripcion NVARCHAR(255)
);

CREATE TABLE Proveedor (
    ProveedorID INT PRIMARY KEY,
    Nombre NVARCHAR(100) NOT NULL,
    Telefono NVARCHAR(20)
);


CREATE TABLE Cliente (
    ClienteID INT PRIMARY KEY,
    Nombre NVARCHAR(50),
    Apellido NVARCHAR(50),
    Correo NVARCHAR(100),
    Telefono NVARCHAR(20)
);

CREATE TABLE Auto (
    AutoID INT PRIMARY KEY,
    Codigo NVARCHAR(20) UNIQUE,
    Marca NVARCHAR(50),
    Modelo NVARCHAR(50),
    AñoFabricacion INT,
    AñoProduccion INT,
    Cilindraje INT,
    TipoVehiculo NVARCHAR(50),
    PrecioCompra FLOAT,
    PrecioVenta FLOAT,
    DescuentoAplicado FLOAT,
    CategoriaID INT,
    ProveedorID INT,
    CONSTRAINT FK_Auto_Categoria FOREIGN KEY (CategoriaID) REFERENCES CategoriaVehiculo(CategoriaID),
    CONSTRAINT FK_Auto_Proveedor FOREIGN KEY (ProveedorID) REFERENCES Proveedor(ProveedorID)
);

CREATE TABLE Empleado (
    EmpleadoID INT PRIMARY KEY,
    Nombre NVARCHAR(50),
    Cargo NVARCHAR(50)
);

CREATE TABLE Venta (
    VentaID INT PRIMARY KEY,
    AutoID INT,
    ClienteID INT,
    EmpleadoID INT,
    FechaVenta DATETIME,
    PrecioFinal FLOAT,
    CONSTRAINT FK_Venta_Auto FOREIGN KEY (AutoID) REFERENCES Auto(AutoID),
    CONSTRAINT FK_Venta_Cliente FOREIGN KEY (ClienteID) REFERENCES Cliente(ClienteID),
    CONSTRAINT FK_Venta_Empleado FOREIGN KEY (EmpleadoID) REFERENCES Empleado(EmpleadoID)
);

CREATE TABLE FotosAuto (
    FotoID INT PRIMARY KEY,
    AutoID INT,
    URLFoto NVARCHAR(255),
    CONSTRAINT FK_FotosAuto_Auto FOREIGN KEY (AutoID) REFERENCES Auto(AutoID)
);
