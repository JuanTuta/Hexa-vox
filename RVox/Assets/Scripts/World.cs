using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World : MonoBehaviour
{
    public Material material;
    public static int aumentos=0;

    private void Start() {

        Chunk newChunk= new Chunk( new ChunkCoord(0),this);
        Chunk newChunk1= new Chunk( new ChunkCoord(1),this);
        Chunk newChunk2= new Chunk( new ChunkCoord(2),this);
        Chunk newChunk3= new Chunk( new ChunkCoord(3),this);
        Chunk newChunk4= new Chunk( new ChunkCoord(4),this);
        Chunk newChunk5= new Chunk( new ChunkCoord(5),this);
    }

    public void aumento(){
		aumentos++;
        //Debug.Log(aumentos);
	} 
}

