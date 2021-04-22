const readCars = async () => {
	const response = await fetch('http://localhost:3005/cars');
	const myjson = await response.json();

	const responseRicknMorty = await fetch('https://rickandmortyapi.com/api/character');
	const myjsonRicknMorty = await responseRicknMorty.json();

	render(myjson, myjsonRicknMorty);
};

const render = (data, dataRicknMorty) => {
	let html = data
		.map((elem) => {
			var randomnumber = Math.floor(Math.random() * (19 - 0 + 1)) + 0;
			var image = dataRicknMorty.results[randomnumber].image;
			return `
            <div>
                <img src="${image}" alt="character" height="50px" />
                ${elem.name} ${elem.model} ${elem.year}
            </div>
        `;
		})
		.join(' ');

	document.getElementById('cars').innerHTML = html;
};

readCars();

function addCar() {
	debugger;
	let name = document.getElementById('name').value;
	let model = document.getElementById('model').value;
	let year = document.getElementById('year').value;

	if (name && model && year) {
		let rawText = `{
			"name": "${name}",
			"model": "${model}",
			"year": "${year}"
		}`;

		apiAddCar(rawText);
	}

	return false;
}

const apiAddCar = async (rawText) => {
	
	const response = await fetch('http://localhost:3005/addcar', {
		method: 'POST',
		body: rawText,
		headers: {
			'Content-Type': 'application/json',
		},
	});

	if (response.status === 200) {
		console.log('Car added');
		readCars();
	} else {
		console.log('something went wrong..');
	}
};
