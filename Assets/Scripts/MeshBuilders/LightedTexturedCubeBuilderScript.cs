using UnityEngine;

namespace MeshBuilders
{
    public class LightedTexturedCubeBuilderScript : MonoBehaviour
    {
        public MeshFilter mf;
    
        // Start is called before the first frame update
        private void Start()
        {
            var mesh = CreateLightedTexturedCube();

            mf.mesh = mesh;
        }

        private static Mesh CreateLightedTexturedCube()
        {
            var mesh = new Mesh();

            mesh.vertices = new[]
            {
                new Vector3(0.5f, 0.5f, -0.5f), // FRONT FACE
                new Vector3(0.5f, -0.5f, -0.5f),
                new Vector3(-0.5f, -0.5f, -0.5f),
                new Vector3(-0.5f, 0.5f, -0.5f),

                new Vector3(0.5f, -0.5f, -0.5f), // RIGHT FACE
                new Vector3(0.5f, 0.5f, -0.5f),
                new Vector3(0.5f, 0.5f, 0.5f),
                new Vector3(0.5f, -0.5f, 0.5f),

                new Vector3(0.5f, -0.5f, 0.5f), // BACK FACE
                new Vector3(0.5f, 0.5f, 0.5f),
                new Vector3(-0.5f, 0.5f, 0.5f),
                new Vector3(-0.5f, -0.5f, 0.5f),
                
                new Vector3(-0.5f, -0.5f, 0.5f), // LEFT FACE
                new Vector3(-0.5f, 0.5f, 0.5f),
                new Vector3(-0.5f, 0.5f, -0.5f),
                new Vector3(-0.5f, -0.5f, -0.5f),

                new Vector3(0.5f, 0.5f, 0.5f), // TOP FACE
                new Vector3(0.5f, 0.5f, -0.5f),
                new Vector3(-0.5f, 0.5f, -0.5f),
                new Vector3(-0.5f, 0.5f, 0.5f),

                new Vector3(0.5f, -0.5f, -0.5f), // BOTTOM FACE
                new Vector3(0.5f, -0.5f, 0.5f),
                new Vector3(-0.5f, -0.5f, 0.5f),
                new Vector3(-0.5f, -0.5f, -0.5f),
            };

            mesh.normals = new[]
            {
                Vector3.back, 
                Vector3.back, 
                Vector3.back, 
                Vector3.back, 
                
                Vector3.right, 
                Vector3.right, 
                Vector3.right, 
                Vector3.right, 
                
                Vector3.forward, 
                Vector3.forward, 
                Vector3.forward, 
                Vector3.forward, 
                
                Vector3.left, 
                Vector3.left, 
                Vector3.left, 
                Vector3.left, 
                
                Vector3.up, 
                Vector3.up, 
                Vector3.up, 
                Vector3.up, 
                
                Vector3.down, 
                Vector3.down, 
                Vector3.down, 
                Vector3.down, 
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
                
                new Vector2(0f, 0f),
                new Vector2(0f, 1f),
                new Vector2(1f, 1f),
                new Vector2(1f, 0f),
                
                new Vector2(0f, 0f),
                new Vector2(0f, 1f),
                new Vector2(1f, 1f),
                new Vector2(1f, 0f),
                
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
                
                4, 5, 6,   // Right Face
                4, 6, 7,
                
                8, 9, 10,  // Back Face
                8, 10, 11,
                
                12, 13, 14, // Left Face
                12, 14, 15,
                
                16, 17, 18, // Top Face
                16, 18, 19,
                
                20, 21, 22, // Bottom Face
                20, 22, 23,
            };
    
            return mesh;
        }
    }
}
