create procedure PrcFeeStructUpdater
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
go


