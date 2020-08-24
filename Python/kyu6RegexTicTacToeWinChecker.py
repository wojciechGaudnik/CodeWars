import re


def regex_tic_tac_toe_win_checker(board):
	pattern = r"^(X|O)\1\1|^.{3}(X|O)\2\2|.{6}(X|O)\3\3|^(X|O).{2}\4.{2}\4|.{2}(X|O).{2}\5.{2}\5|.{1}(X|O).{2}\6.{2}\6|^(X|O).{3}\7.{3}\7|^..(X|O).\8.\8"
	return re.search(pattern, board) != None
