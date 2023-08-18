create or alter view ArtemTerziVwContactAgeDays
as
select Id as ArtemTerziId, Name as ArtemTerziName, BirthDate as ArtemTerziBirthDate,
datediff(day, BirthDate,getdate()) as ArtemTerziAgeDays
from Contact