function topSecret(str){
    let upper = "XYZABCDEFGHIJKLMNOPQRSTUVW";
    let lower = upper.toLocaleLowerCase();
    var answer = "";
    for (one of str) {
        if (!isCharacterALetter(one)) {
            answer += one;
            continue;
        }
        if (one === one.toUpperCase()) {
           answer += upper.charAt(one.charCodeAt(0) - 65);
        } else if (one === one.toLowerCase()){
            console.log(one.charCodeAt(0));
            answer += lower.charAt(one.charCodeAt(0) - 97);
        }
    }
    return answer;
}
function isCharacterALetter(char) {
    return (/[a-zA-Z]/).test(char)
}
//question1: The top secret file number is...
const answer1="3745";
//question2: Super agent's name is...
const answer2="RILc";
//question3: He stole the treasure is...
const answer3="Expired biscuits";