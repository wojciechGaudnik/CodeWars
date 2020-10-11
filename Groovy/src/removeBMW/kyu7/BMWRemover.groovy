package removeBMW.kyu7

class BMWRemover {

    static removeBMW(str) {
        if ((str as String).any {
            (it as char).isDigit()
        }) {
            throw new IllegalArgumentException("This program only works for text.")
        }
        return str.replaceAll("[bmwBMW]", "")
    }
}
