using lab2_oop.Constructions;
using System.Security.Principal;

var construction1 = new Construction();
var construction2 = new Construction(23.0f, 45.0f, 4, 4, "Material");

Console.WriteLine(construction2.Height);