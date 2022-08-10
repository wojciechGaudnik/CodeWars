def isomorph(a, b):
    cypher = {}
    if len(a) != len(b):
        return False
    for (f, s) in zip(list(a), list(b)):
        if cypher.get(f) and cypher.get(f) != s:
            return False
        if not cypher.get(f) and s in [l for l in cypher.values()]:
            return False
        cypher[f] = s
    return True
