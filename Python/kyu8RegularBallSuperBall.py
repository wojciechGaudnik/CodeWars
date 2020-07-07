class Ball(object):
	def __init__(self, name=''):
		if name == '':
			self.ball_type = "regular"
		else:
			self.ball_type = name
