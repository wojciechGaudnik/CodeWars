function excludingVatPrice(price){
    return Math.round((price / 1.15) * 100) / 100;
}