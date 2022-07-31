def hanoi(disks):
    answer = 0
    while disks != 0:
        answer = 2 * answer + 1
        disks -= 1
    return answer
