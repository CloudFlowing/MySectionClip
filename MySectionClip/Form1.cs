using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySectionClip
{
    public partial class Form1 : Form
    {
        //private Stack<string> p = new Stack<string>();
        //const int StackDeepNumber = 50;
        HotKeys h = new HotKeys();

        // SetClipboardViewer 用于往观察链中添加一个窗口句柄，这个窗口就可成为观察链中的一员了，返回值指向下一个观察者
        [System.Runtime.InteropServices.DllImport("user32")]
        private static extern IntPtr SetClipboardViewer(IntPtr hwnd);

        //ChangeClipboardChain删除由hwnd指定的观察链成员，这是一个窗口句柄，第二个参数hWndNext是观察链中下一个窗口的句柄
        [System.Runtime.InteropServices.DllImport("user32")]
        private static extern IntPtr ChangeClipboardChain(IntPtr hwnd, IntPtr hWndNext);

        //SendMessage 发送消息
        [System.Runtime.InteropServices.DllImport("user32")]
        private static extern int SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, IntPtr lParam);

        //Clipboard内容变化消息
        const int WM_DRAWCLIPBOARD = 0x308;
        //Clipboard观察链变化消息
        const int WM_CHANGECBCHAIN = 0x30D;

        public Form1()
        {
            InitializeComponent();
            this.controlFilter.SelectedIndex = 0;
        }
        //注意把以下两个函数映射到相应事件
        //存放观察链中下一个窗口句柄
        IntPtr NextClipHwnd;
        private void Form_Load(object sender, EventArgs e)
        {
            //获得观察链中下一个窗口句柄
            NextClipHwnd = SetClipboardViewer(this.Handle);

            //全局热键注册
            h.Regist(this.Handle, (int)HotKeys.HotkeyModifiers.Control, Keys.Q, TopMostSetting);
            h.Regist(this.Handle, (int)HotKeys.HotkeyModifiers.Control, Keys.X, Copy);

        }
        private void Form_Closed(object sender, FormClosedEventArgs e)
        {
            //从观察链中删除本观察窗口
            ChangeClipboardChain(this.Handle, NextClipHwnd);
            //将变动消息WM_CHANGECBCHAIN消息传递到下一个观察链中的窗口
            SendMessage(NextClipHwnd, WM_CHANGECBCHAIN, this.Handle, NextClipHwnd);

            //全局热键注销
            h.UnRegist(this.Handle, TopMostSetting);
            h.UnRegist(this.Handle, Copy);
        }
        //重载WndProc方法，监视剪切板，并处理，并把剪切板变化的消息发送给下一个观察者
        protected override void WndProc(ref System.Windows.Forms.Message m)
        {
            switch (m.Msg)
            {
                case WM_DRAWCLIPBOARD:
                    //将WM_DRAWCLIPBOARD消息传递到下一个观察链中的窗口
                    SendMessage(NextClipHwnd, m.Msg, m.WParam, m.LParam);

                    //获取Clipboard内容，并处理
                    //IDataObject iData = Clipboard.GetDataObject();
                    ClipboardContentProcessing();
                    h.ProcessHotKey(m);
                    base.WndProc(ref m);
                    break;
                default:
                    h.ProcessHotKey(m);
                    base.WndProc(ref m);
                    break;
            }
        }


        private void StringFilteringRules(ref string text, string s_in, string s_out) //用于批量替换
        {
            if (s_in == "") return;
            StringBuilder sb = new StringBuilder(text);
            sb.Replace(s_in, s_out);
            text = sb.ToString();
        }
        private string CharacterFilteringRules(string text, string s_in, string s_out)
        {
            if (s_in == "") return "";
            if (text == "" || text == " " || text == "\n") return "";
            return Regex.Replace(text, s_in + "+", s_out);//s_in是正则字符串
        }
        private string CharacterFilteringRulesShell(string s)//用于对复制得到内容中换行符的处理
        {
            StringBuilder sb = new StringBuilder(s);
            for (int i = 0; i < sb.Length; i++) if (sb[i].Equals('\r')) sb[i] = '\n';//注意win下的特殊换行符
            string s1 = sb.ToString();
            if (controlFilter.Text == "" || controlFilter.SelectedIndex == 0) return CharacterFilteringRules(s1, "\n", " ");
            else if (controlFilter.SelectedIndex == 1) return CharacterFilteringRules(s1, "\n", "");
            else if (controlFilter.SelectedIndex == 2) return CharacterFilteringRules(s1, "\n", "\n");
            else return s1;
        }
        private void GetNumberForPags()//给每个有效信息段增加序号
        {

        }
        private void LabelStatusDescription(int a)//状态变化说明
        {
            if (a == 1) labelStatusDescription.Text = "富文本窗口上的信息已复制到剪贴板";
            else if (a == 0) labelStatusDescription.Text = "状态说明";
            else if (a == 2) labelStatusDescription.Text = "富文本窗口上的信息已清空";
            else if (a == 3) labelStatusDescription.Text = "富文本窗口上的信息已批量替换";
            else if (a == 4) labelStatusDescription.Text = "窗口的置顶状态已改变";
            else labelStatusDescription.Text = "状态说明";
        }
        //剪贴板内容获取并处理
        private void ClipboardContentProcessing()
        {
            IDataObject iData = Clipboard.GetDataObject();
            string s1 = (string)iData.GetData(DataFormats.Text);
            string s = CharacterFilteringRulesShell((string)iData.GetData(DataFormats.Text));
            richTextBox1.Text = richTextBox1.Text + s + '\n' + '\n';

            //注意返回上一步操作:
            MyStackOperation();
        }
        private void TopMostSetting()
        {
            if (this.TopMost == false) this.TopMost = true;
            else this.TopMost = false;
            LabelStatusDescription(4);
        }
        //快捷键映射
        private void FrmMain_KeyDown(object sender, KeyEventArgs e)
        {
            // 二级组合键
            if (e.Control && e.KeyCode == Keys.Q)         //Ctrl+q
            {
                TopMostSetting();
            }
            //问题:如何使用本程序操纵剪贴板:比如ctrl+b同时完成了复制当前内容到剪贴板和复制剪贴板内容到其他平台(剪贴板本身功能)?
            else if (e.Control && e.KeyCode == Keys.X)//复制当前内容到剪贴板
            {
                copy_Click(this, EventArgs.Empty);
            }

            else;
        }
        //一个栈操作:如果栈满后push不进去因该怎么做
        private void MyStackOperation()
        {
            //p.Push(richTextBox1.Text);
            //if (p.Count > StackDeepNumber)
            //{
            //    //如果栈满后,应该遗忘以前的操作只记录新的
            //    //一种操作:把栈倒出来,保留最上面的一半值,从新塞回去
            //    string[] strArr = p.ToArray();
            //    p.Clear();
            //    for (int i = strArr.Length / 2; i >= 0; i--) p.Push(strArr[i]);

            //}
            return;

        }
        private void Clear()
        {
            richTextBox1.Text = "";

            MyStackOperation();

            LabelStatusDescription(2);
        }

        private void clear_Click(object sender, EventArgs e)//清空
        {
            Clear();
        }
        private void Copy()
        {
            Clipboard.SetDataObject(richTextBox1.Text + "");

            MyStackOperation();
            richTextBox1.Text = "";

            LabelStatusDescription(1);
        }
        private void copy_Click(object sender, EventArgs e)//复制
        {
            Copy();
        }

        private void replace_Click(object sender, EventArgs e)//批量替换
        {
            string s = richTextBox1.Text;
            StringFilteringRules(ref s, textBox1.Text, textBox2.Text);
            richTextBox1.Text = s;

            MyStackOperation();

            LabelStatusDescription(3);
        }

        private void back_to_last_Click(object sender, EventArgs e)//定义一个深度为StackDeepNumber的栈保存富文本窗口的text
        {
           // if (p.Count > 0) richTextBox1.Text = p.Pop();

            LabelStatusDescription(0);
        }

        private void checkFormFirst_CheckedChanged(object sender, EventArgs e)
        {
            if (checkFormFirst.Checked == true) this.TopMost = true;
            else this.TopMost = false;
        }

        private void Opacity_Click(object sender, EventArgs e)
        {
            this.Opacity = (double)(numericUpDown1.Value / 100);
        }
    }


    public class HotKeys
    {
        //引入系统API
        [DllImport("user32.dll")]
        static extern bool RegisterHotKey(IntPtr hWnd, int id, int modifiers, Keys vk);
        [DllImport("user32.dll")]
        static extern bool UnregisterHotKey(IntPtr hWnd, int id);


        int keyid = 10;     //区分不同的快捷键
        Dictionary<int, HotKeyCallBackHanlder> keymap = new Dictionary<int, HotKeyCallBackHanlder>();   //每一个key对于一个处理函数
        public delegate void HotKeyCallBackHanlder();

        //组合控制键
        public enum HotkeyModifiers
        {
            Alt = 1,
            Control = 2,
            Shift = 4,
            Win = 8
        }

        //注册快捷键
        public void Regist(IntPtr hWnd, int modifiers, Keys vk, HotKeyCallBackHanlder callBack)
        {
            int id = keyid++;
            if (!RegisterHotKey(hWnd, id, modifiers, vk))
            {
                //退出并输出注册失败
                //throw new Exception("注册失败！");
                Environment.Exit(0);
            }
            keymap[id] = callBack;
        }

        // 注销快捷键
        public void UnRegist(IntPtr hWnd, HotKeyCallBackHanlder callBack)
        {
            foreach (KeyValuePair<int, HotKeyCallBackHanlder> var in keymap)
            {
                if (var.Value == callBack)
                {
                    UnregisterHotKey(hWnd, var.Key);
                    return;
                }
            }
        }

        // 快捷键消息处理
        public void ProcessHotKey(Message m)
        {
            if (m.Msg == 0x312)
            {
                int id = m.WParam.ToInt32();
                HotKeyCallBackHanlder callback;
                if (keymap.TryGetValue(id, out callback))
                    callback();
            }
        }
    }
}
