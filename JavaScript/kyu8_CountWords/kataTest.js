describe("countWords", function() {
    it("should work in basic form of problem", function() {
        Test.assertEquals(countWords("Hello"), 1);
        Test.assertEquals(countWords("Hello, World!"), 2);
        Test.assertEquals(countWords("Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."), 19);
        Test.assertEquals(countWords(""), 0);
        Test.assertEquals(countWords("With! Symbol@ #Around! (Every) %Word$"), 5);
        Test.assertEquals(countWords("Dear   Victoria, I love  to press   space button."), 8);
    });

    it("should work with spaces around string", function() {
        Test.assertEquals(countWords(" Arthur "), 1);
        Test.assertEquals(countWords(" David"), 1);
        Test.assertEquals(countWords("Nelson "), 1);
        Test.assertEquals(countWords("  Hello Gomer  "), 3);
        Test.assertEquals(countWords("  Hello     Bart  "), 2);
    });

    it("should work with non-whitespace (ex. breakspace) chars", function() {
        Test.assertEquals(countWords("﻿Hello﻿World "), 2);
        Test.assertEquals(countWords("Hello﻿World"), 2);
    });
});