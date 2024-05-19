using System.Collections;
using UnityEngine;

namespace SleeplessDev.MyTweener
{
	public interface ITweenAction
	{
		IEnumerator Apply(Transform target, MonoBehaviour behaviour, System.Action completeAction = null);
	}
}
