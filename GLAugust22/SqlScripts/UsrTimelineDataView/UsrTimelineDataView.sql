IF EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[UsrTimelineData]'))
DROP VIEW [dbo].UsrTimelineData
GO

create view UsrTimelineData as
select Id as UsrId, Name as UsrName, Data as UsrData,
    CAST(
        CAST(N'' AS XML).value(
            'xs:base64Binary(xs:hexBinary(sql:column("Data")))'
          , 'VARBINARY(MAX)'
        ) 
        AS VARCHAR(MAX)
    ) as UsrStringData
from TimelineTileSetting

