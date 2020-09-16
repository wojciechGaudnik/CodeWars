package drying_potatoes.kyu7

class Potatoes {
    static int potatoes(int initialPercent, int initialWeight, int finalPercent) {
        def potatoesInitialWeight = (100 - initialPercent) * 0.01 * initialWeight
        def potatoesAfterPercent = (100 - finalPercent) * 0.01
        return (((potatoesInitialWeight * finalPercent * 0.01) / potatoesAfterPercent) + potatoesInitialWeight) as int

    }
}
