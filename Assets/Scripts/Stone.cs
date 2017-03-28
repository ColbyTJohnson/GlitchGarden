using UnityEngine;
using System.Collections;

public class Stone : MonoBehaviour {

	private Animator anim;
	
	void Start () {
	
		anim = GetComponent<Animator>();
	
	}

	void OnTriggerStay2D (Collider2D _collider) {
	
		Lizard lizard = _collider.gameObject.GetComponent<Lizard>();
		
		if (lizard) {
		
			anim.SetTrigger("underAttackTrigger");
		
		}	
	
	}

}
