local solution = require 'kyu7_StringMatchup'
describe("Fixed tests", function()
  it("tests", function()
    assert.are.same(solution.solve({'abc','abc','xyz','abcd','cde'},{'abc','cde','uap'}),{2,1,0})
    assert.are.same(solution.solve({'abc','xyz','abc', 'xyz','cde'}, {'abc','cde','xyz'}),{2,1,2})
    assert.are.same(solution.solve({'quick','brown','fox','is','quick'},{'quick','abc','fox'}),{2,0,1})
 end)
end)
