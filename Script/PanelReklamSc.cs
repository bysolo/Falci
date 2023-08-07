using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PanelReklamSc : MonoBehaviour {

	
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        StartCoroutine(time());
	}
    public IEnumerator time()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Game");
        
    }
}
