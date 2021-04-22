const cards = document.querySelectorAll('.square');

let hasFlippedCard = false;
let card1, card2;

function init() {
    hasFlippedCard=false;
    cards.forEach(cards => cards.addEventListener('click', flipCard));
   
}

const render = (data, dataRicknMorty) => {
	let html = data
		.map((elem) => {
			var randomnumber = Math.floor(Math.random() * (8 - 0 + 1)) + 0;
			var image = dataRicknMorty.results[randomnumber].image;
			return `
            <div class="photo">
                <img src="${image}" alt="${dataRicknMorty.results[randomnumber].name}" height="50px" />
            </div>
        `;
		})
		.join(' ');

	document.getElementById('square').innerHTML = html;
};



function flipCard() {
  this.classList.add('flip');

  if (!hasFlippedCard) {
    hasFlippedCard = true;
    card1 = this;
  } else {
    hasFlippedCard = false;
    card2 = this;

    if (card1.datakey === card2.datakey) {
      
      card1.removeEventListener('click', flipCard);
      card2.removeEventListener('click', flipCard);
    } else {
      setTimeout(() => {
        card1.classList.remove('flip');
        card2.classList.remove('flip');
      }, 1200);
    }
  }
}


