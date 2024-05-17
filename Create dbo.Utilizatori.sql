USE [MyDB]
GO

/****** Object: Table [dbo].[Utilizatori] Script Date: 5/17/2024 12:32:36 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE TABLE [dbo].[Utilizatori] (
    [Id]           INT          IDENTITY (1, 1) NOT NULL,
    [nume]         VARCHAR (50) NULL,
    [email]        VARCHAR (50) NULL,
    [password]     VARCHAR (3000) NULL,
    [cnp]          VARCHAR (50) NULL,
    [data_nastere] DATETIME     NULL
);


