package ordered_count_of_characters.kyu7

class Kata {
    static def orderedCount(input) {
        return (input as String).toCharArray().toList().countBy {it}.collect {e -> [e.key, e.value]}
//        return (input as String).toList().countBy {it}.collect {k,v -> [k, v]}
    }
}
