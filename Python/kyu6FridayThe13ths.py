import datetime


def friday_the_thirteenths(start, end=None):
    if end is None:
        end = start
    answer = ""
    for year in range(start, end + 1):
        for month in range(1, 13):
            date = datetime.datetime(year, month, 13)
            if date.weekday() == 4:
                answer += date.strftime("%-m/%d/%Y ")
    return answer.rstrip(" ")
