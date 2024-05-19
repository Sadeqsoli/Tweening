using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace SleeplessDev.Static
{
	public static class TweenMaster
	{
		public static void ApplyTween(this Transform t, ITweenAction action, UnityAction completeAction = null)
		{
			action.Apply(t, completeAction);
		}
	}
}
