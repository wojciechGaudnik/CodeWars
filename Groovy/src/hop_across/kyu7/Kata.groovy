package hop_across.kyu7

class Kata {

    static hopAcross(a) {
        if (a.size() == 1) return 2
        def answer = 0
        for (def i = 0; i < a.size();) {
            answer++
            i += a[i]
        }
        for (def i = a.size() - 1; i >= 0;) {
            answer++
            i -= a[i]
        }
        return answer
    }
}
