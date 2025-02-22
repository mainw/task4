create database WatchmanApiDb
go
use WatchmanApiDb
go
create table Users
(
	id,
	first_name,
	second_name,
	patronumic,
	phone,
	email,
	organization,
	note,
	date_born,
	passport_seria,
	passport_num,

	login,
	password
)
create table Groups
(
	id
)
create table Visiting
(
	id,
	register_date,
	register_num
)
create table UserVisiting
(
	id_user,
	id_visiting
)
create table UserGroup
(
	id,pr
	id_user pr
)
create table UserGroupVisiting
(
	id_group,
	id_visiting
)

create table Staff
(
	id,
	fio,
	divisions,
	departament,
	staff_code
)
create table Divisions
(
	name
)
create table DivisionStaff
(
	name,
	id_staff
)

create table Clients
(
	
)
create table Requests
(
	
)