package elevator_distance.kyu7

class Kata {
    public static void main(String[] args) {
        println(elevatorDistance([5,2,8]))
    }

    static int elevatorDistance(a) {
        def answer = 0
        for (def i = 0; i < a.size() - 1; i++) {
            answer += Math.abs(a[i] - a[i + 1])
        }
        return answer
    }
}
