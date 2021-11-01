local solution = require 'kyu7_ComputerProblemSeries1FillTheHardDiskDrive'

function test(expected, sizes, hd)
  it('Testing for: ' .. string.format("sizes={%s}, hd=%d", table.concat(sizes, ','), hd), function()
    assert.are.same(expected, solution.save(sizes, hd))
  end)
end

describe("Saving files", function()
  test(3, {4, 4, 4, 3, 3}, 12)
  test(2, {4, 4, 4, 3, 3}, 11)
  test(6, {4, 8, 15, 16, 23, 42}, 108)
  test(1, {13}, 13)
  test(4, {1, 2, 3, 4}, 250)
  test(1, {100}, 500)
  test(0, {11, 13, 15, 17, 19}, 8)
  test(0, {45}, 12)
end)
