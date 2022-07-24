import collections


def wave_sort(a):
    b = collections.deque(sorted(a))
    for i in range(len(a)):
        if i % 2 == 0:
            a[i] = b.pop()
        else:
            a[i] = b.popleft()
