// See https://aka.ms/new-console-template for more information
using polymorphism;

var shapes = new List<Shape>();
shapes.Add(new Circle { Wdth = 100, Height = 100 });
shapes.Add(new Retangle { Wdth = 100, Height = 30 });
shapes.Add(new Triangle());

var canvas = new Canvas();
canvas.DrawShape(shapes);

