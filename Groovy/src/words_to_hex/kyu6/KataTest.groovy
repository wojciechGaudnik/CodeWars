package words_to_hex.kyu6

import org.junit.Test

class KataTest{
    @Test
    void "Sample Tests" () {
        assert Kata.wordsToHex('Hello, my name is Gary and I like cheese.') == ['#48656c', '#6d7900', '#6e616d','#697300','#476172','#616e64','#490000','#6c696b','#636865']
        assert Kata.wordsToHex('0123456789') == [ '#303132' ]
        assert Kata.wordsToHex('ThisIsOneLongSentenceThatConsistsOfWords') == [ '#546869' ]
        assert Kata.wordsToHex('Blah blah blah blaaaaaaaaaaaah') == [ '#426c61', '#626c61', '#626c61', '#626c61' ]
        assert Kata.wordsToHex('&&&&& $$$$$ ^^^^^ @@@@@ ()()()()(') == [ '#262626', '#242424', '#5e5e5e', '#404040', '#282928' ]
    }
}
