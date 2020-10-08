package removeBMW.kyu7

class BMWRemover {

    static void main(String[] args) {
        println(removeBMW("bmwvolvoBMW"))
        println(removeBMW(2))
    }

    static removeBMW(str) {
        if ((str as String).any {
            (it as char).isDigit()
        }) {
            throw new IllegalArgumentException("This program only works for text.")
        }
        return str.replaceAll("[bmwBMW]", "")
    }
}
