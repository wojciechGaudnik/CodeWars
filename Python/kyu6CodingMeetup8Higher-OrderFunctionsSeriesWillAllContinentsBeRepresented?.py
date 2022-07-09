def all_continents(lst):
    continents = ['Africa', 'Americas', 'Asia', 'Europe', 'Oceania']
    origins = [dev['continent'] for dev in lst]
    return all(dev in origins for dev in continents)
