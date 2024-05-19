using SleeplessDev.MyTweener;
using UnityEngine;

public class ExampleMyTweener : MonoBehaviour
{
	public Transform target; // Transform for 3D objects
	public Transform uiTarget; // Transform for UI elements

	void Start()
	{
		// Scale Action
		MyTweenMaster.StartTween(this, new ScaleAction(new Vector3(2, 2, 2), 1f), target, () => Debug.Log("Scale Complete"));

		// Rotate Action
		MyTweenMaster.StartTween(this, new RotateAction(new Vector3(0, 180, 0), 1f), target, () => Debug.Log("Rotate Complete"));

		// Move Action
		MyTweenMaster.StartTween(this, new MoveAction(new Vector3(5, 5, 5), 1f), target, () => Debug.Log("Move Complete"));

		// Color Action for SpriteRenderer
		MyTweenMaster.StartTween(this, new ColorAction(Color.red, 1f), target, () => Debug.Log("Color Change Complete"));

		// Color Action for UI Image
		MyTweenMaster.StartTween(this, new UIColorAction(Color.green, 1f), uiTarget, () => Debug.Log("UI Color Change Complete"));
	}
}
