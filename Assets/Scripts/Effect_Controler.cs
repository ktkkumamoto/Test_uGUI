using UnityEngine;
using System.Collections;

public class Effect_Controler : MonoBehaviour {

	public GameObject Effect1;
	public GameObject Effect2;
	public GameObject Effect3;
	public GameObject Effect4;
	public GameObject Effect5;
	public GameObject Effect6;
	public GameObject Effect7;

	void Effect_Instance1() {

	GameObject cloneobj = (GameObject)Instantiate(Effect1, new Vector3(0,0,0), transform.rotation);
	cloneobj.transform.parent = transform;

	}

	void Effect_Instance2() {
		
		GameObject cloneobj = (GameObject)Instantiate(Effect2, new Vector3(0,0,0), transform.rotation);
		cloneobj.transform.parent = transform;
		
	}

	void Effect_Instance3() {
		
		GameObject cloneobj = (GameObject)Instantiate(Effect3, new Vector3(0,0,0), transform.rotation);
		cloneobj.transform.parent = transform;
		
	}

	void Effect_Instance4() {
		
		GameObject cloneobj = (GameObject)Instantiate(Effect4, new Vector3(0,0,0), transform.rotation);
		cloneobj.transform.parent = transform;
		
	}

	void Effect_Instance5() {
		
		GameObject cloneobj = (GameObject)Instantiate(Effect5, new Vector3(0,0,0), transform.rotation);
		cloneobj.transform.parent = transform;
		
	}

	void Effect_Instance6() {
		
		GameObject cloneobj = (GameObject)Instantiate(Effect6, new Vector3(0,0,0), transform.rotation);
		cloneobj.transform.parent = transform;
		
	}

	void Effect_Instance7() {
		
		GameObject cloneobj = (GameObject)Instantiate(Effect7, new Vector3(0,0,0), transform.rotation);
		cloneobj.transform.parent = transform;
		
	}

}
