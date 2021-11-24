function padIt(str,n){
    var answer = str
    var test = true
    while (n-- > 0) {
        if (test) {
            answer = "*" + answer
            test = false
        } else {
            answer = answer + "*"
            test = true
        }
    }
    return answer
}