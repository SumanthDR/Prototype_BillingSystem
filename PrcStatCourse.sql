USE [project]
GO
/****** Object:  StoredProcedure [dbo].[PrcStatCourse]    Script Date: 7/30/2019 8:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[PrcStatCourse]
@Course varchar(50)
as
select Regno,Course,Year,PayType,PayDate,GToTal,AmtPaid from dbo.TblBillSave where Course=@Course
