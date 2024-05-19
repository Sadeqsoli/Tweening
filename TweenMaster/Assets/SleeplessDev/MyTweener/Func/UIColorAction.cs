using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace SleeplessDev.MyTweener
{
	public class UIColorAction : ITweenAction
	{
		private readonly Color _endValue;
		private readonly float _duration;

		public UIColorAction(Color endValue, float duration = 1f)
		{
			_endValue = endValue;
			_duration = duration;
		}

		public IEnumerator Apply(Transform target, MonoBehaviour behaviour, System.Action completeAction = null)
		{
			Image image = target.GetComponent<Image>();
			if (image != null)
			{
				Color startValue = image.color;
				float elapsed = 0f;

				while (elapsed < _duration)
				{
					image.color = Color.Lerp(startValue, _endValue, elapsed / _duration);
					elapsed += Time.deltaTime;
					yield return null;
				}

				image.color = _endValue;
				completeAction?.Invoke();
			}
			else
			{
				Debug.LogWarning("No Image component found on the target object.");
				yield return null;
			}
		}
	}

}
