import re


def validate_pin(pin):
	print("--->" + str(pin) + "<---")
	if "\n" in pin:
		return False
	return re.match(r"^((\d{4})|(\d{6}))$", pin, re.MULTILINE) is not None

print(validate_pin(""""1234
"""))