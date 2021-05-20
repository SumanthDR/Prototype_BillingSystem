USE [project]
GO
/****** Object:  StoredProcedure [dbo].[PrcStatYear]    Script Date: 7/30/2019 8:01:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[PrcStatYear]
@Year varchar(50)
as
select Regno,Course,Year,PayType,PayDate,GToTal,AmtPaid from dbo.TblBillSave where Year=@Year
