describe("Tests", () => {
    it("test", () => {
        Test.assertSimilar(splitAndMerge("My name is John"," ") , "M y n a m e i s J o h n");
        Test.assertSimilar(splitAndMerge("My name is John","-") , "M-y n-a-m-e i-s J-o-h-n");
        Test.assertSimilar(splitAndMerge("Hello World!",".") , "H.e.l.l.o W.o.r.l.d.!");
        Test.assertSimilar(splitAndMerge("Hello World!",",") , "H,e,l,l,o W,o,r,l,d,!");

    });
});
