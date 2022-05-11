// Validator({
//   form: "#form-1",
//   errorForm: ".form-message",
//   rules: [Validator.isRequired("#fullname"), Validator.isEmail("#email")],
// });

function Validator(option) {
  //hàm chung start

  const validator = (inputElement, rule) => {
    var errorValue = rule.test(inputElement.value);
    var errorElement = inputElement.parentElement.querySelector(
      option.errorForm
    );
    if (errorValue) {
      errorElement.innerText = errorValue;
      inputElement.parentElement.classList.add("invalid");
    } else {
      errorElement.innerText = " ";
      inputElement.parentElement.classList.remove("invalid");
    }
  };
  //hàm chung end
  var formElement = document.querySelector(option.form);
  if (formElement) {
    option.rules.forEach((rule) => {
      var inputElement = formElement.querySelector(rule.selector);
      inputElement.onblur = () => {
        validator(inputElement, rule);
      };
    });
  }
}
Validator.isRequired = function (selector) {
  return {
    selector: selector,
    test: function (value) {
      return value ? undefined : "hãy nhập họ và tên của bạn";
    },
  };
};
Validator.isEmail = function (selector) {
  return {
    selector: selector,
    test: function (value) {
      const regex = /^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/;
      return regex.test(value) ? undefined : "trường này phải là 1 email";
    },
  };
};
