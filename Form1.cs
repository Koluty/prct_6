using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prct_6
{
    public partial class Form1 : Form
    {
        GraduationExam graduation;
        Trial trial;
        delegate void MultiDelegate();
        public Form1()
        {
            InitializeComponent();
            graduation = new GraduationExam();
            trial = new Trial();
            graduation.GraduationExamEvent += GUI_Show;
            trial.TrialEvent += GUI_Show;
        }
        //Виклик по черзі 
        private void button1_Click(object sender, EventArgs e)
        {
            graduation.TakeTest();
            graduation.ConductExam();
            graduation.PassGraduationExam();
            trial.StartTrial();
        }
        private void GUI_Show(string obj)
        {
            MessageBox.Show(obj);
        }
        //Виклик через багатоадресний делегат
        private void button2_Click(object sender, EventArgs e)
        {
            MultiDelegate multiDelegate = graduation.TakeTest;
            multiDelegate += graduation.ConductExam;
            multiDelegate += graduation.PassGraduationExam;
            multiDelegate += trial.StartTrial;
            multiDelegate.Invoke();
        }
    }
}
