
// Crear figuras geométricas




using Backend;
using Backend.Backend;
using TallerHerencia;


var circulo = new Circle(name: "Circle", r: 5);
var cuadrado = new Square(name: "Square", a: 10);
var rombo = new Rhombus(name: "Rhombus", a: 5, d1: 7, d2: 10);

// Lista de figuras
var figuras = new List<GeometricFigure>
{


    circulo,
    cuadrado,
    rombo,
    
}
;

// Mostrar cada figura en consola
foreach (var figura in figuras)

{

    Console.WriteLine(figura);

}