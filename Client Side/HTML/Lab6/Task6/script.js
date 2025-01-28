var password = document.querySelector("input");
var toggler = document.getElementById("trogger");

toggler.addEventListener("click", () => {
  if (password.type == "password") {
    password.setAttribute("type", "text");
    toggler.classList.add("fa-eye-slash");
  } else {
    toggler.classList.remove("fa-eye-slash");
    password.setAttribute("type", "password");
  }
});
