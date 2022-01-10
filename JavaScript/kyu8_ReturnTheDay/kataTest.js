describe( "whatday", function(){
    it( "should work for the examples" , function(){
        Test.assertEquals(whatday(1),'Sunday')
        Test.assertEquals(whatday(2), 'Monday')
        Test.assertEquals(whatday(3),'Tuesday')
        Test.assertEquals(whatday(8),  'Wrong, please enter a number between 1 and 7')
        Test.assertEquals(whatday(20),  'Wrong, please enter a number between 1 and 7')

    });
});