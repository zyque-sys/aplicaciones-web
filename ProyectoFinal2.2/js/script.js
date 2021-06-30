let dice1 = document.getElementById("dice1");
let dice2 = document.getElementById("dice2");
let turnP1 = document.getElementById("player1");
let turnP2 = document.getElementById("player2");
var scoreP1 = document.getElementById("totalScoreP1");
var scoreP2 = document.getElementById("totalScoreP2");
var tempscoreP1 = document.getElementById("tempScoreP1");
var tempscoreP2 = document.getElementById("tempScoreP2");
var turn = 1;
var dice = "img/dice.png"; 
var dices = ["img/dice1.png", "img/dice2.png", "img/dice3.png", "img/dice4.png", "img/dice5.png", "img/dice6.png"];
var num1;
var num2;
var sum;
 
 
var winner;
 
const sleep = (delay) => new Promise((resolve) => setTimeout(resolve, delay));
 
document.addEventListener('DOMContentLoaded', () => {
 
    const modal = document.getElementById("modal-result");
    const exit = document.querySelector('.close');
 
    exit.onclick = function () {
 
        modal.style.display = "none";
    }
 
    window.onclick = function (event) {
 
        if (event.target == modal) {
            modal.style.display = "none";
        }
    }
});
 
init();
async function init() {
    sum = 0;
    scoreP1 = 0;
    scoreP2 = 0;
    tempScoreP1 = 0;
    tempScoreP2 = 0;
    winner = "";
    turn = 1;
    dice1.innerHTML = `<img src="${dice}" >`;
    dice2.innerHTML = `<img src="${dice}" >`;
    turnP1.classList.remove("active");
    turnP2.classList.remove("active");
    turnP1.classList.add("active");
    tempscoreP1.innerHTML = `${tempScoreP1}`;
    scoreP1.innerHTML = `${scoreP1}`;
    tempscoreP2.innerHTML = `${tempScoreP2}`;
    scoreP2.innerHTML = `${scoreP2}`;
}
 
 
 
async function RollDice() {
 
    var num1 = Math.floor(Math.random() * 6) + 1;
    var num2 = Math.floor(Math.random() * 6) + 1;
    dice1.innerHTML = `<img src="${dices[num1 - 1]}" >`
    dice2.innerHTML = `<img src="${dices[num2 - 1]}" >`
    Turns(num1, num2);
}
 
function Shift() {
    if (turn == 1) {
        scoreP1 += tempScoreP1;
        tempScoreP1=0;
        turn = 2;
        turnP1.classList.remove("active");
        turnP2.classList.add("active");
        tempscoreP1.innerHTML = `${tempScoreP1}`;
        scoreP1.innerHTML = `${scoreP1}`;
        if(GameOver()){
            return;
        }
         
        return turn;
    }
    if (turn == 2) {
        scoreP2 += tempScoreP2;
        tempScoreP2=0;
        turn = 1;
        turnP1.classList.add("active");
        turnP2.classList.remove("active");
        tempscoreP2.innerHTML = `${tempScoreP2}`;
        scoreP2.innerHTML = `${scoreP2}`;
        if(GameOver()){
            return;
        }
 
        return turn;
    }
}
 
async function Turns(num1, num2) {
    if (num1 == num2) {
        tempScoreP1 = 0;
        tempScoreP2 = 0;
        Shift();
        return
    }
    if (turn == 1) {
        tempScoreP1 += num1 + num2;
        tempscoreP1.innerHTML = `${tempScoreP1}`;
    }
    if (turn == 2) {
        tempScoreP2 += num1 + num2;
        tempscoreP2.innerHTML = `${tempScoreP2}`;
    }
 
}
 
 
 
function GameOver() {
    if (scoreP1 >= 100) {
        winner = "Player1"
        showModal();
        return true;
    }
    if (scoreP2 >= 100) {
        winner = "Player2"
        showModal();
        return true;
    }
    return false;
}
 
function showModal() {
 
    const modal = document.getElementById('modal-result');
    modal.style.display = "block";
 
    const winnerTextResult = document.querySelector('#winner-text-result');
    winnerTextResult.innerHTML = `Winner: ${winner}`;
}
function restart() {
    location.reload();
}