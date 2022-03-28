describe("Tests", () => {
    it("test", () => {
        var people = [['bob','john'],['bob','john','dave'],[],['bob','john','dave','matt','alex']]

        for(var i=0;i<4;i++){
            var person = Person();
            person.fillFriends(people[i])
            Test.assertSimilar(person._friends, people[i])
        }
    });
});
