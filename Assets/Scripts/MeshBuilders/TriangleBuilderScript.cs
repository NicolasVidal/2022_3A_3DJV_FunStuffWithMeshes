using UnityEngine;

namespace MeshBuilders
{
    public class TriangleBuilderScript : MonoBehaviour
    {
        public MeshFilter mf;
    
        // Start is called before the first frame update
        private void Start()
        {
            var mesh = CreateTriangle();

            mf.mesh = mesh;
        }

        private static Mesh CreateTriangle()
        {
            var mesh = new Mesh();

            mesh.vertices = new[]
            {
                new Vector3(-0.5f, -0.5f, 0f), // A
                new Vector3(0.5f, -0.5f, 0f), // B
                new Vector3(0f, 0.5f, 0f), // C
            };

            mesh.triangles = new[]
            {
                0, 2, 1
            };
    
            return mesh;
        }
    }
}
