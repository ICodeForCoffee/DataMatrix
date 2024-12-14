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
    var firstName = "";
    var gender = "";
    if (random.Next(2) == 0)
    {
        firstName = dataCache.FirstNameMaleList[random.Next(dataCache.FirstNameMaleList.Count)];
        gender = "Male";
    }
    else
    {
        firstName = dataCache.FirstNameFemaleList[random.Next(dataCache.FirstNameFemaleList.Count)];
        gender = "Female";
    }
    var lastName = dataCache.LastNameList[random.Next(dataCache.LastNameList.Count)];
    var date1 = GetRandomBirthday();
    var guid = Guid.NewGuid();
    Console.WriteLine($"{key}|{firstName}|{lastName}|{gender}|{date1}|{guid}");
    System.Threading.Thread.Sleep(200);
}

//ToDo This random birthday is absolutely not random.
DateOnly GetRandomBirthday()
{
    DateOnly someDate = new DateOnly();
    someDate = DateOnly.FromDateTime(DateTime.Now);
    return someDate;
}