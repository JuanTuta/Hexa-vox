using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class VoxelData {

	public static readonly float ChunkWidth = 23.0f;
	public static readonly float ChunkWidth1 =15.0f;
	public static readonly float ChunkWidthh = 12.25f;
	public static readonly int ChunkHeight = 1;


	public static readonly Vector3[] voxelVerts = new Vector3[12] {

		//top
		new Vector3(0.0f, 1.0f, 0.25f),
		new Vector3(0.0f, 1.0f, 0.75f),
		new Vector3(0.5f, 1.0f, 1.0f),
		new Vector3(1.0f, 1.0f, 0.75f),
		new Vector3(1.0f, 1.0f, 0.25f),
		new Vector3(0.5f, 1.0f, 0.0f),

		//Base
        new Vector3(0.0f, 0.0f, 0.25f),
		new Vector3(0.0f, 0.0f, 0.75f),
		new Vector3(0.5f, 0.0f, 1.0f),
		new Vector3(1.0f, 0.0f, 0.75f),
		new Vector3(1.0f, 0.0f, 0.25f),
		new Vector3(0.5f, 0.0f, 0.0f),

        

	};

	public static readonly int[,] voxelTris = new int[5,12] {

		/*{0, 3, 1, 1, 3, 2}, // Back Face
		{5, 6, 4, 4, 6, 7}, // Front Face
		{3, 7, 2, 2, 7, 6}, // Top Face
		{1, 5, 0, 0, 5, 4}, // Bottom Face
		{4, 7, 0, 0, 7, 3}, // Left Face
		{1, 2, 5, 5, 2, 6} // Right Face*/

        /*{1,5,0,1,4,5,1,2,4,2,3,4},
        {10,6,11,10,7,6,10,9,7,9,8,7},
        {0,7,1,1,7,8,1,8,2,2,8,9},
        {2,9,3,3,9,8,3,8,4,4,8,7},
        {4,7,5,5,7,6,5,6,0,0,6,11},*/

		{10,6,11,10,7,6,10,9,7,9,8,7},//top
		{1,5,0,1,4,5,1,2,4,2,3,4},//base
		{0,7,1,1,7,8, 1,8,2,2,8,9},
        {2,9,3,3,9,10, 3,10,4,4,10,11},
        {4,11,5,5,11,6, 5,6,0,0,6,7}
		

	};

	/*public static readonly Vector2[] voxelUvs = new Vector2[6] {

		new Vector2 (0.0f, 0.0f),
		new Vector2 (0.0f, 1.0f),
		new Vector2 (1.0f, 0.0f),
		new Vector2 (1.0f, 0.0f),
		new Vector2 (0.0f, 1.0f),
		new Vector2 (1.0f, 1.0f)

	};*/


}

public class ChunkCoord {

    public int y;

    public ChunkCoord (int _y) {

        y = _y;

    }
}