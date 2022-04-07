describe('package.json', () => {
    const isObjStringDictionary = (obj) => {
        if (typeof obj !== 'object') return false;
        if (obj instanceof Array) return false;

        const keys = Object.keys(obj);
        for (let key of keys) {
            if (typeof obj[key] !== 'string')
                return false;
        }

        return true;
    };
    const warn = msg => console.log(`warning: ${msg}`);

    it('check for mandatory fields', () => {
        Test.expect(!!configuration.name, 'Missing required field: name');
        Test.expect(!!configuration.version, 'Missing required field: version');

        if (!configuration.description)
            warn('Missing recommended field: description');
        if (!configuration.keywords)
            warn('Missing recommended field: keywords');
        if (!configuration.bugs)
            warn('Missing recommended field: bugs');
        if (!configuration.license)
            warn('Missing recommended field: license');
        if (!configuration.author)
            warn('Missing recommended field: author');
        if (!configuration.contributors)
            warn('Missing recommended field: contributors');
        if (!configuration.repository && !configuration.private)
            warn('Missing recommended field: repository (or private)');
    });

    it('validating name field', () => {
        Test.assertEquals(typeof configuration.name, 'string', 'name should be a string');

        Test.expect(!/^[._]/.test(configuration.name)
            && /^[\w.~-]+$/.test(configuration.name), 'valid names may have uppercase and lowercase letters, decimal digits, hyphen, period, underscore, and tilde');

        Test.expect(configuration.name.length < 214, 'name should be shorter than 214 characters');

        Test.assertEquals(configuration.name, configuration.name.toLowerCase(), 'only lowercase is allowed');

        if (/node/i.test(configuration.name)) {
            warn(`You shouldn't use 'node' in the package name, use engines section instead`);
        }
        if (/js/i.test(configuration.name)) {
            warn(`You shouldn't use 'js' in the package name, use engines section instead`);
        }

        console.info(`it is always good to check the npm registry to see if the name isn't already taken`);
    });

    it('validating version field', () => {
        Test.expect(/^\d+[.]\d+[.]\d+[\w-]*$/.test(configuration.version), 'expected format [0-9].[0-9].[0-9] (major.minor.patch) optionally followed by [A-Za-z0-9_-]');
    });

    it('validate description if present', () => {
        if (configuration.description)
            Test.assertEquals(typeof configuration.description, 'string', 'description should be a string');
    });

    it('validate main if present', () => {
        if (configuration.main)
            Test.assertEquals(typeof configuration.main, 'string', 'main should be a string');
    });

    it('validate keywords if present', () => {
        if (configuration.keywords) {
            Test.assertEquals(typeof configuration.keywords, 'object', 'keywords should be an array');
            Test.expect(configuration.keywords instanceof Array, 'keywords should be an array');

            if (configuration.keywords instanceof Array) {
                configuration.keywords.forEach(kw => Test.assertEquals(typeof kw, 'string', `keyword ${kw} should be a string`));
            }
        }
    });

    it('validate bugs if present', () => {
        if (configuration.bugs) {
            if (typeof configuration.bugs !== 'string')
                Test.expect(!!(configuration.bugs.url || configuration.bugs.email), 'bugs should contain url and/or email');
            else
                Test.expect(/^(https?|ftp)/i.test(configuration.bugs), 'if not an object a valid url is expected');
        }
    });

    it('validate license if present', () => {
        if (configuration.license) {
            if (typeof configuration.license === 'string') {
                Test.expect(/^(ISC|MIT|UNLICENSED|SEE LICENSE IN [\w. -]+)$/.test(configuration.license)
                    , `Sorry, license should be a valid SPDX license expression (without "LicenseRef"), "UNLICENSED", or "SEE LICENSE IN <filename>".`);
            }
            else {
                Test.expect(false, 'license field is expected to by a string');
            }
        }
    });

    it('validate author if present', () => {
        if (configuration.author) {
            if (typeof configuration.author === 'string') {
                Test.expect(!!configuration.author.replace(/\s/g, '').length);
            }
            else {
                Test.expect(!!configuration.author.name, 'name field is mandatory');
                Test.assertEquals(typeof configuration.author.name, 'string', 'name field should be a string');
            }
        }
    });

    it('validate contributors if present', () => {
        if (configuration.contributors) {
            Test.expect(configuration.contributors instanceof Array, 'contributors should be an array');

            if (configuration.contributors instanceof Array) {
                configuration.contributors.forEach(c => {
                    Test.assertEquals(typeof c.name, 'string', 'name should be a string');

                    if (typeof c.name === 'string')
                        Test.expect(!!c.name.replace(/\s/g, '').length, 'name field is mandatory');
                });
            }
        }
    });

    it('validate repository if present', () => {
        if (configuration.repository) {
            Test.assertEquals(typeof configuration.repository, 'object');

            Test.expect(!!configuration.repository.type, 'type is mandatory');
            Test.expect(!!configuration.repository.url, 'url is mandatory');

            Test.assertEquals(typeof configuration.repository.type, 'string');
            Test.assertEquals(typeof configuration.repository.url, 'string');
        }
    });

    it('validate private if present', () => {
        if (typeof configuration.private !== 'undefined') {
            Test.assertEquals(typeof configuration.private, 'boolean', 'private should be a boolean');
        }
    });

    it('validate preferGlobal if present', () => {
        if (typeof configuration.preferGlobal !== 'undefined') {
            Test.assertEquals(typeof configuration.preferGlobal, 'boolean', 'preferGlobal should be a boolean');
        }
    });

    it('validate engines if present', () => {
        if (configuration.engines) {
            Test.expect(isObjStringDictionary(configuration.engines));
        }
    });

    it('validate os if present', () => {
        if (configuration.os) {
            Test.expect(configuration.os instanceof Array, 'OS should be an array');

            if (configuration.os instanceof Array) {
                configuration.os.forEach(o => {
                    Test.assertEquals(typeof o, 'string');

                    if (typeof o === 'string')
                        Test.expect(!!o.replace(/\s/g, '').length);
                });
            }
        }
    });

    it('validate cpu if present', () => {
        if (configuration.cpu) {
            Test.expect(configuration.cpu instanceof Array, 'CPU should be an array');

            if (configuration.cpu instanceof Array) {
                configuration.cpu.forEach(o => {
                    Test.assertEquals(typeof o, 'string');

                    if (typeof o === 'string')
                        Test.expect(!!o.replace(/\s/g, '').length);
                });
            }
        }
    });

    it('validate scripts if present', () => {
        if (configuration.scripts) {
            Test.expect(isObjStringDictionary(configuration.scripts));
        }
    });

    const validateDependency = dp => {
        Test.expect(isObjStringDictionary(dp));

        const keys = Object.keys(dp);
        for (let key of keys) {
            let dependency = dp[key];
            let isValid = false;

            if (/^(>=?|<=?|[~^])?\d+[.]\d+[.]\d+[\w-]*$/.test(dependency)) isValid = true;
            else if (/^\d+[.]\d+[.]x$/.test(dependency)) isValid = true;
            else if (/^[*]?$/.test(dependency)) isValid = true;
            else if (/^(http|git)/.test(dependency)) isValid = true;
            else if (/^(\w+\/\w+|\w+)$/.test(dependency)) isValid = true;
            else if (/^([.~]?\/|[.][.]\/)/.test(dependency)) isValid = true;
            else if (/^\d+[.]\d+[.]\d+[\w-]*\s*-\s*\d+[.]\d+[.]\d+[\w-]*$/.test(dependency)) isValid = true;

            Test.expect(isValid, `dependency '${dependency}' is not valid`);
        }
    };

    it('validate dependencies if present', () => {
        if (configuration.dependencies) {
            validateDependency(configuration.dependencies);
        }
    });

    it('validate devDependencies if present', () => {
        if (configuration.devDependencies) {
            validateDependency(configuration.devDependencies);
        }
    });
});