// See https://aka.ms/new-console-template for more information
using DataMatrix;
using System;
using System.ComponentModel.DataAnnotations;

Console.WriteLine("Welcome to DataMatrix!");
Console.WriteLine("Loading your data!");
System.Threading.Thread.Sleep(2000);

//These are depdencies...
Data dataCache = new Data();
Random random = new Random();

PersonHelper personHelper = new PersonHelper(dataCache);

while(true)
{
    var newPersaon = personHelper.GetRandomPerson();
    
    var guid = Guid.NewGuid();
    Console.WriteLine($"{newPersaon.Id}|{newPersaon.FirstName}|{newPersaon.LastName}|{newPersaon.Gender}|{newPersaon.Birthday}|{guid}");
    System.Threading.Thread.Sleep(200);
}

