-- add column for field _abilitato
ALTER TABLE [Account] ADD [Abilitato] bit NULL

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

