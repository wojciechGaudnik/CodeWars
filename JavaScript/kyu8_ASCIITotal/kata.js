function uniTotal(word){
    return word.split('').map(c => c.charCodeAt(0)).reduce((a, b) => a + b, 0)
}