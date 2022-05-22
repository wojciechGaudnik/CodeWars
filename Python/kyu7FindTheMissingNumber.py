def missing_no(nums):
	diff = set(range(0, max(nums) + 1)).difference(set(nums))
	return diff.pop() if diff else max(nums) + 1
