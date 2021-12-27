using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indiv2
{

    public class Material
    {
        public float reflection;
        public float refraction;

        public float environment;//преломлениe среды
        public float ambient;//эмбиент
        public float diffuse;//диффузное

        public Point3D color;

        public Material(float refl, float refr, float amb, float dif, float env = 1)
        {
            reflection = refl;
            refraction = refr;
            ambient = amb;
            diffuse = dif;
            environment = env;
        }

        public Material(Material m)
        {
            reflection = m.reflection;
            refraction = m.refraction;
            environment = m.environment;
            ambient = m.ambient;
            diffuse = m.diffuse;
            color = new Point3D(m.color);
        }

        public Material() { }
    }

    public class Ray
    {
        public Point3D start, direction;

        public Ray(Point3D u, Point3D v)
        {
            start = new Point3D(u);
            direction = Point3D.Normal(v - u);
        }
        public Ray(Ray r)
        {
            start = r.start;
            direction = r.direction;
        }

        public Ray() { }

        



        public Ray reflect(Point3D hit_point, Point3D normal)
        {
            Point3D reflect_dir = direction - 2 * normal * Point3D.scAngle(direction, normal);
            return new Ray(hit_point, hit_point + reflect_dir);
        }

        public Ray refract(Point3D hit_point, Point3D normal, float eta)
        {
            Ray res_ray = new Ray();
            float sclr = Point3D.scAngle(normal, direction);

            float k = 1 - eta * eta * (1 - sclr * sclr);

            if (k >= 0)
            {
                float cos_theta = (float)Math.Sqrt(k);
                res_ray.start = new Point3D(hit_point);
                res_ray.direction = Point3D.Normal(eta * direction - (cos_theta + eta * sclr) * normal);
                return res_ray;
            }
            else
                return null;
        }
    }

    public class Lighting: Figure
    {
        public Point3D pointLight;
        public Point3D colorLight;

        public Lighting(Point3D p, Point3D c)
        {
            pointLight = new Point3D(p);
            colorLight = new Point3D(c);
        }

        // вычисление локальной модели освещения
        public Point3D shade(Point3D hitP, Point3D normal, Point3D objectColor, float diffCoef)
        {
            Point3D dir = pointLight - hitP;
            dir = Point3D.Normal(dir);

            Point3D diff = diffCoef * colorLight * Math.Max(Point3D.scAngle(normal, dir), 0);
            return new Point3D(diff.x * objectColor.x, diff.y * objectColor.y, diff.z * objectColor.z);
        }
    }
}
