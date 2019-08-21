drop table flights;
create table flights
(
	id INTEGER
		constraint flights_pk
			primary key autoincrement,
	name TEXT not null,
	capacity INTEGER,
	flying_from TEXT not null,
	flying_to TEXT not null,
	departure_date TEXT not null,
	company TEXT not null
);