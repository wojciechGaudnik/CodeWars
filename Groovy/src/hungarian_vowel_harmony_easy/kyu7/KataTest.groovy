package hungarian_vowel_harmony_easy.kyu7

import org.junit.Test

class KataTest {
    @Test
    void "Example Tests"() {
        assert Kata.dative("ablak") == "ablaknak"
        assert Kata.dative("tükör") == "tükörnek"
        assert Kata.dative("keret") == "keretnek"
        assert Kata.dative("otthon") == "otthonnak"
        assert Kata.dative("virág") == "virágnak"
        assert Kata.dative("tett") == "tettnek"
        assert Kata.dative("rokkant") == "rokkantnak"
        assert Kata.dative("rossz") == "rossznak"
        assert Kata.dative("gonosz") == "gonosznak"
    }
}
