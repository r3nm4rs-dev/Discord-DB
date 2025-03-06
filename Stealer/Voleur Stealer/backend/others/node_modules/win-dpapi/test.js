const dpapi = require('bindings')('node-dpapi');

const entropy = Buffer.from("AHHH!H!H!H!!!!", "utf-8");

const buffer = Buffer.from("Hello World", "utf-8");

const currentUser = dpapi.protectData(buffer, null, "CurrentUser");
const withEntropy = dpapi.protectData(buffer, entropy, 'currentUser');
const localMachine = dpapi.protectData(buffer, null, 'localMachine');

const currentUserClear = dpapi.unprotectData(currentUser, null, 'currentUser');
console.log(`CurrentUser Decrypted: '${currentUserClear}'`);

const withEntropyClear = dpapi.unprotectData(withEntropy, entropy, 'currentUser');
console.log(`WithEntropy Decrypted: '${withEntropyClear}'`);

let clear = dpapi.unprotectData(localMachine, null, 'localMachine');
console.log(`Machine Decrypted: '${clear}'`);
