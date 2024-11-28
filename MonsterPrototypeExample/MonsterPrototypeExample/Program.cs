using MonsterPrototypeExample;

Zombie zombie = new Zombie{Id = "1", Name = "zombie 1", Health = 100};
Vampire vampire = new Vampire { Id = "2", Name = "vampire 1", Bloodlust = 50 };
Mummy mummy = new Mummy { Id = "3", Name = "mummy 1", Bandage = 25 };


zombie.Attack();
vampire.Attack();
mummy.Attack();

Zombie clonedZombie = (Zombie)zombie.Clone();
Vampire clonedVampire = (Vampire)vampire.Clone();
Mummy clonedMummy = (Mummy)mummy.Clone();


clonedZombie.Id = "4";
clonedZombie.Name = "zombie 2";
clonedZombie.Health = 120;
clonedZombie.Attack();

zombie.Attack();


clonedVampire.Id = "5";
clonedVampire.Name = "vampire 2";
clonedVampire.Bloodlust = 70;
clonedVampire.Attack();
vampire.Attack();


clonedMummy.Id = "6";
clonedMummy.Name = "mummy 2";
clonedMummy.Bandage= 17;
clonedMummy.Attack();
mummy.Attack();



