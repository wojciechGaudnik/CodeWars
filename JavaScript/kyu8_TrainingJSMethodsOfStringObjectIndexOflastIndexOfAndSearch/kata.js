function firstToLast(str,c){
    if (!str.includes(c)) {
        return -1;
    }
    let first = str.indexOf(c);
    let last = str.lastIndexOf(c);
    return last - first;
}