def solution(st, limit):
    return st[0:limit] + "..." if limit < len(st) else st
