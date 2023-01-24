def knight_vs_king (knight_position, king_position):
    knight_movement = {
        1: (1, 2),
        2: (2, 1),
        3: (2, -1),
        4: (1, -2),
        5: (-1, -2),
        6: (-2, -1),
        7: (-2, 1),
        8: (-1, 2),
    }
    king_movement = {
        1: (0, 1),
        2: (1, 1),
        3: (1, 0),
        4: (1, -1),
        5: (0, -1),
        6: (-1, -1),
        7: (-1, 0),
        8: (-1, 1),
    }
    for move in knight_movement.items():
        if knight_position[0] + move[1][0] is king_position[0] and chr(ord(knight_position[1]) + move[1][1]) == king_position[1]:
            return "Knight"

    for move in king_movement.items():
        if king_position[0] + move[1][0] == knight_position[0] and chr(ord(king_position[1]) + move[1][1]) == knight_position[1]:
            return "King"
    return "None"

