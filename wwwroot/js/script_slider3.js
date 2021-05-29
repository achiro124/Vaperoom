/*Слайдер 1*/

let position = 0;
let slidesToShow = 3;
let slidesToScroll = 1;
let container = document.querySelector('.slider-container');
let track = document.querySelector('.slider-track');
let btnPrev = document.querySelector('.btn-prev');
let btnNext = document.querySelector('.btn-next');
let items = document.querySelectorAll('.slider-item');
let items2 = document.querySelectorAll('.slider-item2');
let itemsCount = items.length - items2.length;
let itemWidth = container.clientWidth / slidesToShow;
let movePosition = slidesToScroll * itemWidth;

items.forEach((item) => {
	item.style.minWidth = `${itemWidth}px`;
});


btnNext.addEventListener('click', () => {
	const itemsLeft = itemsCount - (Math.abs(position) + slidesToShow * itemWidth) / itemWidth;

	position -=itemsLeft >= slidesToScroll ? movePosition : itemsLeft * itemWidth;

	setPosition();
	checkBtns();
});

btnPrev.addEventListener('click', () => {
	const itemsLeft = Math.abs(position) / itemWidth;
	position += itemsLeft >= slidesToScroll ? movePosition : itemsLeft * itemWidth;

	setPosition();
	checkBtns();
});

var setPosition = () => {
	track.style.transform = `translateX(${position}px)`;
};


var checkBtns = () => {
	btnPrev.disabled = position ===0;
	btnNext.disabled = position <= -(itemsCount - slidesToShow) * itemWidth;
};

checkBtns();


/*Слайдер2*/

var Q = 0;
var W = 3;
var E = 1;
var R = document.querySelector('.slider-container2');
var T = document.querySelector('.slider-track2');
var Y = document.querySelector('.btn-prev2');
var U = document.querySelector('.btn-next2');
var I = document.querySelectorAll('.slider-item2');
let items3 = document.querySelectorAll('.slider-item3');
var O = I.length - items3.length;
var P = R.clientWidth / W;
var A = E * P;

I.forEach((item) => {
	item.style.minWidth = `${P}px`;
});


U.addEventListener('click', () => {
	const K = O - (Math.abs(Q) + W * P) / P;

	Q -=K >= E ? A : K * P;

	S();
	D();
});

Y.addEventListener('click', () => {
	const K = Math.abs(Q) / P;
	Q += K >= E ? A : K * P;

	S();
	D();
});

S = () => {
	T.style.transform = `translateX(${Q}px)`;
};


D = () => {
	Y.disabled = Q ===0;
	U.disabled = Q <= -(O - W) * P;
};

D();




/*Слайдер 3*/
var QW = 0;
var WE = 3;
var ER = 1;
var RT = document.querySelector('.slider-container3');
var TY = document.querySelector('.slider-track3');
var YU = document.querySelector('.btn-prev3');
var UI = document.querySelector('.btn-next3');
var IO = document.querySelectorAll('.slider-item3');
var OP = IO.length;
var PA = RT.clientWidth / WE;
var AS = ER * PA;

IO.forEach((item) => {
	item.style.minWidth = `${PA}px`;
});


UI.addEventListener('click', () => {
	const KL = OP - (Math.abs(QW) + WE * PA) / PA;

	QW -=KL >= ER ? AS : KL * PA;

	SD();
	DF();
});

YU.addEventListener('click', () => {
	const KL = Math.abs(QW) / PA;
	QW += KL >= ER ? AS : KL * PA;

	SD();
	DF();
});

SD = () => {
	TY.style.transform = `translateX(${QW}px)`;
};


DF = () => {
	YU.disabled = QW ===0;
	UI.disabled = QW <= -(OP - WE) * PA;
};

DF();
