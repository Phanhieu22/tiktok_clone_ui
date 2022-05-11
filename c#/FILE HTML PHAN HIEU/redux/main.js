const { createStore } = window.Redux;
// hàm sử lí submit
const formInput = document.querySelector("#formInput");
formInput.addEventListener("submit", handleSubmit);
function handleSubmit(e) {
  console.log(e);
  e.preventDefault();
  const inputElement = document.querySelector("#content");
  let action = {
    type: "ADD",
    payload: inputElement.value,
  };
  store.dispatch(action);
  inputElement.value = "";
}
const initalState = [];

// hàm redux
function happyListReducer(state = initalState, action) {
  switch (action.type) {
    case "ADD": {
      let newState = [...state];
      newState.push(action.payload);
      return newState;
    }
    default:
      return state;
  }
}
// tạo redux
const store = createStore(happyListReducer);

// hàm render
const handleRender = (arr) => {
  if (arr.length === 0 || !Array.isArray(arr)) return;
  const uiElement = document.querySelector("#root");
  if (!uiElement) return;

  const html = arr.map((item) => {
    return `<li>${item}</li>`;
  });
  uiElement.innerHTML = html.join("");
};
store.subscribe(() => {
  const data = store.getState();
  console.log(data);
  handleRender(data);
});
