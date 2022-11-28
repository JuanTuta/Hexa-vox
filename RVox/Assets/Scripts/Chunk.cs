using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Chunk {

	//Declaracion de variables
	public ChunkCoord coord;

	public MeshRenderer meshRenderer;
	public MeshFilter meshFilter;
    GameObject chunkObject;
	

	int vertexIndex = 0;
	//Listas con las distintas informacion de voxeles
	List<Vector3> vertices = new List<Vector3> ();
	List<int> triangles = new List<int> ();
	List<Vector2> uvs = new List<Vector2> ();

	World world;

	public Chunk (ChunkCoord _coord, World _world) {

		//Crea los chunks necesarios pa cada conjunto de voxels recibiendo coordenadas y demas

        coord = _coord;
        chunkObject = new GameObject();
        chunkObject.transform.position = new Vector3(coord.y, 0.0f, coord.x);

        meshRenderer = chunkObject.AddComponent<MeshRenderer>();
        meshFilter = chunkObject.AddComponent<MeshFilter>();
        world = _world;

        chunkObject.transform.SetParent(world.transform);
        meshRenderer.material = world.material;

		//Esto se hace por medio de Childs
        chunkObject.name = coord.y+"_";

        CreateMeshData();
        CreateMesh();

    }


	//Distintas priebas para la construccion de algunas figuras
	/*void Start () {

		
		//Quinta Columna
		AddVoxelDataToChunk(new Vector3(0, 0, 3));
		AddVoxelDataToChunk(new Vector3(1, 0, 3));
		AddVoxelDataToChunk(new Vector3(2, 0, 3));
		AddVoxelDataToChunk(new Vector3(-1, 0, 3));
		AddVoxelDataToChunk(new Vector3(-2, 0, 3));
		//------//

		//Cuarta Columna
		AddVoxelDataToChunk(new Vector3(2.5f, 0, 2.25f));
		AddVoxelDataToChunk(new Vector3(1.5f, 0, 2.25f));
		AddVoxelDataToChunk(new Vector3(0.5f, 0, 2.25f));
		AddVoxelDataToChunk(new Vector3(-0.5f, 0, 2.25f));
		AddVoxelDataToChunk(new Vector3(-1.5f, 0, 2.25f));
		AddVoxelDataToChunk(new Vector3(-2.5f, 0, 2.25f));
		//------//

		//Tercera Columna
		AddVoxelDataToChunk(new Vector3(2f, 0, 1.5f));
		AddVoxelDataToChunk(new Vector3(1f, 0, 1.5f));
		AddVoxelDataToChunk(new Vector3(0f, 0, 1.5f));
		AddVoxelDataToChunk(new Vector3(-1f, 0, 1.5f));
		AddVoxelDataToChunk(new Vector3(-2f, 0, 1.5f));
		//------//

		//Segunda columna
		AddVoxelDataToChunk(new Vector3(2.5f, 0, 0.75f));
		AddVoxelDataToChunk(new Vector3(1.5f, 0, 0.75f));
		AddVoxelDataToChunk(new Vector3(0.5f, 0, 0.75f));
		AddVoxelDataToChunk(new Vector3(-0.5f, 0, 0.75f));
		AddVoxelDataToChunk(new Vector3(-1.5f, 0, 0.75f));
		AddVoxelDataToChunk(new Vector3(-2.5f, 0, 0.75f));
		//------//

		//Primera columna  
		AddVoxelDataToChunk(new Vector3(0, 0, 0));
		AddVoxelDataToChunk(new Vector3(1, 0, 0));
		AddVoxelDataToChunk(new Vector3(2, 0, 0));
		AddVoxelDataToChunk(new Vector3(-1, 0, 0));
		AddVoxelDataToChunk(new Vector3(-2, 0, 0));
		//------//
		*/

		//Figuras de prueba 
		/*for (int p = 0; p < 5; p++) { 
			for (int i = 0; i < 12; i++) {

				int triangleIndex = VoxelData.voxelTris [0, i];
				vertices.Add (VoxelData.voxelVerts [triangleIndex]);
				triangles.Add (vertexIndex);

				uvs.Add (VoxelData.voxelUvs [i]);

				vertexIndex++;

			}
		}*/
        
		/*AddVoxelDataToChunk(new Vector3(0, 0, 1.5f));
		AddVoxelDataToChunk(new Vector3(-0.5f, 0, 0.75f));
		AddVoxelDataToChunk(new Vector3(0, 0, 1.5f));*/

		/*for (float y = 0; y < VoxelData.ChunkHeight; y++) {
			for (float x = 0.5f; x < VoxelData.ChunkWidth; x=x+1f) {
				for (float z = 0.0f; z < VoxelData.ChunkWidth; z=z+1f) {

					

				}
			}
		}
	}*/

	
	public void CreateMeshData () {

		//Recibe coordenadas y cantidad de voxeles

		for (int l = 0; l < VoxelData.ChunkHeight ; l++)
		{
			for (float p = 0.0f; p <= VoxelData.ChunkWidth; p=p+1.5f)
			{
				for (float i = 0.0f; i <= VoxelData.ChunkWidth1; i++)
				{
					AddVoxelDataToChunk(new Vector3(i, l, p));
				}
			}
		}
		

		for (int l = 0; l < VoxelData.ChunkHeight; l++)
		{
			for (float p = 0.75f; p <= VoxelData.ChunkWidthh; p=p+1.5f)
			{	
				for (float i = 0.5f; i <= VoxelData.ChunkWidth1; i++)
				{
					AddVoxelDataToChunk(new Vector3(i, l, p));
				}
			}
		}
	}
	void AddVoxelDataToChunk (Vector3 pos) {

		//Añade el voxel al chunk

		for (int p = 0; p < 5; p++)
        {
            for (int i = 0; i < 12; i++) {

                int triangleIndex = VoxelData.voxelTris [p, i];
                vertices.Add (VoxelData.voxelVerts [triangleIndex]+pos);
                triangles.Add (vertexIndex);

                
                uvs.Add (Vector2.zero);

                vertexIndex++;

            }
        }
		
	}

	void CreateMesh () {


		//Crea las respectiva maya de voxeles prisma hexagonales y asignaciones
		Mesh mesh = new Mesh ();
		mesh.vertices = vertices.ToArray ();
		mesh.triangles = triangles.ToArray ();
		mesh.uv = uvs.ToArray ();

		mesh.RecalculateNormals ();

		meshFilter.mesh = mesh;

	}

	

}