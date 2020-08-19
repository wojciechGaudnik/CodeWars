class Node(object):
	def __init__(self, data):
		self.data = data
		self.next = None


def remove_duplicates(head):
	if head is None:
		return
	if head.next is None:
		return head
	
	previous = head
	current = previous.next
	
	while current:
		if current.data == previous.data:
			previous.next = current.next
		else:
			previous = current
		current = current.next
	return head
