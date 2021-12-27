using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Indiv2
{
    public partial class Form1 : Form
    {
        public List<Figure> scene = new List<Figure>();
        public List<Lighting> lights = new List<Lighting>();
        public Color[,] pixColors;
        public Point3D[,] pixs;
        public Point3D focus;

        public Point3D upperLeft, upperRight, lowerLeft, lowerRight;
        public int h, w;

        public Form1()
        {
            InitializeComponent();
            focus = new Point3D();
            upperLeft = new Point3D();
            upperRight = new Point3D();
            lowerLeft = new Point3D();
            lowerRight = new Point3D();

            h = pictureBox1.Height;
            w = pictureBox1.Width;
            pictureBox1.Image = new Bitmap(w, h);
        }

        public void buildScene()
        {
            //
            //Setting up room
            //
            Figure room = Figure.createHexahedron(12);

            upperLeft = room.sides[0].getPoint(0);
            upperRight = room.sides[0].getPoint(1);
            lowerRight = room.sides[0].getPoint(2);
            lowerLeft = room.sides[0].getPoint(3);

            Point3D normal = Face.getNormal(room.sides[0]);
            Point3D center = (upperLeft + upperRight + lowerLeft + lowerRight) / 4;
            focus = center + normal * 10;

            room.setPen(new Pen(Color.White));
            room.isRoom = true;

            float refl,
                refr,
                amb,
                dif,
                env;
            room.sides[0].color = new Pen(Color.White);

            //front wall settings
            room.sides[1].color = new Pen(Color.White);
            if (frontWallSpecCheckBox.Checked)
            {
                refl = 0.8f;
                refr = 0f;
                amb = 0.0f;
                dif = 0.0f;
                env = 1f;
            }
            else
            {
                refl = 0.0f;
                refr = 0f;
                amb = 0.1f;
                dif = 0.8f;
                env = 1f;
            }
            room.front_wall_material = new Material(refl, refr, amb, dif, env);

            //
            if (backWallSpecCheckBox.Checked)
            {
                refl = 0.8f;
                refr = 0f;
                amb = 0.0f;
                dif = 0.0f;
                env = 1f;
            }
            else
            {
                refl = 0.0f;
                refr = 0f;
                amb = 0.1f;
                dif = 0.8f;
                env = 1f;
            }
            room.back_wall_material = new Material(refl, refr, amb, dif, env);

            //
            room.sides[2].color = new Pen(Color.Blue);
            if (rightWallSpecCheckBox.Checked)
            {
                refl = 0.8f;
                refr = 0f;
                amb = 0.0f;
                dif = 0.0f;
                env = 1f;
            }
            else
            {
                refl = 0.0f;
                refr = 0f;
                amb = 0.1f;
                dif = 0.8f;
                env = 1f;
            }
            room.right_wall_material = new Material(refl, refr, amb, dif, env);

            //
            room.sides[3].color = new Pen(Color.Red);
            if (leftWallSpecCheckBox.Checked)
            {
                refl = 0.8f;
                refr = 0f;
                amb = 0.0f;
                dif = 0.0f;
                env = 1f;
            }
            else
            {
                refl = 0.0f;
                refr = 0f;
                amb = 0.1f;
                dif = 0.8f;
                env = 1f;
            }
            room.left_wall_material = new Material(refl, refr, amb, dif, env);

            //
            room.sides[4].color = new Pen(Color.White);
            if (upWallSpecCheckBox.Checked)
            {
                refl = 0.8f;
                refr = 0f;
                amb = 0.0f;
                dif = 0.0f;
                env = 1f;
            }
            else
            {
                refl = 0.0f;
                refr = 0f;
                amb = 0.1f;
                dif = 0.8f;
                env = 1f;
            }
            room.up_wall_material = new Material(refl, refr, amb, dif, env);

            //
            room.sides[5].color = new Pen(Color.White);
            if (downWallSpecCheckBox.Checked)
            {
                refl = 0.8f;
                refr = 0f;
                amb = 0.0f;
                dif = 0.0f;
                env = 1f;
            }
            else
            {
                refl = 0.0f;
                refr = 0f;
                amb = 0.1f;
                dif = 0.8f;
                env = 1f;
            }
            room.down_wall_material = new Material(refl, refr, amb, dif, env);

            scene.Add(room);


            //
            //Setting up light
            //
            Lighting bulb1 = new Lighting(new Point3D(0f, 1f, 5f), new Point3D(1f, 1f, 1f));
            lights.Add(bulb1);
            if (floorLCheckBox.Checked)
            {
                Lighting bulb2 = new Lighting(new Point3D(0f, 1f, -5f), new Point3D(1f, 1f, 1f));
                lights.Add(bulb2);
            }
            if (leftLCheckBox.Checked)
            {
                Lighting bulb3 = new Lighting(new Point3D(5f, 1f, 0.0f), new Point3D(1f, 1f, 1f));
                lights.Add(bulb3);
            }
            if (rightLCheckBox.Checked)
            {
                Lighting bulb4 = new Lighting(new Point3D(-5f, 1f, 0.0f), new Point3D(1f, 1f, 1f));
                lights.Add(bulb4);
            }

            //
            //Setting up cubes
            //
            Figure cube1 = Figure.createHexahedron(2.5f);
            cube1.Shift(-2.5f, 0.0f, 2.5f);
            cube1.setPen(new Pen(Color.DarkGray));

            if (cubeRefCheckBox.Checked)
            {
                refl = 0.0f;
                refr = 0.8f;
                amb = 0f;
                dif = 0.0f;
                env = 1.03f;
            }
            else
            {
                refl = 0f;
                refr = 0f;
                amb = 0.1f;
                dif = 0.7f;
                env = 1f;
            }
            cube1.figure_material = new Material(refl, refr, amb, dif, env);

            Figure cube2 = Figure.createHexahedron(2.5f);
            cube2.Shift(-2.5f, 0.0f, -2.5f);
            cube2.setPen(new Pen(Color.White));

            if (cubeSpecCheckBox.Checked)
            {
                refl = 0.9f;
                refr = 0f;
                amb = 0f;
                dif = 0.1f;
                env = 1f;
            }
            else
            {
                refl = 0.0f;
                refr = 0f;
                amb = 0.1f;
                dif = 0.8f;
                env = 1f;
            }
            cube2.figure_material = new Material(refl, refr, amb, dif, env);

            scene.Add(cube1);
            scene.Add(cube2);
            //
            //Setting up spheres
            //
            Sphere sphere1 = new Sphere(new Point3D(2.5f, 0.0f, 2.5f), 2f);

            sphere1.setPen(new Pen(Color.White));
            if (sphereSpecCheckBox.Checked)
            {
                refl = 0.9f;
                refr = 0f;
                amb = 0f;
                dif = 0.1f;
                env = 1f;
            }
            else
            {
                refl = 0.0f;
                refr = 0f;
                amb = 0.1f;
                dif = 0.8f;
                env = 1f;
            }
            sphere1.figure_material = new Material(refl, refr, amb, dif, env);


            Sphere sphere2 = new Sphere(new Point3D(2.5f, 0.0f, -2.5f), 2f);

            sphere2.setPen(new Pen(Color.DarkGray));
            if (sphereRefCheckBox.Checked)
            {
                refl = 0.0f;
                refr = 0.8f;
                amb = 0f;
                dif = 0.0f;
                env = 1.03f;
            }
            else
            {
                refl = 0f;
                refr = 0f;
                amb = 0.1f;
                dif = 0.7f;
                env = 1f;
            }
            sphere2.figure_material = new Material(refl, refr, amb, dif, env);

            scene.Add(sphere1);
            scene.Add(sphere2);
        }

        public void Clear()
        {
            scene.Clear();
            lights.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clear();
            buildScene();
            applyRayTracing();

            for (int x = 0; x < w; ++x)
            {
                for (int y = 0; y < h; ++y)
                {
                    (pictureBox1.Image as Bitmap).SetPixel(x, y, pixColors[x, y]);
                }
            }
            pictureBox1.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void applyRayTracing()
        {
            rasterScene();

            for (int i = 0; i < w; ++i)
            {
                for (int j = 0; j < h; ++j)
                {
                    Ray r = new Ray(focus, pixs[i, j]);
                    r.start = new Point3D(pixs[i, j]);
                    Point3D pixColor = RayTracing(r, 10, 1);
                    if (pixColor.x > 1.0f || pixColor.y > 1.0f || pixColor.z > 1.0f)
                        pixColor = Point3D.Normal(pixColor);
                    pixColors[i, j] = Color.FromArgb((int)(255 * pixColor.x), (int)(255 * pixColor.y), (int)(255 * pixColor.z));
                }
            }
        }

        // получение всех пикселей сцены
        public void rasterScene()
        {
            pixs = new Point3D[w, h];
            pixColors = new Color[w, h];
            Point3D step_up = (upperRight - upperLeft) / (w - 1);
            Point3D step_down = (lowerRight - lowerLeft) / (w - 1);

            Point3D up = new Point3D(upperLeft);
            Point3D down = new Point3D(lowerLeft);

            for (int x = 0; x < w; x++)
            {
                Point3D step_y = (up - down) / (h - 1);
                Point3D d = new Point3D(down);
                for (int y = 0; y < h; y++)
                {
                    pixs[x, y] = d;
                    d += step_y;
                }
                up += step_up;
                down += step_down;
            }
        }

        // видима ли точка пересечения луча с фигурой из источника света
        public bool is_visible(Point3D light_point, Point3D hit_point)
        {
            float max_t = (light_point - hit_point).length();     // позиция источника света на луче
            Ray r = new Ray(hit_point, light_point);

            foreach (Figure fig in scene)
                if (fig.figureIntersect(r, out float t, out Point3D n))
                    if (t < max_t && t > Figure.EPS)
                        return false;
            return true;
        }

        //отслеживаем луч
        public Point3D RayTracing(Ray r, int depth, float env)
        {
            float t = 0;
            Point3D normal = null;
            Material m = new Material();
            Point3D resColor = new Point3D(0, 0, 0);
            bool refrAway = false;

            if (depth <= 0)
                return new Point3D(0, 0, 0);

            foreach (Figure f in scene)
            {
                if (f.figureIntersect(r, out float intersect, out Point3D n))
                    if (intersect < t || t == 0)
                    {
                        t = intersect;
                        normal = n;
                        m = new Material(f.figure_material);
                    }
            }

            if (t == 0)
                return new Point3D(0, 0, 0);

            if (Point3D.scAngle(r.direction, normal) > 0)
            {
                normal *= -1;
                refrAway = true;
            }

            Point3D hitP = r.start + r.direction * t;

            //просчёт эмбиента и дифф освещения
            foreach (Lighting l in lights)
            {
                Point3D amb = l.colorLight * m.ambient;
                amb.x = (amb.x * m.color.x);
                amb.y = (amb.y * m.color.y);
                amb.z = (amb.z * m.color.z);
                resColor += amb;

                if (is_visible(l.pointLight, hitP))
                    resColor += l.shade(hitP, normal, m.color, m.diffuse);
            }

            if (m.reflection > 0)
            {
                Ray reflectedRay = r.reflect(hitP, normal);
                resColor += m.reflection * RayTracing(reflectedRay, depth - 1, env);
            }

            if (m.refraction > 0)
            {
                float refrCoef;//коэффициент преломления

                if (refrAway)
                {
                    refrCoef = m.environment;
                }
                else
                {
                    refrCoef = 1 / m.environment;
                }

                Ray refractedRay = r.refract(hitP, normal, refrCoef);
                if (refractedRay != null)
                    resColor += m.refraction * RayTracing(refractedRay, depth - 1, m.environment);
            }

            return resColor;
        }
    }
}
