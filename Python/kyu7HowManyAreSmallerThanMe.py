def smaller(arr):
    answer = []
    for i, n in enumerate(arr):
        count = 0
        for m in arr[i + 1:]:
            if n > m:
                count += 1
        answer.append(count)
    return answer
