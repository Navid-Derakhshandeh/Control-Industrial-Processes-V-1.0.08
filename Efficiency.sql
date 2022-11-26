USE [Industrial]
GO

/****** Object:  Table [dbo].[Efficiency]    Script Date: 11/27/2022 1:28:15 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Efficiency](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Date] [datetime] NOT NULL,
	[Water] [int] NOT NULL,
	[Gas] [int] NOT NULL,
	[Power] [int] NOT NULL,
 CONSTRAINT [PK_Efficiency] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

