
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/21/2019 11:29:02
-- Generated from EDMX file: C:\Users\lsi\source\repos\cinemcass\cinemcass\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [cinema];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[cinemaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[cinemaSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'cinemaSet'
CREATE TABLE [dbo].[cinemaSet] (
    [Idcinema] int IDENTITY(1,1) NOT NULL,
    [header] nvarchar(max)  NOT NULL,
    [col] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Idcinema] in table 'cinemaSet'
ALTER TABLE [dbo].[cinemaSet]
ADD CONSTRAINT [PK_cinemaSet]
    PRIMARY KEY CLUSTERED ([Idcinema] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------