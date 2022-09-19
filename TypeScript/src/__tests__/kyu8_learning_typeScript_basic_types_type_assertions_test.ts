import {expect} from "chai";
import {
    getResult,
    ErrorServerResult,
    SuccessServerResult
} from '../kata/learning_typeScript_basic_types_type_assertions_kyu8';

describe("getResult", () => {
    it("should return correct results for SuccessServerResult", () => {
        var message = {"message": "Hello, world!"};
        var success = new SuccessServerResult(200, message);
        expect(getResult(success)).to.deep.equal(message);
    });
    it("should return correct results for ErrorServerResult", () => {
        var message = "Not found";
        var error = new ErrorServerResult(404, message);
        expect(getResult(error as any)).to.equal(message);
    });
});
