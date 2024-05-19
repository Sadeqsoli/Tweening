using System.Collections;
using UnityEngine;

namespace SleeplessDev.MyTweener
{
	public class ColorAction : ITweenAction
	{
		private readonly Color _endValue;
		private readonly float _duration;

		public ColorAction(Color endValue, float duration = 1f)
		{
			_endValue = endValue;
			_duration = duration;
		}

		public IEnumerator Apply(Transform target, MonoBehaviour behaviour, System.Action completeAction = null)
		{
			if (target.TryGetComponent(out SpriteRenderer renderer))
			{
				Color startValue = renderer.color;
				float elapsed = 0f;

				while (elapsed < _duration)
				{
					renderer.color = Color.Lerp(startValue, _endValue, elapsed / _duration);
					elapsed += Time.deltaTime;
					yield return null;
				}

				renderer.color = _endValue;
				completeAction?.Invoke();
			}
			else
			{
				Debug.LogWarning("No SpriteRenderer found on the target object.");
				yield return null;
			}
		}
	}

}
