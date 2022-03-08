function decimalToHexString(number){
    if (number < 0){
        number = 0xFFFFFFFF + number + 1;
    }
    return ('00' + number.toString(16).toLocaleLowerCase()).substr(-2);
}

function colorOf(r,g,b){
    return `#${decimalToHexString(r)}${decimalToHexString(g)}${decimalToHexString(b)}`
}