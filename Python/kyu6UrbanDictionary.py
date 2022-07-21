import re


class WordDictionary:
    __list_of_words = []

    def __init__(self):
        self.__list_of_words = []

    def add_word(self, word):
        self.__list_of_words.append(word)

    def search(self, word):
        print(word)
        for one in self.__list_of_words:
            if re.search(r'^' + word + '$', one) is not None:
                return True
        return False
