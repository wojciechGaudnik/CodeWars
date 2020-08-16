import re


def is_audio(file_name):
	if re.findall(r"^([A-Za-z]*){1}\.(mp3|flac|alac|aac)$", file_name):
		return True
	return False

def is_img(file_name):
	if re.findall(r"^([A-Za-z]*){1}\.(jpg|jpeg|png|bmp|gif)$", file_name):
		return True
	return False
