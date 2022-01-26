describe("Basic Tests", function() {
    Test.assertEquals(typeValidation(42, "number"), true);
    Test.assertEquals(typeValidation("42", "number"), false);
});