SELECT * FROM dbo.Persons;

INSERT INTO dbo.Persons(PersonID, LastName, FirstName, Address, City)
--VALUES(1, 'agrawal', 'ishansi', 'vaishali nagar', 'jaipur');
--VALUES(2 ,'JHA', 'niharika', 'montena','sandiago');
--VALUES(3,'bhide','vedashree','oracle','usa');
--VALUES(4,'rai','aryan','ms','florida');
VALUES(5,'jangral','ridhima','oracle','oracles');

create procedure SetPerson
As
select * from dbo.Persons;

SELECT * FROM GetPerson;

alter proc SetPerson

@PersonID int

as

begin

SELECT * from dbo.Persons where PersonID = @PersonID

end

execute SetPerson 1;