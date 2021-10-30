local s = require "kyu7_TwoOldestAges"
describe("twoOldestAges", function()
  it("should return {45,87} for ages {1,5,87,45,8,8}", function()
    assert.are.same({45,87}, s.twoOldestAges({1,5,87,45,8,8}))
  end)
  it("should return {18,83} for ages {6,5,83,5,3,18}", function()
    assert.are.same({18,83}, s.twoOldestAges({6,5,83,5,3,18}))
  end)
end)
