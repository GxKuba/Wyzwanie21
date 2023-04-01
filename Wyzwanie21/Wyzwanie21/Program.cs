using Wyzwanie21;

var driver1 = new Driver("Kuba", "Tak");
driver1.AddGrade("Kuba");
driver1.AddGrade("16");
driver1.AddGrade(6f);
driver1.AddGrade(2.5);
driver1.AddGrade(234);
var stats = driver1.GetStats();