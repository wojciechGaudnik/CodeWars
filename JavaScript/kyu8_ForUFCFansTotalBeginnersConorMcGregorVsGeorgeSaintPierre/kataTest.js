describe("Tests", () => {
    it("test", () => {
        Test.assertEquals(quote('george saint pierre'), "I am not impressed by your performance.")
        Test.assertEquals(quote('conor mcgregor'), "I'd like to take this chance to apologize.. To absolutely NOBODY!")

        Test.assertEquals(quote('George Saint Pierre'), "I am not impressed by your performance.")
        Test.assertEquals(quote('Conor McGregor'), "I'd like to take this chance to apologize.. To absolutely NOBODY!")
    });
});
