package selective_array_reversing.kyu6

class SelReverse {

    static selReverse(arr, l) {
        if (l == 0) {
            return arr
        }
        def answer = []
        def i
        for (i = 0; i + l < arr.size(); i += l) {
            answer += arr[i + l - 1..i]
        }
        answer.addAll(arr[-1..i])
        return answer
    }
}
