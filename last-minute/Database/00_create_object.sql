--drop table flights;
create table flights
(
    id INTEGER
        constraint flights_pk
            primary key autoincrement,
    uuid TEXT,
    capacity INTEGER,
    flying_from TEXT not null,
    flying_to TEXT not null,
    departure_date_time TEXT not null,
    company TEXT not null
);

--drop table rooms;
create table rooms
(
    id INTEGER
        constraint rooms_pk
            primary key autoincrement,
    uuid TEXT,
    name TEXT not null,
    location TEXT not null,
    capacity INTEGER not null,
    company TEXT not null
);

drop table lastminute;
create table lastminute
(
	id INTEGER
		constraint lastminute_pk
			primary key autoincrement,
	flight_id TEXT not null,
	room_id TEXT not null,
	create_date TEXT not null
);