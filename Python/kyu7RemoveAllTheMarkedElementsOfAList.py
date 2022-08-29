class List:
    def remove_(self, integer_list, values_list):
        answer = []
        for one in integer_list:
            if one not in values_list:
                answer.append(one)
        return answer
