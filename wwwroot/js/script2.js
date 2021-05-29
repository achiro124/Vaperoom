'use strict';

const ratings = document.querySelectorAll('.rating');
if (ratings.length > 0) 
{
	initRatings();
}

function initRatings()
{
	let ratingActive, ratingValue;
	for (let index = 0; index < ratings.length; index++) {
		const rating = ratings[index];
		initRating(rating);
	}


	function initRating(rating)
	{
		initRatingVars(rating);
		setRatingActiveWidth();

		/**/if (rating.classList.contains('rating_set')) {
			setRating(rating);
		}
	}


	function initRatingVars(rating)
	{
		ratingActive = rating.querySelector('.rating_active');
		ratingValue = rating.querySelector('.rating_value');

	}

	function setRatingActiveWidth(index = ratingValue.innerHTML)
	{
		const ratingActiveWidth = index/0.05;
		ratingActive.style.width = `${ratingActiveWidth}%`;
	}

	//Возможность указывать оценку
	function setRating(rating){
		const ratingItems = rating.querySelectorAll('.rating_item');
		for (let index = 0; index < ratingItems.length; index++) {
			const ratingItem = ratingItems[index];

			ratingItem.addEventListener('mouseenter', function (e){
				initRatingVars(rating);
				setRatingActiveWidth(ratingItem.value);
			});
			
			ratingItem.addEventListener("mouseleave", function (e){
				setRatingActiveWidth();
			});


			ratingItem.addEventListener("click", function (e){
				initRatingVars(rating);

				if (rating.dataset.ajax) {
					// отправить на сервер
					setRatingValue(ratingItem.value, rating);
				} else {
					//отобразить указанную оценку
					ratingValue.innerHTML = index + 1;
					setRatingActiveWidth();
				}
			});
		}
	}

}