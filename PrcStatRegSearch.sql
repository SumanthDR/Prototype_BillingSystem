USE [project]
GO
/****** Object:  StoredProcedure [dbo].[PrcStatRegSearch]    Script Date: 7/30/2019 8:02:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[PrcStatRegSearch]
@Regno varchar(50)
as
begin 
select Regno,Course,Year,PayType,PayDate,GToTal,AmtPaid from dbo.TblBillSave where Regno=@Regno
end
