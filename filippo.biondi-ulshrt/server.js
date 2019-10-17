const express = require('express');
const dotenv = require('dotenv').config();
const path = require('path');
const bodyParser = require('body-parser');
const methodOverride = require('method-override');
const app = express();
const MongoClient = require('mongodb').MongoClient;
const generateRandomString=(len) => {
    let randomString = '';
    const language = process.env.LANGUAGE;
    for(let i=0;i<len;i++) {
        let random = Math.random() * language.length;
        randomString += language.charAt(random); 
    }
    return randomString;
};

app.use(methodOverride());
app.use(bodyParser.json());

MongoClient.connect('mongodb://localhost:27017/shrt',{useUnifiedTopology: true}, (err, client) => {
    if(err) {
        console.err('MongoDB Connection error '+ err);
    }
    else {
        const db = client.db('shrt');
        const urls = db.collection('urls');

        app.get('/', (req, res) => {
            res.sendFile(path.join(__dirname + '/static/index.html'));
        });

        app.post('/register',(req, res) => {
            if(typeof req.body.url === 'string') {
                newUrl = generateRandomString(6);
                url = req.body.url;
                if(!url.startsWith("http://") && !url.startsWith("https://")) {
                    url = "http://" + url;
                }
                urls.updateOne({
                    'shrt': newUrl
                }, 
                {
                    $set: {
                        'url':url
                    }
                }, {upsert:true});
                res.json({url: process.env.DOMAIN + newUrl});
            }
            else {
                res.json({error:true});
            }
        });

        app.get('/*', (req, res) => {
            param = req.url.split("/")[1];
            if(param != 'register') {
                urls.findOne({'shrt':param},(err, data) => {
                    if(data) {
                        res.status(301).redirect(data.url);
                    }
                    else {
                        res.redirect('/');
                    }
                });
            }   
        });

        app.listen(process.env.PORT, () => {
            console.log('urlshrt listening on port ' + process.env.PORT);
        });
    }
});