using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indiv2
{

    public class Material
    {
        public float reflection;    // коэффициент отражения
        public float refraction;    // коэффициент преломления
        public float environment;   // коэффициент преломления среды
        public float ambient;       // коэффициент принятия фонового освещения
        public float diffuse;       // коэффициент принятия диффузного освещения
        public Point3D color;         // цвет материала

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

        public Ray(Point3D st, Point3D end)
        {
            start = new Point3D(st);
            direction = Point3D.norm(end - st);
        }

        public Ray() { }

        public Ray(Ray r)
        {
            start = r.start;
            direction = r.direction;
        }

        // отражение
        public Ray reflect(Point3D hit_point, Point3D normal)
        {
            Point3D reflect_dir = direction - 2 * normal * Point3D.scalar(direction, normal);
            return new Ray(hit_point, hit_point + reflect_dir);
        }

        // преломление
        public Ray refract(Point3D hit_point, Point3D normal, float eta)
        {
            Ray res_ray = new Ray();
            float sclr = Point3D.scalar(normal, direction);

            float k = 1 - eta * eta * (1 - sclr * sclr);

            if (k >= 0)
            {
                float cos_theta = (float)Math.Sqrt(k);
                res_ray.start = new Point3D(hit_point);
                res_ray.direction = Point3D.norm(eta * direction - (cos_theta + eta * sclr) * normal);
                return res_ray;
            }
            else
                return null;
        }
    }

    public class Lighting: Figure
    {
        public Point3D point_light;       // точка, где находится источник света
        public Point3D color_light;       // цвет источника света

        public Lighting(Point3D p, Point3D c)
        {
            point_light = new Point3D(p);
            color_light = new Point3D(c);
        }

        // вычисление локальной модели освещения
        public Point3D shade(Point3D hit_point, Point3D normal, Point3D color_obj, float diffuse_coef)
        {
            Point3D dir = point_light - hit_point;
            dir = Point3D.norm(dir);                // направление луча из источника света в точку удара

            Point3D diff = diffuse_coef * color_light * Math.Max(Point3D.scalar(normal, dir), 0);
            return new Point3D(diff.x * color_obj.x, diff.y * color_obj.y, diff.z * color_obj.z);
        }
    }
}
