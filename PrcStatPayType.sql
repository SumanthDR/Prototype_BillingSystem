USE [project]
GO
/****** Object:  StoredProcedure [dbo].[PrcStatPayType]    Script Date: 7/30/2019 8:02:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[PrcStatPayType]
@PayType varchar(50)
as
begin
select Regno,Course,Year,PayType,PayDate,GTotal,AmtPaid from dbo.TblBillSave where PayType=@PayType
end
