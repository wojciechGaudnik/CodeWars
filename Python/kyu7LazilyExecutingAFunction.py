from random import randint


def make_lazy(*args):
    print(args[0])
    print(args[1])
    print(args[2])
    yield args[0](args[1], args[2])



def modding(a,b):
    return a%b

lazy_mod= make_lazy(modding,4,4)
print(lazy_mod())
# rand_num = randint(0,10)
# rand_num2 = randint(0,10)
# lazy_rand = make_lazy(modding,rand_num,rand_num2)
# print(lazy_rand(),modding(rand_num,rand_num2))
