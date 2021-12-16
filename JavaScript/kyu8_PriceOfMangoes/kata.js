function mango(quantity, price){
    return Math.floor(quantity / 3) * 2 * price + quantity % 3 * price;
}
