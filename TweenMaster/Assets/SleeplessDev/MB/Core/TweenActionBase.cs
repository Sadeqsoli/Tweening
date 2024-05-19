using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;

namespace SleeplessDev
{
	public abstract class TweenActionBase : ITweenAction
	{
		protected readonly Transform transform;
		protected readonly float duration;
		protected readonly Ease ease;
		protected readonly UnityAction completeAction;

		protected TweenActionBase(Transform transform, float duration, Ease ease, UnityAction completeAction)
		{
			this.transform = transform;
			this.duration = duration;
			this.ease = ease;
			this.completeAction = completeAction;
		}

		public abstract void ApplyTween();
		public abstract void ApplyWithoutTween();
	}

}
