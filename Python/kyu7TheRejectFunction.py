def reject(seq, predicate):
    return [e for e in seq if not predicate(e)]
