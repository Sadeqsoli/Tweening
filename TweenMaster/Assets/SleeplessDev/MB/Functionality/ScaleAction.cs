using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace SleeplessDev
{
	public class ScaleAction : TweenActionBase
	{
		private readonly Vector3 endValue;
		private readonly bool isYoyo;

		public ScaleAction(Transform transform, Vector3 endValue, float duration, Ease ease, UnityAction completeAction, bool isYoyo = false)
			: base(transform, duration, ease, completeAction)
		{
			this.endValue = endValue;
			this.isYoyo = isYoyo;
		}

		public override void ApplyTween()
		{
			if (isYoyo)
			{
				transform.DOScale(endValue, duration).SetLoops(-1, LoopType.Yoyo).SetEase(ease).OnComplete(() => completeAction?.Invoke());
			}
			else
			{
				transform.DOScale(endValue, duration).SetEase(ease).OnComplete(() => completeAction?.Invoke());
			}
		}

		public override void ApplyWithoutTween()
		{
			transform.localScale = endValue;
			completeAction?.Invoke();
		}
	}

}
