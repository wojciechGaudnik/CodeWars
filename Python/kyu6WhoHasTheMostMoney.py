class Student:
	def __init__(self, name, fives, tens, twenties):
		self.name = name
		self.fives = fives
		self.tens = tens
		self.twenties = twenties

phil = Student("Phil", 2, 2, 1)
cam = Student("Cameron", 2, 2, 0)
geoff = Student("Geoff", 0, 3, 0)

def most_money(students):
	if len(students) == 1:
		return students[0].name
	students_money = {}
	for student in students:
		students_money[student.name] = student.fives * 5 + student.tens * 10 + student.twenties * 20
	if all(students_money[students[0].name] == value for key, value in students_money.items()):
		return "all"
	students_money = sorted(students_money.items(), key=lambda item: item[1], reverse=True)
	return students_money[0][0]
