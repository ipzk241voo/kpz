using static System.Console;
using ConsoleApp.Task5.Unit;
using ConsoleApp.Task5;

CharacterDirector director = new CharacterDirector();
HeroBuilder heroBuilder = new HeroBuilder();
EnemyBuilder enemyBuilder = new EnemyBuilder();

Character hero = director.ConstructHero(heroBuilder);
Character enemy = director.ConstructEnemy(enemyBuilder);

WriteLine("Hero: " + hero);
WriteLine("Enemy: " + enemy);