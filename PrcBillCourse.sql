USE [project]
GO
/****** Object:  StoredProcedure [dbo].[PrcBillCourse]    Script Date: 7/28/2019 8:18:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[PrcBillCourse]
@Course varchar(50)
as
BEGIN
select Total1,Total2,Total3,GTotal from dbo.TblFeeStructure where Course=@Course
end
go


