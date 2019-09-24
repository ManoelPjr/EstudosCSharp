﻿DECLARE @CurrentMigration [nvarchar](max)

IF object_id('[dbo].[__MigrationHistory]') IS NOT NULL
    SELECT @CurrentMigration =
        (SELECT TOP (1) 
        [Project1].[MigrationId] AS [MigrationId]
        FROM ( SELECT 
        [Extent1].[MigrationId] AS [MigrationId]
        FROM [dbo].[__MigrationHistory] AS [Extent1]
        WHERE [Extent1].[ContextKey] = N'Vidzy.Migrations.Configuration'
        )  AS [Project1]
        ORDER BY [Project1].[MigrationId] DESC)

IF @CurrentMigration IS NULL
    SET @CurrentMigration = '0'

IF @CurrentMigration < '201906202055042_initialMigration'
BEGIN
    CREATE TABLE [dbo].[Genres] (
        [Id] [int] NOT NULL IDENTITY,
        [Name] [nvarchar](max),
        CONSTRAINT [PK_dbo.Genres] PRIMARY KEY ([Id])
    )
    CREATE TABLE [dbo].[Videos] (
        [Id] [int] NOT NULL IDENTITY,
        [Name] [nvarchar](max),
        [ReleaseDate] [datetime] NOT NULL,
        [Genre_Id] [int],
        CONSTRAINT [PK_dbo.Videos] PRIMARY KEY ([Id])
    )
    CREATE INDEX [IX_Genre_Id] ON [dbo].[Videos]([Genre_Id])
    ALTER TABLE [dbo].[Videos] ADD CONSTRAINT [FK_dbo.Videos_dbo.Genres_Genre_Id] FOREIGN KEY ([Genre_Id]) REFERENCES [dbo].[Genres] ([Id])
    CREATE TABLE [dbo].[__MigrationHistory] (
        [MigrationId] [nvarchar](150) NOT NULL,
        [ContextKey] [nvarchar](300) NOT NULL,
        [Model] [varbinary](max) NOT NULL,
        [ProductVersion] [nvarchar](32) NOT NULL,
        CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY ([MigrationId], [ContextKey])
    )
    INSERT [dbo].[__MigrationHistory]([MigrationId], [ContextKey], [Model], [ProductVersion])
    VALUES (N'201906202055042_initialMigration', N'Vidzy.Migrations.Configuration',  0x1F8B0800000000000400ED59DB6EE336107D2FD07F10F4D416592B9797AD61EF62EB2485D1CD055112F42DA0A5B143942255920AEC2DFA657DE827F5173AD4CD1229DBB2DB4D0BB4586061933367AE9C8BF3C76FBF8FDE2F13E6BD805454F0B17F3238F63DE09188295F8CFD4CCFDFBCF5DFBFFBF28BD1459C2CBDC78AEECCD021275763FF59EB7418042A7A8684A8414223299498EB41249280C422383D3EFE3638390900217CC4F2BCD15DC6354D20FF825F27824790EA8CB02B110353E539DE8439AA774D1250298960EC3FD2F8D3CAF73E304A5078086CEE7B8473A18946D5860F0A422D055F84291E1076BF4A01E9E6842928551EAEC9FB6A7F7C6AB40FD68C155494292D923D014FCE4A770436FB414EF56B77A1C32ED0B17A65ACCE9D36F6BF072ED1725BD270C2A4A12A1D3AC8C98EBCFCCB511D68CC07F3EFC89B644C6712C61C322D093BF26EB319A3D10FB0BA173F011FF38CB1A61EA809DEB50EF0E8568A14A45EDDC1BCD46E1AFB5ED0E60B6CC69AADC153A83EE5FAECD4F7AE51389931A8C3DC3033D442021A079268886F89D620B9C180DC518E744B96F9BF92867985AFC2F7AEC8F223F0857E1EFBF8D1F72EE912E2EAA4D4E081537C44C8A465066D21A3601DA3AD91C35880D81DB99CECFFC8BD42E45C2177C0802838470D2B59E6F33D35B21DE32CAC6BF24217B9AD166AF964113CBF55CF342D2A5D11EBA7F2FE528AE44EB02A538AE3A750643232DA08F7EE9EC805E87EE9F8412911D15C81663E96C2DB965CF0D8DBA24911835A7F8C03E6244D310B51EED8FFC6F14C375EA57D03AFF4441BEF783038B16D6C58E3BE396C3F9A504CB4B5A19F56E733730C4BDDF102B1C9948F50957962EB6F6043D0CD802ADF5B7BBAADBF637E9B3D7742177BE94E8BBD61AB8551654E83A223B1ECB7BF3DBAB5B26B3D837E08553C1B0895A3ECC2D236A9237BEB10AE4787A0981DAA1923D830648CAE489A6275680C1DE589171613C7E44DB87F5F4E0A8C20521DEDB9D6B69684B58E2CC0BA45D1A8E925954A63552133628AC8244E1C322B6137645325AC95936EA8AA1CABC8CDE7C6BB187426C9DA6B97684882253AB709ECD8BA7CF9904718911DBD62225896F04DFD661B7751FD9BFCC5898B300A2CC56D8F048E4BACE4B41DDCCBFDE55BD9DFFDC59BDFDFFD1BF8FE69F76F426875D62650EBE2F5C3D9AE441D31AD6A6C67DCAACB5EC13165D3F24A47F9743DD02B9E054657548D076AB9FBA954F6840355DA5B19AC7731CD0794A932C3563D68F531D46E2A6EB49DDE6293D4B956F718AB978CCABABE7BAB750A7D41E27B68FB0B7A188B7CB8521A92812118843FB309A398DD6B822BC2E91C942EA67A1FB7CC536B4BFEF76CAC815231EBB3B6BEFA5E428D4B776E1EBB26FB2DAB087F21327A26F2AB842CBF6E22FDE545F13FEDAB5EAB598C9F75AFD5AC6B217BB22C77B682298F6139F67FC99986DEF4C7A78AEFC8BB91F84487DEB1F7EB61313F6C1B6BB4A2FD162677663F648DC3440369F28030ACA14A4BACA24E3FBEC5D53CA229612D9DDD16D2277B8DFF6A3CFBE61C52E0262D5B66F511B4AD57D6A8D633DA65FB9E2BA9BB08F4D838372F9C4577C1173133812D9271C3EED5B98C6EDE45BB90BBF7C2CFB8A7B6AC6F2C1F3B3753779DFD3CBBA83B1760C6347E13C7645574B18630A30E87A8952B35CD94CF4595B49646158955CFAE40132C86E483D4744E228DD7112895FF46F64858862417C90CE229BFC9749A69341992196BFDE666527F9BFC7CE16EEB3CBA49F3DFB3FE0E13504D6AEAF90DFF2EA32CAEF5BE74EBF92608F3A6CACE6562A94D075BAC6AA46BC17B0295EEAB4BC13D2429433075C343F20287E8F6A0E0232C48B4AAC6BBCD20BB03D176FBE89C928524892A31D6FCE6EF3C81F943CFBB3F01B2C059E41A1A0000 , N'6.2.0-61023')
END

IF @CurrentMigration < '201906202058509_PopulateGenreTable'
BEGIN
    INSERT INTO Genres VALUES('Action')
    INSERT INTO Genres VALUES('Romance')
    INSERT [dbo].[__MigrationHistory]([MigrationId], [ContextKey], [Model], [ProductVersion])
    VALUES (N'201906202058509_PopulateGenreTable', N'Vidzy.Migrations.Configuration',  0x1F8B0800000000000400ED59DB6EE336107D2FD07F10F4D416592B9797AD61EF62EB2485D1CD055112F42DA0A5B143942255920AEC2DFA657DE827F5173AD4CD1229DBB2DB4D0BB4586061933367AE9C8BF3C76FBF8FDE2F13E6BD805454F0B17F3238F63DE09188295F8CFD4CCFDFBCF5DFBFFBF28BD1459C2CBDC78AEECCD021275763FF59EB7418042A7A8684A8414223299498EB41249280C422383D3EFE3638390900217CC4F2BCD15DC6354D20FF825F27824790EA8CB02B110353E539DE8439AA774D1250298960EC3FD2F8D3CAF73E304A5078086CEE7B8473A18946D5860F0A422D055F84291E1076BF4A01E9E6842928551EAEC9FB6A7F7C6AB40FD68C155494292D923D014FCE4A770436FB414EF56B77A1C32ED0B17A65ACCE9D36F6BF072ED1725BD270C2A4A12A1D3AC8C98EBCFCCB511D68CC07F3EFC89B644C6712C61C322D093BF26EB319A3D10FB0BA173F011FF38CB1A61EA809DEB50EF0E8568A14A45EDDC1BCD46E1AFB5ED0E60B6CC69AADC153A83EE5FAECD4F7AE51389931A8C3DC3033D442021A079268886F89D620B9C180DC518E744B96F9BF92867985AFC2F7AEC8F223F0857E1EFBF8D1F72EE912E2EAA4D4E081537C44C8A465066D21A3601DA3AD91C35880D81DB99CECFFC8BD42E45C2177C0802838470D2B59E6F33D35B21DE32CAC6BF24217B9AD166AF964113CBF55CF342D2A5D11EBA7F2FE528AE44EB02A538AE3A750643232DA08F7EE9EC805E87EE9F8412911D15C81663E96C2DB965CF0D8DBA24911835A7F8C03E6244D310B51EED8FFC6F14C375EA57D03AFF4441BEF783038B16D6C58E3BE396C3F9A504CB4B5A19F56E733730C4BDDF102B1C9948F50957962EB6F6043D0CD802ADF5B7BBAADBF637E9B3D7742177BE94E8BBD61AB8551654E83A223B1ECB7BF3DBAB5B26B3D837E08553C1B0895A3ECC2D236A9237BEB10AE4787A0981DAA1923D830648CAE489A6275680C1DE589171613C7E44DB87F5F4E0A8C20521DEDB9D6B69684B58E2CC0BA45D1A8E925954A63552133628AC8244E1C322B6137645325AC95936EA8AA1CABC8CDE7C6BB187426C9DA6B97684882253AB709ECD8BA7CF9904718911DBD62225896F04DFD661B7751FD9BFCC5898B300A2CC56D8F048E4BACE4B41DDCCBFDE55BD9DFFDC59BDFDFFD1BF8FE69F76F426875D62650EBE2F5C3D9AE441D31AD6A6C67DCAACB5EC13165D3F24A47F9743DD02B9E054657548D076AB9FBA954F6840355DA5B19AC7731CD0794A932C3563D68F531D46E2A6EB49DDE6293D4B956F718AB978CCABABE7BAB750A7D41E27B68FB0B7A188B7CB8521A92812118843FB309A398DD6B822BC2E91C942EA67A1FB7CC536B4BFEF76CAC815231EBB3B6BEFA5E428D4B776E1EBB26FB2DAB087F21327A26F2AB842CBF6E22FDE545F13FEDAB5EAB598C9F75AFD5AC6B217BB22C77B682298F6139F67FC99986DEF4C7A78AEFC8BB91F84487DEB1F7EB61313F6C1B6BB4A2FD162677663F648DC3440369F28030ACA14A4BACA24E3FBEC5D53CA229612D9DDD16D2277B8DFF6A3CFBE61C52E0262D5B66F511B4AD57D6A8D633DA65FB9E2BA9BB08F4D838372F9C4577C1173133812D9271C3EED5B98C6EDE45BB90BBF7C2CFB8A7B6AC6F2C1F3B3753779DFD3CBBA83B1760C6347E13C7645574B18630A30E87A8952B35CD94CF4595B49646158955CFAE40132C86E483D4744E228DD7112895FF46F64858862417C90CE229BFC9749A69341992196BFDE666527F9BFC7CE16EEB3CBA49F3DFB3FE0E13504D6AEAF90DFF2EA32CAEF5BE74EBF92608F3A6CACE6562A94D075BAC6AA46BC17B0295EEAB4BC13D2429433075C343F20287E8F6A0E0232C48B4AAC6BBCD20BB03D176FBE89C928524892A31D6FCE6EF3C81F943CFBB3F01B2C059E41A1A0000 , N'6.2.0-61023')
END

IF @CurrentMigration < '201906202112575_AddClassificationInVideosTable'
BEGIN
    ALTER TABLE [dbo].[Videos] ADD [Classification] [int] NOT NULL DEFAULT 0
    INSERT [dbo].[__MigrationHistory]([MigrationId], [ContextKey], [Model], [ProductVersion])
    VALUES (N'201906202112575_AddClassificationInVideosTable', N'Vidzy.Migrations.Configuration',  0x1F8B0800000000000400ED59DB6EE336107D2FD07F10F4D41659CB4E5EDAC0DEC5D6491646D74910278BBE2D6869EC10A52895A4027B8B7E591FFA49FD850E25EA46CAB69CBDB4408B05161639339CCBE15C98BFFEF873FC6A1333EF0984A4099FF8A3C1D0F780874944F97AE2676AF5E27BFFD5CBAFBF1A5F46F1C67B57D29D693AE4E472E23F2A959E07810C1F21267210D350243259A94198C4018992E07438FC21188D0240113ECAF2BCF15DC6158D21FFC0CF69C243485546D83C898049B38E3B8B5CAA774D6290290961E2BFA3D187ADEFBD6694E0E10B602BDF239C278A2854EDFC41C2428984AF17292E1076BF4D01E9568449302A9FD7E47DB51F9E6AED839AB11415665225F191024767C61D81CDFE2CA7FA95BBD06197E858B5D556E74E9BF86F800BB4DC3EE97CCA84A6320E1DE464275EFE7152051AF1A0FF9D78D38CA94CC08443A6046127DE6DB66434FC09B6F7C92FC0273C63ACA9076A827BAD055CBA15490A426DEF6065B49B45BE17B4F9029BB1626BF014AACFB83A3BF5BD6B3C9C2C1954616E98B9508900340E045110DD12A540702D03724739A75B67E9FFCBD31057782B7C6F4E366F81AFD5E3C4C79FBE77453710952B4683074EF11221931219B40F1907758CF6460E6301C9E1C8E564FF47EE0B44CE3DE40E18100917A8617996FE7D4FF5D98E71FB654D199192AE68683281511D13DCC0DE3A24F99A3CD1754E6B9D619201AA9DEFCA479A9A237214BD37FB572289EF125662B0587EBF4832116A3B1377EF9E8835A8BE40CFE206CC6DE366F28A91759DB30FE1BFCDFF911701C31F81605B844B13A86DF7CE215E8230EA2F28C3F2E97BEF08CBF073E404A345FD266151457BBA9FF65607097D55D19FB9FE2D3CD95C7C2D6512D2DC17CD3C6242DB3EEE9247DE9E38D70034A9688E2EA4293A0DA33AF1BF73D4EF965762A321CFE0AC2D6F38188C6C0B1BD6B8B912DB064528AF1C9647FE62A99761A33A9083CD81018F34F7DBD65F8B5D806A5E17E97B358EDBFA3BE6B7D9732774B11B775AEC0D5B2D19E5BD6C50745C5B3B67EF8F6EA56CAD67D04F4219CF8684D2517641689BD4911BAA10D62D5F50F47C656F18EC680EC77392A6784D1BCDA259F11645A7387DB138BE9F8A0B1941283BDAAA4ADBEA24AC51640DD62E1E8D9A5E5121155603B2243A8D4DA3D821B300BB034DE5612D4CBAA12A315692EBDF8D7B31E80449EDB52B3424C6D29ADB04766C5DBEBC39278C888E1A3F4D5816F35D7DC23EEEA26A37F98B1557C238B014B73D12382EB1C0693BB897FBCD5D39DEFDC59D3FDEFD3BF8FE69F7EF92D0EA889A825A1BFDE5D9DD4153A4BDF7E541D2CE6F1D48293377271ACACD5E21D7C9D8F24D4752763DD00B25858C2EAC680F54E71EA792A934CF54E96865308B46346F7B665237C85503D9C750BB54B9D1762A964D5261ADAA5C56851A9B6A71F88DC3291F0589EFA1ED4FE8612C1D8BAD54100F34C160F12B9B328AE8AE09E684D3154855B4B6FEE970746ABD99FC7BDE2F022923D6E711E38B4FA954BBF4E01C7AE49CD71C4CF91311E12311DFC464F36D53D2473F1BFCA77DD56B508FF0B7FA74837A6EFF9192EA6CD490E14C2D331C493713FFB79CE9DC9BFDFCBEE43BF16E045EF6736FE8FDFE3CF43C6F5A6C14B5E3063A77A678CE98899005A1114518666389D33C752BFBADA03CA429612D9DDD62D4E71E68FF55F2EC9D0B48816B80B7CCEA73D0BEAA5B49B52EE421DB8F1C99DD41A5C744BC7B202EEA14DEADA50E6C01C61DB361E7B0BC7B56EE92DC3DB77EC639BA657D63383A3839BBE3F6E79995DD0E0311D3F85B0B8255D2752D42374D1CC216562A9A195F2525682D8D4A122B9FCD41114CABE4B55074454285DB2160AED46FAFE60DEB325E4234E337994A33852643BC64ADB75C0DFD7DE7E70F026D9DC73769FE9AF9294C4035A9AE0C37FCC78C36DEEAAEDC7CBE4B84BE53A606EA582A5D0BD7DB4AD275C27B0A32EEAB52C13DC4294361F2862FC8133C47B707096F614DC26DD928EE167238106DB78F2F28590B124B23A3E6C74FC470146F5EFE0DC877E52C721C0000 , N'6.2.0-61023')
END

