create procedure PrcFeeStructViewer
@Course varchar(50)
as
begin 
select * from dbo.TblFeeStructure where Course=@Course
end
go

