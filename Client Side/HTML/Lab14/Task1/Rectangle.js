import { Shape } from "./Shape.js";
class Rectangle extends Shape {
  constructor(width, height) {
    super(width);
    this.width = width;
    this.height = height;
  }
  getArea() {
    return this.width * this.height;
  }

  getPerimeter() {
    return (this.width + this.height) * 2;
  }
}

export { Rectangle };
