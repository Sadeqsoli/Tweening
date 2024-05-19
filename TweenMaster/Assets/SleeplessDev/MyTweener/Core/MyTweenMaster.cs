using UnityEngine;

namespace SleeplessDev.MyTweener
{
	public class MyTweenMaster
	{
		public static void StartTween(MonoBehaviour behaviour, ITweenAction action, Transform target, System.Action onComplete = null)
		{
			behaviour.StartCoroutine(action.Apply(target, behaviour, onComplete));
		}
	}
}
