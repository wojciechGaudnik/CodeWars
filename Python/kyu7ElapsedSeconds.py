from datetime import datetime


def elapsed_seconds(start, end):
	return int(end.timestamp() - start.timestamp())
