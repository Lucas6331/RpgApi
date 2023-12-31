﻿BEGIN TRANSACTION;
GO

ALTER TABLE [TB_ARMAS] ADD [PersonagemId] int NOT NULL DEFAULT 0;
GO

UPDATE [TB_ARMAS] SET [PersonagemId] = 1
WHERE [Id] = 1;
SELECT @@ROWCOUNT;

GO

UPDATE [TB_ARMAS] SET [PersonagemId] = 2
WHERE [Id] = 2;
SELECT @@ROWCOUNT;

GO

UPDATE [TB_ARMAS] SET [PersonagemId] = 3
WHERE [Id] = 3;
SELECT @@ROWCOUNT;

GO

UPDATE [TB_ARMAS] SET [PersonagemId] = 4
WHERE [Id] = 4;
SELECT @@ROWCOUNT;

GO

UPDATE [TB_ARMAS] SET [PersonagemId] = 5
WHERE [Id] = 5;
SELECT @@ROWCOUNT;

GO

UPDATE [TB_ARMAS] SET [PersonagemId] = 6
WHERE [Id] = 6;
SELECT @@ROWCOUNT;

GO

UPDATE [TB_ARMAS] SET [PersonagemId] = 7
WHERE [Id] = 7;
SELECT @@ROWCOUNT;

GO

UPDATE [TB_USUARIOS] SET [PasswordHash] = 0xC5FECB7DA9A8809B2F2D64C6E91445A2DDA81352C8209494A9F8BE9D25DB37BE3AE5450824005171350E27E789DF93B409BFC3E5A6A8BFB8229F3F512EA5BB83, [PasswordSalt] = 0xA08F0C2FCF57702E5C141C46033F7C23F21F9EE693E8549865016C02DE0FA46DD82271736EF77B7674E000773582F0A687696D7833B4B181E0DA99E050FC45471A56D7F0B5E502F4EC9A12D66C1D8B00C6480C1C6BA8F8C19674427DA5E765C9075FB9BAF9CBCF468A4D420CAB2351D6F40C995656EA9A5DC2926A22A619A1E6
WHERE [Id] = 1;
SELECT @@ROWCOUNT;

GO

CREATE UNIQUE INDEX [IX_TB_ARMAS_PersonagemId] ON [TB_ARMAS] ([PersonagemId]);
GO

ALTER TABLE [TB_ARMAS] ADD CONSTRAINT [FK_TB_ARMAS_TB_PERSONAGENS_PersonagemId] FOREIGN KEY ([PersonagemId]) REFERENCES [TB_PERSONAGENS] ([Id]) ON DELETE CASCADE;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20230927013304_MigracaoUmParaUm', N'7.0.10');
GO

COMMIT;
GO

