drop table flights;
create table flights
(
	id INTEGER
		constraint flights_pk
			primary key autoincrement,
	capacity INTEGER,
	flying_from TEXT not null,
	flying_to TEXT not null,
	departure_date TEXT not null,
	company TEXT not null
);