using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task5graphics
{
    public partial class Form1 : Form
    {
        public class Node
        {    
            public PointF Pos { get; set; }
            public Color Clr { get; set; }
            public Node (PointF A, Color B)
            {
                Pos = A;
                Clr = B;
            }
            public bool isSelected(PointF A)
            {
                bool yes = false;
                if ((A.X <= Pos.X + 5 && A.X >= Pos.X - 5) && (A.Y <= Pos.Y + 5 && A.Y >= Pos.Y - 5)) {
                    Controller.LastSelNode = Controller.SelNode;
                    yes = true; 
                }
                return yes;
            }
        }
        public class Arc
        {
            public int A { get; set; }
            public int B { get; set; }
            public PointF Mid  { get; set; }
            public Color Clr { get; set; }
            public Arc(int X, int Y, Color C)
            {
                int delt = -10;
                if (Controller.nodes[A].Pos.X > 250 || Controller.nodes[B].Pos.X > 250) delt = 10;
                A = X;
                B = Y;
                Clr = C;
                Mid = new PointF((Controller.nodes[A].Pos.X + Controller.nodes[B].Pos.X) / 2 + delt, (Controller.nodes[A].Pos.Y + Controller.nodes[B].Pos.Y) / 2 + delt);
            }

        }
        public static class Controller
        {
            public static Color SelColor;
            public static PointF Click { get; set; }
            public static PointF HoldUp { get; set; }
            public static int SelNode { get; set; }
            public static int LastSelNode { get; set; }
            public static List<Node> nodes = new List<Node>();
            public static List<Arc> arcs = new List<Arc>();
            public static void changeN()
            {
                nodes[SelNode].Pos = Click;
                nodes[SelNode].Clr = SelColor;
            }
            public static void changeA()
            {
                for (int i = 0; i < arcs.Count; i++)
                {
                    if ((arcs[i].A == SelNode && arcs[i].B == LastSelNode) || (arcs[i].B == SelNode && arcs[i].A == LastSelNode))
                    {
                        arcs[i].Clr = SelColor;
                        arcs[i].Mid = Click;
                    }
                }
            }
            public static void addN()
            {
                bool isEmpty = true;
                for (int i = 0; i < nodes.Count; i++)
                {
                    if (nodes[i].isSelected(Click)) isEmpty = false;
                }
               if(isEmpty == true) nodes.Add(new Node(Click, SelColor));
            }
            public static void delA()
            {
                for (int i = 0; i < arcs.Count; i++)
                {
                    if ((arcs[i].A == SelNode && arcs[i].B == LastSelNode) || (arcs[i].B == SelNode && arcs[i].A == LastSelNode))
                    {
                        arcs.Remove(arcs[i]);
                    }
                }
            }
            public static void delN()
            {
                int ind = SelNode;
                for (int i = 0; i < arcs.Count; i++)
                {
                    if ((arcs[i].A == SelNode) || (arcs[i].B == SelNode))
                    {
                        arcs.Remove(arcs[i]);
                    }
                    if (arcs[i].A > SelNode) arcs[i].A -= 1;
                    if (arcs[i].B > SelNode) arcs[i].B -= 1;
                }
                if (SelNode != -1)
                {  
                    nodes.Remove(nodes[SelNode]);
                    SelNode = -1;
                }
            }
            public static void addA()
            {
                if(SelNode != -1 && LastSelNode != -1)arcs.Add(new Arc(SelNode, LastSelNode, SelColor));
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int h = Screen.PrimaryScreen.WorkingArea.Height;
            int w = Screen.PrimaryScreen.WorkingArea.Width;
            
            PointF A = this.PointToClient(Panel.MousePosition);
            Controller.Click = A;
            if (create.Checked) { Controller.addN(); }
            else
            {
                for(int i =0; i<Controller.nodes.Count; i++)
                {
                    if (Controller.nodes[i].isSelected(A)) Controller.SelNode = i;
                }

            }

        }
        public void ReDraw(List <Node> A, List <Arc> B)
        {
            
            Graphics g = pictureBox1.CreateGraphics();

                for (int i = 0; i < A.Count; i++)
                {
                Pen c = new Pen(Color.OrangeRed);
                Pen b = new Pen(A[i].Clr);
                g.DrawEllipse(b, A[i].Pos.X-5, A[i].Pos.Y-5, 10, 10);
                if(i == Controller.SelNode || i == Controller.LastSelNode)
                {
                    g.DrawEllipse(b, A[i].Pos.X - 3, A[i].Pos.Y - 3, 6, 6);
                }
                if (i == Controller.SelNode)
                {
                    g.DrawEllipse(c, A[i].Pos.X - 3, A[i].Pos.Y - 3, 6, 6);
                }
            }
            for (int i = 0; i < B.Count; i++)
            {
                Pen b = new Pen(B[i].Clr);
                PointF X = A[B[i].A].Pos;
                PointF Y = A[B[i].B].Pos;
                PointF M = B[i].Mid;
                PointF[] mass = new PointF[3] { X, M, Y };
                g.DrawCurve(b, mass);
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            ReDraw(Controller.nodes, Controller.arcs);
            sX.Text = Convert.ToString(Controller.Click.X);
            sY.Text = Convert.ToString(Controller.Click.Y);
            sColor.Text = Convert.ToString(Controller.SelColor);
            sA.Text = Convert.ToString(Controller.SelNode);
            sB.Text = Convert.ToString(Controller.LastSelNode);
            sNodes.Text = Convert.ToString(Controller.nodes.Count);
            sArcs.Text = Convert.ToString(Controller.arcs.Count);
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Interval = 10 * timer1.Interval;
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.White);
        }

        private void black_Click(object sender, EventArgs e)
        {
            blue.Checked = false;
            red.Checked = false;
            Controller.SelColor = Color.Black;
            black.Checked = true;
        }

        private void blue_Click(object sender, EventArgs e)
        {
            red.Checked = false;
            black.Checked = false;
            Controller.SelColor = Color.Blue;
            blue.Checked = true;
        }

        private void red_Click(object sender, EventArgs e)
        {
            blue.Checked = false;
            black.Checked = false;
            Controller.SelColor = Color.Red;
            red.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controller.addA();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Controller.SelNode = -1;
            Controller.LastSelNode = -1;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            Controller.delN();
        }

        private void change_Click(object sender, EventArgs e)
        {
            Controller.changeN();
        }

        private void changeA_Click(object sender, EventArgs e)
        {
            Controller.changeA();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Controller.delA();
        }
    }
}
