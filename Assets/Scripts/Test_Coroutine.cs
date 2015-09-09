using UnityEngine;
using System.Collections;

public class Test_Coroutine : MonoBehaviour {

    public float smoothing = 1f;
    public Transform target;
	// Use this for initialization
	void Start () {
        StartCoroutine(Move(target));
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    IEnumerator Move(Transform target)
    {
        while(Vector3.Distance(transform.position,target.position)>0.05f)
        {
            transform.position = Vector3.Lerp(transform.position, target.position, smoothing * Time.deltaTime);
            yield return null;
        }
        print("Finish Move");
        yield return new WaitForSeconds(3f);
        print("Coroutine is Done.");
    }
}
