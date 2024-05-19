using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace SleeplessDev.Static
{
	public class ColorAction : ITweenAction
	{
		private readonly Color _endValue;
		private readonly float _tweenTime;
		private readonly Ease _ease;

		public ColorAction(Color endValue, float tweenTime = 1f, Ease ease = Ease.InOutExpo)
		{
			_endValue = endValue;
			_tweenTime = tweenTime;
			_ease = ease;
		}

		public Tweener Apply(Transform t, UnityAction completeAction = null)
		{
			Image image = t.GetComponent<Image>();
			if (image == null) throw new MissingComponentException("Transform must have an Image component.");

			return image.DOColor(_endValue, _tweenTime)
				.SetEase(_ease)
				.OnComplete(() => completeAction?.Invoke());
		}
	}
}
