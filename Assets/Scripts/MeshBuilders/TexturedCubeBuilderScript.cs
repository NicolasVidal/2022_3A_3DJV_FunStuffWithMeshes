using UnityEngine;

namespace MeshBuilders
{
    public class TexturedCubeBuilderScript : MonoBehaviour
    {
        public MeshFilter mf;
    
        // Start is called before the first frame update
        private void Start()
        {
            var mesh = CreateTexturedCube();

            mf.mesh = mesh;
        }

        private static Mesh CreateTexturedCube()
        {
            var mesh = new Mesh();

            mesh.vertices = new[]
            {
                new Vector3(-0.5f, -0.5f, -0.5f),
                new Vector3(-0.5f, 0.5f, -0.5f),
                new Vector3(0.5f, 0.5f, -0.5f),
                new Vector3(0.5f, -0.5f, -0.5f),

                new Vector3(0.5f, -0.5f, 0.5f),
                new Vector3(0.5f, 0.5f, 0.5f),
                new Vector3(-0.5f, 0.5f, 0.5f),
                new Vector3(-0.5f, -0.5f, 0.5f),
            };

            mesh.uv = new[]
            {
                new Vector2(0f, 0f),
                new Vector2(0f, 1f),
                new Vector2(1f, 1f),
                new Vector2(1f, 0f),
                
                new Vector2(0f, 0f),
                new Vector2(0f, 1f),
                new Vector2(1f, 1f),
                new Vector2(1f, 0f),
            };

            mesh.triangles = new[]
            {
                0, 1, 2,   // Front Face
                0, 2, 3,
                
                4, 5, 6,   // Back Face
                4, 6, 7,
                
                1, 6, 2,  // Top Face
                6, 5, 2,
                
                3, 4, 7, // Bottom Face
                3, 7, 0,
                
                3, 2, 5, // Right Face
                3, 5, 4,
                
                7, 6, 1, // Left Face
                7, 1, 0,
            };
    
            return mesh;
        }
    }
}
