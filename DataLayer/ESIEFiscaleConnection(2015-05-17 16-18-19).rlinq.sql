-- DataLayer.Account
CREATE TABLE [Account] (
    [Username] varchar(max) NULL,           -- _username
    [StudioCommercialeId] int NOT NULL,     -- _studioCommerciale
    [Password] varchar(max) NULL,           -- _password
    [Nickname] varchar(max) NULL,           -- _nickname
    [Id] int IDENTITY NOT NULL,             -- _id
    [AziendaId] int NOT NULL,               -- _azienda
    CONSTRAINT [pk_Account] PRIMARY KEY ([Id])
)
go

-- DataLayer.AnagraficaAzienda
CREATE TABLE [AnagraficaAzienda] (
    [Telefono] varchar(max) NULL,           -- _telefono
    [StudioCommercialeId] int NOT NULL,     -- _studioCommerciale
    [RagioneSociale] varchar(max) NULL,     -- _ragioneSociale
    [Provincia] varchar(max) NULL,          -- _provincia
    [PartitaIVA] varchar(max) NULL,         -- _partitaIVA
    [Indirizzo] varchar(max) NULL,          -- _indirizzo
    [Id] int IDENTITY NOT NULL,             -- _id
    [Fax] varchar(max) NULL,                -- _fax
    [Email] varchar(max) NULL,              -- _email
    [Comune] varchar(max) NULL,             -- _comune
    [CodiceFiscale] varchar(max) NULL,      -- _codiceFiscale
    [Cap] varchar(max) NULL,                -- _cap
    CONSTRAINT [pk_AnagraficaAzienda] PRIMARY KEY ([Id])
)
go

-- DataLayer.Azienda
CREATE TABLE [Azienda] (
    [UltimoAggiornamento] datetime NULL,    -- _ultimoAggiornamento
    [TipoSoftwareFatturazione] varchar(max) NULL, -- _tipoSoftwareFatturazione
    [TipoContabilita] varchar(max) NULL,    -- _tipoContabilita
    [StudioCommercialeId] int NOT NULL,     -- _studioCommerciale
    [MdbFile] varchar(max) NULL,            -- _mdbFile
    [Id] int IDENTITY NOT NULL,             -- _id
    [IDAzienda] varchar(max) NULL,          -- _iDAzienda
    [AnagraficaAziendaId] int NOT NULL,     -- _anagraficaAzienda
    CONSTRAINT [pk_Azienda] PRIMARY KEY ([Id])
)
go

-- DataLayer.Cliente
CREATE TABLE [Cliente] (
    [Id] int IDENTITY NOT NULL,             -- _id
    [IDConto] varchar(max) NULL,            -- _iDConto
    [IDCliente] varchar(max) NULL,          -- _iDCliente
    [AziendaId] int NOT NULL,               -- _azienda
    [AnagraficaAziendaId] int NOT NULL,     -- _anagraficaAzienda
    CONSTRAINT [pk_Cliente] PRIMARY KEY ([Id])
)
go

-- DataLayer.Comunicazione
CREATE TABLE [Comunicazione] (
    [ScadenzaIVA] datetime NULL,            -- _scadenzaIVA
    [Numero] varchar(max) NULL,             -- _numero
    [Id] int IDENTITY NOT NULL,             -- _id
    [ContabilitaId] int NOT NULL,           -- _contabilita
    CONSTRAINT [pk_Comunicazione] PRIMARY KEY ([Id])
)
go

-- DataLayer.Contabilita
CREATE TABLE [Contabilita] (
    [Tipo] varchar(max) NULL,               -- _tipo
    [Id] int IDENTITY NOT NULL,             -- _id
    [AziendaId] int NOT NULL,               -- _azienda
    [Anno] varchar(max) NULL,               -- _anno
    CONSTRAINT [pk_Contabilita] PRIMARY KEY ([Id])
)
go

-- DataLayer.Customer
CREATE TABLE [Customer] (
    [Telefono] varchar(max) NULL,           -- _telefono
    [RagioneSociale] varchar(max) NULL,     -- _ragioneSociale
    [Provincia] varchar(max) NULL,          -- _provincia
    [PartitaIVA] varchar(max) NULL,         -- _partitaIVA
    [Indirizzo] varchar(max) NULL,          -- _indirizzo
    [Id] int IDENTITY NOT NULL,             -- _id
    [IDCliente] varchar(max) NULL,          -- _iDCliente
    [Fax] varchar(max) NULL,                -- _fax
    [ExportId] int NOT NULL,                -- _export
    [Email] varchar(max) NULL,              -- _email
    [Comune] varchar(max) NULL,             -- _comune
    [CodiceFiscale] varchar(max) NULL,      -- _codiceFiscale
    [Cap] varchar(max) NULL,                -- _cap
    CONSTRAINT [pk_Customer] PRIMARY KEY ([Id])
)
go

-- DataLayer.Documento
CREATE TABLE [Documento] (
    [Totale] numeric(20,10) NULL,           -- _totale
    [Tipo] varchar(max) NULL,               -- _tipo
    [Numero] varchar(max) NULL,             -- _numero
    [Imponibile] numeric(20,10) NULL,       -- _imponibile
    [Id] int IDENTITY NOT NULL,             -- _id
    [IVA] numeric(20,10) NULL,              -- _iVA
    [IDRegistroIVA] varchar(max) NULL,      -- _iDRegistroIVA
    [IDMovimento] varchar(max) NULL,        -- _iDMovimento
    [IDIVA] varchar(max) NULL,              -- _iDIVA
    [IDConto] varchar(max) NULL,            -- _iDConto
    [IDCliente] varchar(max) NULL,          -- _iDCliente
    [IDCausale] varchar(max) NULL,          -- _iDCausale
    [ExportId] int NOT NULL,                -- _export
    [DataRegistrazione] datetime NULL,      -- _dataRegistrazione
    [Data] datetime NULL,                   -- _data
    CONSTRAINT [pk_Documento] PRIMARY KEY ([Id])
)
go

-- DataLayer.Export
CREATE TABLE [Export] (
    [XmlFile] varchar(max) NULL,            -- _xmlFile
    [Stato] varchar(max) NULL,              -- _stato
    [Progressivo] varchar(max) NULL,        -- _progressivo
    [Id] int IDENTITY NOT NULL,             -- _id
    [Data] datetime NULL,                   -- _data
    [ComunicazioneId] int NOT NULL,         -- _comunicazione
    CONSTRAINT [pk_Export] PRIMARY KEY ([Id])
)
go

-- DataLayer.Import
CREATE TABLE [Import] (
    [TXTMovimenti] varchar(max) NULL,       -- _tXTMovimenti
    [TXTClienti] varchar(max) NULL,         -- _tXTClienti
    [Stato] varchar(max) NULL,              -- _stato
    [Id] int NOT NULL,                      -- _id
    [Data] datetime NULL,                   -- _data
    CONSTRAINT [pk_Import] PRIMARY KEY ([Id])
)
go

-- DataLayer.StudioCommerciale
CREATE TABLE [StudioCommerciale] (
    [TipoSoftwareContabilita] varchar(max) NULL, -- _tipoSoftwareContabilita
    [Telefono] varchar(max) NULL,           -- _telefono
    [Provincia] varchar(max) NULL,          -- _provincia
    [PartitaIVA] varchar(max) NULL,         -- _partitaIVA
    [Indirizzo] varchar(max) NULL,          -- _indirizzo
    [Id] int IDENTITY NOT NULL,             -- _id
    [Fax] varchar(max) NULL,                -- _fax
    [Email] varchar(max) NULL,              -- _email
    [Denominazione] varchar(max) NULL,      -- _denominazione
    [Comune] varchar(max) NULL,             -- _comune
    [Cap] varchar(max) NULL,                -- _cap
    CONSTRAINT [pk_StudioCommerciale] PRIMARY KEY ([Id])
)
go

CREATE INDEX [idx_Accunt_StudioCommercialeId] ON [Account]([StudioCommercialeId])
go

CREATE INDEX [idx_Account_AziendaId] ON [Account]([AziendaId])
go

CREATE INDEX [idx_AngrfcAznd_StdCmmercialeId] ON [AnagraficaAzienda]([StudioCommercialeId])
go

CREATE INDEX [idx_Azenda_StudioCommercialeId] ON [Azienda]([StudioCommercialeId])
go

CREATE INDEX [idx_Azenda_AnagraficaAziendaId] ON [Azienda]([AnagraficaAziendaId])
go

CREATE INDEX [idx_Cliente_AziendaId] ON [Cliente]([AziendaId])
go

CREATE INDEX [idx_Clente_AnagraficaAziendaId] ON [Cliente]([AnagraficaAziendaId])
go

CREATE INDEX [idx_Cmunicazione_ContabilitaId] ON [Comunicazione]([ContabilitaId])
go

CREATE INDEX [idx_Contabilita_AziendaId] ON [Contabilita]([AziendaId])
go

CREATE INDEX [idx_Customer_ExportId] ON [Customer]([ExportId])
go

CREATE INDEX [idx_Documento_ExportId] ON [Documento]([ExportId])
go

CREATE INDEX [idx_Export_ComunicazioneId] ON [Export]([ComunicazioneId])
go

ALTER TABLE [Account] ADD CONSTRAINT [ref_Account_Azienda] FOREIGN KEY ([AziendaId]) REFERENCES [Azienda]([Id])
go

ALTER TABLE [Account] ADD CONSTRAINT [ref_Account_StudioCommerciale] FOREIGN KEY ([StudioCommercialeId]) REFERENCES [StudioCommerciale]([Id])
go

ALTER TABLE [AnagraficaAzienda] ADD CONSTRAINT [ref_AngrfcAznd_StdCmm_80B22AE8] FOREIGN KEY ([StudioCommercialeId]) REFERENCES [StudioCommerciale]([Id])
go

ALTER TABLE [Azienda] ADD CONSTRAINT [ref_Azienda_AnagraficaAzienda] FOREIGN KEY ([AnagraficaAziendaId]) REFERENCES [AnagraficaAzienda]([Id])
go

ALTER TABLE [Azienda] ADD CONSTRAINT [ref_Azienda_StudioCommerciale] FOREIGN KEY ([StudioCommercialeId]) REFERENCES [StudioCommerciale]([Id])
go

ALTER TABLE [Cliente] ADD CONSTRAINT [ref_Cliente_AnagraficaAzienda] FOREIGN KEY ([AnagraficaAziendaId]) REFERENCES [AnagraficaAzienda]([Id])
go

ALTER TABLE [Cliente] ADD CONSTRAINT [ref_Cliente_Azienda] FOREIGN KEY ([AziendaId]) REFERENCES [Azienda]([Id])
go

ALTER TABLE [Comunicazione] ADD CONSTRAINT [ref_Comunicazione_Contabilita] FOREIGN KEY ([ContabilitaId]) REFERENCES [Contabilita]([Id])
go

ALTER TABLE [Contabilita] ADD CONSTRAINT [ref_Contabilita_Azienda] FOREIGN KEY ([AziendaId]) REFERENCES [Azienda]([Id])
go

ALTER TABLE [Customer] ADD CONSTRAINT [ref_Customer_Export] FOREIGN KEY ([ExportId]) REFERENCES [Export]([Id])
go

ALTER TABLE [Documento] ADD CONSTRAINT [ref_Documento_Export] FOREIGN KEY ([ExportId]) REFERENCES [Export]([Id])
go

ALTER TABLE [Export] ADD CONSTRAINT [ref_Export_Comunicazione] FOREIGN KEY ([ComunicazioneId]) REFERENCES [Comunicazione]([Id])
go

ALTER TABLE [Import] ADD CONSTRAINT [ref_Import_Export] FOREIGN KEY ([Id]) REFERENCES [Export]([Id])
go

