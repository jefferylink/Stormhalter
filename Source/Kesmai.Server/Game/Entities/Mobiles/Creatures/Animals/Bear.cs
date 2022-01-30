using System.IO;
using Kesmai.Server.Items;

namespace Kesmai.Server.Game
{
	public partial class Bear : AnimalEntity
	{
		public Bear()
		{
			Name = "bear";
			Body = 55;

			Alignment = Alignment.Chaotic;

			CanSwim = true;
		}

		protected override void OnCreate()
		{
			base.OnCreate();

			_brain = new CombatAI(this);
		}

		public override int GetNearbySound() => 18;
		public override int GetAttackSound() => 30;
		public override int GetDeathSound() => 42;
		
		public override ItemEntity OnCorpseTanned()
		{
			return new BearJacket();
		}
	}
}