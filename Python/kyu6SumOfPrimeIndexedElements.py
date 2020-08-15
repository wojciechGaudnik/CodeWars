def total(arr):
	for i, n in enumerate(arr):
		print(str(i) + " " + str(n))
	return sum([n for i, n in enumerate(arr) if is_prime(i)])


def is_prime(n):
	if n <= 1:
		return False
	if n <= 3:
		return True
	if n % 2 == 0 or n % 3 == 0:
		return False
	i = 5
	while i ** 2 <= n:
		if n % i == 0 or n % (i + 2) == 0:
			return False
		i += 6
	return True

print(total([1,2,3,4,5,6,7,8,9,10,11,12,13,14,15]))