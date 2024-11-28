using PrototypeExample1;
Circle circle = new Circle { Id = 1};
Rectangle rectangle = new Rectangle{ Id = 2};
Square square = new Square { Id = 3};


circle.Draw();
rectangle.Draw();
square.Draw();

Circle cloneCircle = (Circle)circle.Clone();
Rectangle cloneRectangle = (Rectangle)rectangle.Clone();
Square cloneSquare = (Square)square.Clone();

cloneCircle.Draw();

cloneCircle.Id = 4;
cloneCircle.Draw();
circle.Draw();
