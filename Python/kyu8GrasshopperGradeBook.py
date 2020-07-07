import statistics


def get_grade(s1, s2, s3):
	grades = {
		60: "F",
		70: "D",
		80: "C",
		90: "B",
		100: "A"
	}
	average = statistics.mean([s1, s2, s3])
	answer = [v for k, v in grades.items() if average < k]
	if len(answer) > 0:
		return answer[0]
	return "A"
