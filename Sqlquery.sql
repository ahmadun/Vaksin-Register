USE [hrddb_sbi]
GO

/****** Object:  Table [dbo].[Participant_vaccine]    Script Date: 02/22/2023 7:35:06 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Participant_vaccine](
	[Period] [datetime] NOT NULL,
	[Nik] [char](6) NOT NULL,
	[Name] [varchar](90) NOT NULL,
	[Flag] [char](1) NULL,
	[EntDate] [datetime] NULL,
	[UptDate] [datetime] NULL,
 CONSTRAINT [PK_Participant_vaccine] PRIMARY KEY CLUSTERED 
(
	[Period] ASC,
	[No_vak] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


