describe("Tests", () => {
    it("test", () => {
        Test.assertSimilar(infiniteLoop( [[1,2,3],[4,5,6],[7,8,9]],"left",1) , [[2,3,4],[5,6,7],[8,9,1]]);
        Test.assertSimilar(infiniteLoop( [[1,2,3],[4,5,6],[7,8,9]],"right",1) , [[9,1,2],[3,4,5],[6,7,8]]);
        Test.assertSimilar(infiniteLoop( [[1,2],[3,4,5,6],[7,8,9,10]],"left",2)  , [[3,4],[5,6,7,8],[9,10,1,2]]);

    });
});
