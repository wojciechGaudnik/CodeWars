function roundIt(n){
    let split = n.toString().split('.');
    if (split[0].length > split[1].length) {
        return Math.floor(n);
    }
    if (split[0].length < split[1].length) {
        return Math.ceil(n);
    }
    return Math.round(n);
}