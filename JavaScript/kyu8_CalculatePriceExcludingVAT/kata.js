function excludingVatPrice(price){
    if (price === null) {
        return -1;
    }
    return Math.round((price / 1.15) * 100) / 100;
}