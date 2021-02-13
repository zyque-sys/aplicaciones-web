var socket = io.connect('http://localhost:8080', { forceNew: true });

socket.on('messages', (data) => {
	console.log(data);

	render(data);
});

function render(data) {
	let htmlArray = data.map((elem) => {
		let author = elem.author;
		let text = elem.text;

		return `<div>
            <strong>${author}:</strong>
            <em>${text}</em>
        </div>`;
	});
	console.log(htmlArray);

	let html = htmlArray.join(' ');
	console.log(html);

	let htmlArrayUsers = data.map((elem) => {
		let author = elem.author;

		return `<div >
		<ins style="color:chartreuse;">●</ins>
            <strong>${author}</strong>
			<br>
        </div><br>`;
	});
	let htmlusers = htmlArrayUsers.join(' ');
	console.log(htmlusers);

	document.getElementById('divmessages').innerHTML = html;
	document.getElementById('divonlineusers').innerHTML = htmlusers;
}

function addMessage(form) {
	let payload = {
		author: document.getElementById('username').value,
		text: document.getElementById('text').value,
	};

    socket.emit('new-message', payload);

    document.getElementById('text').value = '';
    return false;
}
