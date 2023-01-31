def check_concatenated_sum(param, param1):
    answer = 0
    if str(param)[0] == '-':
        for one in str(param)[1:]:
            answer -= int(str(one) * param1)
        return answer == param
    else:
        for one in str(param):
            answer += int(str(one) * param1)
        return answer == param


print(check_concatenated_sum(2997, 3), True)
print(check_concatenated_sum(-2997, 3), True)
