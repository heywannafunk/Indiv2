using CGLab69.helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media.Media3D;

namespace CGLab69.models
{

    public enum Projections { Perspective, Isometric, Trimetric, Dimetric }

    /// <summary>
    /// Многогранник
    /// </summary>
    /// 
    public class Polyhedron
    {
        /// <summary>
        /// Грани
        /// </summary>
        public List<Polyhedron> Faces{ get; }
        /// <summary>
        /// Прямые (ребра)
        /// </summary>
        public List<Edge> Edges { get; }
        /// <summary>
        /// Вершины
        /// </summary>
        public List<Point3D> Vertices { get; set; }
        /// <summary>
        /// Матрица смежности
        /// </summary>
        public Dictionary<Point3D, List<Point3D>> AdjacencyMatrix { get; }

        public Polyhedron()
        {
            Faces = new List<Polyhedron>();
            Edges = new List<Edge>();
            Vertices = new List<Point3D>();
            AdjacencyMatrix = new Dictionary<Point3D, List<Point3D>>();
        }

        public Polyhedron(List<Point3D> points) : this()
        {
            Faces = new List<Polyhedron>();
            Vertices = points;
            foreach (var p in points)
                AdjacencyMatrix.Add(p, new List<Point3D>());
        }

        public void AddEdge(Point3D p1, Point3D p2)
        {
            if (!Vertices.Contains(p1))
                Vertices.Add(p1);
            if (!Vertices.Contains(p2))
                Vertices.Add(p2);
            if (!Edges.Contains(new Edge(p1, p2)))
                Edges.Add(new Edge(p1, p2));
            if (!AdjacencyMatrix.ContainsKey(p1))
                AdjacencyMatrix.Add(p1, new List<Point3D> { p2 });
            else
                AdjacencyMatrix[p1].Add(p2);

        }

        public void AddEdges(Point3D point, List<Point3D> other)
        {
            foreach (var p in other)
                AddEdge(point, p);
        }

        public void AddFace(List<Point3D> points)
        {
            Polyhedron f = new Polyhedron(points);

            for (int i = 0; i < points.Count - 1; i++)
            {
                f.AddEdge(points[i], points[i + 1]);
            }
            f.AddEdge(points[points.Count - 1], points[0]);

            Faces.Add(f);
        }

        public Polyhedron useProjection(Projections projection)
        {
            Matrix3D projMatrix;
            switch (projection)
            {
                case Projections.Perspective:
                    projMatrix = new Matrix3D(1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0.001, 0, 0, 0, 1);
                    break;
                case Projections.Isometric:
                    projMatrix = new Matrix3D(0.707,-0.408,0,0,0,0.816,0,0,-0.707,-0.408,0,0,0,0,0,1);
                    break;
                case Projections.Dimetric:
                    projMatrix = new Matrix3D(0.935,-0.118,0,0,0,0.943,0,0,-0.354,-0.312,0,0,0,0,0,1);
                    break;
                case Projections.Trimetric:
                    projMatrix = new Matrix3D(-Math.Sqrt(2) / 2, (-Math.Sqrt(2) / 2) * (1 / 2), 0, 0, 0, Math.Sqrt(3) / 2, 0, 0, -Math.Sqrt(2) / 2, -(-Math.Sqrt(2) / 2) * (Math.Sqrt(3) / 2), 0, 0, 0, 0, 0, 1);
                    break;
                default:
                    projMatrix = new Matrix3D(1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0.001, 0, 0, 0, 1);
                    break;
            }
            Polyhedron result = new Polyhedron();
            foreach (var val in AdjacencyMatrix)
            {
                var matr = new Matrix3D(val.Key.X, val.Key.Y, val.Key.Z, 1 ,1,1,1,1,1,1,1,1,1,1,1,1);
                var mult = Matrix3D.Multiply(matr, projMatrix);
                var startPoint = new Point3D(mult.M11/mult.M14, mult.M12/mult.M14, 0);

                foreach (var v in val.Value)
                {

                    matr = new Matrix3D(v.X, v.Y, v.Z, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1);
                    mult = Matrix3D.Multiply(matr, projMatrix);
                    var endPoint = new Point3D(mult.M11 / mult.M14, mult.M12 / mult.M14, 0);
                    result.AddEdge(startPoint, endPoint);

                }
            }
            return result;
        }


        public Vector3D NormalVec()
        {
            var p1 = Edges[0].First;
            var p2 = Edges[0].Second;
            var p3 = Edges[1].Second;

            return Vector3D.CrossProduct(p2 - p1, p3 - p2);
        }
    }
}
