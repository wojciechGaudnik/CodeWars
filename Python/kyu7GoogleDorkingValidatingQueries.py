FILTERS = ('intext', 'inurl', 'intitle', 'allintext', 'allinurl', 'allintitle', 'site', 'before', 'after', 'filetype')
import re


def is_valid(query: str) -> bool:
    p = re.compile(r'\w+:')
    for q in p.findall(query):
        if q.rstrip(':') not in FILTERS:
            return False
    return True
