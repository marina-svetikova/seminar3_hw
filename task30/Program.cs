﻿// Напишите программу, которая выводит массив из 8 элементов,
//  заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

 int [] array = new int [8]; //создали массив на 8 элеметов
 
 Random rand = new Random (); 
 for (int i =0; i< array.Length; i++)
 {
    array[i] = rand.Next(0, 2);
 }
 Console.WriteLine(string.Join (",",array));
 

