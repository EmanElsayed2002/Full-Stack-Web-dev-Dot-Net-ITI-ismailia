var rectangle = {
  width: 0,
  height: 0,
  area: function () {
    return this.width * this.height;
  },
  primeter: function () {
    return 2 * (Number(this.height) + Number(this.width));
  },
  displayInfo: function () {
    Widthprmpt = prompt("Please Enter Width:");
    while (isNaN(Widthprmpt)) {
      Widthprmpt = prompt("Please Enter a valid Width:");
    }
    heightprmpt = prompt("Please Enter Height:");
    while (isNaN(heightprmpt)) {
      heightprmpt = prompt("Please Enter a valid Height:");
    }
    this.width = Widthprmpt;
    this.height = heightprmpt;
    document.write("<h3>Rectangle Width: " + this.width + "</h3>");
    document.write("<h3>Rectangle Height: " + this.height + "</h3>");
    document.write("<h3>Rectangle Area: " + this.area() + "</h3>");
    document.write("<h3>Rectangle Perimeter: " + this.primeter() + "</h3>");
  },
};
rectangle.displayInfo();
