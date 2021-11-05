#!/bin/python3

import os

states = ['ESTABLISHED', 'TIME_WAIT', 'CLOSE_WAIT']

def combine(states):
	print('Proto Local Address         Foreign Address       PID/Program name    Count')
	ALL = os.popen('netstat -tunp|grep ":443\|:80"|grep ' + states[0]).read().rstrip()
	MAP_ALL = {}
	MAP_COUNT = {}
	ALL_IP_COUNTED = ""
	for line in ALL.split("\n"):
		LINE_SPLIT = line.split()
		REMOTE_IP = LINE_SPLIT[4]
		if REMOTE_IP not in MAP_ALL:
			MAP_ALL[REMOTE_IP] = [LINE_SPLIT[0], LINE_SPLIT[3], LINE_SPLIT[6]]
			MAP_COUNT[REMOTE_IP] = 1
		else:
			MAP_COUNT[REMOTE_IP] += 1
	for items in MAP_ALL.items():
		ALL_IP_COUNTED += items[1][0].ljust(6) + items[1][1].ljust(22) + items[0].ljust(22) + states.ljust(12) + items[1][2].ljust(20) + str(MAP_COUNT[items[0]]) + '\n'
	print(ALL_IP_COUNTED)

for state in states:
	combine(state)
