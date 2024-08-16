﻿
Movie movieA = new Movie("Alien", "Ridley Scott", 112);
Movie movieB = new Movie("Inception", "Christopher Nolan", 162);

Console.WriteLine("Before calls of Watch():");
Console.WriteLine($"{movieA.Title}, by {movieA.Director}, " +
                  $"watched it {movieA.NoOfViews} time(s)");
Console.WriteLine($"{movieB.Title}, by {movieB.Director}, " +
                  $"watched it {movieB.NoOfViews} time(s)");
Console.WriteLine();

movieA.Watch();
movieA.Watch();
movieB.Watch();

Console.WriteLine("After calls of Watch():");
Console.WriteLine($"{movieA.Title}, by {movieA.Director}, " +
                  $"watched it {movieA.NoOfViews} time(s)");
Console.WriteLine($"{movieB.Title}, by {movieB.Director}, " +
                  $"watched it {movieB.NoOfViews} time(s)");
Console.WriteLine();
