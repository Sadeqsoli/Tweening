using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SleeplessDev
{
	public class TweenManager
	{
		private readonly List<ITweenAction> actions = new List<ITweenAction>();
		private readonly bool animate;

		public TweenManager(bool animate)
		{
			this.animate = animate;
		}

		public void AddAction(ITweenAction action)
		{
			actions.Add(action);
		}

		public void ExecuteActions()
		{
			foreach (var action in actions)
			{
				if (animate)
				{
					action.ApplyTween();
				}
				else
				{
					action.ApplyWithoutTween();
				}
			}
		}
	}

}
