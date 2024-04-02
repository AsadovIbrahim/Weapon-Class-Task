using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Practic.Models
{
    public class Weapon
    {
		private int _Capacity;
		private int CurrentBullet;
		private bool isAutomatic;

		public int Capacity
		{
			get { return _Capacity; }
			set { _Capacity = value; }
		}
		
		public Weapon(int capacity,bool IsAutomatic)
		{
			Capacity = capacity;
			CurrentBullet = 0;
			this.isAutomatic=IsAutomatic;
		}
		public void Shoot()
		{
			if(CurrentBullet> 0) {
				if (!isAutomatic)
				{
					Console.WriteLine("1 shot fired...");
					CurrentBullet--;
				}
				else
				{
					Console.WriteLine("Automatic shot fired...");
					CurrentBullet = 0;
				}
			}
			else
			{
				GetReload();
				Console.WriteLine("Weapon Updated...");
			}
		}
		public int GetRemainBulletCount()
		{
			return Capacity - CurrentBullet;
		}
		public void GetReload()
		{
			CurrentBullet = Capacity;
		}
		public void ChangeFireMode()
		{
			isAutomatic = !isAutomatic;
			Console.WriteLine("FireMode is Changed "+(isAutomatic?"Automatic":"Single"));
		}
	}
}
