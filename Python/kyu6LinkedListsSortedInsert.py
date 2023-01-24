class Node(object):
	def __init__(self, data):
		self.data = data
		self.next = None

def sorted_insert(head, data):
	if head is None:
		return Node(data)
	data_list = []
	while head is not None:
		data_list.append(head.data)
		head = head.next
	data_list.append(data)
	data_list.sort()
	new_head = Node(data_list[0])
	inset_data(new_head, data_list[1:])
	return new_head
	

def inset_data(head, data):
	head.next = Node(data[0])
	if len(data[1:]) > 0:
		inset_data(head.next, data[1:])
