class LinkedList:
    def __init__(self, value=0, next=None):
        self.value = value
        self.next = next


def list_to_array(node):
    answer = []
    current_node = node
    while current_node is not None:
        answer.append(current_node.value)
        current_node = current_node.next
    return answer
