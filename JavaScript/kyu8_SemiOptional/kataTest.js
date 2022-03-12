describe("Fixed tests", function () {
    const res = wrap("MyTest")
    Test.assertEquals(typeof res , 'object',"Doesn't return an object")
    Test.assertEquals(res.value , "MyTest")
    Test.assertEquals(wrap(343).value , 343)
    var obj = {"test":"testy"};
    Test.assertEquals(wrap(obj).value , obj)
})
