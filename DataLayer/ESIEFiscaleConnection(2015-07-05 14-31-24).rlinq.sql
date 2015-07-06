ALTER TABLE [Documento] DROP CONSTRAINT [ref_Documento_Cliente]

go

ALTER TABLE [Documento] DROP CONSTRAINT [ref_Documento_Export]

go

-- Dropping index 'idx_Documento_ClienteId' which is not configured in OpenAccess but exists on the database.
DROP INDEX [idx_Documento_ClienteId] ON [Documento]

go

-- Dropping index 'idx_Documento_ExportId' which is not configured in OpenAccess but exists on the database.
DROP INDEX [idx_Documento_ExportId] ON [Documento]

go

-- add column for field _customer
ALTER TABLE [Documento] ADD [CustomerId] int NULL

go

UPDATE [Documento] SET [CustomerId] = 0

go

ALTER TABLE [Documento] ALTER COLUMN [CustomerId] int NOT NULL

go

-- dropping unknown column [ExportId]
ALTER TABLE [Documento] DROP COLUMN [ExportId]

go

-- dropping unknown column [ClienteId]
ALTER TABLE [Documento] DROP COLUMN [ClienteId]

go

ALTER TABLE [Documento] ADD CONSTRAINT [ref_Documento_Customer] FOREIGN KEY ([CustomerId]) REFERENCES [Customer]([Id])

go

-- Index 'idx_Documento_CustomerId' was not detected in the database. It will be created
CREATE INDEX [idx_Documento_CustomerId] ON [Documento]([CustomerId])

go

