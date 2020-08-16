import sqlite3

query_create = "CREATE TABLE IF NOT EXISTS MOVIES (" \
               "id integer PRIMARY KEY," \
               "Name text NOT NULL," \
               "Year integer," \
               "Rating integer)"

query_insert = "INSERT INTO MOVIES(id, Name, Year, Rating)" \
               "VALUES(?,?,?,?)"

movies = {
	(1, 'Rise of the Planet of the Apes', 2011, 77),
	(2, 'Dawn of the Planet of the Apes', 2014, 91),
	(3, 'Alien', 1979, 97),
	(4, 'Aliens', 1986, 98),
	(5, 'Mad Max', 1979, 95),
	(6, 'Mad Max 2: The Road Warrior', 1981, 100)
}

conn = None
try:
	conn = sqlite3.connect("/tmp/movies.db")
	c = conn.cursor()
	c.execute(query_create)
	conn.commit()
	c.execute("DELETE FROM MOVIES")
	conn.commit()
	for movie in movies:
		c.execute(query_insert, movie)
		conn.commit()
	c.execute("select * from MOVIES")
except EOFError as e:
	print(e)
finally:
	if conn:
		conn.close()

