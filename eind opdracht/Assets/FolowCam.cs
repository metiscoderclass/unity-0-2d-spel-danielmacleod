using UnityEngine;

public class FolowCam : MonoBehaviour {

	public GameObject followTarget;
	private Vector2 targetPos;
	public float moveSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		targetPos = new Vector2(followTarget.transform.position.x, followTarget.transform.position.y);
			transform.position = Vector2.Lerp (transform.position, targetPos, moveSpeed);
	}
}
