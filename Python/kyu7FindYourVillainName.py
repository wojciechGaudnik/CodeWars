from datetime import datetime


def get_villain_name(birthdate):
    first = ["The Evil", "The Vile", "The Cruel", "The Trashy", "The Despicable", "The Embarrassing", "The Disreputable", "The Atrocious", "The Twirling", "The Orange", "The Terrifying", "The Awkward"]
    last = ["Mustache", "Pickle", "Hood Ornament", "Raisin", "Recycling Bin", "Potato", "Tomato", "House Cat", "Teaspoon", "Laundry Basket"]
    month = int(str(birthdate).split("-")[1])
    lst_digit = int(str(birthdate).split(" ")[0].split("-")[2][1])
    return first[month - 1] + " " + last[lst_digit]
