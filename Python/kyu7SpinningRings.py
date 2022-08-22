def spinning_rings(inner_max, outer_max):
    answer = 1
    inner = list(range(inner_max + 1))
    outer = list(range(outer_max + 1))
    inner_i = len(inner) - 1
    outer_i = 1
    while inner[inner_i] != outer[outer_i]:
        inner_i -= 1
        outer_i += 1
        if inner_i < 0:
            inner_i = len(inner) - 1
        if outer_i >= len(outer):
            outer_i = 0
        answer += 1
    return answer
