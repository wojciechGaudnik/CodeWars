describe("Tests", () => {
    it("test", () => {
//Fixed testcase only test the correctness
//of the decryption code.
//The answer to the three question will appear
//only after clicking on "Submit".
        Test.assertSimilar(topSecret("Pb qdph lv Mrkq") , "My name is John");
        Test.assertSimilar(topSecret("wklv lv dq hadpsoh") , "this is an example");
        Test.assertSimilar(topSecret("Khoor Zruog!") , "Hello World!");

    });
});
