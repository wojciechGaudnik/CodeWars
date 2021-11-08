function isVow(a){
    let vowels = "aeiou"
    for (let i = 0; i < a.length; i++) {
        if (vowels.includes(String.fromCharCode(a[i]))) {
           a[i] = String.fromCharCode(a[i])
        }
    }
    return a
}

module.exports = {isVow}