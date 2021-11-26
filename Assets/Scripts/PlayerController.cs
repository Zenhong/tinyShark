using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

	public float speed;


	
	[SerializeField] Animator m_anim;
	[SerializeField] GameObject m_model;
	Rigidbody rbd;



	void Start()
	{
		rbd = GetComponent<Rigidbody>();
		
		
	}

	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");
		var movement = new Vector3(moveHorizontal, moveVertical, 0f).normalized * speed * Time.deltaTime;
		m_anim.SetFloat("vX", moveHorizontal);
		m_anim.SetFloat("vY", moveVertical);
		rbd.AddForce(movement);
	}





}