package elevator_distance.kyu7

class Kata {

    static int elevatorDistance(a) {
        def answer = 0
        for (def i = 0; i < a.size() - 1; i++) {
            answer += Math.abs(a[i] - a[i + 1])
        }
        return answer
    }
}
