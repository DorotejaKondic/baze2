
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/02/2021 21:25:25
-- Generated from EDMX file: C:\Users\Sava\Desktop\2\Dora\Dora\Biblioteka.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [dora];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_OsobaClan]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Clans] DROP CONSTRAINT [FK_OsobaClan];
GO
IF OBJECT_ID(N'[dbo].[FK_ClanClanarina]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Clans] DROP CONSTRAINT [FK_ClanClanarina];
GO
IF OBJECT_ID(N'[dbo].[FK_ClanarinaBibliotekar]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Bibliotekars] DROP CONSTRAINT [FK_ClanarinaBibliotekar];
GO
IF OBJECT_ID(N'[dbo].[FK_BibliotekaBibliotekar]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Bibliotekars] DROP CONSTRAINT [FK_BibliotekaBibliotekar];
GO
IF OBJECT_ID(N'[dbo].[FK_BibliotekaClan_Biblioteka]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BibliotekaClan] DROP CONSTRAINT [FK_BibliotekaClan_Biblioteka];
GO
IF OBJECT_ID(N'[dbo].[FK_BibliotekaClan_Clan]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BibliotekaClan] DROP CONSTRAINT [FK_BibliotekaClan_Clan];
GO
IF OBJECT_ID(N'[dbo].[FK_BibliotekaKnjiga_Biblioteka]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BibliotekaKnjiga] DROP CONSTRAINT [FK_BibliotekaKnjiga_Biblioteka];
GO
IF OBJECT_ID(N'[dbo].[FK_BibliotekaKnjiga_Knjiga]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BibliotekaKnjiga] DROP CONSTRAINT [FK_BibliotekaKnjiga_Knjiga];
GO
IF OBJECT_ID(N'[dbo].[FK_KnjigaIzdanje]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Izdanjes] DROP CONSTRAINT [FK_KnjigaIzdanje];
GO
IF OBJECT_ID(N'[dbo].[FK_IzdanjeIzdavac]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Izdanjes] DROP CONSTRAINT [FK_IzdanjeIzdavac];
GO
IF OBJECT_ID(N'[dbo].[FK_IzdanjePrimerak]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Primeraks] DROP CONSTRAINT [FK_IzdanjePrimerak];
GO
IF OBJECT_ID(N'[dbo].[FK_PrimerakZa_Iznajmljivanje]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Za_Iznajmljivanje] DROP CONSTRAINT [FK_PrimerakZa_Iznajmljivanje];
GO
IF OBJECT_ID(N'[dbo].[FK_PrimerakZa_Prodaju]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Za_Prodaju] DROP CONSTRAINT [FK_PrimerakZa_Prodaju];
GO
IF OBJECT_ID(N'[dbo].[FK_Za_IznajmljivanjeClan]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Clans] DROP CONSTRAINT [FK_Za_IznajmljivanjeClan];
GO
IF OBJECT_ID(N'[dbo].[FK_Za_ProdajuOsoba]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Za_Prodaju] DROP CONSTRAINT [FK_Za_ProdajuOsoba];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Osobas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Osobas];
GO
IF OBJECT_ID(N'[dbo].[Clans]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Clans];
GO
IF OBJECT_ID(N'[dbo].[Clanarinas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Clanarinas];
GO
IF OBJECT_ID(N'[dbo].[Bibliotekars]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Bibliotekars];
GO
IF OBJECT_ID(N'[dbo].[Bibliotekas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Bibliotekas];
GO
IF OBJECT_ID(N'[dbo].[Knjigas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Knjigas];
GO
IF OBJECT_ID(N'[dbo].[Izdanjes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Izdanjes];
GO
IF OBJECT_ID(N'[dbo].[Izdavacs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Izdavacs];
GO
IF OBJECT_ID(N'[dbo].[Primeraks]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Primeraks];
GO
IF OBJECT_ID(N'[dbo].[Za_Iznajmljivanje]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Za_Iznajmljivanje];
GO
IF OBJECT_ID(N'[dbo].[Za_Prodaju]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Za_Prodaju];
GO
IF OBJECT_ID(N'[dbo].[BibliotekaClan]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BibliotekaClan];
GO
IF OBJECT_ID(N'[dbo].[BibliotekaKnjiga]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BibliotekaKnjiga];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Osobas'
CREATE TABLE [dbo].[Osobas] (
    [JMBG] int IDENTITY(1,1) NOT NULL,
    [Ime] nvarchar(max)  NOT NULL,
    [Prezime] nvarchar(max)  NOT NULL,
    [Mejl] nvarchar(max)  NOT NULL,
    [Adresa] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Clans'
CREATE TABLE [dbo].[Clans] (
    [ID_clana] int IDENTITY(1,1) NOT NULL,
    [OsobaJMBG] int  NOT NULL,
    [ClanClanarina_Clan_ID_Clanarine] smallint  NOT NULL,
    [Za_IznajmljivanjeClan_Clan_PrimerakID_Primerka] smallint  NOT NULL
);
GO

-- Creating table 'Clanarinas'
CREATE TABLE [dbo].[Clanarinas] (
    [ID_Clanarine] smallint IDENTITY(1,1) NOT NULL,
    [Cena] int  NOT NULL
);
GO

-- Creating table 'Bibliotekars'
CREATE TABLE [dbo].[Bibliotekars] (
    [ID_Bibliotekara] smallint IDENTITY(1,1) NOT NULL,
    [Ime] nvarchar(max)  NOT NULL,
    [Prezime] nvarchar(max)  NOT NULL,
    [BibliotekaPIB] smallint  NOT NULL,
    [ClanarinaBibliotekar_Bibliotekar_ID_Clanarine] smallint  NULL
);
GO

-- Creating table 'Bibliotekas'
CREATE TABLE [dbo].[Bibliotekas] (
    [PIB] smallint IDENTITY(1,1) NOT NULL,
    [Naziv] nvarchar(max)  NOT NULL,
    [Adresa] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Knjigas'
CREATE TABLE [dbo].[Knjigas] (
    [ID_Knjige] smallint IDENTITY(1,1) NOT NULL,
    [Autor] nvarchar(max)  NOT NULL,
    [Naziv] nvarchar(max)  NOT NULL,
    [Kolicina] int  NOT NULL,
    [Zanr] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Izdanjes'
CREATE TABLE [dbo].[Izdanjes] (
    [Rbr_Izdanja] smallint IDENTITY(1,1) NOT NULL,
    [KnjigaID_Knjige] smallint  NOT NULL,
    [IzdavacID_Izdavaca] smallint  NOT NULL
);
GO

-- Creating table 'Izdavacs'
CREATE TABLE [dbo].[Izdavacs] (
    [ID_Izdavaca] smallint IDENTITY(1,1) NOT NULL,
    [Naziv_Izdavaca] nvarchar(max)  NOT NULL,
    [IzdanjeRbr_Izdanja] smallint  NOT NULL
);
GO

-- Creating table 'Primeraks'
CREATE TABLE [dbo].[Primeraks] (
    [ID_Primerka] smallint IDENTITY(1,1) NOT NULL,
    [IzdanjeRbr_Izdanja] smallint  NOT NULL
);
GO

-- Creating table 'Za_Iznajmljivanje'
CREATE TABLE [dbo].[Za_Iznajmljivanje] (
    [Datum_Iznajmljivanja] nvarchar(max)  NOT NULL,
    [PrimerakID_Primerka] smallint  NOT NULL
);
GO

-- Creating table 'Za_Prodaju'
CREATE TABLE [dbo].[Za_Prodaju] (
    [Cena_Knjige] bigint  NOT NULL,
    [PrimerakID_Primerka] smallint  NOT NULL,
    [Za_ProdajuOsoba_Za_Prodaju_JMBG] int  NOT NULL
);
GO

-- Creating table 'BibliotekaClan'
CREATE TABLE [dbo].[BibliotekaClan] (
    [BibliotekaClan_Clan_PIB] smallint  NOT NULL,
    [Clans_ID_clana] int  NOT NULL
);
GO

-- Creating table 'BibliotekaKnjiga'
CREATE TABLE [dbo].[BibliotekaKnjiga] (
    [Bibliotekas_PIB] smallint  NOT NULL,
    [Knjigas_ID_Knjige] smallint  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [JMBG] in table 'Osobas'
ALTER TABLE [dbo].[Osobas]
ADD CONSTRAINT [PK_Osobas]
    PRIMARY KEY CLUSTERED ([JMBG] ASC);
GO

-- Creating primary key on [ID_clana] in table 'Clans'
ALTER TABLE [dbo].[Clans]
ADD CONSTRAINT [PK_Clans]
    PRIMARY KEY CLUSTERED ([ID_clana] ASC);
GO

-- Creating primary key on [ID_Clanarine] in table 'Clanarinas'
ALTER TABLE [dbo].[Clanarinas]
ADD CONSTRAINT [PK_Clanarinas]
    PRIMARY KEY CLUSTERED ([ID_Clanarine] ASC);
GO

-- Creating primary key on [ID_Bibliotekara] in table 'Bibliotekars'
ALTER TABLE [dbo].[Bibliotekars]
ADD CONSTRAINT [PK_Bibliotekars]
    PRIMARY KEY CLUSTERED ([ID_Bibliotekara] ASC);
GO

-- Creating primary key on [PIB] in table 'Bibliotekas'
ALTER TABLE [dbo].[Bibliotekas]
ADD CONSTRAINT [PK_Bibliotekas]
    PRIMARY KEY CLUSTERED ([PIB] ASC);
GO

-- Creating primary key on [ID_Knjige] in table 'Knjigas'
ALTER TABLE [dbo].[Knjigas]
ADD CONSTRAINT [PK_Knjigas]
    PRIMARY KEY CLUSTERED ([ID_Knjige] ASC);
GO

-- Creating primary key on [Rbr_Izdanja] in table 'Izdanjes'
ALTER TABLE [dbo].[Izdanjes]
ADD CONSTRAINT [PK_Izdanjes]
    PRIMARY KEY CLUSTERED ([Rbr_Izdanja] ASC);
GO

-- Creating primary key on [ID_Izdavaca] in table 'Izdavacs'
ALTER TABLE [dbo].[Izdavacs]
ADD CONSTRAINT [PK_Izdavacs]
    PRIMARY KEY CLUSTERED ([ID_Izdavaca] ASC);
GO

-- Creating primary key on [ID_Primerka] in table 'Primeraks'
ALTER TABLE [dbo].[Primeraks]
ADD CONSTRAINT [PK_Primeraks]
    PRIMARY KEY CLUSTERED ([ID_Primerka] ASC);
GO

-- Creating primary key on [PrimerakID_Primerka] in table 'Za_Iznajmljivanje'
ALTER TABLE [dbo].[Za_Iznajmljivanje]
ADD CONSTRAINT [PK_Za_Iznajmljivanje]
    PRIMARY KEY CLUSTERED ([PrimerakID_Primerka] ASC);
GO

-- Creating primary key on [PrimerakID_Primerka] in table 'Za_Prodaju'
ALTER TABLE [dbo].[Za_Prodaju]
ADD CONSTRAINT [PK_Za_Prodaju]
    PRIMARY KEY CLUSTERED ([PrimerakID_Primerka] ASC);
GO

-- Creating primary key on [BibliotekaClan_Clan_PIB], [Clans_ID_clana] in table 'BibliotekaClan'
ALTER TABLE [dbo].[BibliotekaClan]
ADD CONSTRAINT [PK_BibliotekaClan]
    PRIMARY KEY CLUSTERED ([BibliotekaClan_Clan_PIB], [Clans_ID_clana] ASC);
GO

-- Creating primary key on [Bibliotekas_PIB], [Knjigas_ID_Knjige] in table 'BibliotekaKnjiga'
ALTER TABLE [dbo].[BibliotekaKnjiga]
ADD CONSTRAINT [PK_BibliotekaKnjiga]
    PRIMARY KEY CLUSTERED ([Bibliotekas_PIB], [Knjigas_ID_Knjige] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [OsobaJMBG] in table 'Clans'
ALTER TABLE [dbo].[Clans]
ADD CONSTRAINT [FK_OsobaClan]
    FOREIGN KEY ([OsobaJMBG])
    REFERENCES [dbo].[Osobas]
        ([JMBG])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_OsobaClan'
CREATE INDEX [IX_FK_OsobaClan]
ON [dbo].[Clans]
    ([OsobaJMBG]);
GO

-- Creating foreign key on [ClanClanarina_Clan_ID_Clanarine] in table 'Clans'
ALTER TABLE [dbo].[Clans]
ADD CONSTRAINT [FK_ClanClanarina]
    FOREIGN KEY ([ClanClanarina_Clan_ID_Clanarine])
    REFERENCES [dbo].[Clanarinas]
        ([ID_Clanarine])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClanClanarina'
CREATE INDEX [IX_FK_ClanClanarina]
ON [dbo].[Clans]
    ([ClanClanarina_Clan_ID_Clanarine]);
GO

-- Creating foreign key on [ClanarinaBibliotekar_Bibliotekar_ID_Clanarine] in table 'Bibliotekars'
ALTER TABLE [dbo].[Bibliotekars]
ADD CONSTRAINT [FK_ClanarinaBibliotekar]
    FOREIGN KEY ([ClanarinaBibliotekar_Bibliotekar_ID_Clanarine])
    REFERENCES [dbo].[Clanarinas]
        ([ID_Clanarine])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClanarinaBibliotekar'
CREATE INDEX [IX_FK_ClanarinaBibliotekar]
ON [dbo].[Bibliotekars]
    ([ClanarinaBibliotekar_Bibliotekar_ID_Clanarine]);
GO

-- Creating foreign key on [BibliotekaPIB] in table 'Bibliotekars'
ALTER TABLE [dbo].[Bibliotekars]
ADD CONSTRAINT [FK_BibliotekaBibliotekar]
    FOREIGN KEY ([BibliotekaPIB])
    REFERENCES [dbo].[Bibliotekas]
        ([PIB])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BibliotekaBibliotekar'
CREATE INDEX [IX_FK_BibliotekaBibliotekar]
ON [dbo].[Bibliotekars]
    ([BibliotekaPIB]);
GO

-- Creating foreign key on [BibliotekaClan_Clan_PIB] in table 'BibliotekaClan'
ALTER TABLE [dbo].[BibliotekaClan]
ADD CONSTRAINT [FK_BibliotekaClan_Biblioteka]
    FOREIGN KEY ([BibliotekaClan_Clan_PIB])
    REFERENCES [dbo].[Bibliotekas]
        ([PIB])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Clans_ID_clana] in table 'BibliotekaClan'
ALTER TABLE [dbo].[BibliotekaClan]
ADD CONSTRAINT [FK_BibliotekaClan_Clan]
    FOREIGN KEY ([Clans_ID_clana])
    REFERENCES [dbo].[Clans]
        ([ID_clana])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BibliotekaClan_Clan'
CREATE INDEX [IX_FK_BibliotekaClan_Clan]
ON [dbo].[BibliotekaClan]
    ([Clans_ID_clana]);
GO

-- Creating foreign key on [Bibliotekas_PIB] in table 'BibliotekaKnjiga'
ALTER TABLE [dbo].[BibliotekaKnjiga]
ADD CONSTRAINT [FK_BibliotekaKnjiga_Biblioteka]
    FOREIGN KEY ([Bibliotekas_PIB])
    REFERENCES [dbo].[Bibliotekas]
        ([PIB])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Knjigas_ID_Knjige] in table 'BibliotekaKnjiga'
ALTER TABLE [dbo].[BibliotekaKnjiga]
ADD CONSTRAINT [FK_BibliotekaKnjiga_Knjiga]
    FOREIGN KEY ([Knjigas_ID_Knjige])
    REFERENCES [dbo].[Knjigas]
        ([ID_Knjige])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BibliotekaKnjiga_Knjiga'
CREATE INDEX [IX_FK_BibliotekaKnjiga_Knjiga]
ON [dbo].[BibliotekaKnjiga]
    ([Knjigas_ID_Knjige]);
GO

-- Creating foreign key on [KnjigaID_Knjige] in table 'Izdanjes'
ALTER TABLE [dbo].[Izdanjes]
ADD CONSTRAINT [FK_KnjigaIzdanje]
    FOREIGN KEY ([KnjigaID_Knjige])
    REFERENCES [dbo].[Knjigas]
        ([ID_Knjige])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_KnjigaIzdanje'
CREATE INDEX [IX_FK_KnjigaIzdanje]
ON [dbo].[Izdanjes]
    ([KnjigaID_Knjige]);
GO

-- Creating foreign key on [IzdavacID_Izdavaca] in table 'Izdanjes'
ALTER TABLE [dbo].[Izdanjes]
ADD CONSTRAINT [FK_IzdanjeIzdavac]
    FOREIGN KEY ([IzdavacID_Izdavaca])
    REFERENCES [dbo].[Izdavacs]
        ([ID_Izdavaca])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_IzdanjeIzdavac'
CREATE INDEX [IX_FK_IzdanjeIzdavac]
ON [dbo].[Izdanjes]
    ([IzdavacID_Izdavaca]);
GO

-- Creating foreign key on [IzdanjeRbr_Izdanja] in table 'Primeraks'
ALTER TABLE [dbo].[Primeraks]
ADD CONSTRAINT [FK_IzdanjePrimerak]
    FOREIGN KEY ([IzdanjeRbr_Izdanja])
    REFERENCES [dbo].[Izdanjes]
        ([Rbr_Izdanja])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_IzdanjePrimerak'
CREATE INDEX [IX_FK_IzdanjePrimerak]
ON [dbo].[Primeraks]
    ([IzdanjeRbr_Izdanja]);
GO

-- Creating foreign key on [PrimerakID_Primerka] in table 'Za_Iznajmljivanje'
ALTER TABLE [dbo].[Za_Iznajmljivanje]
ADD CONSTRAINT [FK_PrimerakZa_Iznajmljivanje]
    FOREIGN KEY ([PrimerakID_Primerka])
    REFERENCES [dbo].[Primeraks]
        ([ID_Primerka])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [PrimerakID_Primerka] in table 'Za_Prodaju'
ALTER TABLE [dbo].[Za_Prodaju]
ADD CONSTRAINT [FK_PrimerakZa_Prodaju]
    FOREIGN KEY ([PrimerakID_Primerka])
    REFERENCES [dbo].[Primeraks]
        ([ID_Primerka])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Za_IznajmljivanjeClan_Clan_PrimerakID_Primerka] in table 'Clans'
ALTER TABLE [dbo].[Clans]
ADD CONSTRAINT [FK_Za_IznajmljivanjeClan]
    FOREIGN KEY ([Za_IznajmljivanjeClan_Clan_PrimerakID_Primerka])
    REFERENCES [dbo].[Za_Iznajmljivanje]
        ([PrimerakID_Primerka])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Za_IznajmljivanjeClan'
CREATE INDEX [IX_FK_Za_IznajmljivanjeClan]
ON [dbo].[Clans]
    ([Za_IznajmljivanjeClan_Clan_PrimerakID_Primerka]);
GO

-- Creating foreign key on [Za_ProdajuOsoba_Za_Prodaju_JMBG] in table 'Za_Prodaju'
ALTER TABLE [dbo].[Za_Prodaju]
ADD CONSTRAINT [FK_Za_ProdajuOsoba]
    FOREIGN KEY ([Za_ProdajuOsoba_Za_Prodaju_JMBG])
    REFERENCES [dbo].[Osobas]
        ([JMBG])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Za_ProdajuOsoba'
CREATE INDEX [IX_FK_Za_ProdajuOsoba]
ON [dbo].[Za_Prodaju]
    ([Za_ProdajuOsoba_Za_Prodaju_JMBG]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------