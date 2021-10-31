local s = require 'kyu7_InterviewQuestionEasy';

describe("Sample Tests", function()
    it("Tests", function()
        assert.equal("c:**,h:*,i:*,a:*,g:*,o:*",  s.getStrings("Chicago"),  "City: Chicago");
        assert.equal("b:*,a:*,n:*,g:*,k:**,o:*",  s.getStrings("Bangkok"),  "City: Bangkok");
        assert.equal("l:*,a:**,s:**,v:*,e:*,g:*", s.getStrings("Las Vegas"), "City: Las Vegas");
    end);
end);
