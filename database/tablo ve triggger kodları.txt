
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/04/2020 23:08:53
-- Generated from EDMX file: C:\Users\omersoy\Desktop\bilplas-projeee\FormOdev\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [odevFormApp];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_EP_Employee]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EmployeePermits] DROP CONSTRAINT [FK_EP_Employee];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Employee]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Employee];
GO
IF OBJECT_ID(N'[dbo].[EmployeePermits]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EmployeePermits];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Employee'
CREATE TABLE [dbo].[Employee] (
    [EmployeeID] int IDENTITY(1,1) NOT NULL,
    [TC] bigint  NULL,
    [Name] varchar(50)  NULL,
    [Surname] varchar(50)  NULL,
    [BDate] datetime  NULL,
    [WDate] datetime  NULL,
    [KanGrubu] varchar(50)  NULL,
    [Address] varchar(50)  NULL,
    [NetMaas] varchar(50)  NULL,
    [FYolu] varchar(500)  NULL,
    [WCikmaDate] datetime  NULL
);
GO

-- Creating table 'EmployeePermits'
CREATE TABLE [dbo].[EmployeePermits] (
    [PermitID] int IDENTITY(1,1) NOT NULL,
    [EmployeeID] int  NULL,
    [PermitsLeft] int  NULL,
    [SpecialPermitCount] int  NULL,
    [AnnualPermitCount] int  NULL
);
GO

-- Creating table 'LoginUserSet'
CREATE TABLE [dbo].[LoginUserSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [UserName] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL,
    [IsAdmin] bit  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [EmployeeID] in table 'Employee'
ALTER TABLE [dbo].[Employee]
ADD CONSTRAINT [PK_Employee]
    PRIMARY KEY CLUSTERED ([EmployeeID] ASC);
GO

-- Creating primary key on [PermitID] in table 'EmployeePermits'
ALTER TABLE [dbo].[EmployeePermits]
ADD CONSTRAINT [PK_EmployeePermits]
    PRIMARY KEY CLUSTERED ([PermitID] ASC);
GO

-- Creating primary key on [Id] in table 'LoginUserSet'
ALTER TABLE [dbo].[LoginUserSet]
ADD CONSTRAINT [PK_LoginUserSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [EmployeeID] in table 'EmployeePermits'
ALTER TABLE [dbo].[EmployeePermits]
ADD CONSTRAINT [FK_EP_Employee]
    FOREIGN KEY ([EmployeeID])
    REFERENCES [dbo].[Employee]
        ([EmployeeID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EP_Employee'
CREATE INDEX [IX_FK_EP_Employee]
ON [dbo].[EmployeePermits]
    ([EmployeeID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------