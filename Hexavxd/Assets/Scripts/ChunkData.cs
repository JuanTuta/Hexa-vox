using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunkData
{
    public Block[] blocks;
    public int ChunkS = 16;
    public int ChunkH = 100;
    public World worldRef;
    public Vector3Int worlpos;

    public bool modifiedbypl = false;

    public ChunkData(int ChunkS, int ChunkH, World world, Vector3Int worlpos )
    {
        this.ChunkH = ChunkH;
        this.ChunkS = ChunkS;
        this.worldRef = world;
        this.worlpos = worlpos;
        blocks = new Block[ChunkS * ChunkH * ChunkS];
    }
}
