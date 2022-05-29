from datetime import datetime


def check_coupon(entered_code, correct_code, current_date, expiration_date):
	if not correct_code or  entered_code != correct_code:
		return False
	dateformat = '%B %d, %Y'
	current_date = datetime.strptime(current_date, dateformat)
	expiration_date = datetime.strptime(expiration_date, dateformat)
	if current_date > expiration_date:
		return False
	return True

