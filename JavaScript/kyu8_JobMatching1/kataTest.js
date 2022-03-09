describe("Tests", () => {
    it("test", () => {
        let candidate1 = { minSalary: 120000 },
            job1 = { maxSalary: 130000 },
            job2 = { maxSalary: 80000 };

        Test.assertEquals(match(candidate1, job1), true);
        Test.assertEquals(match(candidate1, job2), false);
    });
});
