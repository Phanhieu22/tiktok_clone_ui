const myApi = "http://localhost:3000/course";
function main() {
  getCourse(function (info) {
    renderInfoApi(info);
    handleEven();
  });
}
main();
// function cua toi

// hàm lấy giá trị khóa học start
function getCourse(callBack) {
  fetch(myApi)
    .then(function (reponse) {
      return reponse.json();
    })
    .then(callBack)
    .catch(function () {
      alert("lỗi sever");
    });
}
// hàm lấy giá trị khóa học end

//hàm sử lý Api start
function renderInfoApi(info) {
  var demo = document.querySelector("#demo");
  var htmls = info.map(function (item) {
    return `<li>
    <h3>${item.courseName}</h3>
    <p>${item.introduce}</p>
    </li>`;
  });
  demo.innerHTML = htmls.join(" ");
}
//hàm sử lý Api end

//hàm sử lí sự kiện start
function handleEven() {
  var buttonCreate = document.querySelector("#buttonDemo");
  var name1 = document.querySelector('input[name ="courseName"]');
  var introduce1 = document.querySelector('input[name ="introduce"]');
  buttonCreate.onclick = function () {
    var valueNewName = name1.value;
    var valueNewIntroduce = introduce1.value;
    var formData = {
      courseName: valueNewName,
      introduce: valueNewIntroduce,
    };
    createCourse(formData);
  };
}
// hàm sử lí sự kiện end

//hàm tạo dữ liệu
function createCourse(data, callback) {
  const opstion = {
    method: "POST",
    headers: {
      "Content-Type": "application/json",
    },
    body: JSON.stringify(data),
  };
  fetch(myApi, opstion)
    .then(function (reponse) {
      return reponse.json();
    })
    .then(callback);
}
