describe("Tests", () => {
    it("test", () => {
        Test.assertSimilar(capitalizeWord('word'), 'Word');
        Test.assertSimilar(capitalizeWord('i'), 'I');
        Test.assertSimilar(capitalizeWord('glasswear'), 'Glasswear');
    });
});