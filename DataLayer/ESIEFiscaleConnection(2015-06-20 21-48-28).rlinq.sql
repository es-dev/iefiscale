ALTER TABLE [Account] DROP CONSTRAINT [ref_Account_Azienda]

go

-- Index 'idx_Account_AziendaId' was detected in the database but with a different configuration. It will be recreated
DROP INDEX [idx_Account_AziendaId] ON [Account]

go

-- add column for field _abilitato
ALTER TABLE [Account] ADD [Abilitato] bit NULL

go

-- Column was read from database as: [AziendaId] int not null
-- modify column for field _azienda
ALTER TABLE [Account] ALTER COLUMN [AziendaId] int NULL

go

-- add column for field _creazione
ALTER TABLE [Account] ADD [Creazione] datetime NULL

go

-- add column for field _note
ALTER TABLE [Account] ADD [Note] varchar(max) NULL

go

-- add column for field _ruolo
ALTER TABLE [Account] ADD [Ruolo] varchar(max) NULL

go

-- add column for field _codiceCatastale
ALTER TABLE [AnagraficaAzienda] ADD [CodiceCatastale] varchar(max) NULL

go

-- add column for field _cliente
ALTER TABLE [Customer] ADD [ClienteId] int NULL

go

UPDATE [Customer] SET [ClienteId] = 0

go

ALTER TABLE [Customer] ALTER COLUMN [ClienteId] int NOT NULL

go

-- dropping unknown column [Telefono]
ALTER TABLE [Customer] DROP COLUMN [Telefono]

go

-- dropping unknown column [RagioneSociale]
ALTER TABLE [Customer] DROP COLUMN [RagioneSociale]

go

-- dropping unknown column [Provincia]
ALTER TABLE [Customer] DROP COLUMN [Provincia]

go

-- dropping unknown column [PartitaIVA]
ALTER TABLE [Customer] DROP COLUMN [PartitaIVA]

go

-- dropping unknown column [Indirizzo]
ALTER TABLE [Customer] DROP COLUMN [Indirizzo]

go

-- dropping unknown column [IDCliente]
ALTER TABLE [Customer] DROP COLUMN [IDCliente]

go

-- dropping unknown column [Fax]
ALTER TABLE [Customer] DROP COLUMN [Fax]

go

-- dropping unknown column [Email]
ALTER TABLE [Customer] DROP COLUMN [Email]

go

-- dropping unknown column [Comune]
ALTER TABLE [Customer] DROP COLUMN [Comune]

go

-- dropping unknown column [CodiceFiscale]
ALTER TABLE [Customer] DROP COLUMN [CodiceFiscale]

go

-- dropping unknown column [Cap]
ALTER TABLE [Customer] DROP COLUMN [Cap]

go

-- add column for field _cliente
ALTER TABLE [Documento] ADD [ClienteId] int NULL

go

UPDATE [Documento] SET [ClienteId] = 0

go

ALTER TABLE [Documento] ALTER COLUMN [ClienteId] int NOT NULL

go

-- dropping unknown column [IDConto]
ALTER TABLE [Documento] DROP COLUMN [IDConto]

go

-- dropping unknown column [IDCliente]
ALTER TABLE [Documento] DROP COLUMN [IDCliente]

go

-- add column for field _codiceCatastale
ALTER TABLE [StudioCommerciale] ADD [CodiceCatastale] varchar(max) NULL

go

ALTER TABLE [Account] ADD CONSTRAINT [ref_Account_Azienda] FOREIGN KEY ([AziendaId]) REFERENCES [Azienda]([Id])

go

ALTER TABLE [Customer] ADD CONSTRAINT [ref_Customer_Cliente] FOREIGN KEY ([ClienteId]) REFERENCES [Cliente]([Id])

go

ALTER TABLE [Documento] ADD CONSTRAINT [ref_Documento_Cliente] FOREIGN KEY ([ClienteId]) REFERENCES [Cliente]([Id])

go

-- Index 'idx_Account_AziendaId' was detected in the database but with a different configuration. It will be recreated
CREATE INDEX [idx_Account_AziendaId] ON [Account]([AziendaId])

go

-- Index 'idx_Customer_ClienteId' was not detected in the database. It will be created
CREATE INDEX [idx_Customer_ClienteId] ON [Customer]([ClienteId])

go

-- Index 'idx_Documento_ClienteId' was not detected in the database. It will be created
CREATE INDEX [idx_Documento_ClienteId] ON [Documento]([ClienteId])

go

