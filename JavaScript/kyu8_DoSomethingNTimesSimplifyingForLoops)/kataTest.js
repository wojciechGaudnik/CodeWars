describe("Number.prototype.times", () => {
    it("should work exactly like a for loop and throw no errors", () => {
        Test.expectNoError("Unexpected error was thrown", _ => {
            (6).times(_ => {
                console.log("Hello World");
            });
            (6).times(i => {
                if (typeof(i) !== "number") throw "'i' was not properly supplied to the anonymous function ;)";
                console.log(i);
            });
        });
        console.log("<h3>Same as doing this:</h3>");
        for (let i = 0; i < 6; i++) {
            console.log("Hello World");
        }
        for (let i = 0; i < 6; i++) {
            if (typeof(i) !== "number") throw "'i' was not properly supplied to the anonymous function ;)";
            console.log(i);
        }
    });
});