using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SleeplessDev
{
	//this example needs MonoBehaviour Class
	public class TweenExample_MB : MonoBehaviour
	{
		public Transform target;
		public bool animate;

		void Start()
		{
			TweenManager tweenManager = new TweenManager(animate);

			tweenManager.AddAction(new ScaleAction(target, Vector3.one, 1f, Ease.InOutExpo, () => Debug.Log("Scale Complete"), false));

			tweenManager.ExecuteActions();
		}
	}

}
