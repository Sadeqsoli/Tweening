using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;

namespace SleeplessDev.Static
{
	public class MoveAction : ITweenAction
	{
		private readonly Vector3 _endValue;
		private readonly float _tweenTime;
		private readonly Ease _ease;

		public MoveAction(Vector3 endValue, float tweenTime = 1f, Ease ease = Ease.InOutExpo)
		{
			_endValue = endValue;
			_tweenTime = tweenTime;
			_ease = ease;
		}

		public Tweener Apply(Transform t, UnityAction completeAction = null)
		{
			return t.DOMove(_endValue, _tweenTime)
				.SetEase(_ease)
				.OnComplete(() => completeAction?.Invoke());
		}
	}
}
