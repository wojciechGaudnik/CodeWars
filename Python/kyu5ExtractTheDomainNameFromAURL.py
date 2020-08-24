def domain_name(url):
	to_remove = ["http://", "https://", "www.", "http://www."]
	for rem in to_remove:
		url = url.replace(rem, "")
	url = url.split(".")[0]
	return url

