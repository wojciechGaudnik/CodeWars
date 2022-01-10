function isOpposite(s1,s2){
    if (s1 === "") {
        return false;
    }
    let s1switched = '';
    for (let one of s1) {
        if (one === one.toUpperCase()) {
            s1switched += one.toLowerCase();
        } else {
            s1switched += one.toUpperCase();
        }
    }
    return s1switched === s2;
}