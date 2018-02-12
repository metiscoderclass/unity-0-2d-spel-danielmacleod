using UnityEngine;

	
public class PlayerMovement : MonoBehaviour {
	
	public Rigidbody2D rb;

	void Start () {
		
	}

	void FixedUpdate () {
		if(Input.GetKey("d")){
			rb.AddForce(new Vector2(20,2));
		}
		if(Input.GetKey("a")){
			rb.AddForce(new Vector2(-20,2));
		}
		if(Input.GetKeyDown("w")){
			rb.AddForce(new Vector2(0,500));
		}
		if(Input.GetKeyDown("s")){
			rb.AddForce(new Vector2(0,-500));
		}
	}
}
