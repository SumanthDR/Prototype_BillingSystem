USE [project]
GO
/****** Object:  StoredProcedure [dbo].[PrcStatSort]    Script Date: 7/30/2019 8:02:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[PrcStatSort]
@PayType varchar(50),
@Year varchar(50),
@Course varchar(50)
as
begin
select Regno,Course,Year,PayType,PayDate,GToTal,AmtPaid from dbo.TblBillSave where PayType=@PayType and Year=@Year and Course=@Course
end
