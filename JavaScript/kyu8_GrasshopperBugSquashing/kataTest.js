describe('syntax bug fixes', () => {
    it('should define varirables and store values', () => {
        Test.assertEquals(health, 100)
        Test.assertEquals(position, 0)
        Test.assertEquals(coins, 0)
    })
})
describe('reference error bug fixes', () => {
    it('should only call functions that exist', () => {
        Test.expectNoError(() => {
            main()
        })
    })
})
describe('runtime error bug fixes', () => {
    it('should roll dice first', function () {
        Test.assertEquals(log[0], 'rollDice')
    })
    it('should move second', function () {
        Test.assertEquals(log[1], 'move')
    })
    it('should combat third', function () {
        Test.assertEquals(log[2], 'combat')
    })
    it('should get coins fourth', function () {
        Test.assertEquals(log[3], 'getCoins')
    })
    it('should buy health fifth', function () {
        Test.assertEquals(log[4], 'buyHealth')
    })
    it('should print status sixth', function () {
        Test.assertEquals(log[5], 'printStatus')
    })
})