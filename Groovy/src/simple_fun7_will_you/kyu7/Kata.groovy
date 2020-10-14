package simple_fun7_will_you.kyu7

class Kata {
    static def willYou(young, beautiful, loved) {
        if (young && beautiful && !loved) {
            return true
        }
        if (loved && (!young || !beautiful)) {
            return true
        }
        return false
    }
}
