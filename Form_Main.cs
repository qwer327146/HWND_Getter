using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HWND_Getter
{
    public partial class MainForm : Form
    {
        private bool isActive;

       
        public MainForm()
        {
            InitializeComponent();
            isActive = false;
        }

        private void button_Active_Click(object sender, EventArgs e)
        {
            isActive = !isActive;
            if (isActive)
            {
                //启动句柄获取功能
                button_Active.Text = "停止";
                timer1.Start();
            }
            else
            {
                //关闭句柄获取功能
                button_Active.Text = "启动";
                timer1.Stop();
            }            
        }

        /// <summary>
        /// 返回包含了指定点的窗口的句柄。忽略屏蔽、隐藏以及透明窗口
        /// </summary>
        /// <param name="Point">指定的鼠标坐标</param>
        /// <returns>鼠标坐标处的窗口句柄，如果没有，返回</returns>
        [DllImport("user32.dll")]
        internal static extern IntPtr WindowFromPoint(Point Point);

        /// <summary>
        /// 获取鼠标处的坐标
        /// </summary>
        /// <param name="lpPoint">随同指针在屏幕像素坐标中的位置载入的一个结构</param>
        /// <returns>非零表示成功，零表示失败</returns>
        [DllImport("user32.dll")]
        internal static extern bool GetCursorPos(out Point lpPoint);

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point p;
            int calcID = 0; //进程ID
            int calcTD = 0; //线程ID
            GetCursorPos(out p);//获取鼠标坐标
            //基础功能
            //this.Text = WindowFromPoint(p).ToString("X");//转换为16进制
            textBox_HWND.Text = WindowFromPoint(p).ToString();//转换为16进制
            calcID =GetWindowThreadProcessId(WindowFromPoint(p),out calcTD);
            textBox_ProcessID.Text = calcTD.ToString();

            //扩展功能
            RECT mRect = new RECT();
            GetWindowRect(WindowFromPoint(p), ref mRect);
            textBox_Left.Text = mRect.Left.ToString();
            textBox_Top.Text = mRect.Top.ToString();
            textBox_Right.Text = mRect.Right.ToString();
            textBox_Bottom.Text = mRect.Bottom.ToString();

            textBox_Width.Text = (mRect.Right - mRect.Left).ToString();
            textBox_Height.Text = (mRect.Bottom - mRect.Top).ToString();
        }

        [DllImport("user32", EntryPoint = "GetWindowThreadProcessId")]
        private static extern int GetWindowThreadProcessId(IntPtr hwnd, out int pid);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetWindowRect(IntPtr hWnd, ref RECT lpRect);

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left;                            //最左坐标
            public int Top;                             //最上坐标
            public int Right;                           //最右坐标
            public int Bottom;                          //最下坐标
        }
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F4)
            {
                button_Active_Click(this,null);
            }
        }
    }
}
