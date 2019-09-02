function isPronic(pNum) {
    // for(var i  = 0; i <= pNum; i++) {
    //     var result = i * (i+1);
    //     if( result === pNum) {
    //         return true;
    //     }
    // }
    // return false;
    return Math.sqrt(1 + 4 * pNum) % 1 === 0;
}



console.log(isPronic(0));
console.log(isPronic(1));
console.log(isPronic(2));
console.log(isPronic(3));
console.log(isPronic(4));
console.log(isPronic(5));
console.log(isPronic(6));
console.log(isPronic(-3));
console.log(isPronic(-27));
