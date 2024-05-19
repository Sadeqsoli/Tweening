using System.Collections;
using UnityEngine;

namespace SleeplessDev.MyTweener
{
	public class ScaleAction : ITweenAction
	{
		private readonly Vector3 _endValue;
		private readonly float _duration;

		public ScaleAction(Vector3 endValue, float duration = 0.5f)
		{
			_endValue = endValue;
			_duration = duration;
		}

		public IEnumerator Apply(Transform target, MonoBehaviour behaviour, System.Action completeAction = null)
		{
			Vector3 startValue = target.localScale;
			float elapsed = 0f;

			while (elapsed < _duration)
			{
				target.localScale = Vector3.Lerp(startValue, _endValue, elapsed / _duration);
				elapsed += Time.deltaTime;
				yield return null;
			}

			target.localScale = _endValue;
			completeAction?.Invoke();
		}
	}
}
