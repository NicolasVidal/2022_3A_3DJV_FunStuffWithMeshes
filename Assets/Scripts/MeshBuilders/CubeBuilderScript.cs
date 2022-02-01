using UnityEngine;

namespace MeshBuilders
{
    public class CubeBuilderScript : MonoBehaviour
    {
        public MeshFilter mf;
    
        // Start is called before the first frame update
        private void Start()
        {
            var mesh = CreateCube();

            mf.mesh = mesh;
        }

        private static Mesh CreateCube()
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
