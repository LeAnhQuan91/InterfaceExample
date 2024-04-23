internal class Program
{
    private static void Main(string[] args)
    {
        Fish fishyellow = new Fish();
        IAnimal fishred = new Fish();
        fishred.Eat();
        IWater fishGreen = new Fish();
        fishGreen.Swimming();
        Iattack fishBlue = new Fish();
        fishBlue.Attack();
    }
}

public abstract class CatSmall
{
    public abstract string HowToEat();
    
}

public interface IAnimal
{
void Eat();
}
public interface IWater
{
    void Swimming();
}
public interface Iattack
{
void Attack();
}
public class Fish : IAnimal, IWater, Iattack
{
public void Eat()
{
Console.WriteLine("an Reu");
}
public void Swimming()
{
Console.WriteLine("boi");
}
public void Attack()
{
    Console.WriteLine("Attack");
}
}
public class Cat : CatSmall
{
public override string HowToEat()
{
    throw new NotImplementedException();
}
}
public class CharFish : CatSmall, IAnimal
{
   
    public void Eat()
    {
        throw new NotImplementedException();
    }

    public override string HowToEat()
    {
        throw new NotImplementedException();
    }
}
