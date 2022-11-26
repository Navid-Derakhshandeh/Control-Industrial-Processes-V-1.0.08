USE [Industrial]
GO

/****** Object:  Table [dbo].[CIP]    Script Date: 10/12/2022 4:33:37 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CIP](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Issue] [nvarchar](200) NOT NULL,
	[Date_Added] [datetime] NOT NULL,
	[Type] [nvarchar](200) NULL,
	[Des] [varchar](max) NULL,
 CONSTRAINT [PK_CIP] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

