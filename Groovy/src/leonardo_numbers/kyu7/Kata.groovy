package leonardo_numbers.kyu7

class Kata {

    static leonardoNumbers(n, L0, L1, add) {
        def answer = [L0, L1]
        for (def i = 1; answer.size() < n; i++) {
            answer.add(answer[i -1] + answer[i] + add)
        }
        return answer
    }
}
