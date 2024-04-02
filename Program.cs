using ConsoleApp_Practic.Models;

namespace ConsoleApp_Practic
{
    public class Program
    {
        static void Main(string[] args)
        {
            Weapon weapon = null;

            while (true)
            {
                Console.WriteLine("0.Get Information");
                Console.WriteLine("1.To Shot");
                Console.WriteLine("2.ShowRemain Bullet Count");
                Console.WriteLine("3.To Reload");
                Console.WriteLine("4.To Change Fire Mode");
                Console.WriteLine("5.Exit");

                int choice=Convert.ToInt32(Console.ReadLine());

                switch(choice)
                {
                    case 0:
                        if(weapon== null)
                        {
                            Console.WriteLine("Weapon Is Not Created!");
                        }
                        else
                        {
                            Console.WriteLine($"{weapon.GetRemainBulletCount()}");
                        }
                        break;
                    case 1:
                        if (weapon == null)
                        {
                            Console.WriteLine("Add Weapon:");
                            Console.Write("Enter BulletCount:");
                            int capacity=Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Fire Mode:\nfalse:Single\ntrue:Automatic");
                            bool isAutomaTic=Convert.ToBoolean(Console.ReadLine());
                            weapon=new Weapon(capacity, isAutomaTic);
                        }
                        weapon.Shoot();
                        break;
                    case 2:
                        Console.WriteLine($"Remain Bullet Count is:{weapon!.GetRemainBulletCount()}");
                        break;
                    case 3:
                        weapon!.GetReload();
                        Console.WriteLine("Gun Is Reloaded...");
                        break;
                    case 4:
                        weapon!.ChangeFireMode();
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Wrong Choice!!");
                        break;
                }
            }
        }
    }
}