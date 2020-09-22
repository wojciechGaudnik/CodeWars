package switcheroo.kyu7

class Kata {
    static def switcheroo(string) {
        def answer = ""
        for (def one : (string as String).toCharArray()) {
            if (one == 'a') answer += 'b'
            else if (one == 'b') answer += 'a'
            else answer += one
        }
        return answer
    }
}
