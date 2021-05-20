create procedure PrcFeeStructure
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
as
begin 
insert into TblFeeStructure(Course,Ipomo,IdCard,BlueBook,Cultural,Total1,Tution,Uniform,
Library,Lab,Total2,Development,Vani,Stationary,Alumni,Total3,GTotal) values
(@Course,@Ipomo,@IdCrad,@BlueBook,@Cultural,@Total,@Tutuion,@Uniform,
@Library,@Lab,@Total2,@Development,@Vani,@Stationary,@Alumni,@Total3,@GTotal)
end
go