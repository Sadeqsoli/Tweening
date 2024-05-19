
using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;

namespace SleeplessDev.Static
{
	public interface ITweenAction
	{
		Tweener Apply(Transform t, UnityAction completeAction = null);
	}
}
