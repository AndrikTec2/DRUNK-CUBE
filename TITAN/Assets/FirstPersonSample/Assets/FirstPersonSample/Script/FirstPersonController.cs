using UnityEngine;

public class FirstPersonController : MonoBehaviour
{
	[Header("References")]
	public Rigidbody rb;
	public Transform cameraHead;

	[Header("Values")]
	public float headTurnSpeed;
	public float walkSpeed;

	private void Awake()
	{
		//hide mouse and stop physics system from controlling our rotation.
		Cursor.visible = false;
		rb.constraints = RigidbodyConstraints.FreezeRotation;
	}

	private void Update()
	{
		//turn head
		float headTurnHorizontal = Input.GetAxis("Mouse X") * headTurnSpeed;
		float headTurnVertical = Input.GetAxis("Mouse Y") * headTurnSpeed;
		transform.rotation *= Quaternion.Euler(new Vector3(0, headTurnHorizontal, 0)); //turn the entire object left/right
		cameraHead.rotation *= Quaternion.Euler(new Vector3(-headTurnVertical, 0, 0)); //only turn the camera up/down

		//walking
		float moveForwardBack = Input.GetAxis("Vertical") * walkSpeed * Time.fixedDeltaTime;
		float moveLeftRight = Input.GetAxis("Horizontal") * walkSpeed * Time.fixedDeltaTime;
		Vector3 moveVectorForward = transform.forward * moveForwardBack;
		Vector3 moveVectorRight = transform.right * moveLeftRight;
		Vector3 moveVectorGravity = transform.up * rb.velocity.y;
		rb.velocity = moveVectorForward + moveVectorRight + moveVectorGravity;
	}
}
