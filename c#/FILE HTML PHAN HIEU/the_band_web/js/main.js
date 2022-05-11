const btnMobile = document.getElementById("btnSubNavMobile");
const navMoble = document.getElementById("navMobile");
btnMobile.addEventListener("click", action);
var state = {
  btnMobile: false,
};
function action() {
  state.btnMobile = !state.btnMobile;
  if (state.btnMobile == true) {
    navMoble.classList.add("active");
    console.log("pahnhieu");
  } else {
    navMoble.classList.remove("active");
  }
}
//  banner
const baner = document.getElementById("baner");
const databaner = [
  {
    img: "https://www.w3schools.com/w3images/ny.jpg",
    address: "new york",
    title: "The atmosphere in New York is lorem ipsum.",
  },
  {
    img: "https://www.w3schools.com/w3images/la.jpg",
    address: "Los Angeles",
    title: "We had the best time playing at Venice Beach!",
  },
  {
    img: "https://www.w3schools.com/w3images/chicago.jpg",
    address: "chicago",
    title: "Thank you, Chicago - A night we won't forget.",
  },
];
