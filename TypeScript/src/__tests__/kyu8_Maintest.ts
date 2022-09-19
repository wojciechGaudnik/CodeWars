import {Main} from '../Main';

test('first', () => {
    const mainTest = new Main('hello')
    expect(mainTest.main()).toBe('hello');
})

