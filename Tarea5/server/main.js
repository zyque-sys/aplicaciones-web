var express = require('express');
var app = express();
var server = require('http').Server(app);
const fs = require('fs');

app.use(express.static('public'));

const bodyParser = require('body-parser');
app.use(bodyParser.json());

const dataPathCars = 'server/data/cars.json';
const readFile = (callback, filePath) => {
	fs.readFile(filePath, 'utf8', (err, data) => {
		if (err) {
			throw err;
		}

		callback(JSON.parse(data));
	});
};

const writeFile = (fileData, callback, filePath) => {
	fs.writeFile(filePath, fileData, 'utf8', (err) => {
		if (err) {
			throw err;
		}

		callback();
	});
};

app.get('/cars', (req, res) => {
	readFile((data) => {
		res.status(200).send(data);
	}, dataPathCars);
});

app.post('/addcar', (req, res) => {
	readFile((data) => {
		console.log(req.body);
		data.push(req.body);

		writeFile(
			JSON.stringify(data, null, 2),
			() => {
				res.status(200).send('New car added!');
			},
			dataPathCars
		);
	}, dataPathCars);
});



server.listen(3005, () => {
	console.log('Server is running in http://localhost:3005');
});
