def strip_url_params(url, params_to_strip=None):
	if "?" not in url:
		return url
	url_first = url.split("?")[0]
	params = {}
	for param in url.split("?")[1].split("&"):
		p = param.split("=")
		if p[0] in params:
			continue
		params[p[0]] = p[1]
	url_first += "?" if len(params) > 0 else ""
	for key, value in params.items():
		if params_to_strip and str(key) in params_to_strip:
			continue
		url_first += key + "=" + value + "&"
	return url_first.strip("&|?")
