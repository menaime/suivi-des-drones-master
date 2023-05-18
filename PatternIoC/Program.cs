using PatternIoC;

Bus bus = new();
Velo velo = new();
Voiture voiture = new();

Person person = new("Igor", bus);
person.AllerAuTravail(new("far far away"));