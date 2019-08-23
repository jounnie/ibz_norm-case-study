drop table rooms;
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