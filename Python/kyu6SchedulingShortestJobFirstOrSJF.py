def SJF(jobs, index):
	jobs_copy = jobs.copy()
	max_number = max(jobs_copy) + 1
	i = -1
	answer = 0
	while i != index:
		min_job = min(jobs_copy)
		i = jobs_copy.index(min_job)
		answer += jobs_copy[i]
		jobs_copy[i] = max_number
	return answer
