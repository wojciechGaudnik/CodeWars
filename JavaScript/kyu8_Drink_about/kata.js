function peopleWithAgeDrink(old) {
    let drink = "drink ";
    if (old <= 12) {
        return drink + "toddy";
    } else if (old <= 16) {
        return drink + "coke";
    } else if (old < 20) {
        return drink + "beer";
    }
    return drink + "whisky";
}
