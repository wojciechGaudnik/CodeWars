describe("Tests", () => {
    it("test", () => {
        Test.assertEquals(addExtra([1,2,3]).length, 4)
        Test.assertEquals(addExtra([1,2]).length, 3)
        Test.assertEquals(addExtra([]).length, 1)

        var arr = [1,2,3];
        Test.assertNotEquals(addExtra(arr),arr, "Description: ...You have to create a new list..." )

    });
});
