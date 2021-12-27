describe('Static tests', function(){
    it('Should work for static tests', function(){
        Test.assertEquals(howMuchWater(10,10,21), 'Too much clothes','');
        Test.assertEquals(howMuchWater(10,10,2), 'Not enough clothes','');
        Test.assertEquals(howMuchWater(10,11,20), 23.58,'');
        Test.assertEquals(howMuchWater(50,15,29), 189.87,'');
    });
})