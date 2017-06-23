
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/15/2017 20:40:54
-- Generated from EDMX file: e:\mis documentos\visual studio 2013\Projects\Entity\Entity\datos.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [AGENDA];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_GrupoContactosSet]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Contacto] DROP CONSTRAINT [FK_GrupoContactosSet];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Contacto]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Contacto];
GO
IF OBJECT_ID(N'[dbo].[Grupo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Grupo];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Contacto'
CREATE TABLE [dbo].[Contacto] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [Direccion] nvarchar(max)  NOT NULL,
    [Telefono] nvarchar(max)  NOT NULL,
    [Grupo_Id] int  NOT NULL
);
GO

-- Creating table 'Grupo'
CREATE TABLE [dbo].[Grupo] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Descripcion] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Contacto'
ALTER TABLE [dbo].[Contacto]
ADD CONSTRAINT [PK_Contacto]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Grupo'
ALTER TABLE [dbo].[Grupo]
ADD CONSTRAINT [PK_Grupo]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Grupo_Id] in table 'Contacto'
ALTER TABLE [dbo].[Contacto]
ADD CONSTRAINT [FK_GrupoContactosSet]
    FOREIGN KEY ([Grupo_Id])
    REFERENCES [dbo].[Grupo]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_GrupoContactosSet'
CREATE INDEX [IX_FK_GrupoContactosSet]
ON [dbo].[Contacto]
    ([Grupo_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------