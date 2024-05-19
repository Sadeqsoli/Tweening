using System.Collections;
using UnityEngine;

namespace SleeplessDev.MyTweener
{
	public class RotateAction : ITweenAction
	{
		private readonly Vector3 _endValue;
		private readonly float _duration;

		public RotateAction(Vector3 endValue, float duration = 1f)
		{
			_endValue = endValue;
			_duration = duration;
		}

		public IEnumerator Apply(Transform target, MonoBehaviour behaviour, System.Action completeAction = null)
		{
			Quaternion startValue = target.rotation;
			Quaternion endValue = Quaternion.Euler(_endValue);
			float elapsed = 0f;

			while (elapsed < _duration)
			{
				target.rotation = Quaternion.Lerp(startValue, endValue, elapsed / _duration);
				elapsed += Time.deltaTime;
				yield return null;
			}

			target.rotation = endValue;
			completeAction?.Invoke();
		}
	}
}
