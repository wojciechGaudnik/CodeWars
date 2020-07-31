from collections import OrderedDict
from operator import itemgetter


def get_winner(ballots):
	ballots_set = set(ballots)
	ballots_dict = {}
	for b in ballots_set:
		ballots_dict[b] = ballots.count(b)
	ballots_dict = OrderedDict(sorted(ballots_dict.items(), key=itemgetter(1), reverse=True))
	first = next(iter(ballots_dict))
	return first if (ballots_dict[first] > (len(ballots) / 2)) else None
