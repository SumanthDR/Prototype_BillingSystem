USE [project]
GO
/****** Object:  StoredProcedure [dbo].[PrcStatViewAll]    Script Date: 7/29/2019 11:19:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[PrcStatViewAll]
as
begin
select * from dbo.TblBillSave
end
