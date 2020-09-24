package simple_fun20_first_reverse_try.kyu7

class Kata {
    static def solution(arr) {
        if (arr.size() <= 1) return arr
        if (arr.size() == 2) return  [arr[-1]] + [arr[0]]
        return [arr[-1]] + arr[1..-2] + [arr[0]]
    }
}