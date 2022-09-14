describe("The Shark class", () => {
    it("should construct an object properly", () => {
        var billy = new Shark("Billy", 3, "Alive and well");
        Test.assertEquals(billy.name, "Billy");
        Test.assertEquals(billy.age, 3);
        Test.assertEquals(billy.legs, 0);
        Test.assertEquals(billy.species, "shark");
        Test.assertEquals(billy.status, "Alive and well");
        Test.assertEquals(billy.introduce(), `Hello, my name is Billy and I am 3 years old.`);
        var charles = new Shark("Charles", 8, "Finding a mate");
        Test.assertEquals(charles.name, "Charles");
        Test.assertEquals(charles.age, 8);
        Test.assertEquals(charles.legs, 0);
        Test.assertEquals(charles.species, "shark");
        Test.assertEquals(charles.status, "Finding a mate");
        Test.assertEquals(charles.introduce(), `Hello, my name is Charles and I am 8 years old.`);
    });
});

describe("The Cat class", () => {
    it("should construct an object properly", () => {
        var cathy = new Cat("Cathy", 7, "Playing with a ball of yarn");
        Test.assertEquals(cathy.name, "Cathy");
        Test.assertEquals(cathy.age, 7);
        Test.assertEquals(cathy.legs, 4);
        Test.assertEquals(cathy.species, "cat");
        Test.assertEquals(cathy.status, "Playing with a ball of yarn");
        Test.assertEquals(cathy.introduce(), "Hello, my name is Cathy and I am 7 years old.  Meow meow!");
        var spitsy = new Cat("Spitsy", 6, "sleeping");
        Test.assertEquals(spitsy.name, "Spitsy");
        Test.assertEquals(spitsy.age, 6);
        Test.assertEquals(spitsy.legs, 4);
        Test.assertEquals(spitsy.species, "cat");
        Test.assertEquals(spitsy.status, "sleeping");
        Test.assertEquals(spitsy.introduce(), "Hello, my name is Spitsy and I am 6 years old.  Meow meow!");
    });
});

describe("The Dog class", () => {
    it("should construct an object properly", () => {
        var doug = new Dog("Doug", 12, "Serving his master", "Eliza");
        Test.assertEquals(doug.name, "Doug");
        Test.assertEquals(doug.age, 12);
        Test.assertEquals(doug.legs, 4);
        Test.assertEquals(doug.species, "dog");
        Test.assertEquals(doug.status, "Serving his master");
        Test.assertEquals(doug.introduce(), "Hello, my name is Doug and I am 12 years old.");
        Test.assertEquals(doug.greetMaster(), "Hello Eliza");
    });
});
