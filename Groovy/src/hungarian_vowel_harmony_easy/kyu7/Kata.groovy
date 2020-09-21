package hungarian_vowel_harmony_easy.kyu7

class Kata {

    static def dative(word) {
        def frontVowel =  "eéiíöőüű"
        def backVowel = "aáoóuú"
        return (word as String).reverse().findResult {
            if (frontVowel.contains(it)) {
                return word + "nek"
            }
            if (backVowel.contains(it)) {
                return word + "nak"
            }
        }
    }
}
