const cards = document.querySelectorAll('.square');

let hasFlippedCard = false;
let card1, card2;
function init() {
    hasFlippedCard=false;
    cards.forEach(cards => cards.addEventListener('click', flipCard));
}
cards.forEach(cards => cards.addEventListener('click', flipCard));

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


