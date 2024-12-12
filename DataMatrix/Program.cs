// See https://aka.ms/new-console-template for more information
using DataMatrix;
using System;
using System.ComponentModel.DataAnnotations;

Console.WriteLine("Welcome to DataMatrix!");
Console.WriteLine("Loading your data!");
System.Threading.Thread.Sleep(2000);


Data dataCache = new Data();
Random random = new Random();

while(true)
{
    var key = random.Next(99999);
    var firstName = dataCache.FirstNameList[random.Next(dataCache.FirstNameList.Count)];
    var lastName = dataCache.LastNameList[random.Next(dataCache.LastNameList.Count)];
    var date1 = GetRandomBirthday();
    var guid = Guid.NewGuid();
    Console.WriteLine($"{key}|{firstName}|{lastName}|{date1}|{guid}");
    System.Threading.Thread.Sleep(200);
}

DateOnly GetRandomBirthday()
{
    DateOnly someDate = new DateOnly();
    someDate = DateOnly.FromDateTime(DateTime.Now);
    return someDate;
}