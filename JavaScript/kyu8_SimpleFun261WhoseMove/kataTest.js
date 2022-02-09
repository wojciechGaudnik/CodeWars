describe("Basic Tests", function(){
    it("It should works for basic tests.", function(){

        Test.assertEquals(whoseMove("black",false),"white")

        Test.assertEquals(whoseMove("white",true),"white")

        Test.assertEquals(whoseMove("white",false),"black")

    })})