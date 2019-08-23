drop table lastminute;
create table lastminute
(
	id INTEGER
		constraint lastminute_pk
			primary key autoincrement,
	flying_from TEXT not null,
	flying_to TEXT not null,
	departure_date TEXT not null,
	arrival_date TEXT not null
);