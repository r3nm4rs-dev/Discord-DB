const dpapi = require('bindings')('node-dpapi');

module.exports.protectData = dpapi.protectData;
module.exports.unprotectData = dpapi.unprotectData;
