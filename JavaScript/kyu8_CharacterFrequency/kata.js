function charFreq(message) {
    var f = {};
    for (let c of message) {
        if (f[c]) {
            f[c] += 1;
        } else {
            f[c] = 1;
        }
    }
    return f;
}