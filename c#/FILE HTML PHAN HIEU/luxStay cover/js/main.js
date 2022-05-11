var Container = document.querySelector('#container');
var widthContainer = container.clientWidth;
console.log(widthContainer);
//  sub nav bar start //////////////////////////////
var iconNavBar = document.querySelector('.iconNavBar');
var overLayer = document.querySelector('.overLayer');
var navMobile = document.querySelector('.navMobile');
var navMobileIconClose = document.querySelector('.navMobileIconClose');
iconNavBar.addEventListener("click",function(){
  overLayer.style.display = 'block';
  navMobile.classList.add("active");
})
overLayer.addEventListener('click',function(){
  navMobile.classList.remove('active');
  overLayer.style.display = 'none';
})
navMobileIconClose.addEventListener('click',function(){
  navMobile.classList.remove('active');
  overLayer.style.display = 'none';
})
//  phan sub nav bar end          /////////////////////////////////////////////////

// PHẦN SLIDESHOW START //////////////////////////////////////////////////////////////////
const swiper = new Swiper('.swiper-container', {
  // Optional parameters
  loop: true,
  // If we need pagination
  pagination: {
    el: '.swiper-pagination',
  },
  navigation: {
    nextEl: '.swiper-button-next',
    prevEl: '.swiper-button-prev',
  },
});
var swiperContainer = document.querySelector('.swiper-container');
var imgSwiperContainer = document.querySelectorAll('.swiper-slide > .imgSwiper-slide')
swiperContainer.style.width = widthContainer+ 'px';
imgSwiperContainer[0].style.width = widthContainer+ 'px';
imgSwiperContainer[1].style.width = widthContainer+ 'px';
imgSwiperContainer[2].style.width = widthContainer+ 'px';
imgSwiperContainer[3].style.width = widthContainer+ 'px';
swiperContainer.style.width =widthContainer+ 'px';
 var swiperWrapper = document.querySelector('.swiper-wrapper');
 var currentWidthSlide = 0;
 setInterval(function(){
  document.querySelector('.swiper-button-next').addEventListener('click',function(){
    
  })
 },3000)
// PHẦN SLIDESHOW END ////////////////////////////////////////////////////////

