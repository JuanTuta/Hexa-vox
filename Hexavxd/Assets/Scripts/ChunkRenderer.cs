using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(MeshCollider))]

public class ChunkRenderer : MonoBehaviour
{
   MeshFilter meshFilter;
   MeshCollider meshCollider;
   Mesh mesh;
   public bool showGizmo = false;

   public ChunkData ChunkData{get; private set;}

   public bool modifiedbypl
   {
        get
        {
            return ChunkData.modifiedbypl;
        }
        set
        {
            ChunkData.modifiedbypl = value;
        }
   }

   private void Awake()
   {
        meshFilter = GetComponent<MeshFilter>();
        meshCollider = GetComponent<MeshCollider>();
        mesh = meshFilter.mesh;
   }

   public void InitializaChunk(ChunkData data)
   {
        this.ChunkData = data;
   }

    private void RenderMesh(MeshData meshData)
   {
        mesh.Clear();

        mesh.subMeshCount = 2;
        mesh.vertices = meshData.vertices.Concat(meshData.waterMesh.vertices).ToArray();

        mesh.SetTriangles(meshData.triangles.ToArray(), 0);
        mesh.SetTriangles(meshData.waterMesh.triangles.Select(val => val + meshData.vertices.Count).ToArray(), 1);
        mesh.uv = meshData.uv.Concat(meshData.waterMesh.uv).ToArray();
        //mesh.uv = meshData.uv.ToArray();
        mesh.RecalculateNormals();

        meshCollider.sharedMesh = null;
        Mesh collisionMesh = new Mesh();
        collisionMesh.vertices = meshData.colliderVertices.ToArray();
        collisionMesh.triangles = meshData.colliderTriangles.ToArray();
        collisionMesh.RecalculateNormals();

        meshCollider.sharedMesh= collisionMesh;
   }

   public void UpdateChunk()
   {
    RenderMesh(Chunk.GetChunkMeshData(ChunkData));
   }

   public void UpdateChunk(MeshData data)
   {
    RenderMesh(data);
   }


}
