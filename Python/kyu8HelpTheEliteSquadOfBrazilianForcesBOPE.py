from typing import Tuple


def mag_number(info: Tuple[str, int]):
    answer = 0
    base = info[1] * 3
    BOPE = {
        'PT92': 17,
        'M4A1': 30,
        'M16A2': 30,
        'PSG1': 5
    }
    while base > 0:
        answer += 1
        base -= BOPE.get(info[0])
    return answer
