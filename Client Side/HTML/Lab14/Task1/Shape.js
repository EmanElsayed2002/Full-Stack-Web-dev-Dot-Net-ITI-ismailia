class Shape {
  constructor(side) {
    this.side = side;
  }
  getArea() {
    console.log("GetArea from Shape Class");
  }
  getPerimeter() {
    console.log("GetPerimeter from Shape Class");
  }
  toString() {
    return `Area = ${this.getArea()}, Perimeter = ${this.getPerimeter()}`;
  }
}

export { Shape };
