﻿


string[] snacks = { "sushi", "pizza", "burger", "chips", "pasta" };

Random rnd= new Random();

int randomIndex =rnd.Next(0, snacks.Length);

Console.WriteLine($"Tonight we are going to eat {snacks[randomIndex]}.");