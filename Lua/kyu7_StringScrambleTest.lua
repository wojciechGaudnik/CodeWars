local solution = require 'kyu7_StringScramble'

describe('Solution', function()
  it('passes the sample tests', function()
    assert.are.same('acdb',   solution.scramble('abcd',   { 1, 4, 2, 3 }))
    assert.are.same('c0s3s1', solution.scramble('sc301s', { 5, 1, 4, 2, 6, 3 }))
    assert.are.same('5sblk',  solution.scramble('bskl5',  { 3, 2, 5, 4, 1 }))
    assert.are.same('hello',  solution.scramble('ehlol',  { 2, 1, 4, 5, 3 }))
    assert.are.same('world',  solution.scramble('dwolr',  { 5, 1, 2, 4, 3 }))
  end)
end)
