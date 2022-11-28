using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//En este apartado se crea el mundo es decir cada uno de los pixeles a tener en 
//cuenta segun la imagen
public class World : MonoBehaviour
{

    public Material material;
    public static int aumentos=0;

    private void Start() {

        //este for trabaja con las dimenciones de la imagen generando cada capa de voxeles
        for (float i = 0; i < 15; i++)
        {
            for (float o = 0; o < 23.0f; o=o+1.5f)
            {
                Chunk newChunk= new Chunk( new ChunkCoord(i,o),this);
            }  
        }
        for (float i = 0.5f; i < 15; i++)
        {
            for (float o = 0.75f; o < 23.0f; o=o+1.5f)
            {
                Chunk newChunk1= new Chunk( new ChunkCoord(i,o),this);
            }  
        }

        //Distintas pruebas necesarias 
        /*
        Chunk newChunk= new Chunk( new ChunkCoord(0f,0f),this);
        Chunk newChunk1= new Chunk( new ChunkCoord(1f,0f),this);
        Chunk newChunk2= new Chunk( new ChunkCoord(2f,0f),this);
        Chunk newChunk3= new Chunk( new ChunkCoord(3f,0f),this);
        Chunk newChunk4= new Chunk( new ChunkCoord(4f,0f),this);
        Chunk newChunk5= new Chunk( new ChunkCoord(5f,0f),this);
        Chunk newChunk6= new Chunk( new ChunkCoord(6f,0f),this);
        Chunk newChunk7= new Chunk( new ChunkCoord(7f,0f),this);
        Chunk newChunk8= new Chunk( new ChunkCoord(8f,0f),this);
        Chunk newChunk9= new Chunk( new ChunkCoord(0.5f,0.75f),this);
        */
    }

    //una bandera necesaria pa comprobar el funcionamiento
    public void aumento(){
		aumentos++;
        //Debug.Log(aumentos);
	} 
}

