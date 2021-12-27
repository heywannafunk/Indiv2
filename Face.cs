using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media.Media3D;

namespace CGLab69.models
{
    /// <summary>
    /// Многоугольник (грань)
    /// </summary>
    public class Face
    {
        /// <summary>
        /// Прямые (ребра)
        /// </summary>
        public List<Edge> Edges { get; }

        public Face()
        {
            Edges = new List<Edge>();
        }

        public Face(List<Point3D> points) 
        {
            Edges = new List<Edge>();
            for (int i = 0; i < points.Count-1; i++)
            {
                AddEdge(points[i], points[i+1]);
            }
            AddEdge(points[points.Count-1], points[0]);
        }

        public Face(IEnumerable<Edge> edges)
        {
            Edges = new List<Edge>();
            Edges.AddRange(edges);
        }

        public void AddEdge(Point3D p1, Point3D p2)
        {
            Edges.Add(new Edge(p1,p2));
        }

    }
}
