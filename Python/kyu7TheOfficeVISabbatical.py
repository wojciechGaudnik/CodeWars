def sabb(s, val, happiness):
    return "Sabbatical! Boom!" if sum(s.count(one) for one in "sabticl") + val + happiness > 22 else "Back to your desk, boy."
