package words_to_hex.kyu6

class Kata {
    static String[] wordsToHex(String words) {
        words.split(' ').collect {
            def answer = new StringBuilder("000000")
            if (it[0]) {
                answer.replace(0, 2, Integer.toHexString((it[0] as char) as int) )
            }
            if (it.size() > 1) {
                answer.replace(2, 4, Integer.toHexString((it[1] as char) as int) )
            }
            if (it.size() > 2) {
                answer.replace(4, 6, Integer.toHexString((it[2] as char) as int) )
            }
            ("#" + answer).toString()
        }
    }
}
