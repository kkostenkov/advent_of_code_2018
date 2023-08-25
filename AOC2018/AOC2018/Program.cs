// See https://aka.ms/new-console-template for more information

using AOC2018;


var fileReader = new FileReader();
var input = fileReader.ReadFile("../../../../Inputs/Input1.txt");
var dev = new Device();
var result = dev.Calibrate(input);
Console.WriteLine(result);