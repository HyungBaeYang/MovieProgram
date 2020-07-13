using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 회원_로그인_Test
{
    static class Program
    {
        
        public static MainForm mainForm_ = null;
        public static ProgramState programState_ = null;
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            mainForm_ = new MainForm();
            programState_ = new ProgramState();
            Application.Run(new Form1());
            Application.Exit();
        }
    }
}
