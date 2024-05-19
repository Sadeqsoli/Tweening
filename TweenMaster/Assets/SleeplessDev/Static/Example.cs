using UnityEngine;
using SleeplessDev.Static;
public class Example : MonoBehaviour
{
	public Transform myTransform;

	void Start()
	{
		// Scale action
		myTransform.ApplyTween(new ScaleAction(new Vector3(2, 2, 2)));

		// Rotate action
		myTransform.ApplyTween(new RotateAction(new Vector3(0, 180, 0)));

		// Move action
		myTransform.ApplyTween(new MoveAction(new Vector3(0, 5, 0)));

		// Color action
		myTransform.ApplyTween(new ColorAction(Color.red));

		// Fade action
		myTransform.ApplyTween(new FadeAction(0.5f));
	}
}
