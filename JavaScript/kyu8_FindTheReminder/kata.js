function remainder(a, b){
    if (!a || !b) {
        return NaN;
    }
    return  Math.max(a, b) % Math.min(a, b);
}

module.exports = {remainder}