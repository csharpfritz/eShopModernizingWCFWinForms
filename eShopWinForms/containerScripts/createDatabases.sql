USE master;
CREATE DATABASE eShopDatabase;
GO
USE eShopDatabase;

CREATE TABLE CatalogBrand (
    [Id]    INT          NOT NULL,
    [Brand] VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE CatalogItem (
    [Id]              INT          NOT NULL,
    [CatalogTypeId]   INT          NULL,
    [CatalogBrandId]  INT          NULL,
    [AvailableStock]  INT          NOT NULL,
    [Description]     VARCHAR (50) NULL,
    [Name]            VARCHAR (50) NULL,
    [Price]           SMALLMONEY   NULL,
    [PictureFileName] VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE CatalogType (
    [Id]   INT          NOT NULL,
    [Type] VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
