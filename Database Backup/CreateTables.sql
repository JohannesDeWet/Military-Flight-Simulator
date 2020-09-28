
CREATE DATABASE MilitarySimDataDase;

USE MilitarySimDataDase

/* thought we could make the ID: 'PL01' */
CREATE TABLE Planes (
	PlaneID varchar(4),
	PlaneName varchar(100),
	PlaneType varchar(100),
  PlaneHP int,
	MaxAltitude int,
	PayLoad int,
	FuelRange int,
	CruiseSpeed int,
	MaxSpeed int,
	MountingPoints int
	)

/* thought we could make the ID: 'BM01' */
CREATE TABLE Bombs (
	BombID varchar(4),
	BombName varchar(100),
	BombWeight int,
	SlotsNeeded int,
	Damage int
	)

/* thought we could make the ID: 'BL01' */
CREATE TABLE Buildings (
	BuildingID varchar(4),
	BuildingName varchar(100),
	BuildingType varchar(100),
	BuildingHealth int,
	BuildingDescription varchar(255)
	)

/* thought we could make the ID: 'AD01' */
  CREATE TABLE AdminUsers (
    AdminID varchar(4),
    Username varchar(50),
    Passwork varchar(50)
  )
