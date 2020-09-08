
USE MilitarySimDataDase
 
/* thought we could make the ID: 'PL01' */
CREATE TABLE Planes (
	PlaneID char(4) PRIMARY KEY,
	PlaneName varchar(100),
	PlaneType varchar(100),
	MaxAltitude int,
	PayLoad int,
	FuelRange int,
	CruiseSpeed int,
	MaxSpeed int,
	MountingPoints int
	)

/* thought we could make the ID: 'BM01' */
CREATE TABLE Bombs (
	BombID char(4) PRIMARY KEY,
	BombName varchar(100),
	BombWeight int,
	SlotsNeeded int,
	Damage int
	)

/* thought we could make the ID: 'BL01' */
CREATE TABLE Buildings (
	BuildingID char(4) PRIMARY KEY,
	BuildingName varchar(100),
	BuildingType varchar(100),
	BuildingHealth int,
	BuildingDescription varchar(255)
	)
