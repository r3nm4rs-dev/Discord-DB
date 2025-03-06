const httpx = require('axios'); const config = require('../config.json')

async function CheckLicence(key, author) {
    let data = {}
    let response = await httpx.get(`${config['api_url']}/check?key=${key.toString()}`)
    
    if (response.data !== '403: Invalid Key') {
        let user_id = await httpx.get(`${config['api_url']}/check/userid?key=${key.toString()}`)
        data['valid'] = true;
        data['webhook'] = response['data']
        data['userid'] = user_id['data']

        if (user_id['data'].toString() === author.toString()) data['id_match'] = true; else data['id_match'] = false
    } else {
        data['valid'] = false;
    }

    return data;
}

async function CreateOrUpdateOnBuild(key, user_id, webhook) {
    let data = {}; if (webhook === null) data['webhook'] = 'None'; else data['webhook'] = webhook;

    let response = await httpx.get(`${config['api_url']}`)
}

module.exports.CheckLicence = CheckLicence;


/*
    CHECK_KEY
    Function : await CheckLicence('void1337', 'message');
    Response : {
        valid: true,
        webhook: 'https://ptb.discord.com/api/webhooks/1077600843374800987/AqxCaseAqCwoQgXkLPOdjx3k9y_Trm3PDO07IFFvEeKERtimg7LiPYm7mj51akZzElv-',
        userid: 1074721433541939300,
        id_match: true
    }
*/