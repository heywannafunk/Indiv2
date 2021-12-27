using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indiv2
{
    public class Face
    {
        public Figure owner = null;
        public List<int> points = new List<int>();
        public Pen color = new Pen(Color.Black);
        public Point3D Normal;

        public Face(Figure h = null)
        {
            owner = h;
        }
        public Face(Face s)
        {
            points = new List<int>(s.points);
            owner = s.owner;
            color = s.color.Clone() as Pen;
            Normal = new Point3D(s.Normal);
        }
        public Point3D getPoint(int ind)
        {
            if (owner != null)
                return owner.points[points[ind]];
            return null;
        }

        public static Point3D getNormal(Face S)
        {
            if (S.points.Count() < 3)
                return new Point3D(0, 0, 0);

            Point3D U = S.getPoint(1) - S.getPoint(0);
            Point3D V = S.getPoint(S.points.Count - 1) - S.getPoint(0);
            Point3D normal = U * V;
            return Point3D.Normal(normal);
        }
    }

    public class Figure
    {
        public bool isRoom = false;
        public static float EPS = 0.0001f;
        public List<Point3D> points = new List<Point3D>();
        public List<Face> sides = new List<Face>();
        public Material figure_material;

        public Material front_wall_material;
        public Material back_wall_material;
        public Material left_wall_material;
        public Material right_wall_material;
        public Material up_wall_material;
        public Material down_wall_material;

        public Figure() { }

        public Figure(Figure f)
        {
            foreach (Point3D p in f.points)
                points.Add(new Point3D(p));

            foreach (Face s in f.sides)
            {
                sides.Add(new Face(s));
                sides.Last().owner = this;
            }
        }

        public bool ray_intersects_triangle(Ray r, Point3D p0, Point3D p1, Point3D p2, out float intersect)
        {
            intersect = -1;

            Point3D edge1 = p1 - p0;
            Point3D edge2 = p2 - p0;
            Point3D h = r.direction * edge2;
            float a = Point3D.scAngle(edge1, h);

            if (a > -EPS && a < EPS)
                return false;// This ray is parallel to this triangle.

            float f = 1.0f / a;
            Point3D s = r.start - p0;
            float u = f * Point3D.scAngle(s, h);

            if (u < 0 || u > 1)
                return false;

            Point3D q = s * edge1;
            float v = f * Point3D.scAngle(r.direction, q);

            if (v < 0 || u + v > 1)
                return false;
            // At this stage we can compute t to find out where the intersection point is on the line.
            float t = f * Point3D.scAngle(edge2, q);
            if (t > EPS)
            {
                intersect = t;
                return true;
            }
            else      // This means that there is a line intersection but not a ray intersection.
                return false;
        }

        // пересечение луча с фигурой
        public virtual bool figureIntersect(Ray r, out float intersect, out Point3D normal)
        {
            intersect = 0;
            normal = null;
            Face sd = null;
            int fm = -1; 

            for (int i = 0; i < sides.Count; ++i)
            {
                
                if (sides[i].points.Count == 3)
                {
                    if (ray_intersects_triangle(r, sides[i].getPoint(0), sides[i].getPoint(1), sides[i].getPoint(2), out float t) && (intersect == 0 || t < intersect))
                    {
                        intersect = t;
                        sd = sides[i];
                    }
                }
                else if (sides[i].points.Count == 4)
                {
                    if (ray_intersects_triangle(r, sides[i].getPoint(0), sides[i].getPoint(1), sides[i].getPoint(3), out float t) && (intersect == 0 || t < intersect))
                    {
                        fm = i;
                        intersect = t;
                        sd = sides[i];
                    }
                    else if (ray_intersects_triangle(r, sides[i].getPoint(1), sides[i].getPoint(2), sides[i].getPoint(3), out t) && (intersect == 0 || t < intersect))
                    {
                        fm = i;
                        intersect = t;
                        sd = sides[i];
                    }
                }
            }

            if (intersect != 0)
            {
                normal = Face.getNormal(sd);
                if (isRoom)
                    switch (fm)
                    {
                        case 0:
                            figure_material = new Material(back_wall_material);
                            break;
                        case 1:
                            figure_material = new Material(front_wall_material);
                            break;
                        case 2:
                            figure_material = new Material(right_wall_material);
                            break;
                        case 3:
                            figure_material = new Material(left_wall_material);
                            break;
                        case 4:
                            figure_material = new Material(up_wall_material);
                            break;
                        case 5:
                            figure_material = new Material(down_wall_material);
                            break;
                        default:
                            break;
                    }
                figure_material.color = new Point3D(sd.color.Color.R / 255f, sd.color.Color.G / 255f, sd.color.Color.B / 255f);
                return true;
            }
            return false;
        }

        //transformations
        public float[,] GetMatrix()
        {
            var res = new float[points.Count, 4];
            for (int i = 0; i < points.Count; i++)
            {
                res[i, 0] = points[i].x;
                res[i, 1] = points[i].y;
                res[i, 2] = points[i].z;
                res[i, 3] = 1;
            }
            return res;
        }

        public void Matrix(float[,] matrix)
        {
            for (int i = 0; i < points.Count; i++)
            {
                points[i].x = matrix[i, 0] / matrix[i, 3];
                points[i].y = matrix[i, 1] / matrix[i, 3];
                points[i].z = matrix[i, 2] / matrix[i, 3];
            }
        }

        private Point3D Center()
        {
            Point3D res = new Point3D(0, 0, 0);
            foreach (Point3D p in points)
            {
                res.x += p.x;
                res.y += p.y;
                res.z += p.z;

            }
            res.x /= points.Count();
            res.y /= points.Count();
            res.z /= points.Count();
            return res;
        }

        public void Spin(float rangle, string type)
        {
            float[,] mt = GetMatrix();
            Point3D center = Center();
            switch (type)
            {
                case "X":
                    mt = Shift(mt, -center.x, -center.y, -center.z);
                    mt = RotateX(mt, rangle);
                    mt = Shift(mt, center.x, center.y, center.z);
                    break;
                case "Y":
                    mt = Shift(mt, -center.x, -center.y, -center.z);
                    mt = RotateY(mt, rangle);
                    mt = Shift(mt, center.x, center.y, center.z);
                    break;
                case "Z":
                    mt = Shift(mt, -center.x, -center.y, -center.z);
                    mt = RotateZ(mt, rangle);
                    mt = Shift(mt, center.x, center.y, center.z);
                    break;
                default:
                    break;
            }
            Matrix(mt);
        }

        public void rotateAxis(float angle, string type)
        {
            Spin(angle * (float)Math.PI / 180, type);
        }

        public void scaleAxis(float xs, float ys, float zs)
        {
            float[,] pnts = GetMatrix();
            pnts = Scale(pnts, xs, ys, zs);
            Matrix(pnts);
        }

        public void Shift(float xs, float ys, float zs)
        {
            Matrix(Shift(GetMatrix(), xs, ys, zs));
        }

        public virtual void setPen(Pen dw)
        {
            foreach (Face s in sides)
                s.color = dw;
        }

        private static float[,] multiply_matrix(float[,] m1, float[,] m2)
        {
            float[,] res = new float[m1.GetLength(0), m2.GetLength(1)];
            for (int i = 0; i < m1.GetLength(0); i++)
            {
                for (int j = 0; j < m2.GetLength(1); j++)
                {
                    for (int k = 0; k < m2.GetLength(0); k++)
                    {
                        res[i, j] += m1[i, k] * m2[k, j];
                    }
                }
            }
            return res;
        }

        private static float[,] Shift(float[,] transform_matrix, float offset_x, float offset_y, float offset_z)
        {
            float[,] translationMatrix = new float[,] { 
                { 1, 0, 0, 0 }, 
                { 0, 1, 0, 0 }, 
                { 0, 0, 1, 0 }, 
                { offset_x, offset_y, offset_z, 1 } };
            return multiply_matrix(transform_matrix, translationMatrix);
        }

        private static float[,] RotateX(float[,] transform_matrix, float angle)
        {
            float[,] rotationMatrix = new float[,] { 
                { 1, 0, 0, 0 }, 
                { 0, (float)Math.Cos(angle), (float)Math.Sin(angle), 0 },
                { 0, -(float)Math.Sin(angle), (float)Math.Cos(angle), 0}, 
                { 0, 0, 0, 1} };
            return multiply_matrix(transform_matrix, rotationMatrix);
        }

        private static float[,] RotateY(float[,] transform_matrix, float angle)
        {
            float[,] rotationMatrix = new float[,] {
                { (float)Math.Cos(angle), 0, -(float)Math.Sin(angle), 0 }, 
                { 0, 1, 0, 0 },
                { (float)Math.Sin(angle), 0, (float)Math.Cos(angle), 0}, 
                { 0, 0, 0, 1} };
            return multiply_matrix(transform_matrix, rotationMatrix);
        }

        private static float[,] RotateZ(float[,] transform_matrix, float angle)
        {
            float[,] rotationMatrix = new float[,] { 
                { (float)Math.Cos(angle), (float)Math.Sin(angle), 0, 0 }, 
                { -(float)Math.Sin(angle), (float)Math.Cos(angle), 0, 0 },
                { 0, 0, 1, 0 },
                { 0, 0, 0, 1} };
            return multiply_matrix(transform_matrix, rotationMatrix);
        }

        private static float[,] Scale(float[,] transform_matrix, float scale_x, float scale_y, float scale_z)
        {
            float[,] scaleMatrix = new float[,] { 
                { scale_x, 0, 0, 0 }, 
                { 0, scale_y, 0, 0 },
                { 0, 0, scale_z, 0 }, 
                { 0, 0, 0, 1 } };
            return multiply_matrix(transform_matrix, scaleMatrix);
        }


        static public Figure createHexahedron(float sz)
        {
            Figure res = new Figure();
            res.points.Add(new Point3D(sz / 2, sz / 2, sz / 2)); // 0 
            res.points.Add(new Point3D(-sz / 2, sz / 2, sz / 2)); // 1
            res.points.Add(new Point3D(-sz / 2, sz / 2, -sz / 2)); // 2
            res.points.Add(new Point3D(sz / 2, sz / 2, -sz / 2)); //3

            res.points.Add(new Point3D(sz / 2, -sz / 2, sz / 2)); // 4
            res.points.Add(new Point3D(-sz / 2, -sz / 2, sz / 2)); //5
            res.points.Add(new Point3D(-sz / 2, -sz / 2, -sz / 2)); // 6
            res.points.Add(new Point3D(sz / 2, -sz / 2, -sz / 2)); // 7

            Face s = new Face(res);
            s.points.AddRange(new int[] { 3, 2, 1, 0 });
            res.sides.Add(s);

            s = new Face(res);
            s.points.AddRange(new int[] { 4, 5, 6, 7 });
            res.sides.Add(s);

            s = new Face(res);
            s.points.AddRange(new int[] { 2, 6, 5, 1 });
            res.sides.Add(s);

            s = new Face(res);
            s.points.AddRange(new int[] { 0, 4, 7, 3 });
            res.sides.Add(s);

            s = new Face(res);
            s.points.AddRange(new int[] { 1, 5, 4, 0 });
            res.sides.Add(s);

            s = new Face(res);
            s.points.AddRange(new int[] { 2, 3, 7, 6 });
            res.sides.Add(s);

            return res;
        }
    }

    public class Sphere : Figure
    {
        float radius;

        public Pen color = new Pen(Color.Black);

        public Sphere(Point3D p, float r)
        {
            points.Add(p);
            radius = r;
        }

        public static bool sphereRayIntersection(Ray r, Point3D sphere_pos, float sphere_rad, out float t)
        {
            Point3D k = r.start - sphere_pos;
            float b = Point3D.scAngle(k, r.direction);
            float c = Point3D.scAngle(k, k) - sphere_rad * sphere_rad;
            float d = b * b - c;
            t = 0;

            if (d >= 0)
            {
                float sqrtd = (float)Math.Sqrt(d);
                float t1 = -b + sqrtd;
                float t2 = -b - sqrtd;

                float min_t = Math.Min(t1, t2);
                float max_t = Math.Max(t1, t2);

                t = (min_t > EPS) ? min_t : max_t;
                return t > EPS;
            }
            return false;
        }

        public override void setPen(Pen dw)
        {
            color = dw;

        }

        public override bool figureIntersect(Ray r, out float t, out Point3D normal)
        {
            t = 0;
            normal = null;

            if (sphereRayIntersection(r, points[0], radius, out t) && (t > EPS))
            {
                normal = (r.start + r.direction * t) - points[0];
                normal = Point3D.Normal(normal);
                figure_material.color = new Point3D(color.Color.R / 255f, color.Color.G / 255f, color.Color.B / 255f);
                return true;
            }
            return false;
        }
    }
}
