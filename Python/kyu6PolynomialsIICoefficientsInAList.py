def calc_poly(pol_list, x):
    p = len(pol_list) - 1
    sum_poly = 0
    answer = "For"
    i = 0
    while p >= 0:
        if pol_list[i] != 0:
            part = (" " + str(pol_list[i]) + "*x^" + str(p)).replace("^1", "").replace("*x^0", "")
            answer += part + " +"
            answer = answer.replace("+ -", "- ").replace("-1*x", "-x").replace(" 1*x", " x")
            sum_poly += pol_list[i] * pow(x, p)
        i += 1
        p -= 1
    answer = answer.rstrip("+ ")
    answer += " with x = " + str(x) + " the value is " + str(sum_poly)
    return answer
