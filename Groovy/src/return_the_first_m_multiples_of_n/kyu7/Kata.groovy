package return_the_first_m_multiples_of_n.kyu7

class Kata {

    static def multiples(m, n) {
        def answer = []
        for(def i = 1; i <= m; i++)
            answer.add(n * i)
        return answer
    }
}
