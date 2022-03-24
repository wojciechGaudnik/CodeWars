describe('Fixed Tests', () => {
    it("Basic Tests", () => {
        Test.assertEquals(generateLink('matt c'),'http://www.codewars.com/users/matt%20c');
        Test.assertEquals(generateLink('g964'),'http://www.codewars.com/users/g964');
        Test.assertEquals(generateLink('GiacomoSorbi'),'http://www.codewars.com/users/GiacomoSorbi');
        Test.assertEquals(generateLink('ZozoFouchtra'),'http://www.codewars.com/users/ZozoFouchtra');
        Test.assertEquals(generateLink('colbydauph'),'http://www.codewars.com/users/colbydauph');
    });
});