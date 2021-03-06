USE [project]
GO
/****** Object:  StoredProcedure [dbo].[PrcBillCourse]    Script Date: 8/5/2019 9:37:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[PrcBillCourse]
@Course varchar(50)
as
BEGIN
select Total1,Total2,Total3,GTotal from dbo.TblFeeStructure where Course=@Course
end

GO
/****** Object:  StoredProcedure [dbo].[PrcBillRegno]    Script Date: 8/5/2019 9:37:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[PrcBillRegno]
@Regno varchar(50),
@Course varchar(50),
@Year varchar(50),
@BalAmt numeric(18,0)
as
begin
select Regno,Course,Year,BalAmt from dbo.TblBillSave where Regno=@Regno
end

GO
/****** Object:  StoredProcedure [dbo].[PrcBillSave]    Script Date: 8/5/2019 9:37:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[PrcBillSave]
@Regno varchar(50),
@Course varchar(50),
@Year varchar(50),
@PayDate date,
@ValueAddedFee numeric(18,0),
@DevFee numeric(18,0),
@TutionFee numeric(18,0),
@GTotal numeric(18,0),
@AmtPaid numeric(18,0),
@PayType varchar(50)
as
begin 
insert into dbo.TblBillSave(Regno,Course,Year,PayDate,ValueAddedFee,DevFee,TutionFee,GTotal,AmtPaid,PayType)
values (@Regno,@Course,@Year,@PayDate,@ValueAddedFee,@DevFee,@TutionFee,@GTotal,@AmtPaid,@PayType)
end

GO
/****** Object:  StoredProcedure [dbo].[PrcFeeStructUpdater]    Script Date: 8/5/2019 9:37:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[PrcFeeStructUpdater]
@Course varchar(50),
@Ipomo int,
@IdCrad int,
@BlueBook int,
@Cultural int,
@Total numeric(18,0),
@Tutuion int,
@Uniform int,
@Library int,
@Lab int,
@Total2 numeric(18,0),
@Development int,
@Vani int,
@Stationary int,
@Alumni int,
@Total3 numeric(18,0),
@GTotal numeric(18,0)
AS
Update dbo.TblFeeStructure set 
Ipomo=@Ipomo,
IdCard=@IdCrad,
BlueBook=@BlueBook,
Cultural=@Cultural,
Total1=@Total,
Tution=@Tutuion,
Uniform=@Uniform,
Library=@Library,
Lab=@Lab,
Total2=@Total2,
Development=@Development,
Vani=@Vani,
Stationary=@Stationary,
Alumni=@Alumni,
Total3=@Total3,
GTotal=@GTotal
where Course=@Course

GO
/****** Object:  StoredProcedure [dbo].[PrcFeeStructure]    Script Date: 8/5/2019 9:37:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[PrcFeeStructure]
@Course varchar(50),
@Ipomo int,
@IdCrad int,
@BlueBook int,
@Cultural int,
@Total numeric(18,0),
@Tutuion int,
@Uniform int,
@Library int,
@Lab int,
@Total2 numeric(18,0),
@Development int,
@Vani int,
@Stationary int,
@Alumni int,
@Total3 numeric(18,0),
@GTotal numeric(18,0)
as
begin 
insert into TblFeeStructure(Course,Ipomo,IdCard,BlueBook,Cultural,Total1,Tution,Uniform,
Library,Lab,Total2,Development,Vani,Stationary,Alumni,Total3,GTotal) values
(@Course,@Ipomo,@IdCrad,@BlueBook,@Cultural,@Total,@Tutuion,@Uniform,
@Library,@Lab,@Total2,@Development,@Vani,@Stationary,@Alumni,@Total3,@GTotal)
end

GO
/****** Object:  StoredProcedure [dbo].[PrcFeeStructViewer]    Script Date: 8/5/2019 9:37:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[PrcFeeStructViewer]
@Course varchar(50)
as
begin 
select * from dbo.TblFeeStructure where Course=@Course
end

GO
/****** Object:  StoredProcedure [dbo].[PrcStatCourse]    Script Date: 8/5/2019 9:37:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[PrcStatCourse]
@Course varchar(50)
as
select Regno,Course,Year,PayType,PayDate,GToTal,AmtPaid from dbo.TblBillSave where Course=@Course

GO
/****** Object:  StoredProcedure [dbo].[PrcStatPayType]    Script Date: 8/5/2019 9:37:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[PrcStatPayType]
@PayType varchar(50)
as
begin
select Regno,Course,Year,PayType,PayDate,GTotal,AmtPaid from dbo.TblBillSave where PayType=@PayType
end

GO
/****** Object:  StoredProcedure [dbo].[PrcStatRegSearch]    Script Date: 8/5/2019 9:37:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[PrcStatRegSearch]
@Regno varchar(50)
as
begin 
select Regno,Course,Year,PayType,PayDate,GToTal,AmtPaid from dbo.TblBillSave where Regno=@Regno
end

GO
/****** Object:  StoredProcedure [dbo].[PrcStatSort]    Script Date: 8/5/2019 9:37:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[PrcStatSort]
@PayType varchar(50),
@Year varchar(50),
@Course varchar(50)
as
begin
select Regno,Course,Year,PayType,PayDate,GToTal,AmtPaid from dbo.TblBillSave where PayType=@PayType and Year=@Year and Course=@Course
end

GO
/****** Object:  StoredProcedure [dbo].[PrcStatViewAll]    Script Date: 8/5/2019 9:37:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[PrcStatViewAll]
as
begin
select * from dbo.TblBillSave
end

GO
/****** Object:  StoredProcedure [dbo].[PrcStatYear]    Script Date: 8/5/2019 9:37:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[PrcStatYear]
@Year varchar(50)
as
select Regno,Course,Year,PayType,PayDate,GToTal,AmtPaid from dbo.TblBillSave where Year=@Year

GO
/****** Object:  Table [dbo].[TblBillSave]    Script Date: 8/5/2019 9:37:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TblBillSave](
	[Regno] [varchar](50) NULL,
	[Course] [varchar](50) NULL,
	[Year] [varchar](50) NULL,
	[PayDate] [date] NULL,
	[ValueAddedFee] [numeric](18, 0) NULL,
	[DevFee] [numeric](18, 0) NULL,
	[TutionFee] [numeric](18, 0) NULL,
	[GTotal] [numeric](18, 0) NULL,
	[AmtPaid] [numeric](18, 0) NULL,
	[PayType] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TblFeeStructure]    Script Date: 8/5/2019 9:37:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TblFeeStructure](
	[Slno] [int] IDENTITY(1,1) NOT NULL,
	[Course] [varchar](50) NOT NULL,
	[Ipomo] [int] NULL,
	[IdCard] [int] NULL,
	[BlueBook] [int] NULL,
	[Cultural] [int] NULL,
	[Total1] [numeric](18, 0) NULL,
	[Tution] [int] NULL,
	[Uniform] [int] NULL,
	[Library] [int] NULL,
	[Lab] [int] NULL,
	[Total2] [numeric](18, 0) NULL,
	[Development] [int] NULL,
	[Vani] [int] NULL,
	[Stationary] [int] NULL,
	[Alumni] [int] NULL,
	[Total3] [numeric](18, 0) NULL,
	[GTotal] [numeric](18, 0) NULL,
 CONSTRAINT [PK_TblFeeStructure] PRIMARY KEY CLUSTERED 
(
	[Course] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
