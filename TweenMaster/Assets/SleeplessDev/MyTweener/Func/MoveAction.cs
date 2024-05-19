using System.Collections;
using UnityEngine;

namespace SleeplessDev.MyTweener
{
	public class MoveAction : ITweenAction
	{
		private readonly Vector3 _endValue;
		private readonly float _duration;

		public MoveAction(Vector3 endValue, float duration = 1f)
		{
			_endValue = endValue;
			_duration = duration;
		}

		public IEnumerator Apply(Transform target, MonoBehaviour behaviour, System.Action completeAction = null)
		{
			Vector3 startValue = target.position;
			float elapsed = 0f;

			while (elapsed < _duration)
			{
				target.position = Vector3.Lerp(startValue, _endValue, elapsed / _duration);
				elapsed += Time.deltaTime;
				yield return null;
			}

			target.position = _endValue;
			completeAction?.Invoke();
		}
	}

}
