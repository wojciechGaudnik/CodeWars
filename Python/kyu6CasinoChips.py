import math


def solve(arr):
	# print(arr)
	if arr[0] == arr[1] == arr[2]:
		return math.floor(arr[0] / 2 + arr[1] / 2 + arr[2] / 2)
	arr = sorted(arr, reverse=True)
	answer = arr[2] + arr[1] - arr[2] // 2
	if arr[2] % 2 == 1:
		max_n = arr[0] - (arr[2] // 2 + 1)
		avg_n = arr[1] - arr[2] // 2
		if answer < avg_n + arr[2]:
			answer = avg_n + arr[2]
	else:
		max_n = arr[0] - arr[2] // 2
		avg_n = arr[1] - arr[2] // 2
		if answer < avg_n + arr[2]:
			answer = avg_n + arr[2]
	return answer if answer > arr[0] - arr[2] + min(arr[0] - arr[2], arr[1]) else arr[0] - arr[2] + min(arr[0] - arr[2], arr[1])


def solve1(arr):
	print(arr)
	answer = 0
	if arr[0] == arr[1] == arr[2]:
		return math.floor(arr[0] / 2 + arr[1] / 2 + arr[2] / 2)
	arr = sorted(arr, reverse=True)
	# if arr[0] > arr[1] and arr[1] == arr[2]:
	# 	return arr[1] + arr[2] if arr[0] >= arr[1] + arr[2] else
	if arr[0] != arr[1] != arr[2]:
		answer =  arr[2] + arr[1] if arr[2] + arr[1] < arr[0] else arr[0]
		
	return answer if answer > arr[0] - arr[2] + min(arr[0] - arr[2], arr[1]) else arr[0] - arr[2] + min(arr[0] - arr[2], arr[1])

print(solve([7,4,10]))