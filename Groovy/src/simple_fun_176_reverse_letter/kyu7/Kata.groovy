package simple_fun_176_reverse_letter.kyu7

class Kata {

    static def reverseLetter(string) {
        return (string as String).reverse().findAll({ c -> (c as char).isLetter() }).join("")
    }
}
