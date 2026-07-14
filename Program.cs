using PixMapper;
using System.Drawing;

// See https://aka.ms/new-console-template for more information

string bitmap_filename = @"c:\tmp\rectLOTS.bmp";
//var col = Color.FromArgb(255,149, 4, 149);

BitmapFactory f = new BitmapFactory();
//f.Create("this is a lot of text!", bitmap_filename, 128, 128, col);
//Console.WriteLine($"Created {bitmap_filename}");
string msg = f.Read(bitmap_filename);
Console.WriteLine($"Read: {msg}");

Console.WriteLine("Hello, World!");