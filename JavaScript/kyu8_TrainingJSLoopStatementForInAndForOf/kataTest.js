describe("Tests", () => {
    it("test", () => {
        Test.assertSimilar(giveMeFive({Our:"earth",is:"a",beautyful:"world"}),["earth","world"]);
        Test.assertSimilar(giveMeFive({Ihave:"enough", money:"to",buy:"a",car:"model"}),["Ihave","money","model"]);
        Test.assertSimilar(giveMeFive({Pears:"than",apple:"sweet"}),["Pears","apple","sweet"]);

    });
});
