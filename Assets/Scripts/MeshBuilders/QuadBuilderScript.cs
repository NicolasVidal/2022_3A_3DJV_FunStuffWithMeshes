using UnityEngine;

namespace MeshBuilders
{
    public class QuadBuilderScript : MonoBehaviour
    {
        public MeshFilter mf;
    
        // Start is called before the first frame update
        private void Start()
        {
            var mesh = CreateQuad();

            mf.mesh = mesh;
        }

        private static Mesh CreateQuad()
        {
            var mesh = new Mesh();

            mesh.vertices = new[]
            {
                new Vector3(-0.5f, -0.5f, 0f), // A
                new Vector3(-0.5f, 0.5f, 0f), // B
                new Vector3(0.5f, 0.5f, 0f), // C
                new Vector3(0.5f, -0.5f, 0f), // D
            };

            mesh.triangles = new[]
            {
                0, 1, 2,
                0, 2, 3,
            };
    
            return mesh;
        }
    }
}
