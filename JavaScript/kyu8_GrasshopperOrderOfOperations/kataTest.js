const func = orderOperations.toString()
describe('order of operations', () => {
    it('should not use any numbers other than 2', () => {
        let re = /([0,1,3,4,5,6,7,8,9])/gi
        let others = func.match(re)
        Test.assertEquals(others, null)
    })
    it('should have the plus and the multiplication in the same place', () => {
        let re = /[+,*]/gi
        let operators = func.match(re)
        Test.assertEquals(operators[0], '+')
        Test.assertEquals(operators[1], '*')
        Test.assertEquals(operators[2], '+')
        Test.assertEquals(operators[3], '*')
    })
    it('should get the correct number', () => {
        Test.assertEquals(orderOperations(), 32)
    })
})