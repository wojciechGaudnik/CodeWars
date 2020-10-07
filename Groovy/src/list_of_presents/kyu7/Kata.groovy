package list_of_presents.kyu7

class Kata {

    public static void main(String[] args) {
//        println(howManyGifts(20, [13, 2, 4, 6, 1]))
        println(howManyGifts(100, [6, 94, 10, 45, 2, 4, 5, 6, 8, 1]))
        println([1, 2, 4, 5, 6, 6, 8, 10, 45, 94].take(9).sum())
    }

    static int howManyGifts(maxBudget, gifts){
        println(maxBudget + " "  + gifts)
        gifts = gifts.sort()
        def answer = 0
        def sum = 0
        for (def i = 0; i < gifts.size(); i++) {
            sum += gifts[i]
            if (sum <= maxBudget) {
                answer++
                continue
            }
            break
        }
        return answer ;
    }
}
