
let cards = document.querySelectorAll('.square');
let cardsamt;
let movesamt;
let cardSets=[];
let cardCouples=[];
const url= "https://rickandmortyapi.com/api/character/";
var flips = document.querySelector('.flips');
let hasFlippedCard = false;
let card1, card2=[];

document.addEventListener('DOMContentLoaded', () => {

  const modal = document.getElementById("modal-result");
  const exit = document.querySelector('.close');

  exit.onclick = function() {
      
      modal.style.display = "none";
  }

  window.onclick = function(event) {
      if(event.target == modal) {
          modal.style.display = "none";
      }
  }
});
init();

const sleep = (delay) => new Promise((resolve) => setTimeout(resolve, delay));

function init() {
    setCards();
   
}
function setMoves() {
  flips.innerHTML = `Movimientos: ${movesamt}`;
}
async function setCards() {
  hasFlippedCard = true;

  cardsamt = 0;
  movesamt = 0;
  cardSets = [];
  cardCouples = [];
  card1 = [];
  card12 = [];
  const response = await fetch(`${url}`);
  setMoves();

  for (let i = 0; i < 16; i++) {
      cardsamt++;
      cardSets[i] = "https://rickandmortyapi.com/api/character/avatar/" + cardsamt + ".jpeg";
      if (cardsamt == 8) {
          cardsamt = 0;
      }
  }
  cardSets.sort(() => Math.random() - 0.5);
}
function restart() {
  location.reload();
}
async function isCouple(){
  movesamt++;
  setMoves();
  if(card2[0] == card2[1]){
      cardCouples.push(card1.pop());
      cardCouples.push(card1.pop());
      hasFlippedCard= true;
      return true;
  }
  await sleep(900);
  card1.pop().innerHTML = ``;
  card1.pop().innerHTML = ``;
  hasFlippedCard = true;
  return false;
}

async function flipCards(number) {
  if (!hasFlippedCard) return;
  if (GameOver()) return;
  
  for (let i = 0; i < cardCouples.length; i++) {
      const element = cardCouples[i];
      if (element.dataset.key == cards[number].dataset.key) {
          return;
      }
  }

  if (card1.length == 0) {
      
      card1.push(cards[number]);
      card1[0].innerHTML = `<img src="${cardSets[number]}" >`
      card2[0] = cardSets[number];
      return;
  }

  if (card1[0].dataset.key === cards[number].dataset.key)  return;
 
  hasFlippedCard = false;
  card1.push(cards[number]);
  card1[1].innerHTML = `<img src="${cardSets[number]}" >`
  card2[1] = cardSets[number];
  doMatch();
  if (GameOver()) return;
}



function GameOver() {

  if (CompletedCards.length == 16) {
      findWinner();
      return true
  }
  return false;
}
function findWinner() {
   const modal = document.getElementById('modal-result');
   modal.style.display = "block";

   const winnerTextResult = document.querySelector('#winner-result-text');
   winnerTextResult.innerHTML = `Movimientos: ${movesamt}`;
}

