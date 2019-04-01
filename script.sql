USE [SchoolDB]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 01/04/2019 14:27:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__MigrationHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ContextKey] [nvarchar](300) NOT NULL,
	[Model] [varbinary](max) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC,
	[ContextKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Courses]    Script Date: 01/04/2019 14:27:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Courses](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [varchar](40) NULL,
	[TeacherName] [varchar](40) NULL,
	[NumberVacancies] [int] NOT NULL,
	[StartDate] [datetime] NOT NULL,
	[EndDate] [datetime] NOT NULL,
 CONSTRAINT [PK_dbo.Courses] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CourseStudents]    Script Date: 01/04/2019 14:27:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CourseStudents](
	[Student_Id] [uniqueidentifier] NOT NULL,
	[Course_Id] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_dbo.CourseStudents] PRIMARY KEY CLUSTERED 
(
	[Student_Id] ASC,
	[Course_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 01/04/2019 14:27:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[Type] [varchar](8000) NOT NULL,
	[Id] [uniqueidentifier] NOT NULL,
	[UserName] [nvarchar](40) NOT NULL,
	[Password] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_dbo.Login] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 01/04/2019 14:27:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[Id] [uniqueidentifier] NOT NULL,
	[FirstName] [varchar](40) NULL,
	[SurName] [varchar](40) NULL,
	[DOB] [datetime2](7) NOT NULL,
	[Address1] [varchar](100) NULL,
	[Address2] [varchar](100) NULL,
	[Address3] [varchar](100) NULL,
 CONSTRAINT [PK_dbo.Students] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__MigrationHistory] ([MigrationId], [ContextKey], [Model], [ProductVersion]) VALUES (N'201903311528286_InitialDatabase', N'School_Project.Migrations.Configuration', 0x1F8B0800000000000400E55A5F6FDB36107F1FB0EF20E8691B52CB76FAD005768BD4698AA0CD1FC469B1B7809168879B44A92495D918F6C9F6B08FB4AFB0A3FE5014255992ED18DD8A00814DF27EBC3BDE1DEF78FEE7AFBF276F56816F3D61C64948A7F66830B42D4CDDD0237439B563B178F1CA7EF3FAFBEF26EFBC60657DCED71DCB754049F9D47E14223A711CEE3EE200F141405C16F27021066E1838C80B9DF170F8B3331A3918206CC0B2ACC96D4C050970F205BECE42EAE248C4C8BF0C3DECF36C1C66E609AA758502CC23E4E2A90D2361E8DFDFB0F057EC8A01900ABC12B675EA1304DCCCB1BFB02D44692890005E4F3E713C172CA4CB790403C8BF5B4718D62D90CF7126C349B1BCAB38C3B114C72908732837E6220C7A028E8E33FD3826F9565AB695FE4083EF40D3622DA54EB438B56761CCA4E8E65627339FC9651515270804F3414A7964A5F32FB2F9236516603DF2EFC89AC5BE88199E521C0B86FC23EB267EF089FB01AFEFC2DF309DD2D8F77526814D982B0DC010E0479889F52D5E64AC5F78B6E594E91C9350916934A958EF63029FAF606FF4E0636502CE4672F93F07003B02B7B0AD4BB4FA88E9523C4E6DF8685BE76485BD7C2443FD44097811100916B76E7287119C2B3BC85E5771F080D967E422EAC2A1E6FB5D50713CEEAD9DB9404C9C21A1D8969FEF8814A327D23BEA6D8773859EC83231E00A6FB187A900096FB19F2CE08F244A234466CAF7C59A731606B7A1AFFC434DDDCFE1BB2B190BEBE7EF105B6251E66BE2146EB7D11933946DBC3123FDB6DCF19C302E0EE227F3F830FE7876FD7667E739F53C86391F3D3BB3D946E3436D74BCFF8D1AE345EAD73B878B3C1C34858B3C9C6C152E3E864B42B7091609E1B7152A20F16BF3E097C34E16D473E31BC4F9EF21F3366C3C1A3ECBCE72BF3D78CCC65D9B6CF594F3D0258939961CAA709A32EB70E15B2D176E2A47E17F200C982789C0208181A9FD53451FCDA0CA2D0B5075F76E449D389A6455E794F5072214B3FCDA483CECECADAA4B2ABE0A7699B92BCF146ECA2071E75818F97AA1764329151D94E99598150035D38290459D0A7D366E506BEA3285D002A8B6AA21C69A41A5DD6014DF85D29CEE28B98568284D0A72CA32D67887328BA29475D25A36AF799D86A2777289A2083C572B82B3116B9E56C0B317F3FE65619062382EAFA90E15B76A271132B4C4C6ACD4998793140C5215F480A486675E5059663A418379E5BB95ECBC7A60B9D5E5CBE567DDD9CCB780413D52A1C873902D80734DC4C455ABA910260F11C847ACE6869A857E1CD0A65B6E13757A39E9F4E948778452DDA80395267A7064D68625E6CCC9EEB85A99A8236AC3DDB154A1A823A9C12ACEC4314EDD3430A7626186B39BF6DAC99AF3D0B107736E80EA60CF8D94CF63D05A71A68368C33D4C26AE316B35D81D2729AF748C64A03B7D515AE920C5686FA4712DD2780BA4E35AA4E3AFC809D204610F2E500BD4C1011AE89EC7FC8B8243C72846BB231515848E548CF6B821928AA07435242387379172CA5477F56BD961C72B5EA3A8BFCA9BA3B0575BFD5772CAAA9A3A194E8656673F524F6AF3FE7C6559EA967C65303D1933F3DDEAF956D25E7389B22E95FE1A69EE244B39DB1B40951C345D625BC0FB13F192FC73CD050E0672C160FEC59FF924C9E2F30597889205E6227DD2B0C7C3D1D8E81F7D3DBD1C8773CFEFD4D039F8AB4C4CC99718136950644130DBA9B7429F10731F11FB2140AB1F75A42DFB273BE135F4488834A25D3B241E7C167BE89074C4E9DD89F8EF9951A527B0D3D91BEFFE3B61696FFB5B1FBBF9B6BF1343E6FBFD3EC08EB700DBF9C1FB827A7835B5FFB0FE3C94C1EA6FAB99A0A5C7D55743F9A6DBF370F7E805E67337AD63F2657F16CDD7EC5ADC51ABEC9D4F7C43E2D6ED7037E55ED5D5CD1951BB49683B351D62B3E14A8813EBE2977B8572645D33C84E4EAC215875FF7BA6906307660A981EDC6CDD12A8CDB22B4FB41D3A01A34A867F4DCFB08F05B64EDD34759B21EE22AFAA4799F56EDE5FBD0257D8E8D6410048B037CCE441201F52642E1824C99502EB8611483722E497A5AFA6FA5D029A944C019A336738C254725E2B67970D3716380ADED0749B161A5B2DED8654571669075977840D87F7BF34A53E477B705BDA5C94EEDD98EAFB76D5CEC6E69E586B572EAD4A21F17B08E1B8D3D8A97E62B07BCBAE0EBE780DD9ADA157875DDFEBABD74A33FBC67CB38E1A45E9D25D540DC1D62663C3334FCD15B44D6FD1D043CDBB54F7C66257D1F32E66BBE8F52F497541B3BD23FACCC2F7E8AA569F91205468BF368678C5C9B28090BF3DA6D82D0509B5E6822EC23C5E191CE54B8C34EC120B04A51E3A6590742157C0B40B3552F24B8CCFC88F651D1F3C60EF825EC7228A05888C83077FAD2B43C6BC4DFB27ADE332CF93EB28F9C5D23E44003689AC56AFE9DB98F89EE2FBBC26F16B8090C1F43D86F1F42C21360BBC5C2BA4AB907604CAD4A7EE803B1C443E80F16B3A474F781BDEA04EFA8897C85DE7AF81CD20ED075156FBE48CA0254301CF300A7AF80A36EC05ABD7FF022FFC2453742F0000, N'6.2.0-61023')
INSERT [dbo].[__MigrationHistory] ([MigrationId], [ContextKey], [Model], [ProductVersion]) VALUES (N'201904011142067_ChangeColumnType', N'School_Project.Migrations.Configuration', 0x1F8B0800000000000400E55A5F6FDB36107F1FB0EF20E8691B52CB7606AC0BEC16A9D314419B3F88D3626F0123D10E378952292AB331EC93ED611F695F6147FDA12852B2255B31BA1501029BE4FD7877BC3BDEF1FCCF5F7F4F5EAF02DF7AC22C26219DDAA3C1D0B63075438FD0E5D44EF8E2C54BFBF5AB6FBF99BCF58295F5A958772CD601258DA7F623E7D189E3C4EE230E503C0888CBC2385CF0811B060EF242673C1CFEEC8C460E06081BB02C6B729B504E029C7E81AFB390BA38E209F22F430FFB713E0E33F314D5BA42018E23E4E2A90D2361E8DFDFB0F057ECF2019072BCE2B675EA1304DCCCB1BFB02D4469C811075E4F3EC678CE594897F30806907FB78E30AC5B203FC6B90C27E5F2B6E20CC7421CA7242CA0DC24E661D01170749CEBC7D1C977D2B22DF5071A7C0B9AE66B2175AAC5A93D0B132644D7B73A99F94C2C33549C22101C0F32CA232B9B7F91CF1F49B300EB117F47D62CF179C2F094E28433E41F5937C9834FDCF7787D17FE86E99426BEAF32096CC25C650086003FC28CAF6FF12267FDC2B32DA74AE7E884924CA1C9C47A9710F87C057BA3071F4B137036928BFF0500D811B8856D5DA2D5074C97FC716AFF087E704E56D82B0672D08F948013010D67C9D63DEE3082636587D8EA2A091E30FB845C445D38D262BB0BCA8FC79D7533E788F133C425D7E2F31D115274447A4BBDDD70AED01359A6E66BF09678987290F016FBE982F89144597CC80DF9BE5C73CEC2E036F4A577C8A9FB397C77056361FDFC1D624BCCAB7C4D9CD2E936BA628EB28B2FE6A45F97339E1316F343B8C93C3988379E5DBFD9DB754E3D8FE1381E6DE0153EF6C06CBED1F8501B1DF7BF5163B4C8BC7AEF60510483A6605104939D82C5877049E82EA12225FCBA0205247D3D3970C78D6F501CFF1E326FC3C6A3E1B3EC2CF6EBC16336EEDA64ABA7711CBA2435C78A43954E53651DAE7B6BCB759BC951FA1F0803E64922304860606AFF60E8A31954BA65092A6FDE8DA8134791CC744E517B2042312B6E8DD4C3CEDEC89AC4F055B0CBDC5DE35CE1BA0C02778EB996AB976AD79462E8A04A2FC53400E4CC16843CEA18F4F9B846ADA84B174209A0CAAA8618AB0795ED0623F92E95E6B447292C44416952905395B1C63BA4599465AC93D5B145BDEB3414BC934B1445E0B94A019C8F58F3ACFA9DBD98772F09830CC371E39ACA50722B77E221434BACCD0A9D79384DC02055410F486878E605C632DD091ACCABD8AD62E7E6811556572C179F5567D3DF0106F548A522CF41B600CE3515139B566310A68F10C847ACE6869A857E12D0A65B6E13757639A9F4D9487B844AD1A80255263A70A4578615E6F4C9F6B84A91A8222AC3EDB16499A822C9411367E268A7AE1B98635898E6ECBABDB6B2E62274F460CE0D502DECB991F2790C5A29CD541065B883C92435662D07DBE3A4E5958A910EB4A72F4B2B15A41CED8C34AE451AEF80745C8B74FC0539419620F4E002B5402D1CA081EE79CCBF2C38548C72B43D525941A848E568871B22AD082A57433A727813A9A64C7557BF921DB6BCE2158AFAABBC390A7BB5D5BF91539A6A6A653839CC7D9D010945C9DDBB3396A7A93B3296A375E34BCF77CDF335D25E7D89B42E99FE6A69EE244F39B7377F8C1C345B625BC0FB13F1D2FC731D731C0CC482C1FCB33FF3499AC5170B2E11250B1CF3EC49C31E0F4763AD77F4E5F4719C38F6FC1D9B3917D4C3ABA9FD87F5E7E19F6C124A3E2798089B250B82D95E4D17FA8498FB8898F1785362EED863E909B9A1A54284D5EDDB50F1E033EFA1A1D212A787C6C57FDAEE8CFE424F26A2B5137A4255BA07C5F98E45A0C32EC9BAF43FEDDD4C2838FD2E40ABEFBBF2A7370CFA003BDE016CEF17F6C3DBB4FA985B672C2F87C361E7C3EDD151F4F7F51616BDD3F3792DEE68ABECAD4F7C43A6D8EE7037267BE6F2C6146CBB49A83B359D62B3E50A8C13EBE297FB12E6C8BA6690109D5843B0EBAE07A508B2073312A5032F3BF7206AD37AE34DB845EB61649414D7F40CFB9863EBD4CD72C5198A5DE4995A1469F6E6FDE5CD6AB0D1AE650190606E988973403EE4E4316790951B15DD0D2390AE44C8AF4A6F96166D029A904C02EA336738C254705E2B679B0D375754125F53F53635343677B65B525D1DA69C64DD19369CDEFFD296BA9CEDC18D696315DCBB2DD5370ACD56CAE626DCD636605606431EF810C26967B153FEA661FF1E611D7CF9FCB25F07B10EBBBEB958AF9566F6B5F9661D358AD2A69D293B905BBB9A0DEF4A3557D02ECD4C4D0F350F61ED3B996D452FDAA6DB45AF7FB9AA8B99DB5BB0CF2C7C8736AEF96E05A142F9693384AB982C4B08F143678ADD4A90906B2EE8222CC295C651B1444BC22E314750F9A15306391772394CBB5023A53FFDF884FC44BC03040FD8BBA0D7098F120E22E3E0C15FABCA10316FD3FE69AFBACAF3E43A4A7F22D58708C02611C5EB357D9310DF937C9FD7247E0D102298BEC3309E9D25C4668E976B897415D29640B9FAE41D708783C807B0F89ACED113DE8537A8933EE02572D7C5F36333C8F683A8AA7D7246D092A120CE314A7AF80A36EC05AB57FF028A94960BE12F0000, N'6.2.0-61023')
INSERT [dbo].[__MigrationHistory] ([MigrationId], [ContextKey], [Model], [ProductVersion]) VALUES (N'201904011145374_ChangeColumnTypeVarchar', N'School_Project.Migrations.Configuration', 0x1F8B0800000000000400E55A5F6FDB36107F1FB0EF20E871482DDB19B02EB05BA44E53046BFE204E8BBD058C443BDC244AA5A834C6B04FB6877DA47D851DF587A248C9926CD5E85604086C92F7E3DDF1EE78C7F33F7FFD3D7BFD1CF8D613663109E9DC9E8CC6B685A91B7A84AEE776C2572F5EDAAF5F7DFFDDECAD173C5B1F8B75C7621D50D2786E3F721E9D384EEC3EE200C5A380B82C8CC3151FB961E0202F74A6E3F1CFCE64E26080B001CBB266B709E524C0E917F8BA08A98B239E20FF32F4B01FE7E330B34C51AD2B14E038422E9EDB301286FEFD0D0B7FC32E1F0129C7CFDCB64E7D82809B25F657B685280D39E2C0EBC987182F390BE97A19C100F2EF361186752BE4C73897E1A45CDE559CF15488E3948405949BC43C0C7A024E8E73FD383AF94E5AB6A5FE40836F41D37C23A44EB538B71761C284E8FA56270B9F8965868A530482E35146796465F32FF2F9236916603DE2EFC85A243E4F189E539C7086FC23EB2679F089FB0BDEDC85BF633AA789EFAB4C029B3057198021C08F30E39B5BBCCA59BFF06CCBA9D2393AA124536832B1DE25043E5FC1DEE8C1C7D2049CADE4E27F010076046E615B97E8F93DA66BFE38B77F043F3827CFD82B0672D00F948013010D6749EB1E7718C1B1B2436C7595040F987D442EA22E1C69B1DD05E5C7D3DEBA5972C4F819E2926BF1F98E08297A22BDA5DE6E3857E889AC53F335784B3C4C3948788BFD7441FC48A22C3EE4867C5FAE396761701BFAD23BE4D4FD12BEBB82B1B07EFE0EB135E655BE664EE9745B5D3147D9C51773D26FCB19CF098BF921DC64991CC41BCFAEDFECED3AA79EC7701C4FB6F03A190FC16CBED1F4501B1D0FBF5163B4C8BC7AEF60510483A6605104939D82C5FB704DE82EA12225FCB60205247D033970CF8D6F501C7F0E993780EDF6DC59ECB76557F8B8FFAE4DB67A1AC7A14B5273AC3854E93455D6E1BAB75AAEDB4C8ED2FF4018304F128141020373FB07431FCDA0D22D4B5079F36E459D398A64A6738ADA03118A59716BA41E76F646D62486AF825DE6EE1AE70AD76510B84BCCB55CBD54BBA6144307557A29A60120675A10F2A863D0E7E31AB5A22E5D0825802AAB1A62AC1E54DA0D46F25D2ACDE98E52588882D2A420A72A638D7748B328CB5827AB638B7AD76928786797288AC0739502381FB19659F5BB78B1EC5F12061986E3C63595A1E456EEC44386D6589B153AF3709A8041AA821E90D0F0C20B8C65BA13349857B15BC5CECD032BACAE582E3EABCEA6BF038CEA914A459E836C019C6B2A2636ADC6204C1F21908F58CD0DB508FD24A04DB7DC36EAEC7252E9B391EE0895A25105AA4CF4E048AF0C2BCCE993DD71952251455486BB63C9325145928326CECCD14E5D3730C7B030CDD9757BED64CD45E818C09C1BA03AD87323E5973168A534534194E11E2693D498B51CEC8E9396572A463AD09DBE2CAD549072B437D2B41669BA03D2712DD2F157E404598230800BD40275708006BA2F63FE65C1A16294A3DD91CA0A42452A477BDC10694550B91AD291C39B483565AABBFA95ECB0E315AF50D45FE5CD51D8ABADFE8D9CD2545327C3C961EEEB0C48284AEEDE9FB13C4DDD91B11CAD1F5F7ABE6B9EAF91F6EA4BA475C9F4574B736779CAD9DEFC3172D06C896D01EF4FC44BF3CF4DCC7130120B46CB4FFEC22769165F2CB84494AC70CCB3270D7B3A9E4CB5DED1D7D3C771E2D8F3776CE65C500F3FCFED3FAC3F0FFF649350F229C144D82C5911CCF66ABA3C21E63E2266BCDD94903BB65886016E68A8106173FBB6533CF8CC0768A774C419A06DF19FB63AA3BB308C8568BD84614095CE4171BA5311E4B04BB20EFD4F7B3712EA184DDF2EFB71AAB70D86853DDE0B76EFB7F7C3DBBBFACC5B27F3CB7155E84E473FA013E92FEFB4DDDE777A58AFC59DB4CADEF9C4B7E490DD0E776B1A682E6F4CCEDA4D42DDA9E9149B2D57609C5817BFDE973047D6358354E9C41A835DF73D2845903D9891283D78D9B93B519BF01BAFC51D9A1213A3D8B8A667D8C71C5BA76E96452E50EC22CFD4A248C0B7EF2F6F5D838D6ECD0C800473C34C9C03F2215B8F39837CDDA8F56E18815426427E557AB3E8E812D0846412509F39C311A682F35A39BB6CB8BDD692F89AAADBD4D0D8F669B7A4BA0A4D39C9BA336C38BDFFA52DF539DB831BD3D6FA78705BAA6F219A4D96EDEDB9D6066156204396F810C26967B153FEDA61FFEE611D7CF930B35F6FB10EBBBEED58AF9566F6B5F9661D358AD2A5D1297B93ADFDCE8617A79A2B689736A7A6879A27B2EE3DCEAEA2170DD576D1EBDFB4EA62667B73F60B0BDFA3C16BBE6841A8507EF40CE12A26EB1242FC049A62B71224E49A0BBA0A8B70A571542CD192B04BCC11D485E89441CE855C0ED32E544BE98F423E223F116F04C103F62EE875C2A38483C83878F037AA3244CCDBB67FDAC5AEF23CBB8ED21F4F0D2102B04944697B4DDF24C4F724DFE735895F038408A6EF308C676709B199E3F546225D85B42350AE3E7907DCE120F2012CBEA64BF48477E10DEAA4F7788DDC4DF130D90CD27E1055B5CFCE085A3314C43946490F5FC186BDE0F9D5BF1EE2FBCAFB2F0000, N'6.2.0-61023')
INSERT [dbo].[Courses] ([Id], [Name], [TeacherName], [NumberVacancies], [StartDate], [EndDate]) VALUES (N'025e96f2-7401-43a6-ac04-463e082e8cff', N'History', N'Ivania', 5, CAST(N'2018-02-01T00:00:00.000' AS DateTime), CAST(N'2019-10-02T00:00:00.000' AS DateTime))
INSERT [dbo].[Courses] ([Id], [Name], [TeacherName], [NumberVacancies], [StartDate], [EndDate]) VALUES (N'04c75a14-007e-4e0d-87a0-526ff2d91350', N'Swimming', N'Juca', 4, CAST(N'2018-02-02T00:00:00.000' AS DateTime), CAST(N'2019-12-12T00:00:00.000' AS DateTime))
INSERT [dbo].[Courses] ([Id], [Name], [TeacherName], [NumberVacancies], [StartDate], [EndDate]) VALUES (N'4e0baa9d-a70c-4d23-b510-8a12cf7cde57', N'Soccer', N'Roberto', 16, CAST(N'2019-01-02T00:00:00.000' AS DateTime), CAST(N'2019-03-03T00:00:00.000' AS DateTime))
INSERT [dbo].[Courses] ([Id], [Name], [TeacherName], [NumberVacancies], [StartDate], [EndDate]) VALUES (N'bdf0effc-3d2f-4f4f-913c-a604636eba3c', N'Basketball', N'Ronaldo', 4, CAST(N'2018-12-01T00:00:00.000' AS DateTime), CAST(N'2019-04-02T00:00:00.000' AS DateTime))
INSERT [dbo].[Courses] ([Id], [Name], [TeacherName], [NumberVacancies], [StartDate], [EndDate]) VALUES (N'07c545a5-6030-47d4-a311-b10a53ca932a', N'Math', N'Emanoel', 10, CAST(N'2019-01-10T00:00:00.000' AS DateTime), CAST(N'2020-10-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Courses] ([Id], [Name], [TeacherName], [NumberVacancies], [StartDate], [EndDate]) VALUES (N'bdeb1019-c6e7-4abf-8abb-b7f8a2eb9055', N'Football', N'João', 6, CAST(N'2010-02-02T00:00:00.000' AS DateTime), CAST(N'2020-01-02T00:00:00.000' AS DateTime))
INSERT [dbo].[Courses] ([Id], [Name], [TeacherName], [NumberVacancies], [StartDate], [EndDate]) VALUES (N'1ec75c9f-b790-4bad-b942-f1867bf6601b', N'English Language', N'Josue', 3, CAST(N'2019-03-01T00:00:00.000' AS DateTime), CAST(N'2019-04-05T00:00:00.000' AS DateTime))
INSERT [dbo].[CourseStudents] ([Student_Id], [Course_Id]) VALUES (N'025e96f2-7401-43a6-ac04-463e082e8cff', N'f44f6842-a876-4223-b4a2-038b8bd4317f')
INSERT [dbo].[CourseStudents] ([Student_Id], [Course_Id]) VALUES (N'025e96f2-7401-43a6-ac04-463e082e8cff', N'f82f74c7-f3bf-4890-b640-6f6a15ed34fe')
INSERT [dbo].[CourseStudents] ([Student_Id], [Course_Id]) VALUES (N'025e96f2-7401-43a6-ac04-463e082e8cff', N'58dbe5dd-4b59-47f9-b7d1-c0ba23495deb')
INSERT [dbo].[Login] ([Type], [Id], [UserName], [Password]) VALUES (N'A', N'd91874fe-fbe3-4035-b72e-3af39382425d', N'caio.augusto', N'25-d5-5a-d2-83-aa-40-0a-f4-64-c7-6d-71-3c-07-ad')
INSERT [dbo].[Students] ([Id], [FirstName], [SurName], [DOB], [Address1], [Address2], [Address3]) VALUES (N'f44f6842-a876-4223-b4a2-038b8bd4317f', N'Joao', N'Nazare', CAST(N'2010-02-10T00:00:00.0000000' AS DateTime2), N'Address', NULL, NULL)
INSERT [dbo].[Students] ([Id], [FirstName], [SurName], [DOB], [Address1], [Address2], [Address3]) VALUES (N'1bb7af4d-e1f7-4ee7-9b31-568782c23a6d', N'Caio Augusto', N'Azevedo', CAST(N'1996-05-04T00:00:00.0000000' AS DateTime2), N'Street 32', N'Street 10', N'Street 100')
INSERT [dbo].[Students] ([Id], [FirstName], [SurName], [DOB], [Address1], [Address2], [Address3]) VALUES (N'f82f74c7-f3bf-4890-b640-6f6a15ed34fe', N'Ana ', N'Maria', CAST(N'1977-04-05T00:00:00.0000000' AS DateTime2), N'Street 15', NULL, NULL)
INSERT [dbo].[Students] ([Id], [FirstName], [SurName], [DOB], [Address1], [Address2], [Address3]) VALUES (N'58dbe5dd-4b59-47f9-b7d1-c0ba23495deb', N'Izabel', N'Ferreira', CAST(N'2018-01-10T00:00:00.0000000' AS DateTime2), N'Street 21 A', NULL, NULL)
ALTER TABLE [dbo].[CourseStudents]  WITH CHECK ADD  CONSTRAINT [FK_dbo.CourseStudents_dbo.Courses_Course_Id] FOREIGN KEY([Student_Id])
REFERENCES [dbo].[Courses] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CourseStudents] CHECK CONSTRAINT [FK_dbo.CourseStudents_dbo.Courses_Course_Id]
GO
ALTER TABLE [dbo].[CourseStudents]  WITH CHECK ADD  CONSTRAINT [FK_dbo.CourseStudents_dbo.Students_Student_Id] FOREIGN KEY([Course_Id])
REFERENCES [dbo].[Students] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CourseStudents] CHECK CONSTRAINT [FK_dbo.CourseStudents_dbo.Students_Student_Id]
GO
