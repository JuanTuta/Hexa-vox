using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CambioColor : MonoBehaviour
{

	//Variables para el cambio de color llamando obviamente el mundo de voxeles
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

	//Funciones respectivas para el proceso de asignacion de color de la imagen
    private void Cambcol(){
		
		rCh1=Random.Range(0.1f,0.5f);
		rCh2=Random.Range(0.1f,0.5f);
		rCh3=Random.Range(0.1f,0.5f);

		nuevocol = new Color(rCh1,rCh2,rCh3,1f);
		ChunkR.material.SetColor("_Color", nuevocol);
		
	}
	//Funcion para el cambio de voxel para pintarlo
	void FixedUpdate(){
		int a = World.aumentos;
		ChunkR = Worldos.GetComponentsInChildren<Renderer>()[a];
		//Declaracion del boton
		gameObject.GetComponent<Button>().onClick.AddListener(Cambcol);
		
		Debug.Log(a);
	}
}
