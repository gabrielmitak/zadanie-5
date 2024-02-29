create table klienci (
	ID SERIAL PRIMARY KEY,
	name VARCHAR(50) COLLATE "C",
    surname VARCHAR(50) COLLATE "C",
	Pesel varchar(11),
	BirthYear date,
	Płeć int
) ;