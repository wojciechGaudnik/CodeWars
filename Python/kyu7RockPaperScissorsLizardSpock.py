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

print(rpsls('rock', 'lizard'), 'Player 1 Won!')
print(rpsls('paper', 'rock'), 'Player 1 Won!')
print(rpsls('scissors', 'lizard'), 'Player 1 Won!')
print(rpsls('lizard', 'paper'), 'Player 1 Won!')
print(rpsls('spock', 'rock'), 'Player 1 Won!')

print(rpsls('lizard', 'scissors'), 'Player 2 Won!')
print(rpsls('spock', 'lizard'), 'Player 2 Won!')
print(rpsls('paper', 'lizard'), 'Player 2 Won!')
print(rpsls('scissors', 'spock'), 'Player 2 Won!')
print(rpsls('rock', 'spock'), 'Player 2 Won!')
