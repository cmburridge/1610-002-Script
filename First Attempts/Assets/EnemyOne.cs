using UnityEngine;

public class EnemyOne : MonoBehaviour
{

	public Vector3 move;
	public Rigidbody ai;
	
	void Update () {
		transform.Translate(translation: move*Time.deltaTime);
	}
}
