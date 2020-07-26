spoken    = lambda greeting: str(greeting) + '.'
shouted   = lambda greeting: str(greeting).upper() + '!'
whispered = lambda greeting: str(greeting).lower() + '.'

greet = lambda style, msg:  style(msg)