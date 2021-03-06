USE [project]
GO
/****** Object:  StoredProcedure [dbo].[PrcBillSave]    Script Date: 7/29/2019 7:08:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[PrcBillSave]
@Regno varchar(50),
@Course varchar(50),
@Year varchar(50),
@PayDate date,
@ValueAddedFee numeric(18,0),
@DevFee numeric(18,0),
@TutionFee numeric(18,0),
@GTotal numeric(18,0),
@AmtPaid numeric(18,0),
@BalAmt numeric(18,0),
@PayType varchar(50)
as
begin 
insert into dbo.TblBillSave(Regno,Course,Year,PayDate,ValueAddedFee,DevFee,TutionFee,GTotal,AmtPaid,BalAmt,PayType)
values (@Regno,@Course,@Year,@PayDate,@ValueAddedFee,@DevFee,@TutionFee,@GTotal,@AmtPaid,@BalAmt,@PayType)
end
go

