describe("Tests", () => {
    it("test", () => {
        Test.assertSimilar(cutIt(["ab","cde","fgh"]) , ["ab","cd","fg"]);
        Test.assertSimilar(cutIt(["abc","defgh","ijklmn"]) , ["abc","def","ijk"]);
        Test.assertSimilar(cutIt(["codewars","javascript","java"]) , ["code","java","java"]);

    });
});
