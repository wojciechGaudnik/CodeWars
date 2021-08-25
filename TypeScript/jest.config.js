module.exports = {
  "roots": [
    "<rootDir>/src"
  ],
  "testMatch": [
    "**/__tests__/**/*.+(ts|tsx|js)",
    "**/?(*.)+(spec|test|Test).+(ts|tsx|js)",
    '<rootDir>/src/**/*.test.js',
  ],
  "transform": {
    "^.+\\.(ts|tsx)$": "ts-jest"
  },
}