class Calculator:
    @staticmethod
    def average(*args):
        if args:
            return sum(args) / len(args)
        return 0
    