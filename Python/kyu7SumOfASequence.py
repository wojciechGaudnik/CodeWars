def sequence_sum(begin_number, end_number, step):
	return sum(i for i in range(begin_number, end_number + 1, step))


#Write your function here
def append_sum(lst):
	lst = lst + [sum([lst[-2], lst[-1]])]
	lst = lst + [sum([lst[-2], lst[-1]])]
	lst = lst + [sum([lst[-2], lst[-1]])]
	return lst
#Uncomment the line below when your function is done


