describe("Basic tests",() =>{
    Test.assertEquals(checkTheBucket(["stone", "stone", "stone", "stone", "stone"]), false);
    Test.assertEquals(checkTheBucket(["stone", "stone", "stone", "stone", "gold"]), true);
    Test.assertEquals(checkTheBucket(["gold", "stone", "stone", "stone", "stone"]), true);
    Test.assertEquals(checkTheBucket([]), false);
    Test.assertEquals(checkTheBucket(["stone", "stone", "stone", "gold", "gold"]), true);
})