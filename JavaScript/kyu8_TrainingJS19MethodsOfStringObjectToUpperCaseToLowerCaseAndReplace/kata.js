function alienLanguage(str){
    let answer = [];
    for (let word of str.split(" ")) {
        answer.push(word.toUpperCase().slice(0, word.length - 1) + word[word.length - 1].toLowerCase())
    }
    return answer.join(" ")
}
