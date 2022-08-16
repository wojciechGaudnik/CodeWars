def rpsls(pl1, pl2):
    tests = [["scissors", "paper"], ["paper", "rock"], ["rock", "lizard"], ["lizard", "spock"], ["spock", "scissors"], ["scissors", "lizard"], ["lizard", "paper"],
             ["paper", "spock"], ["spock", "rock"], ["rock", "scissors"]]
    for one in tests:
        if one == [pl1, pl2]:
            return "Player 1 Won!"
    for one in tests:
        if one == [pl2, pl1]:
            return "Player 2 Won!"
    return "Draw!"
