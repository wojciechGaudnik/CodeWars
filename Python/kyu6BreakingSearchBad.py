def search(titles, term):
	return list(filter(lambda title: term.lower() in title.lower(), titles))