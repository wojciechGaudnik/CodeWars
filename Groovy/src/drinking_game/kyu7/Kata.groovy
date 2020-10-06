package drinking_game.kyu7


class Kata {
    static game(A, B) {
        if (A == 0 || B == 0) {
            return "Non-drinkers can't play"
        }
        def Mike = 0
        def Joe = 0
        def paint = 1
        while (Mike <= A && Joe <= B) {
            if (paint % 2 == 1) {
                Mike += paint++
                continue
            }
            Joe += paint++
        }
        if (Mike > A) {
            return "Joe"
        }
        return "Mike"
    }
}
