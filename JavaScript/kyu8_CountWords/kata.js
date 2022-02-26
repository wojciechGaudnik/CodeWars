function countWords(str) {
    const found = str.match(/[A-Za-z0-9\-']+/g);
    return found ? found.length : 0;
}