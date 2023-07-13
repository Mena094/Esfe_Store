--Creación de la Base de Datos
CREATE DATABASE dbstore
 --Uso de la DB
 USE dbstore
-- Creación de la tabla "Usuarios"
CREATE TABLE Usuarios (
    Id INT PRIMARY KEY IDENTITY (1,3),
    Nombre VARCHAR(50) NOT NULL,
    Apellido VARCHAR(50) NOT NULL,
    CorreoElectronico VARCHAR(60) NOT NULL,
    Contraseña VARCHAR(100) NOT NULL
);

-- Creación de la tabla "Productos"
CREATE TABLE Productos (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(100) NOT NULL,
    Descripcion VARCHAR(500) NULL,
    Precio DECIMAL(10, 2) NOT NULL,
    CantidadDisponible INT NOT NULL
);

-- Creación de la tabla "Pedidos"
CREATE TABLE Pedidos (
    Id INT PRIMARY KEY IDENTITY(1,1),
    IdUsuario INT NOT NULL,
    FechaPedido DATETIME NOT NULL,
    Estado TINYINT NOT NULL,
    Total DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (IdUsuario) REFERENCES Usuarios(Id)
);

-- Creación de la tabla "DetallesPedido"
CREATE TABLE DetallesPedido (
    Id INT PRIMARY KEY IDENTITY(1,1),
    IdPedido INT NOT NULL,
    IdProducto INT NOT NULL,
    Cantidad INT NOT NULL,
    Subtotal DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (IdPedido) REFERENCES Pedidos(Id),
    FOREIGN KEY (IdProducto) REFERENCES Productos(Id)
);

