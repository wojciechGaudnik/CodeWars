describe("countWords", function() {
    it("should work in basic form of problem", function() {
        "Hello"), 1);
        "Hello, World!"), 2);
        "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."), 19);
        ""), 0);
        "With! Symbol@ #Around! (Every) %Word$"), 5);
        "Dear   Victoria, I love  to press   space button."), 8);
        " Arthur "), 1);
        " David"), 1);
        "Nelson "), 1);
        "  Hello Gomer  "), 3);
        "  Hello     Bart  "), 2);
        "﻿Hello﻿World "), 2);
        "Hello﻿World"), 2);
    });
});