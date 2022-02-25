function Dog (breed) {
    this.breed = breed;
}

var snoopy = new Dog("Beagle");

snoopy.bark = function() {
    return "Woof";
};

var scoobydoo = new Dog("Great Dane");

scoobydoo.bark = function() {
    return "Woof";
};
