def sing():
    first_line = "{} bottles of beer on the wall, {} bottles of beer."
    second_line = "Take one down and pass it around, {} bottles of beer on the wall."
    answer = []
    for num in range(99, 2, -1):
        answer.append(first_line.format(num, num))
        answer.append(second_line.format(num - 1))
    answer.append("2 bottles of beer on the wall, 2 bottles of beer.")
    answer.append("Take one down and pass it around, 1 bottle of beer on the wall.")
    answer.append("1 bottle of beer on the wall, 1 bottle of beer.")
    answer.append("Take one down and pass it around, no more bottles of beer on the wall.")
    answer.append("No more bottles of beer on the wall, no more bottles of beer.")
    answer.append("Go to the store and buy some more, 99 bottles of beer on the wall.")
    return answer
