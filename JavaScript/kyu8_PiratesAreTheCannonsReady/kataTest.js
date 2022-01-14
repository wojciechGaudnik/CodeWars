var a = {'Mike':'aye','Joe':'aye','Johnson':'aye','Peter':'aye'},
    b = {'Mike':'aye','Joe':'nay','Johnson':'aye','Peter':'aye'};

describe("Tests", function(){
    it("should Fire on aye", function(){
        Test.assertEquals(cannonsReady(a), 'Fire!');
    });
    it("should Shiver me timbers on nay", function(){
        Test.assertEquals(cannonsReady(b), 'Shiver me timbers!');
    });
});