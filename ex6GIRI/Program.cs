﻿int a = 2;
int b = 3;
int c = 5;
int d = 11;
int max = a;
if(a > max) max = a;
if(b > max) max = b;
if(c > max) max = c;
if(d > max) max = d;
Console.WriteLine("Максимальное число: " + max);
