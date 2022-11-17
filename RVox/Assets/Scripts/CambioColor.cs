using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CambioColor : MonoBehaviour
{

    public GameObject Worldos;
	private Renderer ChunkR;
	public static int i=0;
	public int a = World.aumentos;

	private Color nuevocol;
	private float rCh1,rCh2,rCh3;
    // Start is called before the first frame update
    void Start()
    {
		
		
	
		
        
    }

    private void Cambcol(){
		
		rCh1=Random.Range(0f,1f);
		rCh2=Random.Range(0f,1f);
		rCh3=Random.Range(0f,1f);

		nuevocol = new Color(rCh1,rCh2,rCh3,1f);
		ChunkR.material.SetColor("_Color", nuevocol);
		
	}
	void FixedUpdate(){
		int a = World.aumentos;
		ChunkR = Worldos.GetComponentsInChildren<Renderer>()[a];
		gameObject.GetComponent<Button>().onClick.AddListener(Cambcol);
		
		Debug.Log(a);
	}
}
